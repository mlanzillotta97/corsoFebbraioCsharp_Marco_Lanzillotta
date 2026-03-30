using Microsoft.EntityFrameworkCore;

public class ProdottiContext : DbContext
{
    public DbSet<Prodotto> Prodotti => Set<Prodotto>();

    private const string _connectionString =
        "server=localhost;user=root;password=Milan1997.;database=prodotti";

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
}