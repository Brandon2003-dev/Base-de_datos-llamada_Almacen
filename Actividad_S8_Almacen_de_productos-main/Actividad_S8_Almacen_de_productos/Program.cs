using Actividad_S8_Almacen_de_productos.Models;

Console.WriteLine()
Console.WriteLine("           ******************************************************************       ");
Console.WriteLine("             BIENVENIDO NUEVAMENTE A SU ALMACEN SERA UN PLACER ATENDERLO :D     ");
Console.WriteLine("           ******************************************************************       ");
Console.WriteLine();

AlmacenContext db = new AlmacenContext();
Producto producto = new Producto();

Console.WriteLine();

Console.Write("- Nombre de el producto ---> ");
producto.Nombre = Console.ReadLine();
Console.Write("- Descripción del producto ---> ");
producto.Descripcion = Console.ReadLine();
Console.Write("- Precio de el producto ---> ");
producto.Precio = Convert.ToDecimal(Console.ReadLine());
Console.Write("- Cantidad de productos en stock ---> ");
producto.Stock = Convert.ToInt32(Console.ReadLine());

db.Producto.Add(producto);
db.SaveChanges();

Console.WriteLine("  El producto se registro con exito:");
Console.WriteLine("-----------------------------------------");
Console.WriteLine(" Id Cantidad. Productos Descripcion Precio ");
Console.WriteLine("-----------------------------------------");

Console.WriteLine();

var ListaProductos = db.Producto.ToList();
foreach (var product in ListaProductos){

    Console.WriteLine($"  {product.Id}  {product.Stock}    {product.Nombre} / {product.Descripcion} / ${product.Precio}");
}

Console.WriteLine()
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("         GRACIAS POR PREFERIRNOS QUE TENGA UN EXCELENTE DIA :D          ");
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine()
