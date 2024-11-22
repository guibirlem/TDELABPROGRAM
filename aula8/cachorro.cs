public class Cachorro : Animal 
{
    public override void EmitirSom()
    {
        Console.WriteLine($"{nome}está latindo");
    }
}