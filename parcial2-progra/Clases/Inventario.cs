using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcial2_progra.Clases;

namespace parcial2_progra.Clases
{
    //Clase Inventario 
    public class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        //Evento
        public event Notificacion? ProductoAgregado; //para permitir valor null con ?

        // Indexador
        public Producto this[int i]
        {
            get { return productos[i]; }
            set { productos[i] = value; }
        }

        //Para modificar la lista de productos
        public void AgregarProducto(Producto producto)
        {
            // Eventos: Notifica a los componentes del programa que un producto ha sido agregado.
            productos.Add(producto);
            ProductoAgregado?.Invoke($"LIBRO = {producto.Nombre} ha sido agregado al inventario.");
        }

    }


}
