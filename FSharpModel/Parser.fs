module Parser

open QUT
open FParsec

// Helper functions to create various types of Prerequisites ...

let private CreatePrereqCP (number:int)           : Prereq = CreditPoints number
let private CreatePrereqAnd (a:Prereq) (b:Prereq) : Prereq = And [a; b]
let private CreatePrereqOr  (a:Prereq) (b:Prereq) : Prereq = Or [a; b]
let private CreatePrereqUnit (unitCode:UnitCode)  : Prereq = Unit unitCode
let private CreatePrereqNil                       : Prereq = Nil

// Parser to parse prerequisites, e.g. (CAB201 or ITD121) and (MZB151 or 12cp)

let private whitespace = spaces
let private str_ws s = pstring s >>. whitespace

// parse e.g. "96cp"
let private creditpoints = (pint32 .>> pstring "cp" .>> whitespace) |>> (fun cp -> CreatePrereqCP cp)

// parse e.g. CAB402 or EGH400-1
let private unitcode = 
    pipe5 
        (manyMinMaxSatisfy 3 3 isAsciiUpper) // 3 upper case letters
        (manyMinMaxSatisfy 3 3 isDigit) // followed by 3 digits
        (manyMinMaxSatisfy 0 1 (fun ch -> ch='-')) // optionally followed by - digit
        (manyMinMaxSatisfy 0 1 isDigit) 
        whitespace // optionally followed by whitespace
        (fun letters digits dash dig spaces -> CreatePrereqUnit (letters+digits+dash+dig)) // combine parts of unit code to create prereq for a specific unit

let private opp = new OperatorPrecedenceParser<Prereq,unit,unit>(); // create operator prededence parser

opp.TermParser <-                                            // terms are either:
    creditpoints <|>                                         // number of credit points, or
    unitcode <|>                                             // specific unit, or
    between (str_ws  "(") (str_ws  ")") opp.ExpressionParser // another prereq between parenthesis

// prerequisistes can be created using binary operators "and" and "or"
opp.AddOperator(InfixOperator("and", whitespace, 2, Associativity.Left, (fun a b -> CreatePrereqAnd  a b)))
opp.AddOperator(InfixOperator("or", whitespace, 1, Associativity.Left, (fun a b -> CreatePrereqOr a b)))

let private parsePrereq (str:string) : Prereq = 
    if (str = "") then Nil // if there is no prerequisite
    else
        match run (opp.ExpressionParser .>> eof) str with // check for parse errors
        | Success(result,_,_) -> result
        | Failure(errorMsg,_,_) -> raise (new System.Exception(errorMsg))

// convert bit encoding to set of semesters
let private parseOfferings number = 
    match number with 
    | 0 -> set [ ]
    | 1 -> set [ Semester1 ]
    | 2 -> set [ Semester2 ]
    | 3 -> set [ Semester1; Semester2 ]
    | 4 -> set [ Summer ]
    | 5 -> set [ Semester1; Summer ]
    | 6 -> set [ Semester2; Summer]
    | 7 -> set [ Semester1; Semester2; Summer ]
    | _ -> raise (new System.ArgumentOutOfRangeException "offerings")

// Each line of csv file contains: unitCode,offered,creditPoints,unitTitle,prereqs
let private ParseCSV (csv:string[]): UnitInfo = 
    { offered = parseOfferings (int csv.[1]); creditpoints = (int csv.[2]); title=csv.[3];  prereq = parsePrereq csv.[4]; prereqString = csv.[4] }

// Parse the entire CSV resource file by splitting files into lines and splitting lines containing commas
// combine the results into a mapping from unit code to unit info
let parseUnitData (unitData:string) : Map<UnitCode,UnitInfo> = 
    unitData.Split('\n')
    |> Array.toSeq
    |> Seq.map(fun line -> line.Split(','))
    |> Seq.fold (fun oldMap csv -> oldMap.Add (csv.[0], ParseCSV csv))  Map.empty