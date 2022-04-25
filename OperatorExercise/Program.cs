using System;
using System.Text;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(OperatorExercise1.Modulus());
            Console.WriteLine(OperatorExercise1.AreaOfCircle());
            


        }
    }

    public class OperatorExercise1
    {

        public static int Addition()
        {
            Console.WriteLine("Please Enter in 2 numbers to Add ");
            int answer = int.Parse(Console.ReadLine());
            int answer2 = int.Parse(Console.ReadLine());
            return answer + answer;
        }

        public static int Subtraction()
        {
            Console.WriteLine("Please Enter in 2 numbers to Subtract ");
            int answer = int.Parse(Console.ReadLine());
            int answer2 = int.Parse(Console.ReadLine());
            return answer - answer;
        }

        public static int Multiplication()
        {
            Console.WriteLine("Please Enter in 2 numbers to Multiply ");
            int answer = int.Parse(Console.ReadLine());
            int answer2 = int.Parse(Console.ReadLine());
            return answer * answer;
        }

        public static int Division()
        {
            Console.WriteLine("Please Enter in 2 numbers to Divide ");
            int answer = int.Parse(Console.ReadLine());
            int answer2 = int.Parse(Console.ReadLine());
            return answer / answer;
        }

        public static string Modulus()
        {
            Console.WriteLine("Please Enter in 2 numbers to Divide and return the remainder");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int divide = a / b;
            int quotient = a % b;

            string solution = ($"\n{a}/{b} is {divide} remainer {quotient}\n");
            return solution;
        }

        public static string AreaOfCircle()
        {
            Console.WriteLine("Please Enter the radius of your circle");
            var radius = double.Parse(Console.ReadLine());
            double solution = Math.PI * Math.Pow(radius, 2);
            string solution2 = ($"\nThe area of a circle with radius of {radius} is {solution}");

            return solution2;
        }


    }


}