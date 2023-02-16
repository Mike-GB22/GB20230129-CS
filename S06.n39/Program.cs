// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №40\n"
    + "Напишите программу, которая принимает на вход"
    + "три числа и проверяет,\n может ли существовать"
    + "треугольник с сторонами такой длины.\n"
);

//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintString(string prompt, string text)
{
    Console.Write(prompt + ": " + text);
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] array){
    System.Console.Write("Печать массива: [");
    for(int i=0; i<array.Length-1; i++){
        System.Console.Write(array[i]+", ");
    }
    System.Console.WriteLine(array[array.Length-1]+"]");
}

void ReversArray(int[] array){
    int tmp;
    for(int i=0;i<array.Length/2; i++){
        tmp=array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i]=tmp;
    }
}

int[] array = GenerateArray(100,-9,9);
PrintArray(array);
ReversArray(array);
PrintString("\nРеверсируем массив","\n");
PrintArray(array);