﻿using System;

namespace IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력: ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
                Console.Write("음수");
            else if (number > 0)
                Console.WriteLine("양수");
            else
                Console.WriteLine("0");

            if (number % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");

        }
    }
}
