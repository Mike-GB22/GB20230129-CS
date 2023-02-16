// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №41\n"
    + "Пользователь вводит с клавиатуры M чисел.\n" 
    + "Посчитайте, сколько чисел больше 0 ввёл пользователь.\n"
    + "Например: [0, 7, 8, -2, -2] -> 2; [-1, -7, 567, 89, 223] -> 3\n"    
);

//Запрос числа с клавиатуры
int ReadKeyboardInt(string prompt)
{
    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintString(string prompt, string text)
{
    Console.Write(prompt + ": " + text);
}

void ReversArray(int[] array){
    int tmp;
    for(int i=0;i<array.Length/2; i++){
        tmp=array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i]=tmp;
    }
}

int countPositivZahln=0;
for(int i = ReadKeyboardInt("Сколько чисел будем вводить"); i>0; i--){
        int zahl = ReadKeyboardInt("Введите число");
        if (zahl>0) countPositivZahln++;
}
PrintString("Введено положительных чисел",""+countPositivZahln);

