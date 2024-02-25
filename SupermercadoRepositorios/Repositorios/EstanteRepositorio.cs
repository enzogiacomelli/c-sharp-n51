using SupermercadoRepositorios.BancoDados;
using SupermercadoRepositorios.Entidades;
using System.Data;

namespace SupermercadoRepositorios.Repositorios
{
    public class EstanteRepositorio : IEstanteRepositorio
    {
        //private ConexaoBancoDados conexao;
        private readonly SupermercadoContexto _contexto;

        //construtor
        public EstanteRepositorio()
        {
            _contexto = new SupermercadoContexto();
            //conexao = new ConexaoBancoDados(); //instanciando objeto da classe conexaoBancoDados para usar abaixo.
        }

        public void Apagar(int id)
        {
            var estante = ObterPorId(id);
            _contexto.Estantes.Remove(estante);
            /*
            var comando = conexao.Conectar();
            comando.CommandText = "DELETE FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }

        public void Atualizar(Estante estante)
        {
            _contexto.Estantes.Update(estante);
            _contexto.SaveChanges();
            /*
            var comando = conexao.Conectar();
            comando.CommandText = "UPDATE estantes SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", estante.Id);
            comando.Parameters.AddWithValue("@NOME", estante.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estante.Sigla);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }

        public void Cadastrar(Estante estante)
        {
            _contexto.Estantes.Add(estante);
            _contexto.SaveChanges();
            /*
            var comando = conexao.Conectar();
            comando.CommandText = "INSERT INTO estantes (nome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", estante.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estante.Sigla);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
            */
        }


        public Estante ObterPorId(int id)
        {
            return _contexto.Estantes.Where(x => x.Id == id).FirstOrDefault();
            /*
            var comando = conexao.Conectar();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            var registro = tabelaEmMemoria.Rows[0];
            var estante = new Estante();
            estante.Id = id;
            estante.Nome = registro["nome"].ToString();
            estante.Sigla = registro["sigla"].ToString();
            return estante;
            */
        }

        public List<Estante> ObterTodos(string pesquisa)
        {
            return _contexto.Estantes.Where(x => x.Nome.Contains(pesquisa)).ToList();
            /*
            pesquisa = $"%{pesquisa}%";
            var comando = conexao.Conectar();
            comando.CommandText = "SELECT id, nome, sigla FROM estantes WHERE nome LIKE @PESQUISA";
            comando.Parameters.AddWithValue("@PESQUISA", pesquisa);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();
            var estantes = new List<Estante>();

            foreach(DataRow registro in tabelaEmMemoria.Rows)
            {
                var estante = new Estante();
                estante.Id = Convert.ToInt32(registro["id"]);
                estante.Nome = registro["nome"].ToString();
                estante.Sigla = registro["sigla"].ToString();
                estantes.Add(estante);
            }
            return estantes;
            */
        }
    }
}
