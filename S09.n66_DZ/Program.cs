// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215 \n\n"
+ "Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в"
+ "промежутке от M до N. Выполнить с помощью рекурсии.\n"
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
int LineGeneratorRecurent(int numberM, int numberN){
    if(numberM >= numberN) return numberM;
    return (numberM+LineGeneratorRecurent(numberM+1, numberN));
}

int m = ReadKeyboard("Введите M");
int n = ReadKeyboard("Введите N");
if ( m > n) { int tmp = m; m = n; n = tmp;}
PrintResult("Итоговая строка",LineGeneratorRecurent(m,n).ToString());