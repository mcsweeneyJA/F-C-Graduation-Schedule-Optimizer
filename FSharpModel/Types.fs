namespace QUT

// types used in model

type UnitCode = string

type Prereq =
    | And of seq<Prereq>
    | Or of seq<Prereq>
    | Unit of UnitCode
    | CreditPoints of int
    | Nil

type Offering = Semester1 | Semester2 | Summer

type Semester = { year: int; offering: Offering }

type UnitInfo = { offered: Set<Offering>; creditpoints: int; title: string; prereq: Prereq; prereqString : string }

type UnitInPlan = { code:UnitCode; studyArea: string; semester: Semester }

type StudyPlan =  seq<UnitInPlan>

type PlannedUnit = { code:UnitCode; studyArea: string; possibleSemesters: seq<Semester> }

type BoundPlan =  List<PlannedUnit>