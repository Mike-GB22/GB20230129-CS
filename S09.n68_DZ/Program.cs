// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215 \n\n"
+ "Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии."
+ " Даны два неотрицательных числа m и n.\n"
);


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

float AkermanFunc(float m, float n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkermanFunc(m - 1, 1);
    return AkermanFunc(m - 1, AkermanFunc(m, n - 1));
}

PrintResult("Функция Акермана A(M,N)", 
    AkermanFunc(
        ReadKeyboard("Число M"),
        ReadKeyboard("Число N")
    ).ToString());
