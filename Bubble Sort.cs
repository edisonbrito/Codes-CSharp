static void Main(string[] args)  
       {  
           Console.WriteLine("Bubble Sort");  
           int[] arr = { 2, 6, 1, 4, 3, 5 };  
           print(arr, "Unsorted Array");  
           int[] sorted = bubbleSort(arr, arr.Length);  
           print(sorted, "sorted Array");  
           Console.ReadLine();  
       }  
       static int[] bubbleSort(int[] arr, int n)  
       {  
  
           int temp = 0;  
           for (int i = 0; i < n; i++)  
           {  
               for (int j = 0; j < n-1; j++)  
               {  
                   if (arr[j] > arr[j+1])  
                   {  
                       temp = arr[j + 1];  
                       arr[j+1] = arr[j];  
                       arr[j] = temp;  
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