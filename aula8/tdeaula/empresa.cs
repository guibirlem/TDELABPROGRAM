public class Empresa 
{
    private List<Funcionario> Funcionarios;

    public Empresa ()
    {
        Funcionarios = new List<Funcionario>();

    }
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add (funcionario);
    }

    public void ListarFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            Console.WriteLine($"Nome do funcionário{funcionario.Nome} \n Salário do funcionário é {funcionario.CalcularSalario} ");
        }
    }
}