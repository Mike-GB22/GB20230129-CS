// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №42\n"
    + "Напишите программу, которая будет преобразовывать десятичное число в двоичное.\n" 
    + "\n"
    + "Например: 45 -> 101101; 3 -> 11; 2 -> 10\n"    
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

string DecToBin(int num){
    if(num<2) return num.ToString();
    return ""+DecToBin(num/2)+num%2;

}
int numDec = ReadKeyboardInt("Введите число");

PrintString("Двоичное представлине числа"+numDec,DecToBin(numDec));

