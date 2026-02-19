using System.Data.SqlClient;

namespace tegma_new_procto_cargas
{
    public class Conexao
    {
        private static string connectionString =
            @"Server=DESKTOP-N98DB69\PDVNET;Database=TegmaDB;Trusted_Connection=True;";

        public static SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }
    }
}
