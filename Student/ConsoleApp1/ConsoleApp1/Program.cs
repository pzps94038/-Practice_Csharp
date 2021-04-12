using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    class Program
    {
        private static void Main(string[] args)
        {
            //tomas變數創立套用Student的格式因為格式限制裡面只有name
            Student tomas = new Student();
            tomas.name = "Tomas Dalton ";
            Student emily = new Student();
            emily.name = "Emily VanCamp";
            Console.WriteLine($"第一位學生: {tomas.name}");
            Console.WriteLine($"第二位學生: {emily.name}");

            Console.ReadKey();
        }

    }
}
