using Microsoft.EntityFrameworkCore;
public class ScuolaContext : DbContext

{
    public DbSet<Studente> Studenti => Set<Studente>();

    // Connection string centrale (adatta server/credenziali al tuo ambiente)

    private const string _connectionString ="server=localhost;user=root;password=Milan1997.;database=scuola";

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
}