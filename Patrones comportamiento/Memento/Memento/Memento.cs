using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memento //se usa para salvar el estado interno de un objeto y tomarlo de manera externa
{
    class Memento
    {
        internal void Salvar(Originador originador)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("auto.aut", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, originador);
            stream.Close();

            Console.WriteLine("se salvo");
        }

        internal Originador Restaurar()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("auto.aut", FileMode.Open, FileAccess.Read, FileShare.None);
            Originador temp = formatter.Deserialize(stream) as Originador;
            stream.Close();

            Console.WriteLine("se restauro");

            return temp;
        }
    }
}
