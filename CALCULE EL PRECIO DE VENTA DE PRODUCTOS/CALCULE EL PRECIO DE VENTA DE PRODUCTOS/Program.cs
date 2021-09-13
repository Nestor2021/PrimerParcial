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
            Usuario usuario = new Usuario();
            ClsUsuario clsUsuario = new ClsUsuario();
            Venta venta = new Venta();
            ClsVenta clsVenta = new ClsVenta();
            usuario.A = 0; 
            //Se piden los datos al usuario para iniciar sesion
            Console.WriteLine("Bienvenido!!!!");
            Console.WriteLine("Ingrese su nombre de usuario  (Nestor)");
            usuario.Nombre= Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            usuario.Contra= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(clsUsuario.Acceso(usuario));
           
            //Pregunto si A = 0, si es igual es porque a iniciado correctanmete
            //Y si es A = 1, no se inicio correctamente
            if (usuario.A == 0)
            {
                Console.WriteLine("////////////////////////////");
                Console.WriteLine(usuario.ToString());
                Console.WriteLine("////////////////////////////");
                venta.X = 1;
                while (venta.X == 1)
                {
                    
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Ingrese los datos");
                    Console.WriteLine("Ingrese el identificador del producto");
                    venta.Identificaciordeproducto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nombre del producto");
                    venta.Nombre_producto = Console.ReadLine();
                    Console.WriteLine("Descripcion del producto");
                    venta.Descripcion_del_producto = Console.ReadLine();
                    Console.WriteLine("Precio del producto");
                    venta.Precio_del_producto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cantidad del producto");
                    venta.Cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(clsVenta.COBRO(venta));
                    Console.WriteLine(venta.ToString());
                }
            }
            else
            {
               
                
            }
            Console.ReadLine();

            
        }
    }
}
