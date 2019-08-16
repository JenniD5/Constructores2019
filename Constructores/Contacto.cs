using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Contacto()//inicializar variables
        {
            Nombre = "sin nombre";
            Celular = "sin celular";
            Telefono = "sin telefono";
            Correo = "sin correo";
            Direccion = "sin direccion";
        }

        public Contacto(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = "sin celular";
            Telefono = "sin telefono";
            Direccion = "sin direccion";
        }

        public Contacto(string nombre, string celular, string telefono, string correo, string direccion)
        {
            Nombre = nombre;
            Celular = celular;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }
 





    }
}
