using System;

class Pokemon
{

    
    public string nombre;
    public List<string> tipos;
    public int nivel;
    public int vida;
    public int ataque;

    public Pokemon(){
        
    }

    public Pokemon(string nombre_, int vida_, int ataque_)
    {
        this.nombre = nombre_;
        this.tipos = new List<string> { "Normal" };
        this.vida = vida_;
        this.ataque = ataque_;
        this.nivel = 10;

    }

    public Pokemon(PokemonJson data)
    {
        this.nombre = data.Name;
        this.tipos = data.Type;
        this.vida = data.Hp;
        this.ataque = data.Attack;
        this.nivel = 1;

    }

    public void Atacar()
    {

    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"=== Pokemon {nombre} (Nivel{nivel}) === ");
        Console.WriteLine($"Tipos: {string.Join(", ",  tipos)}");
        Console.WriteLine($"Vida (HP): {vida}");
        Console.WriteLine($"Ataque: {ataque}");
        Console.WriteLine("===========================");

    }
}

