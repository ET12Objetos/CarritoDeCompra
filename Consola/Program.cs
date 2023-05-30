using Biblioteca;

Carrito carrito = new Carrito();

carrito.AgregarUn(new Articulo("Leche", "Vale por una descripción", 390));
carrito.AgregarUn(new Articulo("Dulce de leche", "Vale por una descripción", 400));
carrito.AgregarUn(new Articulo("Queso", "Vale por una descripción", 650.5));

carrito.Informar();

var articulos = carrito.Buscar("Leche");

foreach (Articulo articulo in articulos)
{
    Console.WriteLine(articulo.Nombre);
}

carrito.Modificar(new Articulo("Leche", "Nueva descripcion", 400), "Leche");

carrito.Borrar("Queso");

carrito.Informar();
