Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №43\n"
    + "Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями \n"
    + "y = k1 * x + b1, y = k2 * x + b2; \n"
    + "значения b1, k1, b2 и k2 задаются пользователем. \n"
    + "\n"
    + "Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)\n"    
);

//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

//Вывод строки
void PrintString(string prompt, string text)
{
    Console.WriteLine(prompt + ": " + text);
}

double b1 = ReadKeyboardInt("Введите точку B1");
double k1 = ReadKeyboardInt("Введите точку K1");
double b2 = ReadKeyboardInt("Введите точку B2");
double k2 = ReadKeyboardInt("Введите точку K2");

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
//double y2 = k2*x+b2;

PrintString("Пересечение в точке",$"({x},{y})");
//PrintString("Пересечение в точке",$"({x},{y2})");