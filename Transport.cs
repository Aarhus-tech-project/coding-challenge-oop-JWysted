namespace vehicles_museum;
public class Transport(IEngine engine)
{
    public string Name{get; private set;} 
    private IEngine Engine;
    private string Description;

    public void Use()
    {
        Console.writeLine($"name: {Name}");
        Console.writeLine($"Engine running status: {Engine.IsRunning}");
        console.writeLine($"Description: {Description} ");
    }
    
}