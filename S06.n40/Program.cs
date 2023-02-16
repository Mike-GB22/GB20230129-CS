// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №40\n"
    + "Напишите программу, которая принимает на вход"
    + "три числа и проверяет, может ли существовать"
    + "треугольник с сторонами такой длины."
);

//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

bool DreiEckeMoglich(int a, int b, int c)
{
    return (a + b > c && a + c > b && b + c > a);
}

void PrintString(string prompt, string text)
{
    Console.Write(prompt + ": " + text);
}

void PrintStringMoglich(string prompt, bool moglich)
{
    if (moglich) PrintString(prompt, "Возможно!");
    else PrintString(prompt, "Невозможно!");
}

PrintStringMoglich("Сущесвования такого треугольника",
    DreiEckeMoglich(
        ReadKeyboardInt("Длина 1й стороны"),
        ReadKeyboardInt("Длина 2й стороны"),
        ReadKeyboardInt("Длина 3й стороны"))
        );