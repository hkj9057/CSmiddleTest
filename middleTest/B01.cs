//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace middleTest
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int puls = 0;
//            double[] a = new double[5];
//            double sum = 0;
//            for (int i = 0; i <= 4; i++)
//            {
//                Console.WriteLine(i + 1 + "번째 숫자를 입력하세요");
//                a[i] = double.Parse(Console.ReadLine());

//            }

//            Array.Sort(a);

//            for (int i = 0; i <= 4; i++)
//            {
//                Console.Write(a[i] + " ");
//            }

//            Console.WriteLine("\n 추가 입력을 원할 경우 y를 누르세요");
//            string c = Console.ReadLine();
//            if (c == "y")
//            {
//                Console.WriteLine("추가 입력할 계수를 입력해주세요");
//                puls = int.Parse(Console.ReadLine());
//                int v = puls + 5;
//                double[] b = new double[v];


//                for (int i = 0; i < v; i++)
//                {
//                    if (i < 5)
//                    {
//                        b[i] = a[i];
//                    }
//                    else
//                    {
//                        Console.WriteLine(i + "번째 숫자를 입력하세요");
//                        b[i] = double.Parse(Console.ReadLine());
//                    }
//                }

//                Array.Sort(b);

//                for (int i = 0; i < v; i++)
//                {
//                    Console.Write(b[i] + " ");
//                }

//            }

//        }


//    }
//}
