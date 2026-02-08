namespace vehicles_museum;

public class Tank : Transport, IWheelie
{
    public Tank() : base("Tank")
    {
        Engine = new Engine();
        Description = "Armored military vehicle with belts";
    }

    public void Drive()
    {
        Console.WriteLine("The wheels makes the belts move the tank forward.");
    }

    public override void Use()
    {
        base.Use();
        Drive();
    }
}