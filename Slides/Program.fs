open Compile

[<EntryPoint>]
let main argv = 
  do batchProcess LatexDefinition.generatePresentation FunctionalWeek1.slides "diswis01-1-Lec1-Lambda-calculus" "The INFDEV@HR Team" "Introduction to functional programming and lambda calculus" true false
//  do batchProcess LatexDefinition.generatePresentation FunctionalWeek2.slides "diswis01-1-Lec2-Delta-rules" "The INFDEV@HR Team" "Delta rules" true false


  0
