using System;
using Tienda-Don-Pedro.Models;
namespace Company.ClassLibrary1;

public class ProductoService
{
    private readonly AppDbContext _context
    {
        _context = context;
    }
    public void Agregar (string Nombre, decimal Precio)
    {
        Nombre = nombre,
        Precio = precio
    }
    _context.Productos.Add(Producto);
    _context.SaveChanges();
}

public List<Producto>ObtenerTodos()
{
    return _context.Productos.ToList();
}