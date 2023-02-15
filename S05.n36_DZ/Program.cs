// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215");
Console.WriteLine(
    "Задача №36.\n"
    + "Задайте одномерный массив, заполненный случайными числами." 
    + "Найдите сумму элементов, стоящих на нечётных позициях."
    + "[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0"
    + "\n");

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
    System.Console.WriteLine("");
}

int SumElementsOnOddPositionsInArray(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2!=0) summ+= array[i];
    }
    return summ;
}


int[] array = GenerationArray(2, -999, 999);
PrintArray(array);

PrintResult($"Сумма чисел на нечетных позициях равна", SumElementsOnOddPositionsInArray(array).ToString());


