using System;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            // OEF 1 overlopen van getal en is het priemgetal?
            ShowNumbers();
            // fib
            Console.Write("Enter the length of the Fibonacci Series: ");  
            int length = Convert.ToInt32(Console.ReadLine());  
   
            for (int i = 0; i < length; i++)  
            {  
                Console.Write("{0} \n", Fibonacci(i));  
            } 
            

        }

        private static void ShowNumbers()
        {

            int aantal =0;
            int deler = 1;
            Console.WriteLine("Geef een getal in naar keuze kleiner dan 100: ");
            int j = Convert.ToInt32(Console.ReadLine());
            
            if (j <= 100){
                for (int i = 1 ; i <= j; i++){
                    Console.Write(i.ToString()+": ");
                    aantal = 0;
                    //Console.WriteLine("{0}", i);
                    
                    for (deler =1; deler <= i; deler++){
                        if (i % deler ==0){
                            aantal++;
                        }
                    }
                    if (aantal == 2){
                        Console.Write("is een priemgetal");
                    }
                    Console.WriteLine();
            }
            Console.WriteLine();

            } else {
                Console.WriteLine("Getal is niet kleiner dan 100");
            }
        }

        private static int Fibonacci(int n)
        {
            
        int a = 0;
        int b = 1;
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
            return result;
        }
 
    }  
        

    
}
