namespace vehicles_museum;

public interface IMuseum
{
    void UseAll();
}

public class Museum : IMuseum
{
    public HashSet<Transport>? transports;


    public void UseAll()
    {
        if (transports != null)
        {
            foreach (Transport transport in transports)
            {
                transport.Use();
            }
        }
    }
}