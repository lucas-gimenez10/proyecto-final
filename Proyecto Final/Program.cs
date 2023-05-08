using Proyecto_Final;

Usuario usuario1 = new Usuario(1,"lucas","gimenez","raksik","1234","lucas@gmail.com");

Console.WriteLine("id: {0}, nombre: {1}, apellido: {2}, nombre de usuario: {3}, contraseña: {4}, mail: {5}", usuario1.Id, usuario1.Nombre, usuario1.Apellido, usuario1.NombreUsuario, usuario1.Contrasena, usuario1.Mail);

Producto prod1 = new Producto(1, "jabon", 10.40f, 20.80f, 10, 1);
Console.WriteLine("id: {0}, descripcion: {1}, costo: {2}, precio de venta: {3}, stock: {4}, id de usuario: {5}", prod1.Id, prod1.Descripcion, prod1.Costo, prod1.PrecioVenta, prod1.Stock, prod1.IdUsuario);

ProductoVendido prodvendido1 = new ProductoVendido(1, 44321, 30, 12312);
Console.WriteLine("id: {0}, idProducto: {1}, stock: {2}, idVenta:{3}",prodvendido1.Id, prodvendido1.IdProducto, prodvendido1.Stock, prodvendido1.IdVenta);

Venta venta1 = new Venta(1, "sin comentarios", 1);
Console.WriteLine("id: {0}, comentario: {1}, Idusuario: {2}", venta1.Id, venta1.Comentarios, venta1.IdUsuario);

Console.ReadLine();