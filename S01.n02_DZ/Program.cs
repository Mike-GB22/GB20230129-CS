// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №02\n"
    + "Напишите программу, которая на вход принимает.\n"
    + "два числа и и выдаёт, какое число большее, а какое меньшее.\n"
    + "Например:\na = 5; b = 7 ->  max = 7\na = 2 b = 10 -> max = 10\na = -9 b = -3 -> max  = -3\n"
    + "\n"
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
    Console.WriteLine(prompt + ": \n" + text + "\n");
}

string SolutionTask(int a, int b)
{
    int max = a;
    string maxName = "a";
    if (a < b)
    {
        max = b;
        maxName = "b";
    }
    return $"Большее из числа a [{a}] и b [{b}], является число \"{maxName}\" [{max}].";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число a"),
        ReadKeyboardInt("Введите число b")
    )
);