using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
          var randomGenerate = new RandomNumberGenerator();
          randomGenerate.FindingEqualRandomNumbers(0,10);
        }
    }

    public class RandomNumberGenerator
    {
        private Random _randomNumber;  //class level scope

        public RandomNumberGenerator() //class level scope
        {
            _randomNumber = new Random(); //local
        }

        public void FindingEqualRandomNumbers(int a, int b) //class level scope
        {
            var num1 = _randomNumber.Next(a, b); //local
            var num2 = _randomNumber.Next(a, b); //local

            while (num1 != num2)
            {
                num2 = _randomNumber.Next(a, b); 
            }

            Console.WriteLine("random numbers with equal values are: {0} and {1} ", num1, num2); //local
        }
    }
}