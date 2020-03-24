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
    seq { yield firstSemester
          if not (firstSemester = lastSemester) then 
            yield! SemesterSequence (nextSemester firstSemester) lastSemester  }




// Functions dealing with prerequisites ...

// True if and only if the prerequisites have been met based on units in the study 
// plan taken in an earlier semester (based on the before function)
let rec private satisfied (prereq:Prereq) (plannedUnits:StudyPlan) (before: Semester->bool) : bool = 
    false
    //match prereq with
   // | And (v) -> false
    //| Or (v) -> v |> Seq.exists satisfied prereq plannedUnits 
   // | Unit (v) -> plannedUnits |> Seq.exists (fun x -> x.code = v)
  //  | CreditPoints (v) -> false
 //   | Nil -> true
    
    



 // Functions used for determining when units can be studied ...

 // True if and only if the unit with the specified unit code is offered in the specified semester
let isOffered (unitCode:UnitCode) (semester:Semester) : bool = 
   let looked = lookup unitCode
   looked.offered
   |>Set.contains semester.offering
    

// True if and only if the specified unit can be studied in the specified semester based on the specified study plan.
// Requires that the unit is offered in that semester and that prerequistes are meet by units studied before that semester 
let isLegalIn (unitCode:UnitCode) (semester:Semester) (plannedUnits:StudyPlan) : bool =
    
    let lookedUp = lookup unitCode
    let inPlan code =
        plannedUnits
        |>Seq.exists (fun x -> x.code = code)

    let rec foo (prereq: Prereq) : bool =   
        match prereq with
        | Unit (name) -> isOffered name semester && inPlan name
        | And (seqPrereqs) -> seqPrereqs |> Seq.forall (fun x -> x = lookedUp.prereq)
        | Or (seqPrereqs) ->  seqPrereqs |> Seq.exists (fun x -> x = lookedUp.prereq)
        | Nil -> isOffered unitCode semester
        | CreditPoints (num) -> isOffered unitCode semester

    foo lookedUp.prereq
   
   
   
   // let looked = lookup unitCode
    //let lookedPre = looked.prereqString
    //let offd = isOffered unitCode 
    
    //plannedUnits
    //|> Seq.filter (fun x -> x.semester = semester)
   //|> Seq.exists (fun x -> x.code = lookedPre ) 

// True if and only if the specified unit can be added to the study plan in that semester.
// Requires that the number of units currently studied in that semester is less than four and that it is legal in that semester
let isEnrollableIn (unitCode:UnitCode) (semester:Semester) (plannedUnits:StudyPlan) : bool =
    // TODO: Fixme (difficulty: 2/10)
    false

// True if and only if the unit can be legally added to the study plan (in some semester) 
let isEnrollable (unitCode:UnitCode) (plannedUnits:StudyPlan) : bool =
    // TODO: Fixme (difficulty: 4/10)
    false

// True if and only if the all of the units in the study plan are legally scheduled
let isLegalPlan (plan: StudyPlan): bool =
    // TODO: Fixme (difficulty: 4/10)
    false




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
        | CreditPoints (num) -> Seq.empty

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
    // TODO: Fixme (difficulty: 5/10)
    "???"

// The specified semester as a string (format: year/semester)
// e.g. display(currentSemester) = "2020/1"
let display (sem:Semester) : string = 
    match sem.offering with
    | Semester1 -> string sem.year + "/1"
    | Semester2 -> string sem.year + "/2"
    | Summer -> string sem.year + "/S"
    
    
    
    
