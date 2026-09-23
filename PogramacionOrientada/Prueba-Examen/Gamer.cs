using System;
public class Gamer
{
    public string Nickname;

    private double _saldo;

    public Membresia MiMembresia;

    public double Saldo
    {
        get { return _saldo; }
        set 
        { 
            if (value < 0)
            {
            Console.WriteLine("Saldo no posible");
            }
            else
            {
            _saldo = value;
            }
        }
    }

    public Gamer(string nickname_)
    {
        this.Nickname = nickname_;
        Saldo = 0;
        MiMembresia = new Membresia();
        
        

    }

    public Gamer(string nickname, double saldoincial)
    {
        this.Nickname = nickname;
        Saldo = saldoinical;
        MiMembresia = new Membresia();

    }

}