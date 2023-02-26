// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №21\n"
    + "Напишите программу, которая на вход принимает координаты двух точек\n"
    + "и находит растояние между ними в 3D пространстве.\n"
    + "Например:\nA (3,6,8); B (2,1,-7), -> 15.84 \nA (7,-5, 0); B (1,-1,9) -> 11.53 \n"
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

string SolutionTask(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double distance = (a2 - a1)*(a2 - a1)+(b2 - b1)*(b2 - b1)+(c2 - c1)*(c2 - c1);
    distance = Math.Round(Math.Sqrt(distance)*1000)/1000;
    return $"Растояние между точкой 1 ({a1},{b1},{c1}) и точкой 2 ({a2},{b2},{c2}) [{distance}]";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Координата 1\nВведите число x"),
        ReadKeyboardInt("Введите число y"),
        ReadKeyboardInt("Введите число z"),
        ReadKeyboardInt("Координата 2\nВведите число x"),
        ReadKeyboardInt("Введите число y"),
        ReadKeyboardInt("Введите число z")        
    )
);