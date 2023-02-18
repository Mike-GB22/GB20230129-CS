// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №49\n"
    + "Задайте двумерный массив.\n"
    + "Найдите элементы, у которых оба индекса чётные,\n"
    + "и замените эти элементы на их квадраты.\n"
    + "Например: m = 3, n = 3.\n0 1 2\n1 2 3\n2 4 5\n"
    + "->\n0 1 2\n1 2 3\n2 16 5\n"
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
int[,] Generate2xArray(int height, int length)
{
    int[,] array = new int[height, length];
    for (int j = 0; j < height; j++)
    {
        for (int i = 0; i < length; i++)
        {
            array[j, i] = j + i;
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

int[,] Update2xArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = Convert.ToInt32(Math.Pow(array[i, j],2));
        }
    }
    return array;
}

//Изменине цвета вывода текста в консоль, тут для чисел. Сброс цвтвета, по слову "reset".
void ConsoleColorZahle(string text = "reset")
{
    if (text == "reset") Console.ResetColor();
    else
    {
        double number = Convert.ToDouble(text);
        int color = Convert.ToInt32(number)%16;
        Console.ForegroundColor = (ConsoleColor)color;     
    }
}

int[,] matrix = Generate2xArray(
        ReadKeyboardInt("Введите высоту массива"),
        ReadKeyboardInt("Ввидите ширину массива")
        );
Print2xArray(matrix);
PrintString("Выполняем условие задачи");
Print2xArray(Update2xArray(matrix));
