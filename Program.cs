//dotnet run

//int[] array = {1, 2, 3, 4, 5};
//int[] array = {5, 4, 3, 2, 1};
int[] array = {5, 2, 65, 1, 94, 0};

BubbleSort(array);
PrintArray(array);

//Merge Sort

//Insertion Sort

//Quick Sort

//Bubble Sort
static void BubbleSort(int[] array){
    Console.WriteLine("Bubble Sort:");
    int temp; 
    for(int i=0; i<array.Length; i++){
        for(int j=1; j<array.Length; j++){
            temp = array[j];
            if(array[j] < array[j-1]){
                array[j] = array[j-1];
                array[j-1] = temp;
            }
        }
    }
}

//Print Array
static void PrintArray(int[] array){
    for(int i=0; i<array.Length;i++){
        Console.Write(array[i] + " ");
    }
}