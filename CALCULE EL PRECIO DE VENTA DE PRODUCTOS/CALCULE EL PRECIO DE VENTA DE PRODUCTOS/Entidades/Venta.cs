using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS.Entidades
{
    class Venta
    {
        int x;
        int identificaciordeproducto;
        String nombre_producto;
        String descripcion_del_producto;
        double precio_del_producto;
        int cantidad;
        double descuento;
        double total;

        public int Identificaciordeproducto { get => identificaciordeproducto; set => identificaciordeproducto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion_del_producto { get => descripcion_del_producto; set => descripcion_del_producto = value; }
        public double Precio_del_producto { get => precio_del_producto; set => precio_del_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Total { get => total; set => total = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public int X { get => x; set => x = value; }

        public override string ToString()
        {
            return "Nombre del Producto: " + Nombre_producto +
                "\nDescripcion del Porducto: " + Descripcion_del_producto +
                "\nPrecio del Producto $" + Precio_del_producto + 
                "\nCantidad de Producto: " + Cantidad;
        }
    }
}
