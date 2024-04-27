using System;
using parcial2_progra.Clases;

//Instaciación
Inventario inventario = new Inventario();

inventario.ProductoAgregado += MensajeNotificacion;

Libro libro = new Libro("Orgullo y prejuicio", "Jane Austen", "R4-701"); 

libro.Almacenar();
libro.MostrarInfo();

inventario.AgregarProducto(libro);
Producto miProducto = inventario[0];
miProducto.MostrarInfo();
    
//Método para manejar el evento
static void MensajeNotificacion(string mensaje)
{
    Console.WriteLine(mensaje);
}

//Definiendo contrato
public interface InterfazAlmacenar // Define la interfaz Interfazalmacenar

{
    void Almacenar();
}

//Delegado para notificaciones
public delegate void Notificacion(string mensaje);















