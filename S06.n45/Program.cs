Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №45\n"
    + "Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.\n"
    + "\n"
);

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
void PrintArray(int[] array)
{
    System.Console.Write("Печать массива: [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine(array[array.Length - 1] + "]");
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

PrintString("Поэлементно копируем массив", "");
PrintArray(CopyArray(GenerateArray(10, -9, 9)));
