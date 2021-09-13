using CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS.Negocio
{
    class ClsUsuario
    {
        public String Acceso (Usuario usuario)
        {
            if(usuario.Nombre == "Nestor" && usuario.Contra == 123)
            {
                usuario.A = 0;
                return "INICIO DE  SESIÓN CORRECTO PUEDES CONTINUAR CON EL PROCESO DE VENTA";
            }
            else
            {
                usuario.A = 1;
                return "NOMBRE DE USUARIO INCORRECTO";
            }
        }
    }
}
