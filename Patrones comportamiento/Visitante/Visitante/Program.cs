using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitante
{
    class Program //define y lleva nuevas operaciones sobre una estructura sin cambiar sus clases
    {             //vamos visitar los obejtos de esa estructura sin alterar sus clases
        static void Main(string[] args)
        {
            
            Console.Read();
        }
    }

    public abstract class AbstractVisitor
    {
        public abstract string Visitar(AsistenteUAI recibir);
        public abstract string Visitar(AsistenteExterno recibir);
        public abstract string Visitar(AsistenteGeneral recibir);
    }

    public class Recibidor : AbstractVisitor
    {
        public override string Visitar(AsistenteUAI recibir)
        {
            return recibir.Accept(this);
        }

        public override string Visitar(AsistenteExterno recibir)
        {
            return recibir.Accept(this);
        }

        public override string Visitar(AsistenteGeneral recibir)
        {
            return recibir.Accept(this);
        }
    }

    public class AsistenteGeneral : Asistente
    {
        public override string Accept(AbstractVisitor visitante)
        {
            throw new NotImplementedException();
        }
    }

    public class AsistenteExterno : Asistente
    {
        public override string Accept(AbstractVisitor visitante)
        {
            return visitante.Visitar(this);
        }
    }

    public class AsistenteUAI : Asistente
    {
        public override string Accept(AbstractVisitor visitante)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Asistente {

        private string nombre;
        private string apellido;
        private string edad;

        public abstract string Accept(AbstractVisitor visitante);

    }
}
