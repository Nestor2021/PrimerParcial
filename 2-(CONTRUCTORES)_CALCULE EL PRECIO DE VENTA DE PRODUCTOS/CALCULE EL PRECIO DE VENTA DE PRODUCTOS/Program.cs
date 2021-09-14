using CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS.Entidades;
using CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Bienvenido!!!!");
            Console.WriteLine("Ingrese su nombre de usuario  (Nestor)");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            int contra = Convert.ToInt32(Console.ReadLine());
            
            Usuario usuario = new Usuario(a,nombre, contra);
            ClsUsuario clsUsuario = new ClsUsuario();
            Console.WriteLine(clsUsuario.Acceso(usuario));
            if ( usuario.A== 1)
            {
                             
                Venta venta = new Venta();
                ClsVenta clsVenta = new ClsVenta();
                Console.WriteLine("////////////////////////////");
                Console.WriteLine(usuario.ToString());
                Console.WriteLine("////////////////////////////");
                venta.X = 1;
                while(venta.X == 1)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Ingrese los datos");
                    Console.WriteLine("Ingrese el identificador del producto");
                    int identificaciordeproducto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nombre del producto");
                    String nombre_producto = Console.ReadLine();
                    Console.WriteLine("Descripcion del producto");
                    String descripcion_del_producto = Console.ReadLine();
                    Console.WriteLine("Precio del producto");
                    Double precio_del_producto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cantidad del producto");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    Venta venta1 = new Venta(identificaciordeproducto, nombre_producto, descripcion_del_producto, precio_del_producto, cantidad);

                    Console.WriteLine(clsVenta.COBRO(venta1));
                    Console.WriteLine(venta1.ToString());
                   
                }
            }
            Console.ReadLine();
        }
    }
}
