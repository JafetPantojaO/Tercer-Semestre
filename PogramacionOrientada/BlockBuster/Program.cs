using System;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // 1. Leer el archivo JSON (nombre correcto: peliculas.json)
        string rutaArchivo = "peliculas.json";
        if (!File.Exists(rutaArchivo))
        {
            Console.WriteLine($"No se encontró el archivo {rutaArchivo}");
            return;
        }

        string json = File.ReadAllText(rutaArchivo);
        var respuesta = JsonSerializer.Deserialize<BlockBusterRespuestaJson>(json);
        List<BlockBusterJson> datos = respuesta?.peliculas ?? new List<BlockBusterJson>();

        if (datos.Count == 0)
        {
            Console.WriteLine("No se encontraron películas en el JSON.");
            return;
        }

        // 2. Crear una Película usando el constructor desde JSON
        Pelicula peli1 = new Pelicula(datos[0]);
        peli1.MostrarInformacion();

        Console.WriteLine();

        // 3. Crear Copias físicas de esa película en Blockbuster
        Copia copia1 = new Copia(1, peli1, "DVD");
        Copia copia2 = new Copia(2, peli1, "VHS");

        copia1.MostrarInformacion();
        copia2.MostrarInformacion();

        Console.WriteLine();

        // 4. Probar renta y devolución de una copia
        copia1.Prestar();
        copia1.Prestar(); // Intentar rentar de nuevo para verificar validación
        copia1.Devolver();
    }
}