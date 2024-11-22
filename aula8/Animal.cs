public class Animal 
{
    public string nome;
    public int idade;
    public virtual void EmitirSom()
{
    Console.WriteLine($"{nome}está emitindo um som");
}
}