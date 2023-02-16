// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №0\n"
    + "Напишите программу, которая принимает на вход"
    + "три числа и проверяет,\n может ли существовать"
    + "треугольник с сторонами такой длины.\n"
);

Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №42\n"
    + "Напишите программу, которая будет преобразовывать десятичное число в двоичное.\n" 
    + "\n"
    + "Например: 45 -> 101101; 3 -> 11; 2 -> 10\n"    
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

//Генераци заполенного массива нужного размера
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

//Печать массива
void PrintArray(int[] array){
    System.Console.Write("Печать массива: [");
    for(int i=0; i<array.Length-1; i++){
        System.Console.Write(array[i]+", ");
    }
    System.Console.WriteLine(array[array.Length-1]+"]");
}

//Инверсия массива
void ReversArray(int[] array){
    int tmp;
    for(int i=0;i<array.Length/2; i++){
        tmp=array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i]=tmp;
    }
}

//Десятичное число в двоичное
string DecToBin(int num){
    if(num<2) return num.ToString();
    return ""+DecToBin(num/2)+num%2;

}