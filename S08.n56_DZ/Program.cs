// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №56.\n"
    + "Задайте прямоугольный двумерный массив.\n"
    + "Напишите программу, которая будет находить строку с наименьшей суммой элементов.\n"
    + "Например, задан массив:\n"
    + "1 4 7 2\n5 9 2 3\n8 4 2 4\n5 2 6 7\n"
    + "Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка\n"
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

//Подсчет суммы каждой строки Матрицы, возращаем одномерный массив сумм стро, где индекс - номер строки
double[] SummColumnInRow(double[,] array)
{
    int length = array.GetLength(1);
    int height = array.GetLength(0);

    double[] summInRow = new double[height];

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            summInRow[i]+=array[i, j];
        }
    }
    return summInRow;
}

//Поиск минимального элемента одномерного мерного массива, возвращаем индекс
int FindIndexMinimalElemetn(double[] array)
{
    int iMin = 0;    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] < array[iMin]) iMin = i;
    }
    return iMin;
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
    int indexMinimalElement = FindIndexMinimalElemetn(SummColumnInRow(matrix));

    PrintString("Минимальная сумма в строке", indexMinimalElement.ToString());
    
}

main();