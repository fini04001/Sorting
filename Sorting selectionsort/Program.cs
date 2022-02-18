using System;
using System.Linq;
using System.Diagnostics;


namespace Template
{
 
    public class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        //Sorting type
         static public void Selectionsort(int[] selc)
        {
            int smallest;
            for (int i = 0; i < selc.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < selc.Length; j++)
                {
                    if (selc[j] < selc[smallest])
                    {
                        smallest = j;
                    }
                }
                Swap(ref selc[smallest], ref selc[i]);
            }
        }
        //Sorting type
        //Scrambler
         static void Main(string[] args)          
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
            

            Selectionsort(scrm);
     
            
            //Sortering Funktion

            stopwatch.Stop();

            Console.WriteLine("Sorted: ");
            //in Funktion
            foreach(var e in scrm)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Size of sort: " + length);
            Console.WriteLine("Sorting time: {0} ms", stopwatch.Elapsed.Milliseconds);          
        }   
    }
}
