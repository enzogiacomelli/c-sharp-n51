namespace SupermercadoForm.Entidades
{
    internal class Estoque
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
    }
}
