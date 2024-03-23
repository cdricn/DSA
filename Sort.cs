public class Sort {
    public void BubbleSort(int[] array){
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
        PrintArray(array);
    }

    static void PrintArray(int[] array){
        for(int i=0; i<array.Length;i++){
            Console.Write(array[i] + " ");
        }
    }

}

