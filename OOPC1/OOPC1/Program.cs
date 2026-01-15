using System;

namespace OOPC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type name -> creating variable
            Console.WriteLine("Please give me your number?");
            int mynum = int.Parse(Console.ReadLine());
            evenOrOdd(mynum); //argument

            PrimeOrNotPrime(mynum);

            int result = Factorial(mynum);
            Console.WriteLine("the factorial is " + result);

            Fibonacci(mynum);
        }
        //method -> visibility, static, returntype, nameMethod (/parameters) {//what to do}
        public static void evenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("the number is EVEN");
            }
            else
            {
                Console.WriteLine("the number is ODD");
            }
        }
        //make the method to pass parameter int, and tell if the number is prime or not
        public static void PrimeOrNotPrime(int num)
        {
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
                return; //exit the method
            }
            for (int i = 2; i < num / 2; i++)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime )
            {
                Console.WriteLine("the number is Prime");
            }
            else
            {
                Console.WriteLine("the number is not Prime");
            }
        }
        //making a method to get parameter int number and return int factorial
        public static int Factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i; //fact*= i; (same)
            }
            return fact;
        }
        //fibonachi -> 0,1,1,2,3,5,8,13,...
        public static void Fibonacci(int num)
        {
            int a = 0;
            int b = 1;
            Console.Write(a + "," + b + ",");

            for (int i = 3; i <= num; i++)
            {
                int c = a + b;
                Console.Write(c + ",");
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
