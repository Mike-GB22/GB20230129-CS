// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arr = {1,4,3,2,6,7,1,1,2,3,4,5,6};

void PrintArray(int[] array){
    int length = array.Length;
    for(int i=0; i<length; i++){
        System.Console.Write($"{array[i]}");
        System.Console.Write(" ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array){
    for(int i = 0; i < array.Length-1; i++){
        int minPosition = i;

        for(int j = i+1; j < array.Length; j++){
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary=array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
