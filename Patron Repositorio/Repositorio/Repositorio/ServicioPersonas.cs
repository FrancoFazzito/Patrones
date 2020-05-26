namespace Repositorio
{
    class ServicioPersonas<T> : ServicioDatos<T> where T : IEntidad, new()
    {
        public override string GetSelect() //detallar select y prop con campo de BD tiene que ser igual
        {
            return "select * from persona";
        }
    }

}
