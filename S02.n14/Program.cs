// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №14\n"
    + "Напишите программу, которая на вход принимает одно число,\n"
    + "и проверяет, является ли оно кратным 7 и 23 одновременно.\n"
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
    string negativation ="НЕ ";
    if (a % 7 == 0 && a % 23 == 0) negativation="";
    return $"Число [{a}] {negativation}является кратным 7 и 23 одновременно.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число a")
    )
);