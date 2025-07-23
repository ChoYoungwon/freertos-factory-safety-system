using System;

// 삼항 연산자
public class TernaryOperator
{
    public static void Run()
    {
        string result = (10 % 2) == 0 ? "짝수" : "홀수";
        Console.WriteLine(result);
    }
}