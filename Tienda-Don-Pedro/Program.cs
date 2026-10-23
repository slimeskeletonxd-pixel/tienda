using Company.ClassLibrary1;

using var context = new AppDbContext();
var servicio = new ProductoService(context);

servicio.Agregar("Mouse", 13000);
servicio.Agregar("Teclado", 90234092);
servicio.Agregar("Auris", 34534);

Console.WriteLine("-------Lista de Productos el pepe-------\n");

foreach (var p in servicio.ObtenerTodos())
{
    Console.WriteLine($"{p.Id}} - {p.Nombre} - ${p.Precio}");
}