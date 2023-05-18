using Biblioteca;

Console.BackgroundColor = ConsoleColor.Magenta;

Carrito carrito = new Carrito();

carrito.AgregarUn(new Articulo("Leche", "Vale por una descripción", 390));
carrito.AgregarUn(new Articulo("Dulce de leche", "Vale por una descripción", 400));
carrito.AgregarUn(new Articulo("Queso", "Vale por una descripción", 650.5));

carrito.Informar();
