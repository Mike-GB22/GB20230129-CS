// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215 \n\n"
+ "Задача 67: Задайте значения N. Напишите программу, которая найдёт сумму чисел, составляющих число"
+ "(единицы, десятки, сотни ...). Выполнить с помощью рекурсии.\n"
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
    Console.Write(prompt + ": " + outText);

}


int LineGeneratorRecurent(int number){
    if (number < 0) { number *= -1; }
    if (number < 10) return number;
    return (number%10 + LineGeneratorRecurent(number/10));
}


PrintResult("Итоговая строка", LineGeneratorRecurent(ReadKeyboard("Введите N")).ToString());