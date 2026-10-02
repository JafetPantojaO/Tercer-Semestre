// JAFET PANTOJA GARCIA

public class Espectador
{
    public string Nombre;
    public int Edad;
    public TarjetaClub MiTarjeta;

    public Espectador(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        MiTarjeta = new TarjetaClub();

    }

    public Espectador(string nombre)
    {
        this.Nombre = nombre;
        this.Edad = 18;
        MiTarjeta = new TarjetaClub();

        
    }
  

}