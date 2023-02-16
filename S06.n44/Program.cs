// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №44\n"
    + "Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.\n" 
    + "\n"
);

//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

//Генераци чисел Фибаначи
long[] GenerateArrayFibanaci(int length)
{
    if(length<3) {
        return new long[2]{0,1};
    }

    long[] array = new long[length];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < length; i++)
    {
        array[i] = array[i-1]+array[i-2];
    }
    return array;
}

//Печать массива
void PrintArray(long[] array){
    System.Console.Write("Последовательность Фибаначи: [");
    for(int i=0; i<array.Length-1; i++){
        System.Console.Write(array[i]+", ");
    }
    System.Console.WriteLine(array[array.Length-1]+"]");
}

PrintArray(GenerateArrayFibanaci(ReadKeyboardInt("Введите нужное количество чисел Фибаначи")));