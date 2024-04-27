using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcial2_progra.Clases;

//Clase hijo de Producto
namespace parcial2_progra.Clases
{

    public class Libro : Producto
    {
        private string autor;
        private string codidentificador;


        public Libro(string nombre, string autor, string codidentificador)
        {
            this.Nombre = nombre;
            this.autor = autor;
            this.codidentificador = codidentificador;
        }


        public override string Nombre { get; } 


        public string Autor 
        {
            get { return autor; }
            private set { autor = value; }
        }

        public string CodIdentificador
        {
            get { return codidentificador; }
            private set { codidentificador = value; }
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}\nAutor: {Autor}\nCódigo del libro: {CodIdentificador}\n");
        }

        public override void Almacenar()
        {
            Console.WriteLine($"LIBRO = {Nombre} ha sido almacenado.");
        }

    }


}
