module BoundsOptimizer

open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open Parser
open QUT
open StudyPlannerModel

// Challenge exercise for those students aiming for grade of 6 or 7 !!!!!!!!


// Returns a sequence of all pairs of units (X,Y) such that X and Y are both part of the study plan and X must be completed before Y.
// If our plan contains say IFB104 and CAB203 then we can't necessarily assume that IFB104 must be taken before CAB203 because the 
// prerequisite for CAB203 is EGD126 or IFB104 or ITD104 or MZB126, so the prerequisiste might be achieved by one of those other units
// which would therefore allow CAB203 to be taken before ITF104. However, if none of those other units are in the plan, then IFB104
// must be taken before CAB203. So, to determine mandatory dependencies, we consider not only the prerequisites, but also the other 
// units in the plan. Let's assume we have a plan involving units X and Y that is legal. If we find that removing X from the plan make 
// Y no longer enrollable (in any semester), then we can conclude that X must be taken before Y.
let unitDependenciesWithinPlan (allUnits: StudyPlan) : seq<UnitCode*UnitCode> =

    // generate permuations of each unit in allUnits
    seq { for possibleUnit in allUnits do
            let unitPairs = allUnits |> Seq.map (fun unitPlanned -> (unitPlanned, possibleUnit))
            for a,b in unitPairs do
                // for pair A,B try to enrol into B when A is removed,
                // if not enrollable -> Depenendency -> yield A,B
            if not (isEnrollable b.code (allUnits |> Seq.filter ( fun unit -> unit <> a)) ) then yield a.code, b.code}
   
    
  
// Returns the first semester on or after the given semester in which the specified unit is offered
let rec private firstOfferingOnOrAfter (unitCode: UnitCode) (semester: Semester) : Semester =
    
    //helper funnction taking unit and returning set <offering>
    let queriedUnitSet =
        lookup unitCode
        |> (fun targetinfo -> targetinfo.offered)
        
    
    
    match semester.offering with
        //check if the queried unit's set of semesters contains the this Offering (sem1, 2 summer)
        // if it doesnt -> recursively try again with the next possible on/after
        | Semester1  -> if ( queriedUnitSet |> Set.contains (Semester1))
                        then semester
                        else firstOfferingOnOrAfter unitCode {semester with offering = Semester2} 
        | Semester2  -> if ( queriedUnitSet |> Set.contains (Semester2))
                        then semester
                        else firstOfferingOnOrAfter unitCode {semester with year = semester.year + 1; offering = Semester1} 
        | Summer  -> firstOfferingOnOrAfter unitCode {semester with year = semester.year + 1; offering = Semester1}
    
 

// Returns the first semester on or before the given semester in which the specified unit is offered
let rec private firstOfferingOnOrBefore (unitCode: UnitCode) (semester: Semester) : Semester =
    //helper function taking unit and returning set <offering>
    let queriedUnitSet =
        lookup unitCode
        |> (fun targetinfo -> targetinfo.offered)
        
    
     //check if the queried unit's set of semesters contains the this Offering (sem1, 2 summer)
     // if it doesnt -> recursively try again with the next possible on/after
    match semester.offering with
        | Semester1  -> if ( queriedUnitSet |> Set.contains (Semester1))
                        then semester
                        else firstOfferingOnOrBefore unitCode {semester with year = semester.year - 1; offering = Semester2} 
        | Semester2  -> if ( queriedUnitSet |> Set.contains (Semester2))
                        then semester     else firstOfferingOnOrBefore unitCode {semester with  offering = Semester1} 
        | Summer  -> firstOfferingOnOrAfter unitCode {semester with offering = Semester2}






// helper functions to step forward / backward a semester of legal study semesters
let addSem (semester:Semester) =
    match semester.offering with
        | Semester1 ->{semester with offering = Semester2}
        | Semester2 ->{semester with year = semester.year + 1; offering = Semester1}
        | Summer ->{semester with year = semester.year + 1; offering = Semester1}

let backSem (semester:Semester) =
    match semester.offering with
        | Semester1 ->{semester with year = semester.year - 1; offering = Semester2}
        | Semester2 ->{semester with offering = Semester1}
        | Summer ->{semester with offering = Semester2}


