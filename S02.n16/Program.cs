// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №16\n"
    + "Напишите программу, которая на вход принимает два числа,\n"
    + "и проверяет, является ли одно число, квадратом второго.\n"
    + "Например:\na = 25; b = 5 -> 25 является квадаратом 5\na = 2 b = 10 -> не является квадаратом\n"
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
    return SubSolutionTask(a, b)+"\n"+SubSolutionTask(b, a);
}

string SubSolutionTask(int a, int b){
    string negativation ="";
    if (a != b * b) negativation="НЕ ";
    return $"Число [{a}] {negativation}является квадратом числа [{b}].";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число a"),
        ReadKeyboardInt("Введите число b")
    )
);