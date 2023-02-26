// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230226");
Console.WriteLine("\n"
    + "Задача №30\n"
    + "Напишите программу, которая задаёт массив из 8 элементов,\n"
    + "заполенный 0 и 1, и выводит их на экран.\n"
    + "* Ввести с клавиатуры длину массива\n"
);


//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
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


PrintArray(
    GenerateArray(
        ReadKeyboardInt("Введите число элементов массива"),
        0,2
    )
);