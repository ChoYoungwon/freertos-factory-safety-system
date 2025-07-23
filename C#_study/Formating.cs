using System;

public class Formating
{
    public static void Run()
    {
        String name = "Ryu";
        int id = 2020136122;

        // 1
        Console.WriteLine("Student Name: " + name + " ID : " + id);

        // 2
        string message = string.Format("Student Name : {0} ID : {1}", name, id);
        Console.WriteLine(message);

        // 2 
        Console.WriteLine($"Student Name: {name} ID : {id}");
    }
}