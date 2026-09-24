using System;
public class Gamer
{
    public string Nickname;

    private double _saldo;

//3.Composicion 
    public Membresia MiMembresia;


//1.Encapsulamiento
    public double Saldo
    {
        get { return _saldo; }
        set 
        { 
            if (value < 0)
            {
            _saldo = 0;
            }
            else
            {
            _saldo = value;
            }
        }
    }

//2.Constructores y sobrecarga
    public Gamer(string nickname_)
    {
        this.Nickname = nickname_;
        Saldo = 0;
        //3.Composicion - Parte de" --- Depende de -- Si muere el padre, muere el hijo 
        MiMembresia = new Membresia();
        
        

    }

    public Gamer(string nickname, double saldoincial)
    {
        this.Nickname = nickname;
        Saldo = saldoinical;
        MiMembresia = new Membresia();

    }

}