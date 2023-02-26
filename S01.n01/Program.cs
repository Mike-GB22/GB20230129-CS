// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №01\n"
    + "Напишите программу, которая на вход принимает.\n"
    + "два числа и проверяет, является ли первое число, квадратом второго.\n"
    + "Например:\na = 25; b = 5 -> да\na = 2 b = 10 -> нет\na = 9; b = -3 -> да \na = -3 b = 9 -> нет"
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
    string negativation ="";
    if (a != b * b) negativation="НЕ ";
    return $"Число a [{a}] {negativation}является квадратом числа b [{b}].";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число a"),
        ReadKeyboardInt("Введите число b")
    )
);