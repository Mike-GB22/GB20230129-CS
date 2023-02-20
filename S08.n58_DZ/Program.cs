// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230219");
Console.WriteLine("\n"
    + "Задача №58.\n"
    + "Задайте две матрицы.\n"
    + "Напишите программу, которая будет находить произведение двух матриц.\n"
    + "Например, даны 2 матрицы:\n"
    + "2 4 | 3 4\n3 2 | 3 3\n"
    + "Результирующая матрица будет:\n"
    + "18 20\n15 18\n"
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
    System.Console.WriteLine();
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

//Перемножение 2х Матриц, возращаем новую матрицу
double[,] MatrixMultuplication(double[,] array1, double[,] array2)
{
    int length1 = array1.GetLength(1);
    int height1 = array1.GetLength(0);
    int length2 = array2.GetLength(1);
    int height2 = array2.GetLength(0);

    double[,] arrayMultiplication = new double[height1, length2];

    if (length1 != height2)
    {
        System.Console.WriteLine("Матрицы A и B могут быть перемножены, если они совместимы в том смысле, что число столбцов матрицы A равно числу строк.");
        return array1;
    }

    for (int i = 0; i < height1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int index = 0; index < length1; index++)
            arrayMultiplication[i,j] += array1[i,index]*array2[index,j];
        }
    }
    return arrayMultiplication;
}

void main()
{
    int n = ReadKeyboardInt("Введите размер матрицы N");
    int m = ReadKeyboardInt("Введите размер матрицы M");
    double[,] matrix1 = Generate2xArray(n, m, 0, 10);
    double[,] matrix2 = Generate2xArray(m, n, 0, 10);
    PrintString("Матрица №1");
    Print2xArray(matrix1);

    PrintString("Матрица №2");
    Print2xArray(matrix2);

    PrintString("Выполняем условия задачи. Умножение Матрицы 1 на 2");
    Print2xArray(MatrixMultuplication(matrix1,matrix2));

    PrintString("Выполняем условия задачи. Умножение Матрицы 2 на 1");
    Print2xArray(MatrixMultuplication(matrix2,matrix1));

}

main();