﻿using System;

namespace Uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, cont;

            
            cont = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            

            if (a % 2==0)
            {
                
                cont += +1;
            }

            if (b % 2 == 0)
            {
                ;
                cont += +1;
            }

            if (c % 2 == 0)
            {
                
                cont += +1;
            }

            if (d % 2 == 0)
            {
                
                cont += +1;
            }

            if (e % 2 == 0)
            {
                
                cont += +1;
            }

           
            

            Console.WriteLine();
            Console.WriteLine(cont + " Valores pares");
            
        }
    }
}
