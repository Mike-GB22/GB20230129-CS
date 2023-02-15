// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215");
Console.WriteLine(
    "Задача №37.\n"
    + "Найдите произведение пар чисел в одномерном массиве.\n" 
    + "Парой считаем первый и последний элемент, второй и предпоследний и т.д.\n"  
    + "Результат запишите в новом массиве.\n" 
    + "Например:\n"
    + "[1 2 3 4 5] -> 5 8 9; [6 7 3 6] -> 36 21"
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
    //System.Console.WriteLine("");
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine(array[array.Length - 1] + " ]");
    System.Console.WriteLine("");
}

int[] multiplicationElementsFromArray(int[] array)
{
    int[] newArray;
    int lengthOfOldArray = array.Length;
    if(lengthOfOldArray %2 == 0) newArray = new int[lengthOfOldArray/2];
    else newArray = new int[lengthOfOldArray/2+1];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] * array[lengthOfOldArray-1-i];
    }
    return newArray;
}


int[] array = GenerationArray(3, -9, 9);
PrintArray(array);

PrintArray(multiplicationElementsFromArray(array));



