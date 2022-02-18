using System;
using System.Threading;
using System.Diagnostics;

namespace Bubbelsort_Algotithem {

    public class HelloWorld {
    
        public static void Main(string[] args) {
            int[] numberArray = new int[1000]; // Array with 1000 ints
            Random intRng = new Random(); // Random number generator
        
            bool flag = true;  
            int temp;  
            int arrayLength = numberArray.Length; // The length of the array.
        
            for(int i = 0; i <1000 ; i++) { // Assigns random values to the ints
                numberArray[i] = intRng.Next(1, 1001);
                Console.Write(numberArray[i] + " ");
            }
        
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = =");
            Console.WriteLine("Time to sort the array!");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = =");
        
            Console.WriteLine(" ");
            Console.ReadKey();
        
            // === === === === === === === === === === === === \\
            // === === === ===== Bubble sort ===== === === === \\
            // === === === === === === === === === === === === \\
    
            var timer = Stopwatch.StartNew();
            for (int i = 1; (i <= (arrayLength - 1)) && flag; i++) {  
                flag = false;  
                for (int j = 0; j < (arrayLength - 1); j++) {  
                
                // Sorts smallest to largest int
                    if (numberArray[j + 1] < numberArray[j]) { // > = large to smal, < = smal to large
                        temp = numberArray[j];  
                        numberArray[j] = numberArray[j + 1];  
                        numberArray[j + 1] = temp;  
                        flag = true;  
                    }  
                }  
            }  
            foreach (int num in numberArray) {  
            Console.Write("\t {0}",num);  
            } 
            timer.Stop();
            
            Console.WriteLine();
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = =");
            Console.WriteLine("The array has been sorted. it took: " + timer.ElapsedMilliseconds + " ms");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = =");
            Console.Read();  
        }    
    }
}