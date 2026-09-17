using System;

class Pokemon
{

    
    public string nombre;
    public List<string> tipos;
    private int nivel_;
    private int vida_;
    public int ataque;
    
    public int vida{
        get { return vida; }
        set { if( value < 0)
                 vida_ = 0;}
    }

    public int nivel {
        get { return nivel; }
        set { if( value > 100 && value < 1 )
                nivel_ =  }
    }

    public Pokemon(){
        
    }

    public Pokemon(string nombre_, int vida_, int ataque_)
    {
        this.nombre = nombre_;
        this.tipos = new List<string> { "Normal" };
        this.vida_ = vida;
        this.ataque_ = ataque;
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