// Based on a set of dependencies between units, determine the earliest possible semester in which the given unit could be studied
// assuming that all units involved in the dependencies must all be completed no earlier than the first semester.
let rec private earliestSemester (dependencies: seq<UnitCode*UnitCode>) (unitCode: UnitCode) (firstSemester: Semester)  : Semester =
    let isDependent =
        dependencies
        //find the units that need to be done before Y(unitCode)
        |> Seq.filter (fun  pair  ->  snd pair = unitCode )
        
        
        
        
    match isDependent with
        //when the unit does not have any dependent, return first offering on/after this sem
        | some when Seq.isEmpty some -> firstOfferingOnOrAfter unitCode firstSemester
        //when the unit does have dependents
        //recursively map each dependent with its earliest possible sem
        // CHECK FIRST SEMESTER CORRECT OR NOT FOR MAP
        | _ ->  isDependent  |> Seq.map ( fun pairXY -> earliestSemester dependencies (fst pairXY) ( firstSemester))
                            //Take the latest semester of these
                            |> Seq.max
                            // return first offer on/after the next
                            |> (fun sem -> firstOfferingOnOrAfter unitCode  (addSem sem))
                    
  
 
// Based on a set of dependencies between units, determine the latest possible semester in which the given unit could be studied
// assuming that all units involved in the dependencies must all be completed no later than the last semester.
let rec private latestSemester (dependencies: seq<UnitCode*UnitCode>) (unitCode: UnitCode) (lastSemester: Semester) : Semester =
    let hasDependents =
        dependencies
        //find the units that need Y to be done before them
        |> Seq.filter (fun  pairXY  ->  fst pairXY = unitCode )
        
        
        
        
    match hasDependents with
        //when the unit isnt a dependent for anything else
        //return latest sem unit can be done 
        | empty when Seq.isEmpty empty -> firstOfferingOnOrBefore unitCode lastSemester
        
        //when the unit is a predependent for others
        //recursively map each dependent with its latest possible sem
        // CHECK FIRST SEMESTER CORRECT OR NOT FOR MAP
        | _ ->  hasDependents |> Seq.map ( fun pair -> latestSemester dependencies (snd pair) ( lastSemester))
                              |> Seq.min
                              |> (fun sem ->  firstOfferingOnOrBefore unitCode (backSem sem))

// Create a bound plan by determining for each unit in the study plan the earliest and latest possible semester 
// in which that unit could be taken. All units in the plan must be scheduled no earlier than the first semester
// and no later than the last semester. Dependencies between units in the study plan are used to create tighter
// tighter bounds on when each unit can be taken. 
// For example, if the study plan included IFB104, CAB203 and CAB402 and the last semester was 2022/2
// the latest that CAB402 could be taken would be 2022/1 (since it is not offered in semester 2). 
// CAB203 must be taken before CAB402, therefore the latest that CAB203 could be taken would be 2021/1 
// (since it is not offered in semester 2). IFB104 must be taken before CAB203, therefore the latest 
// that IFB104 could be taken would be 2020/2. We similarly compute the earliest semester that each unit could be taken
// taking into account the semesters they are offered and mandatory dependencies between units.
// Once we have the earliest and latest possible semesters in which each unit could be taken, we can then
// generate a sequence of all possible semesters in between in which it might be taken (provided it is offered in those semesters).
let boundUnitsInPlan (allUnits: StudyPlan) (firstSemester: Semester) (lastSemester: Semester) : BoundPlan =
    // (difficulty: 7/10)
    // Naive implementation - only fix for challenge exercise for those students aiming for grade of 6 or 7
    allUnits 
    |> Seq.map (fun unit -> { code =unit.code
                              studyArea = unit.studyArea
                              possibleSemesters =  (SemesterSequence
                                                        (earliestSemester (unitDependenciesWithinPlan allUnits) unit.code firstSemester)
                                                        (latestSemester (unitDependenciesWithinPlan allUnits) unit.code lastSemester)
                                                    |> Seq.filter (fun sem -> isOffered unit.code sem ))}) 
    
    |> Seq.toList