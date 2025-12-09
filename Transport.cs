namespace vehicles_museum;

public abstract class Transport(string name)
{
    public string Name { get; protected set; } = name;
    protected IEngine? Engine { get; set; }
    protected string? Description { get; set; }

    public virtual void Use()
    {
        Console.WriteLine($"{Name}");
        Console.WriteLine($"Description: {Description}");
        
        if (Engine != null)
        {
            Engine.Start();
            Console.WriteLine($"Engine running: {Engine.IsRunning}");
        }
        else
        {
            Console.WriteLine("No engine - uses alternative propulsion");
        }
    }
}