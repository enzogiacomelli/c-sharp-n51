using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;


namespace SupermercadoForm.Repositorios
{
    internal class CategoriaRepositorio
    {
        public List<Categoria> ObterTodos()
        {
            //criando conexão, comando e fazendo select
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "SELECT id, nome FROM categorias ORDER BY nome ASC";//ordenando as categorias no select

            //trazendo a tabela para memoria executando o comando com o select
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            //criando lista
            var categorias = new List<Categoria>();

            //pegando os dados da tabela, montando o objeto e adicionando na lista
            for(var i = 0; i< tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];
                int id = Convert.ToInt32(registro["id"]);
                var nome = registro["nome"].ToString();

                var categoria = new Categoria();
                categoria.Id = id;
                categoria.Nome = nome;
                categorias.Add(categoria);
            }
            return categorias;//retorna uma lista de objetos da entidade categoria
        }
    }
}
