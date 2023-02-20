// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230220");
Console.WriteLine("\n"
    + "Задача №62.\n"
    + "Напишите программу, которая заполнит спирально массив 4 на 4.\n"
    + "Например, на выходе получается вот такой массив:\n"
    + "01 02 03 04\n12 13 14 05\n11 16 15 06\n10 09 08 07\n"
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

//Заполнение 2х мерного массива по спирали, цифрами
double[,] GenerateSpiralArray(int height, int length)
{
    int count = 1;
    int countMax = height * length + count;
    double[,] array = new double[height, length];

    for (int circle = 0; count < countMax && circle <= height / 2; circle++)
    {
        for (int i = circle; i < length - circle && count < countMax; i++) array[circle, i] = count++;
        for (int i = circle + 1; i < height - circle && count < countMax; i++) array[i, length - circle - 1] = count++;
        for (int i = length - circle - 2; i >= circle && count < countMax; i--) array[height - circle - 1, i] = count++;
        for (int i = height - circle - 2; i > circle && count < countMax; i--) array[i, circle] = count++;
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
            System.Console.Write(
                TabulationText(
                    array[j, i].ToString(),
                    maxCharsInElement)
                 + ", ");
            Console.ResetColor();
        }
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


void main()
{
    PrintString("Матрица спиральная");
    Print2xArray(
        GenerateSpiralArray(
            ReadKeyboardInt("Введите размер матрицы N"),
            ReadKeyboardInt("Введите размер матрицы M")
            ));
}

main();