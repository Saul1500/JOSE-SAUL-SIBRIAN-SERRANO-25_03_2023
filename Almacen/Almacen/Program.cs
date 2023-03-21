using Almacen.DAO;
using Almacen.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

    Console.WriteLine("======================================");
    Console.WriteLine("BIENVENIDO AL MENU DE LA BASE DE DATOS");
    Console.WriteLine("======================================");

    Console.WriteLine("");

    Console.WriteLine("Precio 1 para Insertar Productos");

    Console.WriteLine("");

    Console.WriteLine("Precio 0 para Cancelar la Operacion");

    Console.WriteLine("======================================");
    Console.WriteLine("");
    
    var menu = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

switch (menu) {
    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Producto producto = new Producto();
            CrudProductos crudProductos = new CrudProductos();

            Console.WriteLine("Ingrese El Nombre del Producto: ");
            producto.Nombre = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ingrese la Descripcion del Producto: ");
            producto.Descripcion = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Ingrese el Precio del Producto: ");
            producto.Precio = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese la Cantidad de Stock: ");
            producto.Stock = Convert.ToInt32(Console.ReadLine());

            crudProductos.AgregarUsuario(producto);
            Console.WriteLine("");

            Console.WriteLine("Su Registro Ha Sido Guardado Exitosamente...");
            Console.WriteLine("======================================");
            Console.WriteLine("");

            Console.WriteLine("======================================");
            Console.WriteLine("BIENVENIDO AL MENU DE LA BASE DE DATOS");
            Console.WriteLine("======================================");

            Console.WriteLine("Precio 1 para Insertar Productos");

            Console.WriteLine("");

            Console.WriteLine("Precio 0 para Cancelar la Operacion");

            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;

    case 2:
        Console.WriteLine("");
        Console.WriteLine("Su Operacion ha Sido Cancelada");
        break;
}

           
         
       

