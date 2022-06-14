//using System;
//using System.Text.Json;

//namespace _201934020_KJS
//{
//    public class KJS
//    {
//        public string Name { get; set; }
//        public int Number { get; set; }
//        public int Number2 { get; set; }
//        public string Man { get; set; }
//    }
//    class proGram
//    {
//        static void Main(string[] args)
//        {
//            //이름 전화번호 학번 성별
//            var KJS = new KJS
//            {
//                Name = "KimJunSeok",
//                Number = 01062979057,
//                Number2 = 201934020,
//                Man = "Man"
//            };
//            string jsonString = JsonSerializer.Serialize(KJS); // 직렬화

//            Console.WriteLine(jsonString);
//        }
//    }
//}