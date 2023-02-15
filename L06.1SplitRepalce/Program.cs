// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! mip 20230212");
string coordinats = "(1,2) (2,3) (4,5) (6,7) (9,8)"
        .Replace("(","")
        .Replace(")","")
        ;
System.Console.WriteLine(coordinats);

var coordinatsArray = coordinats.Split(" ")
        .Select(item => item.Split(','))
        .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))
        .Where(element => element.x % 2 == 0)
        .Select(element => (x: element.x * 10, y: element.y))
        .ToArray();

for (int i = 0; i < coordinatsArray.Length; i++)
{
    System.Console.WriteLine(coordinatsArray[i] +" : "+ coordinatsArray[i].x + ", " +coordinatsArray[i].y);
}


/// <summary>
/// Название функции, ее функционал
/// </summary>
/// <param name="n1">Парамерт 1 и его описание</param>
/// <param name="n2">Парамерт 2 и его описание</param>
/// <returns>Возвращает что функция</returns>
int Function(int n1, int n2){
    return n1*n2;
}

int x=Function(1,2);
