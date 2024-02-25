using SupermercadoForm.Modelos;
using SupermercadoRepositorios.Entidades;

namespace SupermercadoRepositorios.Repositorios
{
    public interface IProdutoRepositorio //precisa ser public para usar no outro projeto
    {
        void Cadastrar(Produto produto);

        List<Produto> ObterTodos(ProdutoFiltros produtosFiltros);

        int ObterQuantidadeTotalRegistros();

        void Apagar(int id);

        Produto ObterPorId(int id);

        void Atualizar(Produto produto);
    }
}
