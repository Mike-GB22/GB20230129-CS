// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip20230216");
Console.WriteLine("\n"
    + "Задача №57.\n"
    + "Задайте двумерный массив.\n"
    + "Составить частотный словарь элементов двумерного массива.\n"
    + "Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.\n"
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

//Генераци заполенного 2х мерного массива нужного размера
double[,] Generate2xArray(int height, int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] array = new double[height, length];
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
void Print2xArray(double[,] array)
{
    int maxCharsInElement = 5;
    System.Console.WriteLine("Печать массива:");
    for (int j = 0; j < array.GetLength(0); j++)
    {
        System.Console.Write("[");
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            if (i == j) { Console.BackgroundColor = ConsoleColor.DarkGray; }
            System.Console.Write(
                TabulationText(
                    array[j, i].ToString(),
                    maxCharsInElement)
                 + ", ");
            Console.ResetColor();
        }
        if (j == array.GetLength(1) - 1) { Console.BackgroundColor = ConsoleColor.DarkGray; }
        System.Console.WriteLine(
            TabulationText(
                array[j, array.GetLength(1) - 1].ToString(),
                maxCharsInElement)
            + "]");
        Console.ResetColor();
    }
    Console.ResetColor();
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
    ConsoleColorZahle(text);
    return text;
}

//Изменине цвета вывода текста в консоль, тут для чисел. Сброс цвтвета, по слову "reset".
void ConsoleColorZahle(string text = "reset")
{
    if (text == "reset") Console.ResetColor();
    else
    {
        double number = Convert.ToDouble(text);
        int color = Convert.ToInt32(Math.Abs(number)) % 16;
        Console.ForegroundColor = (ConsoleColor)color;
    }
}

//Составляем словарь часттоности 2х мерный массив, 1й стоблец слово, 2й стобец - количество встречаний
double[,] FillFreqDic(double[,] array)
{
    int length = array.GetLength(1);
    int height = array.GetLength(0);

    int worterBuchSize = 0;
    int wordsMax = length * height;
    double[,] worterBuch = new double[wordsMax, 2];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            double wort = array[i, j];
            bool wortAlredyInWorterBuch=false;
            for (int w = 0; w <= worterBuchSize && w < wordsMax; w++)
            {
                if (wort == worterBuch[w, 0])
                {   //Слово есть, увеличиваем счетчик этого слова
                    worterBuch[w, 1]++;
                    wortAlredyInWorterBuch=true;
                    break;
                }
            }
            if(!wortAlredyInWorterBuch)
            {   //Слова нет, увеличиваем счетчик размер словаря, и добавляем этого слово
                //System.Console.WriteLine($"Word {wort} index:{worterBuchSize}, wordsMax:{wordsMax}");
                worterBuch[worterBuchSize, 0]=wort;
                worterBuch[worterBuchSize, 1]=1;
                worterBuchSize++;
            }
            
        }
    }
    //Обрезка словаря, до количества слов
    double[,] worterBuchKurz = new double[++worterBuchSize, 2];
    for(int i = 0; i<worterBuchSize; i++){
        worterBuchKurz[i,0] = worterBuch[i,0];
        worterBuchKurz[i,1] = worterBuch[i,1];
    }
    return worterBuchKurz;
}


void main()
{
    double[,] matrix = Generate2xArray(
        ReadKeyboardInt("Введите размер матрицы N"),
        ReadKeyboardInt("Введите размер матрицы M"),
        -99, 99);
    Print2xArray(matrix);

    System.Console.WriteLine();
    Console.ResetColor();
 
    PrintString("Выполняем условия задачи. Вывод словаря.\nСловао \\ количество повторений");
    Print2xArray(
        FillFreqDic(matrix)
    );
}

main();