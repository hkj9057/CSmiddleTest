//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace middleTest
//{
//    internal class A3
//    {
//        static void Main(string[] args)
//        {
//            StreamWriter sw = new StreamWriter(new FileStream("Result.txt", FileMode.Create));

//            DateTime now = DateTime.Now;
//            DateTime answer = DateTime.Now.AddDays(-125);

//            sw.WriteLine(answer);

//            sw.Close();

//            StreamReader sr = new StreamReader(new FileStream("Result.txt", FileMode.Open));
//            while(sr.EndOfStream == false)
//            {
//                Console.WriteLine(sr.ReadLine());
//            }
//            sr.Close();
//        }
        

//    }
//}
