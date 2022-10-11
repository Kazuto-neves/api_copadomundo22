using Microsoft.EntityFrameworkCore;
using api_copadomundo22.Models;


namespace api_copadomundo22.servicos
{
  public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    public DbSet<Administrador> Administradores { get; set; }
  }
}
