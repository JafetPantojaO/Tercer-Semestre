using System.Collections.Generic;
using System;

public class LocalGaming
{

    //Numero 4
    public string NombreLocal;
    public List<Equipo> inventario { get; set; }


    public LocalGaming(string nombre)
    {
        NombreLocal = nombre;
        inventario = New List<Equipo>();
    }
 

    public void AgregarEquipo(Equipo nuevo)
    {
        inventario.Add(nuevo);

    }

    public void RentarEquipo(Equipo equipo, Gamer Usuario,  double horas)
    {
        TotalTiempo = horas * 10;
        Usuario.Saldo - TotalTiempo;
        Console.WriteLine("El usuario {Usuario} rento el {equipo} por {horas} hora/s")


    }
}