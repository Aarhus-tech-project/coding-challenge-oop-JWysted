namespace vehicles_museum;

public interface IMuseum
{
    void AddTransport(Transport transport);
    void UseAll();
}

public class Museum : IMuseum
{
    private readonly HashSet<Transport> _transports = new();

    public void AddTransport(Transport transport)
    {
        _transports.Add(transport);
    }

    public void UseAll()
    {
        foreach (Transport transport in _transports)
        {
            transport.Use();
            Console.WriteLine(new string('-', 30));
        }
    }
}