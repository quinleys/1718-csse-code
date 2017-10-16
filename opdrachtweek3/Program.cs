using System;

namespace opdrachtweek3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Geef een getal in: ");
        int j = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("vermenigvuldigtal:{0}",j);

        for (int i = 0; i < 10; i++) // startwaarde, voorwaarde en verhogen/verlagen teller
            {
                Console.WriteLine( "{0} * {1} = {2}",i,j,i*j);

            }


        }
    }
}
