using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> g3s = new Guarda3<string>() { "Ola", "Adeus", "LaLa" };
            Guarda3<float> g3f = new Guarda3<float>() { 2.3F, 5.6F, -4F };

            foreach(string s in g3s)
            {
                Console.WriteLine(s);
            }

            foreach (float f in g3f)
            {
                Console.WriteLine(f);
            }
        }
    }
}
