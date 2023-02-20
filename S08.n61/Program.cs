// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №61.\n"
    + "Вывести первые N строк треугольника Паскаля.\n"
    + "Сделать вывод в виде равнобедренного треугольника.\n"
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
    Console.WriteLine(prompt + ": " + text);
}

long Factorial(int n)
{
    long x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void PrintPascalTriangle(int nRow)
{
    for (int row = 0; row <= nRow; row++)
    {
        for (int spaces = 0; spaces <= nRow - row; spaces++)
            System.Console.Write(" ");
        for( int elementsRow = 0; elementsRow <= row; elementsRow++){
            System.Console.Write(" ");
            System.Console.Write(Factorial(row)/(Factorial(elementsRow)*Factorial(row-elementsRow)));
        }
        System.Console.WriteLine("");
    }
}

void main()
{
    int n = ReadKeyboardInt("Введите количество строк треугольника N");
    System.Console.WriteLine();

    PrintString("Выполняем условия задачи");
    PrintPascalTriangle(n);

}

main();