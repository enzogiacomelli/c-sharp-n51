using Microsoft.EntityFrameworkCore;
using SupermercadoRepositorios.Entidades;


namespace SupermercadoRepositorios.BancoDados
{
    internal class SupermercadoContexto : DbContext
    {
        public DbSet<Estante> Estantes {  get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        //https://learn.microsoft.com/en-us/ef/core/cli/dotnet
        //dotnet tool install --global dotnet-ef

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\egiac\\Desktop\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        }
    }
}
