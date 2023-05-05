using Proyecto_Final;

Usuario usuario1 = new Usuario(1,"lucas","gimenez","raksik","1234","lucas@gmail.com");

Console.WriteLine("id: {0}, nombre: {1}, apellido: {2}, nombre de usuario: {3}, contraseña: {4}, mail: {5}", usuario1.id, usuario1.nombre, usuario1.apellido, usuario1.nombreUsuario, usuario1.contrasena, usuario1.mail);

Producto prod1 = new Producto(1, "jabon", 10.40f, 20.80f, 10, 1);
Console.WriteLine("id: {0}, descripcion: {1}, costo: {2}, precio de venta: {3}, stock: {4}, id de usuario: {5}", prod1.id, prod1.descripcion, prod1.costo, prod1.precioVenta, prod1.stock, prod1.idUsuario);

ProductoVendido prodvendido1 = new ProductoVendido(1, 44321, 30, 12312);
Console.WriteLine("id: {0}, idProducto: {1}, stock: {2}, idVenta:{3}",prodvendido1.id, prodvendido1.idProducto, prodvendido1.stock, prodvendido1.idVenta);

Venta venta1 = new Venta(1, "sin comentarios", 1);
Console.WriteLine("id: {0}, comentario: {1}, Idusuario: {2}", venta1.id, venta1.comentarios, venta1.idUsuario);

Console.ReadLine();