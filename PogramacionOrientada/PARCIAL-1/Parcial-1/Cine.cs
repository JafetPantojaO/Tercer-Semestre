// JAFET PANTOJA GARCIA
using System.Collections.Generic;
using System;
public class Cine
{
    public string NombreCine;
    public List<Sala> SalasHabilitadas; 
    public Cine(string nombre)
    {
        NombreCine = nombre;
        SalasHabilitadas = new List<Sala>();
      
    }

   public void AgregarSala(Sala activa)
   {
    SalasHabilitadas.Add(activa);
   }

  
    public void VenderBoleto(Espectador cliente, Sala salaCine)
    {
        if (cliente.Edad >= 18)
        {
            Console.WriteLine("\nHa sido exitosa la venta.");
        }
        else
        {
            Console.WriteLine($"\nEl usuario {cliente} no tiene la suficiente edad.");

        }

        if ( salaCine.AsientosDisponibles < 0)
        {
            Console.WriteLine("\nLa sala esta llena.");


        }

        salaCine.AsientosOcupados =+ 1;
 
        Console.WriteLine($"\nProcesando venta para {cliente.Nombre} - Película: {salaCine.PeliculaProyectada.Titulo}...");
        
     }
}