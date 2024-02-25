namespace SupermercadoRepositorios.Entidades
{
    public class Estoque : EntidadeBase
    {
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
    }
}
