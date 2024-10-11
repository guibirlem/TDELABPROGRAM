// array ramazena um numero predefinido de elementos predefinido de elemtnos do mesmo tipo 
using System.Collections;

Console.WriteLine("cu");

int [] numeros = new int [3];
numeros[0] = 10;
numeros[1] = 70;
numeros[2] = 29;

foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}
//listas armazena elemntos do mesmo tipo e aumentam ou 
//diminuim o tamanho dinamicamente 

List <string> frutas = new List<string>();
frutas.Add("maça");
frutas.Add("Banana");
frutas.Add("limao");

frutas.Remove("maça");

foreach(var fruta in frutas)
{
    Console.WriteLine(fruta);
}

//arraylist é uma coleção que tem tamanho dinamico 
// e que armazena elemtnso de qualquer tipo 

ArrayList itens = new  ArrayList();
itens.Add("maça");
itens.Add(10);
itens.Add(20.5);

foreach(var item in itens)
{
    Console.WriteLine(item);
}
