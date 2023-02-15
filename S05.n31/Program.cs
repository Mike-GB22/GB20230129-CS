// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215");
Console.WriteLine(
    "Задача №31.\n"
    + "Задайте массив из 12 элементов, заполенный случайными числами из промежутка [-9,9]"
    + "Найти сумму отрицательных и положитлеьных эелментов массива");

//Печать результата
void PrintResult(string prompt, string outText)
{
    Console.WriteLine(prompt + ": " + outText);

}

int[] GenerationArray(int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }

    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("");
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine(array[array.Length - 1] + " ]");
}

int SummPositivOrNegativZahl(int[] array, int positivOrNegativ)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int zahl = array[i];
        if (positivOrNegativ >= 0)
        {
            if (zahl > 0) summ += zahl;
        }
        else
        {
            if (zahl < 0) summ += zahl;
        }
    }
    return summ;
}

int[] array = GenerationArray(10, -9, 9);
PrintArray(array);

PrintResult("Сумма всех положительных чисел массива", SummPositivOrNegativZahl(array, 1).ToString());
PrintResult("Сумма всех отрицательных чисел массива", SummPositivOrNegativZahl(array, -1).ToString());

