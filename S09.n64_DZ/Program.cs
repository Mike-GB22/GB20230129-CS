// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215 \n\n"
+ "Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в "
+ "промежутке от N до 1. Выполнить с помощью рекурсии.\n"
);


//Запрос числа с клавиатуры
int ReadKeyboard(string prompt)
{
    Console.Write(prompt + ": ");
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Печать результата
void PrintResult(string prompt, string outText)
{
    Console.Write(prompt + ": "+outText);
    
}

//Генерация строки 1 2 3 4 5 6 ... номер
string LineGeneratorRecurent(int number){
    if(number <=1) return ""+number;
    return ""+number+", "+ LineGeneratorRecurent(number-1);
}

PrintResult("Итоговая строка",LineGeneratorRecurent(ReadKeyboard("Введите N")));