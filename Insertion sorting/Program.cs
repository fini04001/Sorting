using System;
using System.Linq;
using System.Diagnostics;


namespace Template
{
    class Program
    {
        static public void Insertionsort(int[] insr) //place changer
        //Sorting type
        {
            int key, j;

            for (int i = 0; i < insr.Length; i++)
            {
                key = insr[i];
                j = i - 1;

                while (j >= 0 && insr[j] > key)
                {
                    insr[j + 1] = insr[j];
                    j = j - 1;
                }
                insr[j + 1] = key;
            }
            //sorting type
        }         static void Main(string[] args)  
          //Scrambler
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
            

            Insertionsort(scrm);
     
            
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