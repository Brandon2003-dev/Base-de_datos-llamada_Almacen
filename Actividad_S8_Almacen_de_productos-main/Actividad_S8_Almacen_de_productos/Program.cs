using Actividad_S8_Almacen_de_productos.Models;

Console.WriteLine()
Console.WriteLine("           ******************************************************************       ");
Console.WriteLine("             BIENVENIDO/AS NUEVAMENTE A SU <ALMACEN> SERA UN PLACER ATENDERLO      ");
Console.WriteLine("           ******************************************************************       ");
Console.WriteLine();

AlmacenContext db = new AlmacenContext();
Productos productos = new Productos();

Console.WriteLine();

Console.Write("- Nombre de producto ---> ");
producto.Nombre = Console.ReadLine();
Console.Write("- Descripción del producto ---> ");
producto.Descripcion = Console.ReadLine();
Console.Write("- Precio de el producto ---> ");
producto.Precio = Convert.ToDecimal(Console.ReadLine());
Console.Write("- Cantidad de productos en stock ---> ");
producto.Stock = Convert.ToInt32(Console.ReadLine());

db.Productos.Add(producto);
db.SaveChanges();

Console.WriteLine("  Productos ya registrados:");
Console.WriteLine("-----------------------------------------");
Console.WriteLine(" Id Cantidad. Productos Descripcion Precio ");
Console.WriteLine("-----------------------------------------");

Console.WriteLine();

var ListaProductos = db.Productos.ToList();
foreach (var product in ListaProductos){

    Console.WriteLine($"  {product.Id}  {product.Stock}    {product.Nombre} / {product.Descripcion} / ${product.Precio}");
}

Console.WriteLine()
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("         GRACIAS POR PREFERIRNOS QUE TENGA UN EXCELENTE DIA :D          ");
Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine()