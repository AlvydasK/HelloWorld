﻿using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           
            if(args.Length < 1)
            {
                Console.WriteLine("Program requires at least 1 argument");
                return;
            }

            Console.WriteLine(string.Format("Hello {0}!", args[]));

            Console.ReadLine();
        }
    }
}
