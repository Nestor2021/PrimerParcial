using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULE_EL_PRECIO_DE_VENTA_DE_PRODUCTOS.Entidades
{
    class Usuario
    {
        int a;
        String nombre;
        int contra;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Contra { get => contra; set => contra = value; }
        public int A { get => a; set => a = value; }

        public Usuario() { }

        public Usuario(int a, string nombre, int contra)
        {
            this.a = a;
            this.nombre = nombre;
            this.contra = contra;
        }
        public Usuario( string nombre, int contra)
        {
            this.nombre = nombre;
            this.contra = contra;
            
        }

        public override string ToString()
        {
            return "Nombre de Usuario: " + nombre;       
        }


    }
}
