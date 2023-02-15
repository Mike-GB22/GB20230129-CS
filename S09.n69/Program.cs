// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230215 \n\n"
+ "Задача 69: Принимаем 2 числа A и B. Нужно возвести число А в степерь B."
+ "Выполнить с помощью рекурсии.\n"
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

long AvStepenB (int a, int b){
    if(b<=1) return a;
    return a*AvStepenB(a, b-1);

}

long AvStepenBHitriy (int a, int b){
    if(b<1) return 1;
    if(b==1) return a;
    if(b==2) return a*a;
    if(b%2 == 1) return AvStepenBHitriy(a, b/2)*AvStepenBHitriy(a, b/2)*a;
    else  return AvStepenBHitriy(a, b/2)*AvStepenBHitriy(a, b/2);
}

int a = ReadKeyboard("Число А");
int b = ReadKeyboard("Число Б");

System.Console.WriteLine("\n");
DateTime time1 = DateTime.Now;
PrintResult("Число А в степени Б", AvStepenB(a,b).ToString());
PrintResult("Время работы обычного алгоритма", (DateTime.Now-time1).ToString());

System.Console.WriteLine("\n");
DateTime time2 = DateTime.Now;
PrintResult("Число А в степени Б", AvStepenBHitriy(a,b).ToString());
PrintResult("Время работы хитрого алгоритма", (DateTime.Now-time2).ToString());

System.Console.WriteLine("\n");