using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 values with commas between them.");
            var numberString = Console.ReadLine().Split(",");
            Console.WriteLine("Would you like to multiply (*), add(+), divide(/), square (^2), or average (avg) these numbers?");
            var operation = Console.ReadLine();

            var zeroNumber = 0;
            var startingNumber = 1;
            var outputDivide = 0m;
            string newVar = "";

            if (operation == "*")
            {
                foreach (var number in numberString)
                {
                    var convertedNumber = int.Parse(number);
                    startingNumber *= convertedNumber;
                }

                Console.WriteLine(startingNumber);
                Console.ReadLine();
            }
            else if (operation == "^2")
            {
                foreach (var number in numberString)
                {
                    var squareConvertedNumber = int.Parse(number);
                    var square = squareConvertedNumber * squareConvertedNumber;
                    var finalFinal = square.ToString() + ",";
                    newVar += finalFinal;
                }

                char[] removeComma = {','};
                Console.Write(newVar.TrimEnd(removeComma));
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                foreach (var number in numberString)
                {
                    var addConvertedNumber = int.Parse(number);
                    zeroNumber += addConvertedNumber;
                }
                Console.WriteLine(zeroNumber);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                for (int i = 0; i < numberString.Length; i++)
                {
                    if (i == 0)
                    {
                        outputDivide = Convert.ToDecimal(numberString[i]);
                    }
                    else
                    {
                        outputDivide /= Convert.ToDecimal(numberString[i]);
                    }
                }
                Console.WriteLine(outputDivide);
                Console.ReadLine();
            }
            else if (operation == "avg")
            {
                foreach (var number in numberString)
                {
                    var avgConvertedNumber = int.Parse(number);
                    zeroNumber += avgConvertedNumber;
                }
                Console.WriteLine(zeroNumber / 3);
                Console.ReadLine();
            }
        }
    }
}
