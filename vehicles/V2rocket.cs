namespace vehicles_museum;

public class V2Rocket : Transport, IThrustie
{
    public V2Rocket() : base("V2 Rocket")
    {
        Engine = new Engine();
        Description = "World's first long-range ballistic missile";
    }

    public void Thrust()
    {
        Console.WriteLine("Rocket engines provide thrust");
    }

    public override void Use()
    {
        base.Use();
        Thrust();
    }
}