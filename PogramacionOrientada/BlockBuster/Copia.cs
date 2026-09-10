using System;                                                                                                                                                  
                                                                                                                                                                   
public class Copia                                                                                                                                             
    {                                                                                                                                                              
        // Atributos de una copia física en Blockbuster                                                                                                            
        public int idCopia;             // Identificador de la copia física (ej. Copia 1, Copia 2)                                                                 
        public Pelicula pelicula;       // Referencia a la Película (Composición)                                                                                  
        public bool disponible;         // true = disponible en tienda, false = rentada                                                                            
        public string formato;          // Formato físico (ej. "DVD", "VHS", "Blu-ray")                                                                            
                                                                                                                                                                   
        // Constructor vacio por defecto                                                                                                                        
public Copia()                                                                                                                                             
    {                                                                                                                                                          
        this.idCopia = 0;                                                                                                                                      
        this.pelicula = new Pelicula();                                                                                                                        
        this.disponible = true;                                                                                                                                
        this.formato = "DVD";                                                                                                                                  
    }                                                                                                                                                          
                                                                                                                                                                   
        //  Constructor parametros principal                                                                                                                  
public Copia(int idCopia, Pelicula pelicula, string formato = "DVD", bool disponible = true)                                                               
        {                                                                                                                                                          
            this.idCopia = idCopia;                                                                                                                                
            this.pelicula = pelicula;                                                                                                                              
            this.formato = formato;                                                                                                                                
            this.disponible = disponible;                                                                                                                          
        }                                                                                                                                                          
                                                                                                                                                                   
        // Constructor sobrecargado desde datos JSON                                                                                                
public Copia(int idCopia, BlockBusterJson data, string formato = "DVD", bool disponible = true)                                                            
    {                                                                                                                                                          
        this.idCopia = idCopia;                                                                                                                                
        this.pelicula = new Pelicula(data);                                                                                                                    
        this.formato = formato;                                                                                                                                
        this.disponible = disponible;                                                                                                                          
        }                                                                                                                                                          
                                                                                                                                                                   
      // Método para mostrar la información de la copia y su película                                                                                            
public void MostrarInformacion()                                                                                                                           
    {
        Console.WriteLine($"=== Copia #{idCopia} [{formato}] ===");
        Console.WriteLine($"Estado: {(disponible ? "Disponible para renta" : "Rentada")}");
        if (pelicula != null)
        {
            Console.WriteLine($"Película: {pelicula.nombre} (ID: {pelicula.id})");
            Console.WriteLine($"Título original: {pelicula.original}");
            Console.WriteLine($"Duración: {pelicula.duracion} min");
            Console.WriteLine($"Calificación: {pelicula.calificacion}/10");
        }
    Console.WriteLine("================================");
    }
}
  