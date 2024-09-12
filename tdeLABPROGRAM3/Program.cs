/*int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade!");
}
else
{
    Console.WriteLine("Você é menor de idade");
}
*/

//IF NORMAL
/*int nota = 85;
if (nota >= 90)
{
    Console.WriteLine("Aprovado com bom");
}

else if (nota >= 60)
{
    Console.WriteLine("Aprovado");
}
else {
    Console.WriteLine("Reprovado");
}
*/


//SwitchCase
/*string cor = "vermelho";
switch (cor)
{
    case "vermelho":
    Console.WriteLine("A cor é vermelho");
    break;
    case "azul":
    Console.WriteLine("A cor é azul");
    break;
    default:
    Console.WriteLine("Cor não reconhecida");
    break;
}
*/

/*for (int i = 0; i  < 5; i++)
{
    Console.WriteLine($"indice {i}");
}
*/

//while
/*
int contador = 0;
while (contador < 5 )
{
    Console.WriteLine($"Contador:{contador}");
    contador++;
} 
*/
 // DO WHILE
/*int contador = 0;
do 
{
    Console.WriteLine($"Contador:{contador}");
    contador++;


} while (contador < 5);
*/
/*
for (int = 0; i < 10; i++)
{

    if (int ==5)
    {
        break;
    }
    Console.WriteLine(i);
}
*/


//DOJO

double totalPedido = 0;

bool pedidoAberto = true;
while (pedidoAberto)
{
    Console.WriteLine("Bem vindos ao maior programa \n SISTEMA DE GERENCIAMENTO DE PEDIDOS DA ULBRA TORRES ADS QUINTA FEIRA ");
    Console.WriteLine("1 - adicionar item ao pedido ");
    Console.WriteLine("2 - Exibir Total do pedido");
    Console.WriteLine("3 - Finalizar pedido e sair");
    
    string opcao = Console.ReadLine ();

    switch(opcao)
    {
        case "1":
        Console.WriteLine("escolha um item do cardápio \n 1- pizza (R$30,00) \n 2- hamburguer (R$15,00) \n 3- Refrigerante (R$ 5,00)");
        string escolha = Console.ReadLine();
    

        if (escolha == "1")
        {
            Console.WriteLine("Voce adicionou uma pizza!");
            totalPedido += 30 ;

        }
        else if (escolha == "2")
        {
            Console.WriteLine("Voce adicionou um hamburguer!");
            totalPedido += 15;
        }
        else if (escolha == "3")
        {
            Console.WriteLine("Voce adicionou um refrigerante");
            totalPedido += 5;
        }
        else 
        {
         Console.WriteLine("ESCOLHA UMA OPÇÃO VALIDA 1 2 OU 3");
        }
        break;

        case "2":
        Console.WriteLine ($" TOTAL DO PEDIDO É:{totalPedido}");
        break;

        case "3":
        Console.WriteLine("Volte sempre!");
        pedidoAberto=false;
        break;

        default:
        Console.WriteLine("Digite uma opção válida");
        break;}
}







