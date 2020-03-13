module BoundsOptimizer

open QUT

// Challenge exercise for those students aiming for grade of 6 or 7 !!!!!!!!


// Returns a sequence of all pairs of units (X,Y) such that X and Y are both part of the study plan and X must be completed before Y.
// If our plan contains say IFB104 and CAB203 then we can't necessarily assume that IFB104 must be taken before CAB203 because the 
// prerequisite for CAB203 is EGD126 or IFB104 or ITD104 or MZB126, so the prerequisiste might be achieved by one of those other units
// which would therefore allow CAB203 to be taken before ITF104. However, if none of those other units are in the plan, then IFB104
// must be taken before CAB203. So, to determine mandatory dependencies, we consider not only the prerequisites, but also the other 
// units in the plan. Let's assume we have a plan involving units X and Y that is legal. If we find that removing X from the plan make 
// Y no longer enrollable (in any semester), then we can conclude that X must be taken before Y.
let unitDependenciesWithinPlan (allUnits: StudyPlan) : seq<UnitCode*UnitCode> =
    // TODO: Fixme (difficulty: 7/10)
    Seq.empty

// Returns the first semester on or after the given semester in which the specified unit is offered
let rec private firstOfferingOnOrAfter (unitCode: UnitCode) (semester: Semester) : Semester =
    // TODO: Fixme (difficulty: 3/10)
    { year = 1969; offering = Summer }

// Returns the first semester on or before the given semester in which the specified unit is offered
let rec private firstOfferingOnOrBefore (unitCode: UnitCode) (semester: Semester) : Semester =
    // TODO: Fixme (difficulty: 3/10)
    { year = 1969; offering = Summer }

// Based on a set of dependencies between units, determine the earliest possible semester in which the given unit could be studied
// assuming that all units involved in the dependencies must all be completed no earlier than the first semester.
let rec private earliestSemester (dependencies: seq<UnitCode*UnitCode>) (unitCode: UnitCode) (firstSemester: Semester)  : Semester =
    // TODO: Fixme (difficulty: 9/10)
    { year = 1969; offering = Summer }

// Based on a set of dependencies between units, determine the latest possible semester in which the given unit could be studied
// assuming that all units involved in the dependencies must all be completed no later than the last semester.
let rec private latestSemester (dependencies: seq<UnitCode*UnitCode>) (unitCode: UnitCode) (lastSemester: Semester) : Semester =
    // TODO: Fixme (difficulty: 9/10)
    { year = 1969; offering = Summer }

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
    |> Seq.map (fun unit -> { code =unit.code; studyArea = unit.studyArea; possibleSemesters = (StudyPlannerModel.SemesterSequence firstSemester lastSemester)}) 
    |> Seq.toList