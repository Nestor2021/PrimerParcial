using CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS.Negocio
{
    class ClsVenta
    {
        public String COBRO(Venta venta)
        {
            venta.Total = venta.Precio_del_producto * venta.Cantidad;
            if(venta.Total > 50.00)
            {
                venta.X = 1;
                venta.Descuento = venta.Total * 0.15;
                venta.Descuento = venta.Total - venta.Descuento;
                return "El precio original es de $" + venta.Total + 
                    "\nY el precio con un descuento de 15% le queda a $" + venta.Descuento;
            }
            else
            {
                venta.X = 1;
                return "El total a pagar es $" + venta.Total;
            }
        }
    }
}
