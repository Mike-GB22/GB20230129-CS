// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №19\n"
    + "Напишите программу, которая на вход принимает пятизначное числоа\n"
    + "и проверяет, является ли это число палиндромом.\n"
    + "Например:\n14212 -> нет \n23432 -> да \n12821 -> да \n"
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
    string negativation = "";
    char[] text = a.ToString().ToArray();
    int length = text.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (text[i] != text[length - 1 - i])
        {
            negativation = "НЕ! ";
            break;
        }
    }
    
    return $"Число [{a}] {negativation}является полиндромом";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число")
    )
);