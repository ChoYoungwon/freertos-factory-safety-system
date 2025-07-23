using System;

public class Calcurator
{
    public static void Run()
    {
        Console.WriteLine("Enter the first number: ");
        String first = Console.ReadLine();
        int num1 = int.Parse(first);

        Console.WriteLine("Enter the second number: ");
        String second = Console.ReadLine();
        int num2 = int.Parse(second);

        Console.WriteLine("Enter the operator: ");
        String op = Console.ReadLine();
        switch (op)
        {
            case "+":
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case "/":
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            default:
                Console.WriteLine($"num1 : {num1}, num2 : {num2}");
                break;
        }
    }
}