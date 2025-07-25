using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjctForGenkins
{
    internal class Program
    {
        public void Addtion()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("Addition is: " + c);
        }
        static void Main(string[] args)

        {
            Program program = new Program();
            program.Addtion();
            Console.ReadLine(); 
        }
    }
}
