open System

// Функция для получения последней цифры числа
let lastnumber number = abs (number % 10)

// Рекурсивная функция для ввода чисел и формирования списка последних цифр
let rec Collector a =
    printf "Введите число (или 'q' для завершения): "
    let input = Console.ReadLine()
    if input = "q" then
        List.rev a
    else
        match Int32.TryParse input with
        | true, number ->
            let lastDigit = lastnumber number
            Collector (lastDigit :: a)
        | false, _ ->
            printfn "Некорректный ввод. Пожалуйста, введите целое число!"
            Collector a

// Основная программа
let main() =
    printfn "Программа для формирования списка последних цифр введенных чисел."
    let List = Collector []
    printfn "Список последних цифр: %A" List

// Запуск программы
main()