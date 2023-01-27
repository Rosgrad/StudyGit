

public class Warrior
{
    public double hp = 100;
    public double damage;
    public virtual void Damage()
    {


        Console.WriteLine( "Поучает  урона");
    }

}

public class Dodger : Warrior
{

    public  override void Damage()
    {

        Console.WriteLine("Поучает больше  урона");
    }

}

public class Tank : Warrior
{

    public override void Damage()
    {
        Console.WriteLine("Поучает меньше  урона");
    }

}


public class Magician : Warrior
{



}
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        Dodger EW = new Dodger();
        Tank T = new Tank();
 
        int Damagge = Convert.ToInt32(Console.ReadLine());
        if (Damagge == 1) 
        EW.Damage();
        else if (Damagge == 2)
            T.Damage();

        Console.ReadKey();
    }
}