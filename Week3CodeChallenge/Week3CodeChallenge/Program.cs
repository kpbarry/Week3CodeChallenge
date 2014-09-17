using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenFibbonnacciSequencer(4000000);
            Console.WriteLine("========= FINDING N PRIMES =========");
            FindNPrimes(10001);
            Console.WriteLine("========= FINDING COLLATZ =========");
            LongestCollatzSequence();
            Console.ReadKey();
        }

        static void FindNPrimes(long maxPrime)
        {
            //Go from 1 to number
            for (long i = 0; i <= maxPrime; i++)
            {
                //Check for prime
                bool isPrime = true;
                //Check for divisibility
                for (long j = 2; j < i; j++) 
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                //Write all numbers where isPrime is false
                if (isPrime)
                {
                    Console.WriteLine(i+ " is prime.");
                }
            }
        }

        static void EvenFibbonnacciSequencer(int maxValue)
        {
            long[] arr = new long[1000000];
            long i = 2;
            arr[i - 2] = 1;
            arr[i - 1] = 2;
            long n = arr[i];

            long s = 0;
            //Go from 2 to max value
            for (i = 2; arr[i - 1] < maxValue; i++)
            {
                //New index = previous 2 values
                arr[i] = arr[(i - 1)] + arr[(i - 2)];
            }

            //Check for divisibility by 2, add if divisible
            for (long f = 0; f <= arr.Length - 1; f++)
            {
                if (arr[f] % 2 == 0)
                    s += arr[f];
            }
            Console.WriteLine(s);
        }

        static void LongestCollatzSequence()
        {
            //Longest sequence number
            long number = 837799;
            //Keep count of how many tries it took
            int count = 1;
            //Keep going until number is 1
            while (number > 1)
            {
                //Even, number = number / 2
                if (number % 2 == 0)
                {
                    count++;
                    number /= 2;
                } 
                //Odd, number = 3*number + 1
                else
                {
                    count++;
                    number = 3 * number + 1;
                }
                Console.Write(number + " => ");
            }
            Console.WriteLine("Took " + count + " math operations to get to 1");
        }
    }
}
