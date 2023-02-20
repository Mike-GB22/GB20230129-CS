// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №54.\n"
    + "Задайте двумерный массив из целых чисел.\n"
    + "Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n"
    + "Например, задан массив - > итоге получается вот такой массив\n"
    + "1 4 7 2       7 4 2 1\n"
    + "5 9 2 3  - >  9 5 3 2\n"
    + "8 4 2 4       8 4 4 2\n"
);

//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

//Вывод строки
void PrintString(string prompt, string text = "")
{
    Console.WriteLine(prompt + ": " + text);
}

//Генераци заполенного 2х мерного массива нужного размера
double[,] Generate2xArray(int height, int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] array = new double[height, length];
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
void Print2xArray(double[,] array)
{
    int maxCharsInElement = 5;
    System.Console.WriteLine("Печать массива:");
    for (int j = 0; j < array.GetLength(0); j++)
    {
        System.Console.Write("[");
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            if (i == j) { Console.BackgroundColor = ConsoleColor.DarkGray; }
            System.Console.Write(
                TabulationText(
                    array[j, i].ToString(),
                    maxCharsInElement)
                 + ", ");
            Console.ResetColor();
        }
        if (j == array.GetLength(1) - 1) { Console.BackgroundColor = ConsoleColor.DarkGray; }
        System.Console.WriteLine(
            TabulationText(
                array[j, array.GetLength(1) - 1].ToString(),
                maxCharsInElement)
            + "]");
        Console.ResetColor();
    }
    Console.ResetColor();
}

//Доведение строки до размера int maxCharsInElement
string TabulationText(string text, int maxCharsInElement)
{
    if (text.Length > maxCharsInElement)
    {
        text = text.Substring(0, maxCharsInElement);
    }
    else
    {
        for (int weHave = text.Length; weHave < maxCharsInElement; weHave++)
        {
            text = " " + text;
        }
    }
    ConsoleColorZahle(text);
    return text;
}

//Изменине цвета вывода текста в консоль, тут для чисел. Сброс цвтвета, по слову "reset".
void ConsoleColorZahle(string text = "reset")
{
    if (text == "reset") Console.ResetColor();
    else
    {
        double number = Convert.ToDouble(text);
        int color = Convert.ToInt32(Math.Abs(number)) % 16;
        Console.ForegroundColor = (ConsoleColor)color;
    }
}

//Модификация матрицы. Кажду строчку надо отсортировать от Макс к Мин. Работаем со ссылкой
double[,] UpdateMatrix(double[,] array)
{
    int length = array.GetLength(1);
    int height = array.GetLength(0);

    for (int i = 0; i < height; i++)
    {
        double[] arrayTmp = new double[length];
        //Выжимаем строку в отдельный массив, я думаю это можно было бы сделать просче
        for (int j = 0; j < length; j++)
        {
            arrayTmp[j] = array[i, j];
        }
        //Внешняя функция сортировки
        SortArray(arrayTmp);
        for (int j = 0; j < length; j++)
        {
            array[i, j] = arrayTmp[j];
        }
    }
    return array;
}

//Сортируем пузырьком переданный массив, ни чего не возвращаем (работаем со ссылкой)
void SortArray(double[] array)
{
    int length = array.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length - 1 - i; j++)
        {
            if (array[j] < array[j + 1])
            {
                double tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }
}


void main()
{
    double[,] matrix = Generate2xArray(
        ReadKeyboardInt("Введите размер матрицы N"),
        ReadKeyboardInt("Введите размер матрицы M"),
        -99, 99);
    Print2xArray(matrix);

    System.Console.WriteLine();
    Console.ResetColor();

    PrintString("Выполняем условия задачи");
    Print2xArray(
        UpdateMatrix(matrix)
    );
}

main();