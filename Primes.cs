using System;

namespace Numbers
{
    public class Prime
    {
        //IsPrime checks wheter a given number x is a prime.
        public static bool IsPrime(int x) 
        {
            bool check = true;
            if (x > 1) 
            {
                //check if x is prime
                for (int i = 2; i < x; i++)
                {
                    if (x%i==0) 
                    {
                        check = false;
                    }
                }
            }
            return check;
        }
        public static void ListPrimes(int x) 
        {
            for (int i = 2; i < x; i++) 
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void NumberOfPrimes(int x) 
        {
            int count = 0;
            for (int i = 2; i < x; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of primes to {x} is {count}");
        }
        public static void ListPrimeNumber(int x)
        {
            int count = 0;
            int check = 2;
            while (count < x) 
            {
                if (IsPrime(check))
                {
                    count++;
                }
                check++;
            }
            Console.WriteLine($"Prime number {90} is {--check}");
        }
    } 
}