using System;

class Pelicula{

    string nombre;
    int id;
    List<string> reparto;
    string original;
    int duracion;
    float calificacion;
    string pais;


    public Pelicula()
    {

    }

    public Pelicula(BlockBusterJson data)
    {
        this.nombre = data.nombre;
        this.original = data.titulo_original;
        this.id = data.id;
        this.reparto = data.reparto_principal;
        this.duracion = data.duracion;
        this.calificacion = data.calificacion;
        this.pais = data.pais;

    }





}