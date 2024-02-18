using SupermercadoForm.BancoDados;
using SupermercadoForm.Entidades;
using System.Data;

namespace SupermercadoForm.Repositorios
{
    internal class EstanteRepositorio : IEstanteRepositorio
    {
        private ConexaoBancoDados conexao;

        //construtor
        public EstanteRepositorio()
        {
            conexao = new ConexaoBancoDados(); //instanciando objeto da classe conexaoBancoDados para usar abaixo.
        }

        public void Apagar(int id)
        {
            var comando = conexao.Conectar();
            comando.CommandText = "DELETE FROM estantes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Atualizar(Estante estante)
        {
            var comando = conexao.Conectar();
            comando.CommandText = "UPDATE estantes SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", estante.Id);
            comando.Parameters.AddWithValue("@NOME", estante.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estante.Sigla);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Cadastrar(Estante estante) 
        {
            var comando = conexao.Conectar();
            comando.CommandText = "INSERT INTO estantes (nome, sigla) VALUES (@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", estante.Nome);
            comando.Parameters.AddWithValue("@SIGLA", estante.Sigla);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }


        public Estante ObterPorId(int id)
        {
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
        }

        public List<Estante>ObterTodos(string pesquisa) 
        {
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
        }
    }
}
