using System.Data.SqlClient;

namespace Repositorio
{
    public sealed class Conexion
    {
        private const string STRING_CONEXION = "Data Source=.;Initial Catalog=Persona;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(STRING_CONEXION);

        private Conexion()
        {

        }

        public static SqlConnection SqlConexion => conexion;
    }
}
