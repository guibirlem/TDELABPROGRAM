public abstract class FormaGeometrica 
{
    public void Desenhar()
    {
        Console.WriteLine("desenhando forma");
    }
    
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
    
}