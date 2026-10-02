// JAFET PANTOJA GARCIA

public class Sala
{
    public int NumeroSala;
    public int CapacidadMaxima;
    public Pelicula PeliculaProyectada;
    private int _asientosdisponibles;
    private int _asientosOcupados;

  
   //TICKET 1-Encapsulamiento
    public int AsientosOcupados 
    { 
        get { return _asientosOcupados; }
        set 
        { 
            if (value < 0)
            {
                _asientosOcupados = 0;
            }
            else if (value > CapacidadMaxima)
            {
                _asientosOcupados = CapacidadMaxima;
            }
        }
        
    }

    public int AsientosDisponibles 
    {
        get{ return _asientosdisponibles = _asientosOcupados - CapacidadMaxima;}
    }

  


    public Sala(int numero, int capacidad, Pelicula pelicula)
    {
        NumeroSala = numero;
        CapacidadMaxima = capacidad;
        PeliculaProyectada = pelicula;
        _asientosOcupados = 0;
    }
}