﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = 0;

            Console.WriteLine("請熟入你要刷幾次數字组：");
            int ans = int.Parse(Console.ReadLine());
            for (i = 0; i < ans; i++)
            {
                Console.Clear();
                int r1 = rand.Next(45, 90);
                int r2 = rand.Next(45, 90);
                int r3 = rand.Next(45, 90);
                int r4 = rand.Next(45, 90);
                int r5 = rand.Next(45, 90);
                int r6 = rand.Next(45, 90);

                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║               [第{0:00}組]本周頭獎是:                     ║", i);
                Console.WriteLine("╠════════╦════════╦════════╦════════╦════════╦══════════╣");
                Console.WriteLine("║   {0:00}   ║   {1:00}   ║   {2:00}   ║   {3:00}   ║   {4:00}   ║   {5:00}     ║", r1, r2, r3, r4, r5, r6);
                Console.WriteLine("╚════════╩════════╩════════╩════════╩════════╩══════════╝");

                System.Threading.Thread.Sleep(500);
            }
            Console.ReadLine();

        }
    }
}