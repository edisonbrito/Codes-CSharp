static void Main(string[] args)  
       {  
           Console.WriteLine("Selection Sort");  
           int[] arr = { 2, 6, 1, 4, 3, 8 };  
           print(arr, "Unsorted Array");  
           int[] sorted = selectionSort(arr, arr.Length);  
           print(sorted, "sorted Array");  
           Console.ReadLine();  
       }  
       static int[] selectionSort(int[] arr, int n)  
       {  
  
           int temp = 0;  
           for (int i = 0; i < n; i++)  
           {  
               for (int j = i + 1; j < n; j++)  
               {  
                   if (arr[i] > arr[j])  
                   {  
                       temp = arr[j];  
                       arr[j] = arr[i];  
                       arr[i] = temp;  
                   }  
               }  
           }  
           return arr;  
       }  
      static void print(int[] array,string val)  
       {  
           Console.WriteLine(val);  
           for (int i = 0; i < array.Length; i++)  
           {  
               Console.WriteLine(array[i]);  
           }  
       }  