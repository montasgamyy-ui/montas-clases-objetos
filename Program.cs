using InventarioTecnoPunto;

Producto producto1 = LeerProducto();
Producto producto2 = LeerProducto();
Producto producto3 = LeerProducto();

Console.WriteLine("\n=== INVENTARIO REGISTRADO ===\n");

producto1.MostrarInfo();
producto2.MostrarInfo();
producto3.MostrarInfo();

static Producto LeerProducto()
{
    while (true)
    {
        try
        {
            Console.WriteLine("\nRegistro de Producto");

            Console.Write("Código: ");
            string codigo = Console.ReadLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            return new Producto(codigo, nombre, precio, cantidad);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Intente nuevamente.");
        }
    }
}