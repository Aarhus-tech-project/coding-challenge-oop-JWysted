
namespace vehicles_museum;

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