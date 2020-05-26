using System.Data.SqlClient;

namespace Repositorio
{
    public static class Conexion
    {
        public static SqlConnection StringConexion => new SqlConnection("Data Source=.;Initial Catalog=Persona;Integrated Security=True");
    }
}
