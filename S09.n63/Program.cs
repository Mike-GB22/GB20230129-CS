// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215 \n\n"
+ "Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в "
+ "промежутке от 1 до N. Выполнить с помощью рекурсии.\n"
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
    return ""+LineGeneratorRecurent(number-1)+", "+number;
}

PrintResult("Итоговая строка",LineGeneratorRecurent(ReadKeyboard("Введите N")));