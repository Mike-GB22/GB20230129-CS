// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №11\n"
    + "Напитишите программу, которая выводит случайное трёхзначное число\n"
    + "и удаляет вторую цифру этого числа.\n"
    + "Например: 198 -> 18"
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
    int hightDigits = a / 100;
    int lowDigits = a % 10; 
       
    return $"Удаляем вторую цифры (десятки) числа [{a}]: получаем новое число {hightDigits}{lowDigits}.";
}

PrintString("\nРешение задачи",
    SolutionTask(
        GenerateInt(100, 999)
    )
);