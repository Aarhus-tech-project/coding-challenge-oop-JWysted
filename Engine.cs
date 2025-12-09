
namespace vehicles_museum;
public interface IEngine
{
    bool IsRunning{get;}
    void Start();
    void Stop();
}

public class Engine
{
    public bool IsRunning{get; private set;} = true;

    private void Start(){
        IsRunning = true;
    }
    private void Stop(){
        IsRunning = false;

    }
}  