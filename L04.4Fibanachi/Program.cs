// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//20223/02/11
//Fibanachi
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

int Fibanachi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return (Fibanachi(n - 1) + Fibanachi(n - 2));
}

int nMax = 40;
for (int n = 1; n <= nMax; n++)
{
    System.Console.WriteLine($"fibanachi({n}) = {Fibanachi(n)}");
}