// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215");
Console.WriteLine(
    "Задача №38.\n"
    + "Задайте массив вещественных чисел.\n"
    + "Найдите разницу между максимальным и минимальным элементов массива.\n"
    + "Например:\n"
    + "[3 7 22 2 78] -> 76; [2 0,4 9 7,2 78] -> 77,6"
    + "\n");

//Печать результата
void PrintResult(string prompt, string outText)
{
    Console.WriteLine(prompt + ": " + outText);

}

double[] GenerationArray(int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue*10, maxValue*10);
        array[i] /= 10;
    }

    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("");
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.WriteLine(array[array.Length - 1] + " ]");
    System.Console.WriteLine("");
}

double minElement;
double maxElement;
double SearchDifferenceMinAndMaxElementInArray(double[] array)
{
    minElement=array[0];
    maxElement=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElement) minElement = array[i];
        if (array[i] > maxElement) maxElement = array[i];
    }    
    return maxElement-minElement;
}


double[] array = GenerationArray(5, 0, 10);
PrintArray(array);

PrintResult("Разница между максимальным и минимальным элементом массива равна", SearchDifferenceMinAndMaxElementInArray(array).ToString());


