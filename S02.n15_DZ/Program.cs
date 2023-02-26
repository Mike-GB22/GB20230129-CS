// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №15\n"
    + "Напишите программу, которая на вход принимает одно число (N),\n"
    + "а на выходе проверяет, является ли этот день выходным\n"
    + "Например:\n3 -> нет,\n5 -> нет"
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
       
    return $"Число [{a}], сотвествует дню недели \"{days[--a]}\", и это \"{dayIsWeekEnd(a)}\".";
}

string dayIsWeekEnd(int a){
    bool[] weekEnd = new bool[]{false, false, false, false, false, true, true};
    if(weekEnd[a] == true) {return "выходной";}
    return "рабочий день";
}

PrintString("\nРешение задачи",
    SolutionTask(
        ReadKeyboardInt("Введите число (от 1 до 7)")
    )
);