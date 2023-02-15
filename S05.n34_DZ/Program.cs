// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215");
Console.WriteLine(
    "Задача №34.\n"
    + "Задайте массив заполненный случайными положительными трёхзначными числами."
    + "Напишите программу, которая покажет количество чётных чисел в массиве." 
    + "[345, 897, 568, 234] -> 2"
    + "");

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


int CountEvensElementInArray(int[] array)
{
    int countEvensElement=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 == 0){countEvensElement++;
            //PrintResult($"#{countEvensElement}. Элемент находится в позиции",i.ToString());
        };
    }
    return countEvensElement;
}

int[] array = GenerationArray(100, 100, 999);
PrintArray(array);

int countEvensElement = CountEvensElementInArray(array);
if (countEvensElement == 0 ) PrintResult("Искомый (четный) элемент", "не найден");
else PrintResult("Искомый (четный) элемент", $" найден {countEvensElement} раз");


