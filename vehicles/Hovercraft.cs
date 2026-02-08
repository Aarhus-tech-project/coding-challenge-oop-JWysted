namespace vehicles_museum;

public class Hovercraft : Transport, ISpinie
{
    public Hovercraft() : base("Hovercraft")
    {
        Engine = new Engine();
        Description = "Vehicle that hovers over surfaces using spinning fans";
    }

    public void Spin()
    {
        Console.WriteLine(" Fans spin to create air cushion and propel forward!");
    }

    public override void Use()
    {
        base.Use();
        Spin();
    }
}