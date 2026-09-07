using System;
using System.Collections.Generic;
using System.Text.Json;

class Program 
{
    static void Main()
    {
        string json = File.ReadAllText("pokemon.json");
        List<PokemonJson> datos = JsonSerializer.Deserialize<List<PokemonJson>>(json);
                
        Pokemon Bulbasaur = new Pokemon();
        Bulbasaur.nombre = datos[0].Name;
        Bulbasaur.tipos = datos[0].Type;
        Bulbasaur.vida = datos[0].Hp ;
        Bulbasaur.ataque = datos[0].Attack;
        Bulbasaur.nivel = 1; 

        Bulbasaur.MostrarInformacion();
    }
    
}