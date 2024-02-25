using SupermercadoRepositorios.BancoDados;
using SupermercadoRepositorios.Entidades;
using System.Data;


namespace SupermercadoRepositorios.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly SupermercadoContexto _contexto;//declarando contexto entity


        public CategoriaRepositorio()
        {
            _contexto = new SupermercadoContexto();//inicializando contexto
        }


        public List<Categoria> ObterTodos()
        {
            return _contexto.Categorias.ToList();
            /*
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
            */
        }

        public void Cadastrar(Categoria categoria)
        {
            _contexto.Categorias.Add(categoria);
            _contexto.SaveChanges();
            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "INSERT INTO categorias (nome) VALUES (@NOME)";
            comando.Parameters.AddWithValue("@NOME", categoria.Nome);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }

        public void Atualizar(Categoria categoria)
        {
            _contexto.Categorias.Add(categoria);
            _contexto.SaveChanges();

            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "UPDATE categorias SET nome = @NOME WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", categoria.Nome);
            comando.Parameters.AddWithValue("@ID", categoria.Id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }

        public void Apagar(int id)
        {
            var categoria = ObterPorId(id);//obtem categoria pelo id passado
            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();

            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "DELETE FROM categorias WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }

        public Categoria ObterPorId(int id)
        {
            //codigo com entity
            return _contexto.Categorias.Where(x => x.Id == id).FirstOrDefault();

            /*
            var conexao = new ConexaoBancoDados();
            var comando = conexao.Conectar();
            comando.CommandText = "SELECT id, nome FROM categorias WHERE id = @ID";
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            var registro = tabelaEmMemoria.Rows[0];
            var nome = registro["nome"].ToString();

            var categoria = new Categoria();
            categoria.Id = id;
            categoria.Nome = nome;
            return categoria;
            */
        }
    }
}
