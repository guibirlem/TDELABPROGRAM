public class Gato : Animal 
{
    public override void EmitirSom()
    {
        Console.WriteLine($"{nome}está miando");
    }
}