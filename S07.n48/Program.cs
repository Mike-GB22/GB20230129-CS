// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №48\n"
    + "Задайте двумерный массив размером m×n,\n"
    + "каждый элемент в массиве находится по формуле: Aₘₙ=m+n.\n"
    + "Выведите полученный массив на экран\n"
    + "Например: m = 3, n = 4.\n0 1 2 3\n1 2 3 4\n2 3 4 5\n"
);

//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

//Вывод строки
// void PrintString(string prompt, string text)
// {
//     Console.WriteLine(prompt + ": " + text);
// }

//Генераци заполенного 2х мерного массива нужного размера
int[,] Generate2xArray(int height, int length)
{
    int[,] array = new int[height, length];
    for (int j = 0; j < height; j++)
    {
        for (int i = 0; i < length; i++)
        {
            array[j, i] = j+i;
        }
    }
    return array;
}

//Печать массива 2х мерного массива
void Print2xArray(int[,] array)
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
        }
        System.Console.WriteLine(
            TabulationText(
                array[j, array.GetLength(1) - 1].ToString(),
                maxCharsInElement)
            + "]");
    }
    ConsoleColorZahle();
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
        if (number == 0) Console.ForegroundColor = ConsoleColor.Yellow;
        else if (number > 0) Console.ForegroundColor = ConsoleColor.Green;
        else Console.ForegroundColor = ConsoleColor.Red;
    }
}

Print2xArray(
    Generate2xArray(
        ReadKeyboardInt("Введите высоту массива"),
        ReadKeyboardInt("Ввидите ширину массива")
        ));
