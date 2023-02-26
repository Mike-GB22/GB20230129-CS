// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №05\n"
    + "Напишите программу, которая на вход принимает одно число (N),\n"
    + "а на выходе показывает все целые числа в промежутке от -N до N\n"
    + "Например:\n4 -> -4, -3, -2, -1, 0, 1, 2, 3, 4\n"
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

string SolutionTask(int a)
{
    int delta = 1;
    if (a < 0) delta = -1;
    string text = "";
    int i = a * -1;
    do
    {
        text += i + ", ";
        i += delta;
    } while (Math.Abs(i) < Math.Abs(a));
    text += i;
        if (a == 0) text = "0";
    return $"Все числа в диапазоне от [{a * -1}] до [{a}]:\n{text}.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);