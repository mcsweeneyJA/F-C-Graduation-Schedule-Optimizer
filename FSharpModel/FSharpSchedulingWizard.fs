module FSharpSchedulingWizard

open System
open BoundsOptimizer
open BoundsOptimizer
open QUT
open StudyPlannerModel

// Functions used for optimizing study plan ...

// The semester that we are currently in
let currentSemester : Semester = 
    // Do not change
    { year = 2020; offering = Semester1 }


// Given a partial plan, try to schedule the remaining units such that all remaining units are legally scheduled 
// (with no more than 4 units per semester) .
// Should return None if it is not possible to schedule the remaining units
// We start by selecting one of the remaining units that can be scheduled in at least one of its possible semesters.
// If none of the remaining units can be scheduled then we fail.
// Otherwise we try scheduling that unit in each of the possible semesters in which it can be legally scheduled. 
// If any of those schedules can be extended into a complete plan then we succeed, otherwise we fail.
let rec private scheduleRemaining (remainingUnits:BoundPlan) (plannedUnits:StudyPlan): StudyPlan option =
    if not remainingUnits.IsEmpty
    then
  
        remainingUnits
        |> List.tryFind (fun pland ->
                                pland.possibleSemesters
                                |> Seq.exists (fun possibleSem -> isEnrollableIn pland.code possibleSem plannedUnits))
        
        |> (fun planUnitOp -> match planUnitOp with
                                | None -> Option.None
                                | Some(enrollableUnit) ->
                                                        enrollableUnit.possibleSemesters
                                                        //reduce list of sems to those which enrollable in
                                                        |> Seq.filter (fun sem -> isEnrollableIn enrollableUnit.code sem plannedUnits)
                                                        //map those enrollable sems into new schedules
                                                        |> Seq.map ( fun sem ->
                                                            let additionalunit = {code = enrollableUnit.code; studyArea = enrollableUnit.studyArea; semester = sem};
                                                            let newPlan = seq{ yield!plannedUnits; yield additionalunit; }
                                                            let testBound = seq{ yield enrollableUnit}
                                                            let newBound =
                                                                //reduce boundplan by removing unit thats scheduled
                                                                remainingUnits
                                                                |> List.filter (fun queryUnit -> queryUnit <> enrollableUnit) 
                                                                
                                                            //try and extend schedule based on these new sequences
                                                            scheduleRemaining newBound newPlan)
                                                        |> (fun extendedPlans ->
                                                                extendedPlans
                                                                
                                                                |> Seq.tryFind (Option.isSome)
                                                                |> Option.flatten))
            
    else   Some plannedUnits                                                     
                                
                                          
      

// Assuming that study commences in the given first semester and that units are only studied 
// in semester 1 or semester 2, returns the earliest possible semester by which all units in
// the study plan could be completed, assuming at most 4 units per semester.
let bestAchievable (firstSemester:Semester) (plan:StudyPlan) : Semester =
    let additionalSems =
        plan
        |> Seq.length
        |> (fun num -> num - 1)
        |> (fun num -> ceil (float num / 4.0))
        |> (fun num -> int num)
    
    let additionalYears =
        additionalSems
        |> (fun num -> ceil(float num / 2.0))
        |> (fun num -> int num)
        |> (fun num -> num - 1)
    
    match firstSemester.offering with
        | Semester1 -> {firstSemester with year = firstSemester.year + additionalYears; offering = if (additionalSems % 2 =0) then Semester2 else Semester1}
        | Semester2 -> {firstSemester with year = firstSemester.year + additionalYears; offering = if (additionalSems % 2 =0) then Semester1 else Semester2}
        | Summer -> {firstSemester with year = firstSemester.year + 1; offering = Semester1  }
            


// Returns the last semester in which units will be studied in the study plan
let lastSemester (plan: StudyPlan): Semester =
         
    plan
    |> Seq.maxBy (fun p -> p.semester)
    |>(fun x -> x.semester)
    

// Returns true if and only if every unit in the plan has at least one possible semester for it to be scheduled
let allBoundsFeasible (bounds:BoundPlan) =
    // do not change  (difficulty: 3/10)
    bounds |> Seq.forall (fun unit -> not (Seq.isEmpty unit.possibleSemesters)) 

// Returns a sequence of progressively better study plans.
// Each successive plan returned finishes in an earlier semester than the previous plan.
// Should return the empty sequence if the plan cannot be improved.
// The earliest semester that we can schedule units in is the current semester.
// Successively better plans are created by specifying progressively tighter target graduation semesters.
// We determine the final semester of the current plan and set our target semester as the semester before that.
// If we succeed in finding a plan that completes by that target semester then we try to improve that plan further, 
// semester by semester until it becomes impossible to improve further.
let TryToImproveSchedule (plan:StudyPlan) : seq<StudyPlan> =
    let first = currentSemester
    let last = lastSemester plan
    let bestPossible = bestAchievable first plan
    let rec TryToCompleteBy (targetGraduation:Semester) =
        if targetGraduation < bestPossible && isLegalPlan plan
        then
            Seq.empty
        else
        
            let tightBound = boundUnitsInPlan plan first targetGraduation
            let isFeasible = tightBound |> allBoundsFeasible
            
            if isFeasible
            
            then
                let scheduled = scheduleRemaining tightBound Seq.empty
                
                
                
                match scheduled with
                        | Some (studyPlan) -> seq{yield studyPlan;  yield! TryToCompleteBy(backSem (lastSemester studyPlan)); }
                        | None -> Seq.empty
            else Seq.empty

    TryToCompleteBy (previousSemester last)