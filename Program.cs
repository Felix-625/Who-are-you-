﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Activity_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string first_name = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string last_name = Console.ReadLine();

            Console.WriteLine("Your full name is: " + first_name + " " + last_name);


        }
    }
}
