
using System;
using System.Linq;
using System.Diagnostics;


namespace sorting
{
    class Program
    {
        static void Swap(ref int a, ref int b) //Variabels that can be changed and fixed.
        {
            int temp = b;
            b = a;
            a = temp;
        }
        
                                                    //Sorting type
        public static void Bubblesort(int[] bub)
        {
            for(int j = 0; j< bub.Length; j++)
            {
                for (int i = 0; i< bub.Length -1; i ++)
                {
                    if (bub[i] > bub[i + 1])
                    {
                        Swap(ref bub[i], ref bub[i + 1]);
                    }
                }
            }
        }   


        
        static void Main(string[] args)          //Scrambler
        {
            int length = 1000;
            int[] scrm = new int[length];

            for (int s = 0; s <= length - 1; s++)
            {
                scrm[s] = s + 1;
            }
            Random random = new Random();
            scrm = scrm.OrderBy(x => random.Next()).ToArray();
            Console.WriteLine("Scrambled: ");
            foreach (var e in scrm)
            {
                Console.WriteLine(e);
            }
            //Scrambler

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Sortering Funktion
            

            Bubblesort(scrm);
     
            
            //Sortering Funktion

            stopwatch.Stop();

            Console.WriteLine("Sorted: ");
            foreach(var e in scrm) //in Funktion
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Size of sort: " + length);
            Console.WriteLine("Sorting time: {0}ms", stopwatch.Elapsed.Milliseconds);          
        }   
    }
}
    