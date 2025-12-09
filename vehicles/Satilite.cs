namespace vehicles_museum;

public class Satellite : Transport, IOrbitie
{
    public Satellite() : base("Satilite")
    {
        Engine = null;  
        Description = "It is constantly falling around the earth";
    }

    public void Orbit()
    {
        Console.WriteLine("Due to its velocity, even though ot is technically falling, it stays in orbit around the earth.");
    }

    public override void Use()
    {
        base.Use();
        Orbit();
    }
}