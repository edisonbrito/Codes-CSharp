class Program  
{  
    static void Main(string[] args)  
    {  
        string strInput = string.Empty;  
        string strRev = string.Empty;  
        Console.WriteLine("Enter String");  
        strInput = Console.ReadLine();  
        for (int i = strInput.Length-1; i >= 0; i--)  
        {  
            strRev += strInput[i];  
        }  
        Console.WriteLine("Reverse string : {0}",strRev);  
        Console.ReadLine();  
    }  
} 