// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №0\n"
    + "Напишите программу, которая принимает на вход"
    + "три числа и проверяет,\n может ли существовать"
    + "треугольник с сторонами такой длины.\n"
);

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

//Вывод строки
void PrintString(string prompt, string text = "")
{
    Console.WriteLine(prompt + ": " + text);
}

//Генераци числа, от minValue и до maxValue
int GenerateInt(int minValue, int maxValue)
{
    Random rnd = new Random();
    return rnd.Next(minValue, maxValue);
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

//Инверсия массива
void ReversArray(int[] array){
    int tmp;
    for(int i=0;i<array.Length/2; i++){
        tmp=array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i]=tmp;
    }
}

//Десятичное число в двоичное
string DecToBin(int num){
    if(num<2) return num.ToString();
    return ""+DecToBin(num/2)+num%2;

}

//Генераци заполенного 2х мерного массива нужного размера
int[,] Generate2xArray(int height, int length, int minValue, int maxValue)
{
    int[,] array = new int[height, length];
    Random rnd = new Random();
    for (int j = 0; j < height; j++)
    {
        for (int i = 0; i < length; i++)
        {
            array[j, i] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}

//Печать массива 2х мерного массива
void Print2xArray(int[,] array)
{
    int maxCharsInElement = 4;
    System.Console.WriteLine("Печать массива:");
    for (int j = 0; j < array.GetLength(0); j++)
    {
        System.Console.Write("[");
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            System.Console.Write(
                TabulationText(
                    array[j, i].ToString(), 
                    maxCharsInElement)
                 + ", ");
        }
        System.Console.WriteLine(
            TabulationText(
                array[j, array.GetLength(1) - 1].ToString(), 
                maxCharsInElement)
            + "]");
    }
}

//Генераци заполенного 3х мерного массива нужного размера
int[,,] Generate3xArray(int height, int length, int deepth, int minValue, int maxValue)
{
    int[,,] array = new int[height, length, deepth];
    Random rnd = new Random();
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < deepth; k++)
            {
                array[i, j, k] = rnd.Next(minValue, maxValue);
            }
        }
    }
    return array;
}


//Печать массива 3х мерного массива
void Print3xArray(int[,,] array, string prompt = "Печать 3х мернаго массива:", string text ="", int maxCharsInElement = 4, int maxSpaceBeetweenElement = 0)
{
    int length = array.GetLength(0);
    int height = array.GetLength(1);
    int deepth = array.GetLength(2);
    System.Console.WriteLine(prompt+text);
    for (int i = 0; i < length; i++)
    {
        string spaces = "";
        System.Console.WriteLine("Row "+i);
        for (int k = -1; k < deepth; k++)
        {
            if(k!=-1) System.Console.Write(
                spaces+"Deep "+
                TabulationText(k.ToString(),maxCharsInElement-1)
                );
            else System.Console.Write(spaces+"        ");
            for (int j = 0; j < height; j++)
            {
                if(k==-1){
                    System.Console.Write("  Col"+
                        TabulationText(j.ToString(),maxCharsInElement-1)
                        +" "
                    );    
                } else {
                System.Console.Write(" [");
                System.Console.Write(
                    TabulationText(
                        array[i, j, k].ToString(),
                        maxCharsInElement));
                System.Console.Write("]  ");
                }
            }
            spaces +=" ";
            System.Console.WriteLine("");    
        }
        System.Console.WriteLine("");    
    }
}


//Доведение строки до размера int maxCharsInElement
string TabulationText(string text, int maxCharsInElement)
{
    if (text.Length > maxCharsInElement)
    {
        text = text.Substring(0, maxCharsInElement);
    }
    else
    {
        for (int weHave = text.Length; weHave < maxCharsInElement; weHave++)
        {
            text = " " + text;
        }
    }
    return text;
}

//Изменине цвета вывода текста в консоль, тут для чисел. Сброс цвтвета, по слову "reset".
void ConsoleColorZahle(string text = "reset")
{
    if (text == "reset") Console.ResetColor();
    else
    {
        double number = Convert.ToDouble(text);
        if (number == 0) Console.ForegroundColor = ConsoleColor.Yellow;
        else if (number > 0) Console.ForegroundColor = ConsoleColor.Green;
        else Console.ForegroundColor = ConsoleColor.Red;
        // int color = Convert.ToInt32(number)%16;
        // Console.ForegroundColor = (ConsoleColor)color;  
    }
}


//Поиск минимального элемента 2х мерного массива, возвращаем два индекса (позицию)
int[] FindPositionMinimalElemetn(double[,] array)
{
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    return new int[] { iMin, jMin };
}

//Поиск минимального элемента одномерного мерного массива, возвращаем индекс
int FindIndexMinimalElemetn(double[] array)
{
    int iMin = 0;    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] < array[iMin]) iMin = i;
    }
    return iMin;
}

//Факториал
long Factorial(int n)
{
    long x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

//Построение Треугольника Паскала, на основе факториала
void PrintPascalTriangle(int nRow)
{
    for (int row = 0; row <= nRow; row++)
    {
        for (int spaces = 0; spaces <= nRow - row; spaces++)
            System.Console.Write(" ");
        for( int elementsRow = 0; elementsRow <= row; elementsRow++){
            System.Console.Write(" ");
            System.Console.Write(Factorial(row)/(Factorial(elementsRow)*Factorial(row-elementsRow)));
        }
        System.Console.WriteLine("");
    }
}

//Сортируем пузырьком переданный массив, ни чего не возвращаем (работаем со ссылкой)
void SortArray(double[] array)
{
    int length = array.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length - 1 - i; j++)
        {
            if (array[j] < array[j + 1])
            {
                double tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }
}

//Перемножение 2х Матриц, возращаем новую матрицу
double[,] MatrixMultuplication(double[,] array1, double[,] array2)
{
    int length1 = array1.GetLength(1);
    int height1 = array1.GetLength(0);
    int length2 = array2.GetLength(1);
    int height2 = array2.GetLength(0);

    double[,] arrayMultiplication = new double[height1, length2];

    if (length1 != height2)
    {
        System.Console.WriteLine("Матрицы A и B могут быть перемножены, если они совместимы в том смысле, что число столбцов матрицы A равно числу строк.");
        return array1;
    }

    for (int i = 0; i < height1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int index = 0; index < length1; index++)
            arrayMultiplication[i,j] += array1[i,index]*array2[index,j];
        }
    }
    return arrayMultiplication;
}

//Заполнение 2х мерного массива по спирали, цифрами
double[,] GenerateSpiralArray(int height, int length)
{
    int count = 1;
    int countMax = height * length + count;
    double[,] array = new double[height, length];

    for (int circle = 0; count < countMax && circle <= height / 2; circle++)
    {
        for (int i = circle; i < length - circle && count < countMax; i++) array[circle, i] = count++;
        for (int i = circle + 1; i < height - circle && count < countMax; i++) array[i, length - circle - 1] = count++;
        for (int i = length - circle - 2; i >= circle && count < countMax; i--) array[height - circle - 1, i] = count++;
        for (int i = height - circle - 2; i > circle && count < countMax; i--) array[i, circle] = count++;
    }
    return array;
}
