using System;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("pelicula.json");
        List<BlockBusterJson> datos = JsonSerializer.Deserialize<List<BlockBusterJson>>(json);

    }





}