module fsharp_psu_2023.lab4.Task2

open System

(* Мальцев А. 9 в-нт *)
(* Сколько элементов дерева содержит заданную цифру? *)

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
        
let tree_fold func acc tree digit =   
    let rec traverse d k = 
        match d with    (* обход по всем вершинам методом func, digit - доп. параметр *)
        | Node (t,l,r) -> traverse r (func (traverse l k) t digit)
        | Empty -> k
    traverse tree acc

let rec countDigit acc number searchDigit =
    if abs number > 0 then
        countDigit (acc +
                    (if ((abs number) % 10) = searchDigit then 1 else 0)) (* аккумуляция кол-ва найденных цифр*)
                    ((abs number) / 10) searchDigit                       (* рекурсивный вызов на разряд ниже*)
    else
        acc
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
    printf "Введите искомую цифру: "
    let digit = int(Console.ReadLine())
    let digitCount = tree_fold countDigit 0 binTree digit
    printf "Кол-во цифр в древе: %d" digitCount
    0
    
  (*
Node 5
Node -7
Node 16
Node 13
Node -8
Node -112
Введите искомую цифру: 5
Кол-во цифр в древе: 1
  *)