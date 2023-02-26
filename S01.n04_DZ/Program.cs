// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №04\n"
    + "Напишите программу, которая на вход принимает.\n"
    + "три числа и выдаёт, максимальное число.\n"
    + "Например:\na = 5; b = 7; с = 10 -> 10\n"
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

string SolutionTask(int a, int b, int c)
{
    int max = a;
    string maxName = "a";
    if (b > a && b > c)
    {
        max = b;
        maxName = "b";
    }
    if (c > a && c > b)
    {
        max = c;
        maxName = "c";
    }

    return $"Большее из числа a [{a}], b [{b}] и c [{c}], является число \"{maxName}\" [{max}].";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число a"),
        ReadKeyboardInt("Введите число b"),
        ReadKeyboardInt("Введите число c")
    )
);