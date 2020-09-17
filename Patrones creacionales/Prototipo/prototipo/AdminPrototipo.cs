using System.Collections.Generic;

namespace prototipo
{
    class AdminPrototipo //guardamos un listado de prototipos cada uno con una key
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public AdminPrototipo()
        {
            Persona persona = new Persona();
            persona.Nombre = "juan";
            prototipos.Add("persona", persona);

            Casa casa = new Casa();
            casa.Calle = "General paz";
            prototipos.Add("casa", casa);
        }

        public void addPrototipo(string nombre,IPrototipo prototipo)
        {
            prototipos.Add(nombre, prototipo);
        }

        public IPrototipo this[string llave]
        {
            get => prototipos[llave];
            set => prototipos[llave] = value;
        }
    }
}
