using System.Data.SqlClient;

namespace SupermercadoForm.BancoDados
{
    internal class ConexaoBancoDados
    {
        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\egiac\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = ConnectionString;
            conexao.Open();

            var comando = conexao.CreateCommand();

            return comando;
        }
    }
}
