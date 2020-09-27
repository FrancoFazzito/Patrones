using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo
{
    class Program //crea nuevos objetos al clonar prototipos ya existentes
    {
        static void Main(string[] args) //usado cuando cuesta muchos recursos instanciar por constructor
        {
            
        }
    }

	public class ConcretePrototypeCBO1 : Prototype
	{
		//ES UN CONCRETE PROTOTYPE
		public ConcretePrototypeCBO1()
		{
			Carne = TiposCarne.Pollo;
			Medallones = 1;
			TiposQueso = TiposQueso.Cheddar;
			FetasQueso = 1;
			Salsa = TiposSalsa.Mayonesa;
			Tomate = false;
			Nombre = "CBO";
		}
	}

	public class ConcretePrototypeCBO2 : Prototype
	{
		//ES UN CONCRETE PROTOTYPE
		public ConcretePrototypeCBO2()
		{
			Carne = TiposCarne.Pollo;
			Medallones = 2;
			TiposQueso = TiposQueso.Cheddar;
			FetasQueso = 2;
			Salsa = TiposSalsa.Ketchup;
			Tomate = true;
			Nombre = "CBO";
		}
	}

	public class AdminPrototipo
    {
		private Dictionary<string, Prototype> prototipos;

        public AdminPrototipo()
        {
			prototipos = new Dictionary<string, Prototype>();
			prototipos.Add("CBO1", new ConcretePrototypeCBO1());
			prototipos.Add("CBO2", new ConcretePrototypeCBO2());
		}

        public Prototype this[string key]
        {
			get { return prototipos[key]; }
			set { prototipos[key] = value; }
        }
    }


	public abstract class Prototype : ICloneable
	{
		//PROTYPE
		protected string Nombre { get; set; }
		protected TiposCarne Carne { get; set; }
		protected int Medallones { get; set; }
		public int FetasQueso { get; set; }
		protected TiposQueso TiposQueso { get; set; }
		protected bool Tomate { get; set; }
		protected TiposSalsa Salsa { get; set; }

		public object Clone()
		{
			return MemberwiseClone();
		}

		public string Descripcion()
		{
			string mensaje = "Nombre: " + Nombre +
				" -Carne: " + Carne +
				" -Medallones: " + Medallones +
				" -FetasQueso: " + FetasQueso +
				" -Tipo de Queso: " + TiposQueso +
				" -Tipo de Salsa: " + Salsa;
			mensaje += Environment.NewLine;
			return mensaje;
		}
	}

	public enum TiposCarne { Vacuna, Pollo, Cerdo }
	public enum TiposQueso { Cheddar, Mozzarella, SinQueso }
	public enum TiposSalsa { BigMac, Mayonesa, BBQ, Ketchup, Mostaza, SinSalsa }
}
