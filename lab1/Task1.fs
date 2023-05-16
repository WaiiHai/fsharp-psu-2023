module fsharp_psu_2023.lab1.Task1
open System


let rec getList (n, list) =
    if n = 0 then
        list
    else
        let s = (Int32.Parse(Console.ReadLine()) % 2)     
        getList((n-1), list @ [(if (s = 0) then 0 else 1)])
            
        
[<EntryPoint>]
let main argv =
   let len = Int32.Parse(Console.ReadLine())
   let list = (getList(len, [])).ToString()
   printf "%s" list
   0