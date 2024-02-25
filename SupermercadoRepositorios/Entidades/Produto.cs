using System.ComponentModel.DataAnnotations.Schema;

namespace SupermercadoRepositorios.Entidades
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }

        [Column("preco_unitario")]//nome da coluna do banco
        public decimal PrecoUnitario { get; set; }

        [ForeignKey("id_categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
