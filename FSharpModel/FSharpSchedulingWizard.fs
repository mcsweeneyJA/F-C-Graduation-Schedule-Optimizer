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
    
    
    if remainingUnits.IsEmpty then Some plannedUnits
    else
        remainingUnits
        |> List.tryFind (fun pland -> pland.possibleSemesters |> Seq.exists (fun x -> isEnrollableIn pland.code x plannedUnits))
        |> (fun rez -> match rez with
                        | Some(pland) -> pland.possibleSemesters
                                            |> Seq.filter (fun sem -> isEnrollableIn pland.code sem plannedUnits)
                                            |> Seq.map ( fun sem ->
                                                let additionalunit = {code = pland.code; studyArea = pland.studyArea; semester = sem}
                                                let newPlan = seq{yield! plannedUnits; yield additionalunit}
                                                let newBound =
                                                    remainingUnits
                                                    |> List.filter (fun x -> x.code <> pland.code)
                                                 
                                                scheduleRemaining newBound newPlan)
                                                 
                                                
                                            |> (fun mapd ->
                                                    mapd
                                                    |> Seq.tryFind (fun x -> x.IsSome)) |>Option.flatten

                        | None -> None)
        
        
                
                (*check if boundplan is empty
                if not lets try find a unit that it exists some sem for the unit to enrollin
                match the found option with two conditions
                if nothing is found, we return none
                else if we found some plannedunit, get seq of sem where we can enrollin the plannedunit,
                then for each of these available sems, we create a unit with this sem,
                then add this unit to the a newplan(since we cannot update original plan),
                then remove unit from remainingunits,
                then call the recursive function using the above new "variables",
                because this will give us a sequence of options, we
                then try to find if there is an option from this sequence,
                and flatten the option because try to find will give you an option option type.*)
                    

     
                                            
      

// Assuming that study commences in the given first semester and that units are only studied 
// in semester 1 or semester 2, returns the earliest possible semester by which all units in
// the study plan could be completed, assuming at most 4 units per semester.
let private bestAchievable (firstSemester:Semester) (plan:StudyPlan) : Semester =
    let additionalSems  =
        plan
        |> Seq.length
        |> (fun x -> x-1 )
        |> (fun x -> ceil (float x /  4.0 ))
        |> (fun x -> int x)
        
        
    let additionalYears  =
        additionalSems
        |> (fun x -> ceil (float x / 2.0))
        |> (fun x -> int x)
        |> (fun x -> x - 1)
    


  

    match firstSemester.offering with
        | Semester1 -> {firstSemester with year = firstSemester.year + additionalYears; offering = if (additionalSems % 2 = 0) then Semester2 else Semester1}
        | Semester2 ->{firstSemester with year = firstSemester.year + additionalYears; offering = if (additionalSems % 2 = 0) then Semester1 else Semester1}
        | Summer ->{firstSemester with year = firstSemester.year + 1; offering = Semester1}


// Returns the last semester in which units will be studied in the study plan
let lastSemester (plan: StudyPlan): Semester =
         
    plan
    |> Seq.last
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
        if targetGraduation < first
        then Seq.empty
        else
        
            let tightBound = boundUnitsInPlan plan first targetGraduation
            let isFeasible = tightBound |> allBoundsFeasible
            let scheduled = scheduleRemaining tightBound Seq.empty
            if (bestPossible <= targetGraduation && isFeasible)
             
            then match scheduled with
                    | Some (x) -> seq{yield x; yield! TryToCompleteBy(previousSemester (lastSemester x))}
                    | None -> Seq.empty
            else Seq.empty
    TryToCompleteBy (previousSemester last)
