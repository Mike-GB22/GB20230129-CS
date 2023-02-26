// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №13\n"
    + "Напишите программу, которая на вход принимает одно трехзначное число,\n"
    + "а на выходе показывает третью с конца цифру этого числа (сотни)\n"
    + "Например: 123 -> 1\n"
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
    if(a < 100) return $"Чисто меньше 100, так что третьей цифры нет, но будем считать, что третья с конца цифра (сотни) числа [{a}]: 0.";
    
    int text = a/100;
    text %= 10;
    
    return $"Третья с конца цифра (сотни) числа [{a}]: {text}.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);