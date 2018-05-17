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
            Guarda3<string> g3s = new Guarda3<string>();
            Guarda3<float> g3f = new Guarda3<float>();

            g3s.SetItem(1, "Ola");
            g3s.SetItem(2, "Adeus");
            g3s.SetItem(3, "LaLa");

            g3f.SetItem(1, 2.3F);
            g3f.SetItem(2, 5.7F);
            g3f.SetItem(2, -4F);

            Console.WriteLine(g3s.GetItem(1));
            Console.WriteLine(g3s.GetItem(2));
            Console.WriteLine(g3s.GetItem(3));
            Console.WriteLine(g3f.GetItem(1));
            Console.WriteLine(g3f.GetItem(2));
            Console.WriteLine(g3f.GetItem(3));

        }
    }
}
