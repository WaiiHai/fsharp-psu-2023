module fsharp_psu_2023.lab03.Task3

open System
open System.IO

(* Мальцев А. 9 в-нт *)
(* Вывести количество файлов, имя которых начинается с заданного
символа, в указанном каталоге и его подкаталогах.
*)
let main argv =
    printf "Введите расширение файла для поиска: "
    let fileFilter = "*." + Console.ReadLine() (* фильтр по расширению файла *)
    printf "Введите путь к папке: "
    let pth = Console.ReadLine() (* чтение пути *)
    let files = Directory.GetFiles(pth,fileFilter, 
                                   SearchOption.AllDirectories) (* получения списка файлов в подпапках *)
                |> Array.toList                  (* получение листа *)
    printfn "Количество файлов: %A" files.Length (* получения размера листа*)
    0
    
(* Введите расширение файла для поиска: txt
Введите путь к папке: /tmp/tmp.EZGsSMf9pb
Количество файлов: 2
*)