namespace vehicles_museum;
public class Program
{
    public static void Main(string[] args)
    {
        Museum museum = new();

        museum.AddTransport(new Tank());
        museum.AddTransport(new Airbus());
        museum.AddTransport(new Hovercraft());
        museum.AddTransport(new V2Rocket());
        museum.AddTransport(new Amphicar());
        museum.AddTransport(new Sailboat());
        museum.AddTransport(new Helicopter());
        museum.AddTransport(new Satellite());

        museum.UseAll();
    }
}