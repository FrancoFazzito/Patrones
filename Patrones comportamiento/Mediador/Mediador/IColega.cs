namespace Mediador
{
    internal interface IColega
    {
        void recibir(string emisor, string mensaje);
        void enviar(string mensaje);
    }
}
