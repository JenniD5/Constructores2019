
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();//va buscar el constructor sin parametros
            contacto1.Nombre = "jose";
            contacto1.Celular = "123456";
            contacto1.Telefono = "345590";
            contacto1.Correo = "jose@gmail.com";

            Console.WriteLine("nombre: " + contacto1.Nombre);
            Console.WriteLine("correo: " + contacto1.Correo);
            Console.WriteLine("direccion: " + contacto1.Direccion);

            Contacto contacto2 = new Contacto("juan", "juan@gmail");
            Console.WriteLine("nombre2:" + contacto2.Nombre);
            Console.WriteLine("correo2:" + contacto2.Correo);
            Console.WriteLine("direccion2:" + contacto2.Direccion);


            Console.Read(); 
        }
    }
}
