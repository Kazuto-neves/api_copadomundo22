using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFramework;
using Api_Adm.Models;
using System.Data.Entity;

namespace Api_Adm.servicos
{
  public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    public DbSet<Administrador> Administradores { get; set; }
  }
}
