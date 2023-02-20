// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230219");
Console.WriteLine("\n"
    + "Задача №60.\n"
    + "Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.\n"
    + "Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.\n"
    + "Массив размером 2 x 2 x 2\n"
    + "66(0,0,0) 25(0,1,0)\n"
    + "34(1,0,0) 41(1,1,0)\n"
    + "27(0,0,1) 90(0,1,1)\n"
    + "26(1,0,1) 55(1,1,1)\n"
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

//Генераци заполенного 3х мерного массива нужного размера
int[,,] Generate3xArray(int height, int length, int deepth)
{
    int[,,] array = new int[height, length, deepth];
    int count = 10;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < deepth; k++)
            {
                array[i, j, k] = count++;
            }
        }
    }
    return array;
}

//Печать массива 3х мерного массива
void Print3xArray(int[,,] array, string prompt = "Печать 3х мернаго массива:", string text = "", int maxCharsInElement = 4, int maxSpaceBeetweenElement = 0)
{
    int length = array.GetLength(0);
    int height = array.GetLength(1);
    int deepth = array.GetLength(2);
    System.Console.WriteLine(prompt + text);
    for (int i = 0; i < length; i++)
    {
        string spaces = "";
        System.Console.WriteLine("Row " + i);
        for (int k = -1; k < deepth; k++)
        {
            if (k != -1) System.Console.Write(
                spaces + "Deep " +
                TabulationText(k.ToString(), maxCharsInElement - 1)
                );
            else System.Console.Write(spaces + "        ");
            for (int j = 0; j < height; j++)
            {
                if (k == -1)
                {
                    System.Console.Write("  Col" +
                        TabulationText(j.ToString(), maxCharsInElement - 1)
                        + " "
                    );
                }
                else
                {
                    System.Console.Write(" [");
                    System.Console.Write(
                        TabulationText(
                            array[i, j, k].ToString(),
                            maxCharsInElement));
                    System.Console.Write("]  ");
                }
            }
            spaces += " ";
            System.Console.WriteLine("");
        }
        System.Console.WriteLine("");
    }
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
    return text;
}

int x = ReadKeyboardInt("Введите размерность массива, строк");
int y = ReadKeyboardInt("Введите размерность массива, строк");
int z = ReadKeyboardInt("Введите размерность массива, строк");

PrintString("Выполнение задания");

Print3xArray(Generate3xArray(x, y, z));