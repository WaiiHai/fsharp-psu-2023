module fsharp_psu_2023.lab2.Task2

open System

(* Мальцев А. 9 в-нт *)
(* Список содержит строки, обозначающие римские числа от I до IX. Найти в 
десятичной системе счисления сумму элементов списка.
*)

let romanToNumeric (value: string)=
    if value = "V" then
        5
    elif value.Contains("V") then           // 4-8 содержат `V`
            if value.StartsWith("I") then   // начинается с `I` только 4 
                4
            else 4 + value.Length           // `VI` длина 2 (4 + 2 = 6), `VII` длина 3 (4 + 3 = 7), ...
    elif value.Contains("X") then // 9
        9
    else
        value.Length // остались 1-3, они равны длине своей строки
        
let summRoman summ (value: string)=
    summ + (romanToNumeric value) // сумма предыдущих + число в десятичной
let main argv =
    let list = [ for _ in 1 .. int(Console.ReadLine()) // цикл от 1 до введеного кол-ва
            do yield Console.ReadLine()       // заполнение списка из консольного ввода
            ]
    printfn "%d" (List.fold summRoman 0 list)
    0
    
(* запуск = 1 + 5 + 9 + 7 + 3 = 25
5
I
V
IX
VII
III
25
*)


(*  printfn "%A" (List.map romanToNumberic list)
9
I
II
III
IV
V
VI
VII
VIII
IX
[1; 2; 3; 4; 5; 6; 7; 8; 9]
*)