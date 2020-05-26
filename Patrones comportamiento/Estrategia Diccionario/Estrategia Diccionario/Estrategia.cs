using System;
using System.Collections.Generic;

namespace Estrategia_Diccionario
{
    class Estrategia
    {
        private Dictionary<Tipo, Func<string,string>> estrategia;

        public Estrategia()
        {
            estrategia = new Dictionary<Tipo, Func<string, string>>();
            estrategia.Add(Tipo.normal, holaNormal);
            estrategia.Add(Tipo.largo, holaLargo);
            estrategia.Add(Tipo.corto, holaCorto);
        }

        private string holaNormal(string mensaje)
        {
            return mensaje + " NORMAL ";
        }

        private string holaLargo(string mensaje)
        {
            return mensaje + " LARGO ";
        }

        private string holaCorto(string mensaje)
        {
            return mensaje + " CORTO ";
        }

        public string Saludar(string mensaje,Tipo tipo)
        {
            return estrategia[tipo](mensaje);
        }
    }
}
