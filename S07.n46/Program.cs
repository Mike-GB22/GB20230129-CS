// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №46\n"
    + "Задайте двумерный массив размером m×n,\n"
    + "заполненный случайными целыми числами.\n"
    + "Например: m = 3, n = 4.\n-1 4 8 19\n5-2 33-2\n-77 3 8 1 \n"
);

//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

//Вывод строки
void PrintString(string prompt, string text)
{
    Console.WriteLine(prompt + ": " + text);
}

//Генераци заполенного 2х мерного массива нужного размера
int[,] Generate2xArray(int height, int length, int minValue, int maxValue)
{
    int[,] array = new int[height, length];
    Random rnd = new Random();
    for (int j = 0; j < height; j++)
    {
        for (int i = 0; i < length; i++)
        {
            array[j, i] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}

//Печать массива 2х мерного массива
void Print2xArray(int[,] array)
{
    int maxCharsInElement = 4;
    System.Console.WriteLine("Печать массива:");
    for (int j = 0; j < array.GetLength(0); j++)
    {
        System.Console.Write("[");
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            System.Console.Write(
                TabulationText(
                    array[j, i].ToString(), 
                    maxCharsInElement)
                 + ", ");
        }
        System.Console.WriteLine(
            TabulationText(
                array[j, array.GetLength(1) - 1].ToString(), 
                maxCharsInElement)
            + "]");
    }
}

//Доведение строки до размера int maxCharsInElement
string TabulationText(string text, int maxCharsInElement)
{
    for(int weHave = text.Length; weHave < maxCharsInElement; weHave++){
    text = " " + text;
    }
return text;
}

Print2xArray(Generate2xArray(ReadKeyboardInt("Введите высоту массива"), ReadKeyboardInt("Ввидите ширину массива"), -99, 99));
