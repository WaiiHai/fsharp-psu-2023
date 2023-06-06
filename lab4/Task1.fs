module fsharp_psu_2023.lab4.Task1

open System

(* Мальцев А. 9 в-нт *)
(* Дерево содержит вещественные числа. Заменить отрицательные значения на
0, положительные — на 1.
*)

type BinaryTree =
    | Node of int * BinaryTree * BinaryTree
    | Empty
    
let rec printInOrder tree =
    match tree with
    | Node (data, left, right)
        ->
           printfn "Node %d" data (* Корень - Левое - Правое *)
           printInOrder left
           printInOrder right
    | Empty
        -> ()
        
let rec treeMap node func = (* обработка всех элементов функцией func*)
    match node with
    | Node (data, left, right)
        ->  (* новое звено состроит из корня и рекурсивных вызовов над потомками *)
           Node((func data), (treeMap left func), (treeMap right func))
    | Empty
        -> Empty
let transform item = (* функция преобразвания *)
    if (item > 0) then
        1
    else
        0

let main argv =
    let binTree = (* задание древа *)
        Node(5,
            Node(-7, Empty, Empty),
            Node(16,
                Node(13, Empty, Empty),
                Node(-8, Node(-112, Empty, Empty), Empty)
            )
        )
    printInOrder binTree
    printf "\nnew tree:\n"
    let newBinTree = treeMap binTree transform
    printInOrder newBinTree
    0
    (*
Node 5
Node -7
Node 16
Node 13
Node -8
Node -112

new tree:
Node 1
Node 0
Node 1
Node 1
Node 0
Node 0

*)