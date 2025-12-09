namespace vehicles_museum;
public class Transport()
{
    public string? Name {get; private set;} 
    protected IEngine? Engine;
    protected string? Description;

    public void Use()
    {
        Console.WriteLine($"name: {Name}");
        Console.WriteLine($"Engine running status: {Engine?.IsRunning}");
        Console.WriteLine($"Description: {Description} ");
    }
    
}