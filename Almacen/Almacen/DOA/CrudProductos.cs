using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almacen.Models;


namespace Almacen.DAO
{
    internal class CrudProductos
    {
        public void AgregarUsuario(Producto ParametroProductos)
        {

            using (AlmacenContext db = new AlmacenContext())
            {
                Producto productos = new Producto();
                productos.Nombre = ParametroProductos.Nombre;
                productos.Descripcion = ParametroProductos.Descripcion;
                productos.Precio = ParametroProductos.Precio;
                productos.Stock = ParametroProductos.Stock;
                db.Add(productos);
                db.SaveChanges();
            }
        }
    }
}