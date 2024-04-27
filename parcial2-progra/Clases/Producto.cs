using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcial2_progra.Clases;

//Clase padre
namespace parcial2_progra.Clases
{
    //Clase abstracta de Producto, heredando de InterfazAlmacenar
    public abstract class Producto : InterfazAlmacenar //Producto herera clase de InterfazAlmacenar
    {
        public abstract string Nombre { get; }

        public abstract void MostrarInfo();

        public abstract void Almacenar();
    }


}
