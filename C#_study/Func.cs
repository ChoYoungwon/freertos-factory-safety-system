using System;

public class Func
{
    private static int price = 100;

    // 참조 반환
    public static ref int GetPrice()
    {
        return ref price;
    }
    
    // 참조에 의한 매개변수 전달
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // 출력 전용 매개변수(out) - 해당 매개변수에 결과를 저장하지 않으면 컴파일러가 에러 발생, 메소드 호출 전 미리 선언할 필요 없음
    public static void Divide(int a, int b, out int quotient, out int remainder)
    {
        quotient = a / b;
        remainder = a % b;
    }

    public static int Sum(params int[] args)
    {
        int sum = 0;
        for (int i = 0; i < args.Length; i++)
        {
            if (i > 0)
                Console.Write(", ");

            Console.Write(args[i]);

            sum += args[i];
        }
        Console.WriteLine();

        return sum;
    }

    public static void Run()
    {
        // 참조 반환
        ref int ref_local_price = ref GetPrice();
        int normal_local_price = GetPrice();

        Console.WriteLine($"Ref Local Price :{ref_local_price}");
        Console.WriteLine($"Normal Local Price :{normal_local_price}");

        ref_local_price = 200;

        Console.WriteLine($"Local Price :{ref_local_price}");
        Console.WriteLine($"Normal Local Price :{normal_local_price}");
        Console.WriteLine("--------------------\n");

        // 출력 전용 매개변수
        int a = 20; int b = 3;
        Divide(a, b, out int c, out int d);
        Console.WriteLine("a : {0}, b : {1}, a / b : {2}, a % b : {3}", a, b, c, d);
        Console.WriteLine("--------------------\n");

        // 가변 개수의 인수
        int sum = Sum(3, 4, 5, 6);
        Console.WriteLine("Sum : {0}", sum);
        Console.WriteLine("--------------------\n");
    }
}