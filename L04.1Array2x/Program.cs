// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string [,] table = new string [2, 5];
table[1,2] = "slovo";

for(int row = 0; row < table.GetLength(0); row++){
    for (int column = 0; column < table.GetLength(1); column++){
        System.Console.WriteLine($"- {row}.{column} - {table[row, column]}");
    }
}

System.Console.WriteLine("--------- Part 2 ---------");

void initMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

void printMaxtrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write(matrix[i,j]+" ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[3,5];
initMatrix(matrix);
printMaxtrix(matrix);