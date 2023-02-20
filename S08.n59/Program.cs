// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №59.\n"
    + "Задайте двумерный массив из целых чисел.\n"
    + "Напишите программу, которая удалит строку и столбец,\n"
    + "на пересечении которых расположен наименьший элемент массива.\n"
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

//Составляем новую матрицу, удаляя указанную строку и столбец, возвращаем новый массив
double[,] DeleteRowAndColumn(int iDel, int jDel, double[,] array)
{
    int length = array.GetLength(1);
    int height = array.GetLength(0);

    double[,] arrayNew = new double[height - 1, length - 1];
    int iNew = -1;
    for (int i = 0; i < height; i++)
    {
        if (i != iDel)
        {
            iNew++;
            int jNew = -1;
            for (int j = 0; j < length; j++)
            {
                if (j != jDel)
                {
                    jNew++;
                    arrayNew[iNew, jNew] = array[i, j];
                }
            }
        }
    }
    return arrayNew;
}

int[] FindPositionMinimalElemetn(double[,] array)
{
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    return new int[]{iMin, jMin};
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

        PrintString("Выполняем условия задачи пробно, удаляем строку [1], столбец [1]");
        Print2xArray(
            DeleteRowAndColumn(1, 1, matrix)
        );
        System.Console.WriteLine();

        int[] positionMinElement = FindPositionMinimalElemetn(matrix);
        PrintString($"Выполняем условия задачи по настоящему, удаляем строку [{positionMinElement[0]}] и столбец [{positionMinElement[1]}],\n"
            +$"место нахождения минимального значения [{matrix[positionMinElement[0],positionMinElement[1]]}]"
        );
        Print2xArray(
            DeleteRowAndColumn(positionMinElement[0], positionMinElement[1], matrix)
        );

    }

    main();