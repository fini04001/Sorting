using System;
using System.Linq;
using System.Diagnostics;


namespace Template
{
   internal class Program
    {
  static public int Partition(int[] pari, int left, int right)
        {
            int pivot;
            pivot = pari[left];
            while (true)
            {
                while (pari[left] < pivot)
                {
                    left++;
                }
                while (pari[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = pari[right];
                    pari[right] = pari[left];
                    pari[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void Quicksort(int[] quic, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(quic, left, right);
                if (pivot > 1)
                {
                    Quicksort(quic, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quicksort(quic, pivot + 1, right);
                }
            }
        }
        //Sorting type
         
         static void Main(string[] args)  
          //Scrambler
        {
            int length = 1000000;
            int[] scrm = new int[length];

            for (int s = 0; s <= length - 1; s++)
            {
                scrm[s] = s + 1;
            }
            Random random = new Random();
            scrm = scrm.OrderBy(x => random.Next()).ToArray();
            Console.WriteLine("Scrambled: ");
            
            //Scrambler

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Sortering Funktion
            
            Partition(scrm, 0, length - 1);
            Quicksort(scrm, 0, length - 1);

     
            //Sortering Funktion

            stopwatch.Stop();

            Console.WriteLine("Sorted: ");
            //in Funktion
            
            Console.WriteLine("Size of sort: " + length);
            Console.WriteLine("Sorting time: {0} ms", stopwatch.Elapsed.Milliseconds);          
        }   
    }
}