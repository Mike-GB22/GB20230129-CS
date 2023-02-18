// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №51\n"
    + "Задайте двумерный массив. Ширина и Высота одинаковая\n"
    + "Найдите сумму элементов, находящихся на главной диагонали\n"
    + "(с индексами (0,0); (1;1) и т.д. \n"
    + "Например: m = 3.\n0 1 2\n1 2 3\n2 4 5\n"
    + "0 + 2 + 5 = 7\n"
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
            if(i==j) {Console.BackgroundColor=ConsoleColor.Red;}
            System.Console.Write(
                TabulationText(
                    array[j, i].ToString(),
                    maxCharsInElement)
                 + ", ");
            Console.ResetColor();
        }
        if(j==array.GetLength(1)-1) {Console.BackgroundColor=ConsoleColor.Red;}
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

string CountSumDiag(int[,] array)
{   
    string sumText = "";
    int sum = 0;
    int length = array.GetLength(0) <= array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        int num = array[i, i];
        sum += num;
        sumText +=" "+num;
    }
    sumText+=" = "+sum;
    return sumText;
}

//Изменине цвета вывода текста в консоль, тут для чисел. Сброс цвтвета, по слову "reset".
void ConsoleColorZahle(string text = "reset")
{
    if (text == "reset") Console.ResetColor();
    else
    {
        double number = Convert.ToDouble(text);
        int color = Convert.ToInt32(number) % 16;
        Console.ForegroundColor = (ConsoleColor)color;
    }
}

int n = ReadKeyboardInt("Введите размер матрицы");
int[,] matrix = Generate2xArray(n,n);
Print2xArray(matrix);

System.Console.WriteLine();
Console.ResetColor();

PrintString("Сумма чисел главной диагонали равна", CountSumDiag(matrix));