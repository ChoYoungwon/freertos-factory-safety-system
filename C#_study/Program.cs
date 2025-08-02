using System;
using System.Drawing.Printing;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Study in SmartFactory SW Development Program\n");

            // 문자열 포맷팅
            Formating.Run();
            Console.WriteLine("--------------------\n");

            // 삼항연산자 예제
            TernaryOperator.Run();
            Console.WriteLine("--------------------\n");

            // Calculator 예제(조건문, switch-case, 키보드로부터 숫자 읽어오기, 문자열을 정수형으로 변환)
            Calcurator.Run();
            Console.WriteLine("--------------------\n");

            // 반복문 & 배열
            Array.Run();
            Console.WriteLine("--------------------\n");

            // 함수 (참조에 의한 매개변수 전달)
            int a = 3; int b = 4;
            Func.Swap(ref a, ref b);
            Console.WriteLine($"a : {a}, b : {b}");
            Func.Run();

            // 클래스
        }
    }
}