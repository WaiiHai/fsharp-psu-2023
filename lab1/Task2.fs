module fsharp_psu_2023.lab1.Task2

open System

(* Мальцев А. 9 в-нт *)
(* 9 Сформировать список из четных цифр числа. *)
let rec pullEven number list =
    if number > 0 then // все цифры обработаны
        let lastDigit = number % 10 // получение цифры из крайнего правого разряда
        
        pullEven (number/10) (   // рекурсивный вызов, убираем из вызова обработанный разряд
        if (
            (lastDigit % 2) = 0) // праверка четности числа
        then lastDigit::list     // добавляем к списку новую четную цифру
        else list                // иначе возвращаем старый список
        )
    else
        list
        
let main argv =
    let number = int(Console.ReadLine())
    let list = pullEven number []
    printf "%A" list
    0
(* запуск
12345678
[2; 4; 6; 8]
*)