// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №18\n"
    + "Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных\n" 
    + "координат точек в этой четверти (x и y)\n"
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
    string text = "я четверть лежит в координатах";
    if(a == 1) return $"1{text} X>0, Y>0";
    if(a == 2) return $"2{text} X>0, Y<0";
    if(a == 3) return $"3{text} X<0, Y<0";
    if(a == 4) return $"4{text} X<0, Y>0";
    return "Число четверти должно быть от 1 до 4";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите номер четверти")
    )
);