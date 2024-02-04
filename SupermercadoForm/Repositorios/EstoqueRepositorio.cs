using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    internal class EstoqueRepositorio
    {
        public List<Estoque> ObterTodos()
        {
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "SELECT estoques.id, id_produto AS 'idProduto', produtos.nome AS 'nomeProduto', estoques.quantidade from estoques inner join produtos ON (estoques.id_produto = produtos.id)";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            var estoques = new List<Estoque>();

            for (var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var idEstoque = Convert.ToInt32(registro["id"]);//id do estoque
                var idProduto = Convert.ToInt32(registro["idProduto"]);//id do produto
                var nomeProduto = registro["nomeProduto"].ToString();//nome do produto
                var quantidade = Convert.ToDecimal(registro["quantidade"]);//quantidade do estoque

                //instanciando objeto produto
                var produto = new Produto();
                produto.Id = idProduto;
                produto.Nome = nomeProduto;

                //instanciando objeto estoque
                var estoque = new Estoque();
                estoque.Id = idEstoque;
                estoque.Quantidade = quantidade;
                estoque.Produto = produto;

                estoques.Add(estoque);
            }
            return estoques;
        }

        public void Cadastrar(Estoque estoque)
        {
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "INSERT INTO estoques(id_produto, quantidade) VALUES (@IDPRODUTO, @QUANTIDADE)";
            comando.Parameters.AddWithValue("@IDPRODUTO", estoque.Produto.Id.ToString());
            comando.Parameters.AddWithValue("@QUANTIDADE", estoque.Quantidade.ToString());
            
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar cadastrar o estoque: " + ex.Message);
                return;
            }
            comando.Connection.Close();
        }

    }
}
