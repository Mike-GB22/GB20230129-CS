// See https://aka.ms/new-console-template for more information
//2023/02/11
Console.WriteLine("Hello, World!");

double Factorial(double n)
{
    if (n == 1) return 1;
    if (n == 0) return 1;
    else return n * Factorial(n - 1);
}
int n = 20;
for (int i = n; i >= 0; i--)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}