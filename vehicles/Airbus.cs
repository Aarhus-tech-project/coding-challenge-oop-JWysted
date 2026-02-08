namespace vehicles_museum;

public class Airbus : Transport, IWingie, IThrustie
{
    public Airbus() : base("Airbus")
    {
        Engine = new Engine();
        Description = "Large commercial passenger aircraft";
    }

    public void Glide()
    {
        Console.WriteLine("The wings allow the aircraft to glide through the air!");
    }

    public void Thrust()
    {
        Console.WriteLine("Jet engines provide thrust!");
    }

    public override void Use()
    {
        base.Use();
        Thrust();
        Glide();
    }
}