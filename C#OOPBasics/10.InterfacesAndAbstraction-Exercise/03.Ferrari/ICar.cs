public interface ICar
{
    string Model { get; }
    string Brake();
    string Gas();
    string DriverName { get; }
}