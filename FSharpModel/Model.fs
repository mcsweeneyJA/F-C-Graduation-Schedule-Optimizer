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
    // check comparison of lower bound to upper bound
    // if still below, yield current then step forward and repeat
    seq {     
          if (firstSemester <= lastSemester) then
            yield firstSemester;
            yield! SemesterSequence (nextSemester firstSemester) lastSemester }
          
    




// Functions dealing with prerequisites ...

// True if and only if the prerequisites have been met based on units in the study 
// plan taken in an earlier semester (based on the before function)
let rec private satisfied (prereq:Prereq) (plannedUnits:StudyPlan) (before: Semester->bool) : bool = 
    

    //match the given prereq
    match prereq with
        // check that ALL units in the sequence have been satisfied before (Rec)
        | And (seqPrereq) -> seqPrereq |> Seq.forall (fun prereq -> satisfied prereq plannedUnits before )
        // check that at least one unit in the sequence has been satisfied before (Rec)
        | Or (seqPrereq) -> seqPrereq |> Seq.exists (fun queryUnit -> satisfied queryUnit plannedUnits before )
        // base case:
        // narrow units to only those completed BEFORE, then see if the code exists
        | Unit (code) -> plannedUnits |> Seq.filter (fun queryUnit -> before queryUnit.semester )
                                      |> Seq.exists (fun  queryUnit->  queryUnit.code = code )
        // narrow units to only those completed BEFORE, then sum all units in that list for
        // creditpoints, and                              
        | CreditPoints (credits) -> (plannedUnits |> Seq.filter (fun queryUnit -> before queryUnit.semester )
                                                  |> Seq.sumBy (fun queryUnit -> (lookup queryUnit.code).creditpoints)) |> (fun z -> z >= credits)
        | Nil -> true
       
    



 // Functions used for determining when units can be studied ...

 // True if and only if the unit with the specified unit code is offered in the specified semester
let isOffered (unitCode:UnitCode) (semester:Semester) : bool =
   //lookup the specified unit and get the set of offerings associated
   let looked = lookup unitCode
   looked.offered
   //check if the element (queried semester's offering) is contained in set
   |>Set.contains semester.offering
    

// True if and only if the specified unit can be studied in the specified semester based on the specified study plan.
// Requires that the unit is offered in that semester and that prerequistes are meet by units studied before that semester 
let isLegalIn (unitCode:UnitCode) (semester:Semester) (plannedUnits:StudyPlan) : bool =
    
    let before sem semester = 
        sem > semester 
    // check that unit is offered and than its prereqs are satisfied
    let lookedUp = lookup unitCode
    isOffered unitCode semester && satisfied lookedUp.prereq plannedUnits (before semester)
    

// True if and only if the specified unit can be added to the study plan in that semester.
// Requires that the number of units currently studied in that semester is less than four and that it is legal in that semester
let isEnrollableIn (unitCode:UnitCode) (semester:Semester) (plannedUnits:StudyPlan) : bool =
        
        
        plannedUnits
         //reduce sequence to only those units in current semester
         |> Seq.filter (fun queryUnit -> queryUnit.semester = semester)
         |> Seq.length
         //take length and check if the new unit is legal if its less than 4 currently
         |> (fun result -> result < 4 && isLegalIn unitCode semester plannedUnits)
        
  
    
    

// True if and only if the unit can be legally added to the study plan (in some semester) 
let isEnrollable (unitCode:UnitCode) (plannedUnits:StudyPlan) : bool =

    
    //lookup unit and check if its satisfied
    let looked = lookup unitCode
    
    //before function for this scope will always return true (some semester)
    let before sem =
        true

    
    plannedUnits
    |> Seq.forall(fun u -> satisfied looked.prereq plannedUnits before)
    
    
    
    
    
    

// True if and only if the all of the units in the study plan are legally scheduled
let isLegalPlan (plan: StudyPlan): bool =
    plan
    //check if ALL units in the given sequence return true for predicate
    //where predicate is isLegalIn for that unit's sem
    |> Seq.forall ( fun eachUnit -> isLegalIn eachUnit.code eachUnit.semester plan)




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
            |_ -> ""
                
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
    
    
    
    
