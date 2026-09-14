using System;
using System.Collections.Generic;

public class Pelicula
{
    // Atributos públicos
    public int id;
    public string nombre = "";
    public string original = "";
    public List<string> reparto = new List<string>();
    public int duracion;
    public float calificacion;
    public string pais = "";

    // 1. Constructor por defecto (vacío)
    public Pelicula()
    {
    }

    // 2. Constructor con parámetros
    public Pelicula(int id, string nombre, string original, List<string> reparto, int duracion, float calificacion, string pais)
    {
        this.id = id;
        this.nombre = nombre;
        this.original = original;
        this.reparto = reparto ?? new List<string>();
        this.duracion = duracion;
        this.calificacion = calificacion;
        this.pais = pais;
    }

    // 3. Constructor desde objeto JSON
    public Pelicula(BlockBusterJson data)
    {
        this.id = data.id;
        this.nombre = data.nombre;
        this.original = data.original;       
        this.reparto = data.reparto ?? new List<string>(); 
        this.duracion = data.duracion;
        this.calificacion = data.calificacion;
        this.pais = data.pais;
    }

    // Método para imprimir la ficha de la película en consola
    public void MostrarInformacion()
    {
        Console.WriteLine($"=== Película: {nombre} (ID: {id}) ===");
        Console.WriteLine($"Título original: {original}");
        Console.WriteLine($"Duración: {duracion} min");
        Console.WriteLine($"Calificación: {calificacion}/10");
        Console.WriteLine($"País: {pais}");
        Console.WriteLine($"Reparto: {(reparto != null && reparto.Count > 0 ? string.Join(", ", reparto) : "Sin reparto")}");
        Console.WriteLine("========================================");
    }
}