namespace vehicles_museum;

public class Helicopter : Transport, ISpinie
{
    public Helicopter() : base("Helicopter")
    {
        Engine = new Engine();
        Description = "Rotary-wing aircraft that uses spinning blades for lift and thrust";
    }

    public void Spin()
    {
        Console.WriteLine("Rotors spin for lift and maneuvering!");
    }

    public override void Use()
    {
        base.Use();
        Spin();
    }
}