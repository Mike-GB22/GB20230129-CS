// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №24\n"
    + "Напишите программу, которая на вход принимает число (N)\n"
    + "и выдает произведение чисел от 1 до N.\n"
    + "Например:\n4 -> 24, 5 -> 120 \n"
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
    int multi = 1;
    for(int i = 1; i<=a; i++) multi *= i;
    return $"Произведение всех чисел от 1 до [{a}]: {multi}.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);