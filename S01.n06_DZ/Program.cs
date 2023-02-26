// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №06\n"
    + "Напишите программу, которая на вход принимает.\n"
    + "одно число, и выдает является ли четным .\n"
    + "Например:\n4 - четное, 5 - не четное\n"
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
    string text = "четным";
    if (a % 2 != 0) text = "не четным";
    return $"Число [{a}], является \"{text}\".";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);