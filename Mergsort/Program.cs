using System;
using System.Linq;
using System.Diagnostics;


namespace Template
{
    class Program
    {
        public static int[] Mergesort(int[] Merg)
        {
            int[] left;
            int[] right;
            int[] result = new int[Merg.Length];  

            if (Merg.Length <= 1)
                return Merg;              

            int midPoint = Merg.Length / 2;  

            left = new int[midPoint];
  

            if (Merg.Length % 2 == 0)
                right = new int[midPoint];  

            else
                right = new int[midPoint + 1];  

            for (int i = 0; i < midPoint; i++)
                left[i] = Merg[i];  

            int x = 0;

            
            for (int i = midPoint; i < Merg.Length; i++)
            {
                right[x] = Merg[i];
                x++;
            }  

            left = Mergesort(left);
 
            right = Mergesort(right);

            result = Merge(left, right);  
            return result;
        }
          public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;  

            while (indexLeft < left.Length || indexRight < right.Length)
            {

                if (indexLeft < left.Length && indexRight < right.Length)  
                {  

                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }  
            }
            return result;
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
            

            scrm = Mergesort(scrm);
     
            
            //Sortering Funktion

            stopwatch.Stop();

            Console.WriteLine("Sorted: ");
            //in Funktion
            
            Console.WriteLine("Size of sort: " + length);
            Console.WriteLine("Sorting time: {0}ms", stopwatch.Elapsed.Milliseconds);          
        }   
    }
}