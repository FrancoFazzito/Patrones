using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrimitiva normal = new JugueteNormal();

            AlgoritmoArmado armado = new AlgoritmoArmado();

            armado.metodoTemplate(normal, 3);

            Console.Read();
        }
    }
}
