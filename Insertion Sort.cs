static void Main(string[] args)  
       {  
           Console.WriteLine("Bubble Sort");  
           int[] arr = { 2, 6, 1, 4, 3, 5 };  
           print(arr, "Unsorted Array");  
           int[] sorted = insertionSort(arr, arr.Length);  
           print(sorted, "sorted Array");  
           Console.ReadLine();  
       }  
       static int[] insertionSort(int[] arr, int n)  
       {  
  
           int value = 0;  
           int j = 0;  
           for (int i = 1; i < n; i++)  
           {  
               value = arr[i];  
               j = i-1;  
               while(j>=0 && arr[j]>value)  
               {  
                   arr[j + 1] = arr[j];  
                   j = j - 1;  
               }  
               arr[j + 1] = value;  
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