using System;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Study in SmartFactory SW Development Program\n");

            // 삼항연산자 예제
            TernaryOperator.Run();
            Console.WriteLine("--------------------\n");

            // Calculator 예제(조건문)
            Calcurator.run();
            Console.WriteLine("--------------------\n");
            
        }
    }
}