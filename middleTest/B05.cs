using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace middleTest
{
    class B05
    {
        static void Main(string[] args) // 교수님 컴퓨터 최적화 후 실행바람
        {
            var v = Stopwatch.StartNew();

            var sb = new StringBuilder();
            for (int i = 0; i < 1500000; i++)
            {
                sb.Append($"[{i}]김준석");
            }

            Console.WriteLine(sb.ToString());

            v.Stop();
            Console.WriteLine(v.ElapsedMilliseconds / 1000);
        }
    }
}
