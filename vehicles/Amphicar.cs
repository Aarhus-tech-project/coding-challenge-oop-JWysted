namespace vehicles_museum;

public class Amphicar : Transport, IWheelie, IFloatie
{
    public Amphicar() : base("Amphicar")
    {
        Engine = new Engine();
        Description = "This car can both drive on land and float on water.";
    }

    public void Drive()
    {
        Console.WriteLine("The wheels turn to drive the Amphicar on land.");
    }

    public void Float()
    {
        Console.WriteLine("In water, the Amphicar floats and moves using its propellers.");
    }

    public override void Use()
    {
        base.Use();
        Drive();
        Float();
    }
}