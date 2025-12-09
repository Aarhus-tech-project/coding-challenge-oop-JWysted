namespace vehicles_museum;

public interface IEngine
{
    bool IsRunning { get; }
    void Start();
    void Stop();
}

public class Engine : IEngine
{
    public bool IsRunning { get; private set; } = false;

    public void Start()
    {
        IsRunning = true;
    }

    public void Stop()
    {
        IsRunning = false;
    }
}