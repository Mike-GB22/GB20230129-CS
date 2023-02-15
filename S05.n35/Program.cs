// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215");
Console.WriteLine(
    "Задача №35.\n"
    + "Задайте одномерный массив из 123 случайных чисел."
    + "Найдите количество элементов массива, значения которых лежат в отрезке [10,99]."
    + "[5, 18, 123, 6, 2] -> 1; [1, 2, 3, 6, 2] -> 0; [10, 11, 12, 13, 14] -> 5"
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

string whatWeNeed = "больше 10, но меньше 99";
bool IsNeedfulElement(int element)
{
    return (element > 10 && element < 99);
}

int CountNeedfulElementInArray(int[] array)
{
    int countNeedfulElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsNeedfulElement(array[i]))
        {
            countNeedfulElement++;
            PrintResult($"#{countNeedfulElement}. Элемент ({array[i]}, {whatWeNeed}) находится в позиции", i.ToString());
        };
    }
    return countNeedfulElement;
}


int[] array = GenerationArray(123, -999, 999);
PrintArray(array);

int countNeedfulElement = CountNeedfulElementInArray(array);
if (countNeedfulElement == 0) PrintResult("Искомый ({whatWeNeed}) элемент", "не найден");
else PrintResult($"Искомый ({whatWeNeed}) элемент", $" найден {countNeedfulElement} раз");


