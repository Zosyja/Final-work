// Написать программу, которая из имеющегося массива формирует массив из строк,
// длина которых меньше либо равно 3 символам.
// Первоначальный массив можно ввести с клавиатуры.

void PrintMasString (string[] array){
    foreach (var item in array){
        Console.Write(item+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите массив строк через пробел: ");
string mass = Console.ReadLine() ?? " ";
string[] names = mass.Split(" ");

var result = new string[names.Length];
var count = 0;

foreach (var el in names){
    if (el.Length <= 3){
        result[count] = el;
        count++;
    }
}
Console.Write("Скорректированный массив: ");
PrintMasString(result);