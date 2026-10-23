using System;

namespace Company.ClassLibrary1;

public class AppDbContext : DbContext
{
    public DbSset <Producto>   Producto {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conectionString = "Server=localhost;Database=TiendaPedro;User=root;Password=tupass";
        optionsBuilder.UseMySql(conectionString, ServerVersion.AutoDetect(conectionString))
    }
}
