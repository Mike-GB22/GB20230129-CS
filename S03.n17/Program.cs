// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №17\n"
    + "Напишите программу, которая на вход принимает два числа (координаты точки)\n"
    + "и выдает номер четверти плоскости, в которой лежит эта точка.\n"
    + "Например:\nx=34; y=-30 -> 4 \nx=2; y=4-> 1 \nx=-34; y=-30 -> 3 \n"
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
    return $"Точка ({a},{b}) лежит {WhichQuadratXY(a,b)}.";
}

string WhichQuadratXY(int a, int b)
{
    if(a == 0 && b == 0) return "на пересечении осей координат";
    if(a == 0) return "на оси Y";
    if(b == 0) return "на оси X";
    if(a > 0 && b > 0) return "в четверте 1";
    if(a > 0 && b < 0) return "в четверте 2";
    if(a < 0 && b < 0) return "в четверте 3";
    return "в четверте 4";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число x"),
        ReadKeyboardInt("Введите число y")
    )
);