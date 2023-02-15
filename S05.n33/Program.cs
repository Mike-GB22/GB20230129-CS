// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215");
Console.WriteLine(
    "Задача №33.\n"
    + "Определить, есть ли заданное числов в Массиве"
    + "");

//Запрос числа с клавиатуры
int ReadKeyboard(string prompt)
{
    Console.Write(prompt + ": ");
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

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

int countFoundElement=0;
void FindElementInArray(int[] array, int whatWeLookipFor)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == whatWeLookipFor){countFoundElement++;
            PrintResult($"#{countFoundElement}. Элемент [{whatWeLookipFor}] находится в позиции",i.ToString());
        };
    }

}

int[] array = GenerationArray(100, -9, 9);
PrintArray(array);
System.Console.WriteLine("---");
int whatWeLookipFor = ReadKeyboard("Введите элемент который мы будем искать");
FindElementInArray(array, whatWeLookipFor);
if(countFoundElement>0) PrintResult("Всего элемент встретился", $"{countFoundElement} раз");
else PrintResult($"Искомый элемент [{whatWeLookipFor}]", "не найден");


