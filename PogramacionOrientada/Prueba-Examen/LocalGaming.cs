using System.Collections.Generic;
using System;

public class LocalGaming
{

    //Numero 4. Agregacion "Tiene un" --  Independientes (el hijo sobrevive sin el padre)
    public string NombreLocal;
    public List<Equipo> inventario { get; set; }


    public LocalGaming(string nombre)
    {
        NombreLocal = nombre;
        inventario = new List<Equipo>();
    }
 

    public void AgregarEquipo(Equipo nuevo)
    {
        inventario.Add(nuevo);

    }

    // 5. Asociacion --  Independientes (relación débil) -- Ningún objeto es dueño del otro.
    public void RentarEquipo(Equipo equipo, Gamer Usuario,  double horas)
    {
        double TotalCosto = horas * equipo.PrecioPorHora;
        Usuario.Saldo = Usuario.Saldo - totalCosto;
        Console.WriteLine($"El usuario {Usuario} rento el {equipo} por {horas} hora/s");


    }
}