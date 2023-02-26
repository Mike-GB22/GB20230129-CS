// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №03\n"
    + "Напишите программу, которая на вход принимает одно число (N),\n"
    + "а на выходе показывает день недели по этому числу\n"
    + "Например:\n3 -> среда,\n5 -> пятница"
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
    if(a > 7 || a < 1) return $"Число [{a}], выходит за рамки условий.";
    string[] days = new string[]{"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
   
    return $"Число [{a}], сотвествует дню недели \"{days[--a]}\".";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число (от 1 до 7)")
    )
);