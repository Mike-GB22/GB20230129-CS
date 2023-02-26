// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №25\n"
    + "Напишите программу, которая на вход принимает число (N)\n"
    + "и в цикле возводит первое число в натуральную степень - второе число.\n"
    + "Например: \n3, 5 -> 243 \n2, 4 -> 16\n "
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
    if(b < 1) return $"Число степени должно быть больше 0, а у Вас [{a}].";
    int itog = 1;
    for(int i = 1; i<=b; i++) itog *= a;
    return $"Число [{a}] в степери [{b}] будет: [{itog}].";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число"),
        ReadKeyboardInt("Введите число")
    )
);