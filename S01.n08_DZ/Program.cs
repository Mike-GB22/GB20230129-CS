// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №08\n"
    + "Напишите программу, которая на вход принимает одно число (N),\n"
    + "а на выходе показывает все чётные числа от 1 до N\n"
    + "Например:\n5 -> 2, 4\n8 -> 2, 4, 6, 8"
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
    string text = "";
    for(int i = 2; i <=a; i+=2) text += " " + i;
    
    return $"Все четные числа от 1 до [{a}],{text}.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);