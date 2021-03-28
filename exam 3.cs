using System;

namespace So_hard
{
    class Program
    {
        static void Main(string[] args)
        {
            //b1 = bucket1
            //p = pick 1/2 box
            //l = location of bucket
            int b1, b2, b3, p, l;
            Console.WriteLine("Number of box in bucket1: ");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of box in bucket2: ");
            b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of box in bucket3: ");
            b3 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("b1 = {0}, b2 = {1}, b3 = {2}", b1, b2, b3);
                Console.Write("Player A");
                Console.Write(" Choose your Location of bucket: ");
                l = int.Parse(Console.ReadLine());
                switch (l)
                {
                    case 1:
                        Console.Write("How many box that you want to pick: ");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if (p >= 1 && p < 3)
                        {
                            b1 = b1 - p;
                        }
                        break;
                    case 2:
                        Console.Write("How many box that you want to pick: ");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if (p >= 1 && p < 3)
                        {
                            b2 = b2 - p;
                        }
                        break;
                    case 3:
                        Console.Write("How many box that you want to pick: ");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if (p >= 1 && p < 3)
                        {
                            b3 = b3 - p;
                        }
                        break;
                }
                if (b1 == 0 && b2 == 0 && b3 == 0)
                {
                    Console.WriteLine("B is winner");
                }
                else
                {
                    Console.WriteLine("b1 = {0}, b2 = {1}, b3 = {2}", b1, b2, b3);
                    Console.Write("Player B");
                    Console.Write(" Choose your Location of bucket: ");
                    l = int.Parse(Console.ReadLine());
                    switch (l)
                    {
                        case 1:
                            Console.Write("How many box that you want to pick: ");
                            p = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (p >= 1 && p < 3)
                            {
                                b1 = b1 - p;
                            }
                            break;
                        case 2:
                            Console.Write("How many box that you want to pick: ");
                            p = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (p >= 1 && p < 3)
                            {
                                b2 = b2 - p;
                            }
                            break;
                        case 3:
                            Console.Write("How many box that you want to pick: ");
                            p = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if (p >= 1 && p < 3)
                            {
                                b3 = b3 - p;
                            }
                            break;
                    }
                    if (b1 == 0 && b2 == 0 && b3 == 0)
                    {
                        Console.WriteLine("A is winner");
                    }
                }

            }
            while (b1 != 0 || b2 != 0 || b3 != 0);
            Console.ReadLine();   
        }
    }
}
