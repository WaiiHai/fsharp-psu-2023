module fsharp_psu_2023.lab03.Task1

open System

(* Мальцев А. 9 в-нт *)
(* На основе заданного списка чисел получить список из значений true и false. True
— если соответствующий элемент исходного списка чётный, и false — в 
противном случае
*)

let transform item =
    (item % 2) = 0  // четное = true, нечетное = false
let main argv =
    let list = [ for _ in 1 .. int(Console.ReadLine()) // цикл от 1 до введеного кол-ва
                do yield int(Console.ReadLine())       // заполнение списка из консольного ввода
                ]
    
    printf "%A" (Seq.map transform list) // трансформация исходной последовательности при помощи ф-ии `transform`
    0
(* запуск
5
4
3
2
1
0
[true; false; true; false; true]
*)