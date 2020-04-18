module StudyPlannerModel

open System
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open QUT

// Functions dealing with unit lists ...

// Loads unit information about all QUT units from a resource file
let private unitList : Map<UnitCode,UnitInfo> = 
    Parser.parseUnitData CourseData.Properties.Resources.units

// Lookup the given unit code in the unitList
let lookup (code:UnitCode) : UnitInfo =
    unitList
    |> Map.find code 
    
    



// Functions dealing with semester sequences ...

// The semester prior to the given semester
// e.g previousSemester 2020/2 = 2020/1
//     previousSemester 2020/1 = 2019/S
//     previousSemester 2020/S = 2020/2


let previousSemester (semester:Semester) =
    match semester.offering with
        | Semester1 -> {semester with year = semester.year - 1; offering = Summer }
        | Semester2 -> {semester with offering = Semester1 }
        | Summer -> {semester with offering = Semester2 }



// The semester after to the given semester
// e.g nextSemester 2020/1 = 2020/2
//     nextSemester 2020/2 = 2020/S
//     nextSemester 2020/S = 2021/1
let nextSemester (semester:Semester) =
    match semester.offering with
        | Semester1 ->{semester with offering = Semester2}
        | Semester2 ->{semester with offering = Summer}
        | Summer ->{semester with year = semester.year + 1; offering = Semester1}

// Returns a sequence of consecutive semesters starting from the first semester and ending at the last semester.
// E.g. SemesterSequence 2019/2 2021/1 would return the sequence 2019/2, 2019/S, 2020/1, 2020/2, 2020/S, 2021/1.
let rec SemesterSequence (firstSemester: Semester) (lastSemester: Semester): seq<Semester> =
    seq { 
          
          if lastSemester >= firstSemester  then
            yield firstSemester
            yield! SemesterSequence (nextSemester firstSemester) lastSemester }
          
    




// Functions dealing with prerequisites ...

// True if and only if the prerequisites have been met based on units in the study 
// plan taken in an earlier semester (based on the before function)
let rec private satisfied (prereq:Prereq) (plannedUnits:StudyPlan) (before: Semester->bool) : bool = 
    

    
    match prereq with
        | And (seqPrereq) -> seqPrereq |> Seq.forall (fun prereq -> satisfied prereq plannedUnits before )
        | Or (seqPrereq) -> seqPrereq |> Seq.exists (fun x -> satisfied x plannedUnits before )
        | Unit (v) -> plannedUnits |> Seq.filter (fun x -> before x.semester ) |> Seq.exists (fun x->  x.code = v )
        | CreditPoints (v) -> (plannedUnits |> Seq.filter (fun x -> before x.semester ) |> Seq.sumBy (fun x -> (lookup x.code).creditpoints))  >= v
        | Nil -> true
       
    



 // Functions used for determining when units can be studied ...

 // True if and only if the unit with the specified unit code is offered in the specified semester
let isOffered (unitCode:UnitCode) (semester:Semester) : bool = 
   let looked = lookup unitCode
   looked.offered
   |>Set.contains semester.offering
    

// True if and only if the specified unit can be studied in the specified semester based on the specified study plan.
// Requires that the unit is offered in that semester and that prerequistes are meet by units studied before that semester 
let isLegalIn (unitCode:UnitCode) (semester:Semester) (plannedUnits:StudyPlan) : bool =    
    let before sem = 
        sem < semester 
       
    let lookedUp = lookup unitCode
    isOffered unitCode semester && satisfied lookedUp.prereq plannedUnits before 
    

// True if and only if the specified unit can be added to the study plan in that semester.
// Requires that the number of units currently studied in that semester is less than four and that it is legal in that semester
let isEnrollableIn (unitCode:UnitCode) (semester:Semester) (plannedUnits:StudyPlan) : bool =
    let unitsEnrolled = 
        plannedUnits
        |> Seq.filter (fun x -> x.semester = semester)
        |> Seq.length
    
    unitsEnrolled < 4 && isLegalIn unitCode semester plannedUnits
    
    

// True if and only if the unit can be legally added to the study plan (in some semester) 
let isEnrollable (unitCode:UnitCode) (plannedUnits:StudyPlan) : bool =
    let looked = lookup unitCode
    let before sem =
        true

    satisfied looked.prereq plannedUnits before
    
    
    

// True if and only if the all of the units in the study plan are legally scheduled
let isLegalPlan (plan: StudyPlan): bool =
    plan
    |> Seq.forall ( fun x -> isLegalIn x.code x.semester plan)




// Functions returning various information about units ...

// Returns all of the unit codes that are mentioned anywhere in the prerequisites of the specified unit
let UnitPrereqs (unitCode:UnitCode) : seq<UnitCode> =
    let lookedUp = lookup unitCode

    let rec foo (prereq: Prereq) : seq<UnitCode> =   
        match prereq with
        | Unit (name) ->  seq {yield name}
        | And (seqPrereqs) ->  seq { for otherPrereq in seqPrereqs do
                                        yield! foo otherPrereq}
        | Or (seqPrereqs) ->  seq { for otherPrereq in seqPrereqs do
                                        yield! foo otherPrereq}
        | Nil -> Seq.empty
        | CreditPoints (num) ->  Seq.empty

    foo lookedUp.prereq
    
         
     

// The title of the specified unit
// e.g. getUnitTitle("CAB402") = "Programming Paradigms"
let getUnitTitle (unitCode:UnitCode) : string = 
    Map.find unitCode unitList
    |> (fun x -> unitCode  + " " + x.title)

// The prerequisites of the specified unit as a string
// e.g. getPrereq("CAB402") = "Prereqs: (CAB201 or ITD121) and CAB203"
// e.g. getPrereq("IFB104") = "Prereqs: Nil"
let getPrereq (unitCode:UnitCode) : string = 
    Map.find unitCode unitList
    |> (fun unitinfo -> match unitinfo.prereq with
                        | Nil -> "Prereqs: Nil"
                        | _ -> "Prereqs: " + unitinfo.prereqString)
                    

// The semesters that the specified unit is offered in as a string
// e.g. displayOffered("CAB201") = "semester 1 or 2"
// e.g. displayOffered("CAB402") = "semester 1"
let displayOffered (unitCode:UnitCode) : string =
    let threadedY  y =
        match y with
            | "semester 1" -> "1"
            | "semester 2" -> "2"
            | "semester summer" -> "summer"
                
    let looked =
        lookup unitCode
        
    looked.offered
    |> Set.map (fun x -> match x with
                            | Semester1 -> "semester 1"
                            | Semester2 -> "semester 2"
                            | Summer -> "semester summer"
                            )
    |> Set.toSeq
    |> Seq.reduce (fun x y ->   x + " or " + threadedY y)
  
  
// The specified semester as a string (format: year/semester)
// e.g. display(currentSemester) = "2020/1"
let display (sem:Semester) : string = 
    match sem.offering with
    | Semester1 -> string sem.year + "/1"
    | Semester2 -> string sem.year + "/2"
    | Summer -> string sem.year + "/S"
    
    
    
    
