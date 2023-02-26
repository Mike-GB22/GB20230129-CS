// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №09\n"
    + "Напитишите программу,\n"
    + "котоаря выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.\n"
    + "Например: 98 -> 9"
    + "\n"
);

//Генераци числа, от minValue и до maxValue
int GenerateInt(int minValue, int maxValue)
{
    Random rnd = new Random();
    return rnd.Next(minValue, maxValue);
}


//Вывод строки
void PrintString(string prompt, string text = "")
{
    Console.WriteLine(prompt + ": \n" + text + "\n");
}

string SolutionTask(int a)
{
    int digit10 = a / 10;
    int digit1 = a % 10;

    string text = "МЕНЬШЕ";
    int digitMax = digit1;
    if(digit10 > digit1) {
        text = "БОЛЬШЕ";
        digitMax = digit10;
    }
        
    return $"Анализ числа [{a}]: десяток числа {digit10} {text} единиц числа {digit1},"
        +$"\nзначит наибольшая цифра данного числа {digitMax}.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        GenerateInt(10, 99)
    )
);