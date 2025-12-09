namespace vehicles_museum;

public class Sailboat : Transport, IFloatie
{
    public Sailboat() : base("Sailboat")
    {
        Engine = null; 
        Description = "Wind-powered floating vessel";
    }

    public void Float()
    {
        Console.WriteLine("Sailboat bobs on the waves!");
    }

    public override void Use()
    {
        base.Use();
        Console.WriteLine("Wind fills the sails!");
        Float();
    }
}