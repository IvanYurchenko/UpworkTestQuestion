using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UpworkTestQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());

            var operations = new Dictionary<int, Func<int, bool>>();
            operations.Add(1, Operation.IsOdd());
            operations.Add(2, Operation.IsPrime());
            operations.Add(3, Operation.IsPalindrome());

            for (int i = 0; i < amount; i++)
            {
                var line = Console.ReadLine();
                var conditionNumber = int.Parse(line.Split(' ')[0]);
                var number = int.Parse(line.Split(' ')[1]);
                var result = operations[conditionNumber](number);

                string output;
                switch (conditionNumber)
                {
                    case 1:
                        output = result ? "ODD" : "EVEN";
                        break;
                    case 2:
                        output = result ? "PRIME" : "COMPOSITE";
                        break;
                    case 3:
                        output = result ? "PALINDROME" : "NOT PALINDROME";
                        break;
                    default:
                        output = "WRONG OPERATION";
                        break;
                }

                Console.WriteLine(output);
            }

            Console.ReadLine();
        }
    }
}
