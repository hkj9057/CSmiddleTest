//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace middleTest
//{
//    internal class B04
//    {
//        static void Main(string[] args)
//        {
//            Random rd = new Random();

//            string[] name = { "김훈곤", "이윤임", "이은석", "노은석", "이성현" };

//            for(int i = 1; i < 1000000; i++)
//            {
//                string name2 = name[rd.Next(name.Length)];
//                Console.Write("[{0}] {1} {2}", i, name2,(i % 11 == 0 ) ? "|n" : "|t");
//            }
//        }
//    }
//}
