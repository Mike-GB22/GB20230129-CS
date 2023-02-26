// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №22\n"
    + "Напишите программу, которая на вход принимает число (N)\n"
    + "и выдает таблицу квадратов чисел от 1 до N.\n"
    + "Например:\n5 -> 1, 4, 9, 16, 25. \n2 -> 1,4\n"
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
    if (a < 1) return "Число должно быть больше 0";
    return $"Квадраты чисел от 1 до [{a}]: {SubSolutionTask(a)}.";
}

string SubSolutionTask(int a)
{
    string text = "";
    for (int i = 1; i < a; i++)
    {
        text += i * i + ", ";
    }
    text += a * a;
    return text;
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);