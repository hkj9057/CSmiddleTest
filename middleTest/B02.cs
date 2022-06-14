//using System;

//namespace No_B_002
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = int.MaxValue;
//            Console.WriteLine(x);

//            Console.WriteLine("int 최댓값에 값 추가");
//            //int y = int.MaxValue + 10; // 값을 넘어가서 overflow 발생
//            int y = x + 10;
//            Console.Write("Overflow 된 x의 값 :");
//            Console.WriteLine(y);  //x의 값에서 overflow된 값


//            try
//            {
//                Console.WriteLine(x + 10);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}