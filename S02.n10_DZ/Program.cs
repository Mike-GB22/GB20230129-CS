// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №07\n"
    + "Напишите программу, которая на вход принимает одно трехзначное число,\n"
    + "а на выходе показывает вторую с конца цифру этого числа (десятки)\n"
    + "Например: 123 -> 2\n"
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
    if(a < 10) return $"Чисто меньше 10, так что второй цифры нет, но будем считать, что вторая с конца цифра (десятки) числа [{a}]: 0.";

    int text = a/10;
    text %= 10;
    
    return $"Вторая с конца цифра (десятки) числа [{a}]: {text}.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);