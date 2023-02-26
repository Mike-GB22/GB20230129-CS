// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №12\n"
    + "Напишите программу, которая на вход принимает два числа,\n"
    + "и проверяет, является ли второе число кратным первому.\n"
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
    string ostatokText = "";

    int ostatok = a % b;
    if (ostatok != 0) {
        negativation="НЕ ";
        ostatokText = $", остаток от деления [{ostatok}] ";
    }
    return $"Число [{a}] {negativation}является кратным числу [{b}]{ostatokText}.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число a"),
        ReadKeyboardInt("Введите число b")
    )
);