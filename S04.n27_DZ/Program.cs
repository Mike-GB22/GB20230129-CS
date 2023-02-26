// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №27\n"
    + "Напишите программу, которая на вход принимает пятизначное числоа\n"
    + "и выдаёт сумму цифр в числе.\n"
    + "Например:\n452 -> 11 \n82 -> 10 \n9012 -> 12 \n"
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
    int sum = 0;
    char[] text = a.ToString().ToArray();
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        sum += int.Parse(text[i].ToString());
    }
    
    return $"Число [{a}] состоит из цифр, сумма который: {sum} ";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);