using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pierwszagra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kulko i Krzyzyk by dawid11g");
            Thread.Sleep(3000);
            Console.Clear();
            
            Console.WriteLine("Powered by GameVisualTech");
            Thread.Sleep(3000);
            Console.Clear();

            MenuGlowne Menu = new MenuGlowne();
            MenuWyboru Wcisck = new MenuWyboru();
        }
    }
}
