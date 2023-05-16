module fsharp_psu_2023.lab1.Task0

let parseMeters (sm: float) =
    floor (sm / 100.0)

let parseSm (sm: float) =
    floor (sm - ((parseMeters sm) * 100.0))
    
let parseMm (sm: float) =
    (sm - (parseSm sm) - ((parseMeters sm) * 100.0)) * 10.0
    
let main argv =
    let value = 115.375
    let sm = (value * 2.54)
    
    printfn "%.3f дюйма = %.0f м %.0f см %.3f мм" value (parseMeters sm) (parseSm sm) (parseMm sm)
    0 // return an integer exit code
