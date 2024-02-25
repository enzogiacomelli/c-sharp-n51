using Microsoft.EntityFrameworkCore;
using SupermercadoRepositorios.BancoDados;
using SupermercadoRepositorios.Entidades;
using SupermercadoRepositorios.Modelos;
using System.Data;

namespace SupermercadoRepositorios.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {

        private readonly SupermercadoContexto _contexto;

        public ProdutoRepositorio()
        {
            _contexto = new SupermercadoContexto();
        }

        public void Cadastrar(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "INSERT INTO produtos (nome, id_categoria, preco_unitario) VALUES (@NOME, @ID_CATEGORIA, @PRECO_UNITARIO)";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", produto.Categoria.Id);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }

        public void Apagar(int id)
        {
            var produto = ObterPorId(id);
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }


        public List<Produto> ObterTodos(ProdutoFiltros produtoFiltros)
        {
            return _contexto.Produtos
                .Include(x => x.Categoria)//inner join (incluindo no select o inner join com a tabela de categorias)
                .ToList();
            /*
            produtoFiltros.Pesquisa = $"%{produtoFiltros.Pesquisa}%"; //concatenando o texto de pesquisa com % %

            //criando parte do select que ordena pelo campo ordenacao

            if (produtoFiltros.OrdenacaoCampo == "Código")
            {
                produtoFiltros.OrdenacaoCampo = "produtos.id";

            }
            else if (produtoFiltros.OrdenacaoCampo == "Nome")
            {
                produtoFiltros.OrdenacaoCampo = "produtos.nome";

            }
            else if (produtoFiltros.OrdenacaoCampo == "Categoria")
            {
                produtoFiltros.OrdenacaoCampo = "categorias.nome";

            }
            else if (produtoFiltros.OrdenacaoCampo == "Preço Unitário")
            {
                produtoFiltros.OrdenacaoCampo = "produtos.preco_unitario";
            }

            //criando parte do select que ordena alfabeticamente
            if (produtoFiltros.OrdenacaoOrdem == "Z-A")
                produtoFiltros.OrdenacaoOrdem = "DESC";
            else if (produtoFiltros.OrdenacaoOrdem == "A-Z")
                produtoFiltros.OrdenacaoOrdem = "ASC";

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
                "INNER JOIN categorias ON (produtos.id_categoria = categorias.id) " +
                "WHERE produtos.nome LIKE @PESQUISA " +
                $"ORDER BY {produtoFiltros.OrdenacaoCampo} {produtoFiltros.OrdenacaoOrdem} " +
                "OFFSET @POSICAO_PAGINACAO ROWS " + //determinar qual sera a pagina
                "FETCH NEXT @CAMPO_QUANTIDADE ROWS ONLY"; //determinar a quantidade de registros consultados


            comando.Parameters.AddWithValue("@PESQUISA", produtoFiltros.Pesquisa);
            comando.Parameters.AddWithValue("@CAMPO_QUANTIDADE", produtoFiltros.Quantidade);
            comando.Parameters.AddWithValue("@POSICAO_PAGINACAO", produtoFiltros.Pagina);

            //carrega tabela na memoria e executa o comando
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            //criando a lista que será o retorno do metodo
            var produtos = new List<Produto>();

            //percorrer os registros armazenados na tabema em memoria
            for (var i = 0; i < tabelaEmMemoria.Rows.Count; i++)
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
            */
        }

        public int ObterQuantidadeTotalRegistros()
        {
            return _contexto.Produtos.Count();
            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "SELECT COUNT(id) FROM produtos";
            var registroQuantidade = Convert.ToInt32(comando.ExecuteScalar());//pega um numero inteiro do resultado do select count

            comando.Connection.Close();
            return registroQuantidade;
            */
        }

        public Produto ObterPorId(int id)
        {
            return _contexto.Produtos.Where(x => x.Id == id).FirstOrDefault();
            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "SELECT * FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            var registro = tabelaEmMemoria.Rows[0];
            var produto = new Produto();
            produto.Id = Convert.ToInt32(registro["id"]);
            produto.Nome = registro["nome"].ToString();
            produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);
            produto.Categoria = new Categoria();
            produto.Categoria.Id = Convert.ToInt32(registro["id_categoria"]);
            return produto;
            */
        }

        public void Atualizar(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            _contexto.SaveChanges();
            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "UPDATE produtos SET " +
                "nome = @NOME, " +
                "id_categoria = @ID_CATEGORIA, " +
                "preco_unitario = @PRECO_UNITARIO, " +
                "WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", produto.Categoria.Id);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@ID", produto.Id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }
    }
}
