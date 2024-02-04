using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;

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

        public List<Produto> ObterTodos()
        {
            //criando conexão, comando e fazendo select
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            //select com join para buscar a categoria do produto junto
            comando.CommandText = "SELECT " +
                "produtos.id, " +
                "produtos.nome, " +
                "produtos.id_categoria AS 'categoriaId', " +
                "produtos.preco_unitario, " +
                "categorias.nome AS 'categoriaNome' " +
                "FROM produtos " +
                "INNER JOIN categorias ON (produtos.id_categoria = categorias.id)";

            //carrega tabela na memoria e executa o comando
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            //criando a lista que será o retorno do metodo
            var produtos = new List<Produto>();

            //percorrer os registros armazenados na tabema em memoria
            for(var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //obtendo registro
                var registro = tabelaEmMemoria.Rows[i];

                //instanciando objeto produto
                var produto = new Produto();
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();
                produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);

                //instanciando objeto categoria
                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(registro["categoriaId"]);
                categoria.Nome = registro["categoriaNome"].ToString();

                //definir a categoria para o objeto produto, utilizando o objeto categoria
                produto.Categoria = categoria;
                produtos.Add(produto);
            }
            return produtos;
        }
    }
}
