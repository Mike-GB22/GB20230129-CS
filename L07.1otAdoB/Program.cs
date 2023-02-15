// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230212");

string OtADoB(int a, int b)
{
    if (a <= b) return a + OtADoB(a + 1, b);
    else return String.Empty;
}

int a = 1;
int b = 10;
System.Console.WriteLine($"Stroka ot {a} do {b}: {OtADoB(a, b)}");

int SumOt1DoN(int n)
{
    if (n == 0) return 0;
    else return n + SumOt1DoN(n - 1);
}

int n = 10;
System.Console.WriteLine($"Summa ot {1} do {n}: {SumOt1DoN(n)}");

double FactorialOtN(int n)
{
    if (n == 1 || n == 0) return 1;
    else return n * FactorialOtN(n - 1);
}

int m = 10;
System.Console.WriteLine($"Faktorial ot {m}: {FactorialOtN(m)}");


int countWords = 0;
void FindWords(string alphabet, char[] word, int length = 0){
    if (length == word.Length)
    {
        countWords++;
        string n = String.Empty+countWords;
            if(countWords<1000){n+=" ";}
            if(countWords<100){n+=" ";}
            if(countWords<10){n+=" ";}
        System.Console.WriteLine($"{n} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++){
        word[length] = alphabet[i];
        FindWords(alphabet, word, length+1);
    }
}

FindWords("abcd", new char[5]);