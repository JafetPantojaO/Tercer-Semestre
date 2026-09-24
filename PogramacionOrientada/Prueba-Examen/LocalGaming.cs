using System.Collections.Generic;
using System;

public class LocalGaming
{
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
}