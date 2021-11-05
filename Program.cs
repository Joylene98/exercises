using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStars();
           // LongestSequence("1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0");
           //ReverseString("hello world");
           // SumOfDigits(123);
           ReturnNthPrime(3);
           //FindTwoSums(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        }
        // Problem 1
        public static void LongestSequence(String sales)
        {
            String group1 = " ";
            String group2 = " ";
            String group3 = " ";
            String group4 = " ";
            String group5 = " ";
            String group6 = " ";
            String group7 = " ";
            String group8 = " ";
            String noSale = "0,0,0,0";
            int count = 0;
            for (int i=0; i<sales.Length; i++)
            {
                group1 = sales.Substring(0, 3);
                group2 = sales.Substring(4, 7);
                group3 = sales.Substring(8, 11);
                group4 = sales.Substring(12, 15);
                group5 = sales.Substring(16, 19);
                group6 = sales.Substring(20, 23);
                group7 = sales.Substring(23, 26);
                group8 = sales.Substring(27, 30);

                if(group1.Contains(noSale))
                {
                    count = 4;
                    Console.WriteLine("The number of days without no sale is {0}", count);
                }
                else if(group2.Contains(noSale))
                {
                    count = 4;
                    Console.WriteLine("The number of days without no sale is {0}", count);
                }
                else if(group3.Contains(noSale))
                {
                    count = 4;
                    Console.WriteLine("The number of days without no sale is {0}", count);
                }
                else if(group4.Contains(noSale))
                {
                    count = 4;
                    Console.WriteLine("The number of days without no sale is {0}", count);
                }
                else if(group5.Contains(noSale))
                {
                    count = 4;
                    Console.WriteLine("The number of days without no sale is {0}", count);
                }
                else if(group6.Contains(noSale))
                {
                    count = 4;
                    Console.WriteLine("The number of days without no sale is {0}", count);
                }
                else if(group7.Contains(noSale))
                {
                    count = 4;
                    Console.WriteLine("The number of days without no sale is {0}", count);
                }
                else if(group8.Contains(noSale))
                {
                    count = 4;
                    Console.WriteLine("The number of days without no sale is {0}", count);
                }

                Console.ReadLine();
            }

        }

        // Problem 2 
         public static void PrintStars()
          {
            int space = 9;
            for(int i=0; i<space; i++)
            {
                for(int j=0; j<space; j++)
                {
                    Console.Write(" ");
                }
                
                for(int j=0; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                space--;
            }
            Console.ReadLine();


        }
        // Problem 5
        public static void ReverseString(String word)
        {
            String firstword = "";
            String secondword = "";
            int length = word.Length;
            int firstLength = 0;
            String reverseFirst = "";
            for(int i=0; i<word.Length; i++)
            {
                if(word.Contains(" "))
                {
                    firstword = word.Substring(i, word.IndexOf(" ")); // "hello"
                    //secondword = word.Substring(word.IndexOf(" "), word.IndexOf("d");
                    firstLength = firstword.Length - 1;
                    while (firstLength >= 0)
                    {
                        reverseFirst = reverseFirst + firstword[firstLength];
                        firstLength--;
                    }
                    Console.WriteLine("{0}", reverseFirst);
                }
                else
                {
                    Console.ReadLine();
                }

            }
            Console.ReadLine();
        }

        // Problem 7
        public static void SumOfDigits(int number)
        {
            int remainder = 0;
            int sum = 0;
            while(number > 0)
            {
                remainder = number % 10;
                sum += remainder;
                number /= 10;
            }
            Console.Write("Sum of Digits : {0} ", sum);
            Console.ReadLine();
        }
        // Problem 8
        public static List<Tuple<int, int>> FindTwoSums(List <int> numbers, int target)
        {
            List<Tuple<int, int>> IntLists = new List<Tuple<int, int>>();
            for(int i=0; i<numbers.Count; i++)
            {
                if(numbers.ElementAt(i) + numbers.ElementAt(i+1) == target)
                {
                    IntLists.Add(new Tuple<int, int>(numbers.ElementAt(i), numbers.ElementAt(i + 1)));
                    
                    foreach(var tuple in IntLists)
                    {
                        Console.WriteLine("{0} - {1}", tuple.Item1, tuple.Item2);
                    }

                }
                else
                {
                    return null;
                }
            }
            return IntLists;
        }

        // Problem 9
        public static void ReturnNthPrime(int nth)
        {
            int [] primes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int number = 0;

            if(nth <= primes.Length)
            {
                number = primes[nth-1];
                Console.WriteLine("{0}", number);
            }
            Console.ReadLine();
        }

        // Problem 10
        public static void ReturnNextPrime(int number)
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            
            
        }
    }

}
