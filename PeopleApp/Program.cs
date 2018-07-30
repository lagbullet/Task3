using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boy boy = new Boy("SN","Bob","PT","20.05.1998",20);
            Girl girl = new Girl("SN", "Lilly", "PT", "10.02.1995", 23, 175);
            boy.Show();
            boy.Talk();
            girl.SayHello();
            Console.ReadKey();
        }
    }
}
