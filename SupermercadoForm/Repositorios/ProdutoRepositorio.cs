using SupermercadoForm.BancoDados;

namespace SupermercadoForm.Repositorios
{
    internal class ProdutoRepositorio
    {
        public void Cadastrar(string nome, int idCategoria, decimal precoUnitario)
        {
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "INSERT INTO produtos (nome, id_categoria, preco_unitario) VALUES (@NOME, @ID_CATEGORIA, @PRECO_UNITARIO)";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", idCategoria);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}
