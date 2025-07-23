using System;
using System.Collections;

public class Array
{
    public static void Run()
    {
        // 배열 선언 방식
        int[] scores = new int[5] { 80, 74, 81, 90, 34 };
        // int[] scores = { 80, 74, 81, 90, 34 };

        // for문
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"{scores[i]} ");
        }
        Console.WriteLine("");

        // foreach문
        foreach (int a in scores)
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine("");

        // // 2차원 배열 생성
        // int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        // int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        // int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // // 2차원 배열 접근
        // Console.WriteLine(arr[0, 2]);

        // ArrayList (배열과 가장 닮은 컬렉션)
        ArrayList list = new ArrayList();

        // 리스트 요소 추가
        list.Add(10);
        list.Add(20);
        list.Add(30);

        // 요소 삭제
        list.RemoveAt(2);

        // 요소 추가 (1번 위치에 25 추가)
        list.Insert(1, 25);

        for (int i = 0; i < list.Count; i++)
        {
            // 리스트 요소 접근
            Console.Write($"{list[i]} ");
        }
        Console.WriteLine();
    } 
}