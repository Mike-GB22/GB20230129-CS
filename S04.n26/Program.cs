// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №26\n"
    + "Напишите программу, которая на вход принимает пятизначное числоа\n"
    + "и выдает количество цифр в числе\n"
    + "Например:\n14212 -> 5 \n234 -> 3 \n1282121 -> 7 \n"
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
    char[] text = a.ToString().ToArray();
    int length = text.Length;
   
    return $"Число [{a}] состоит из количества цифр: {length} ";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);