//interpolação
Console.WriteLine("Informe o primeiro numero");
double num1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Primeiro numero digitado foi {num1}");
Console.WriteLine("Informe o primeiro numero");
double num2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Segundo numero digitado foi {num2}");
Console.WriteLine($"A soma dos numeros {num1}+{num2} \n foi de");
Console.WriteLine($"{num1 + num2}");
Console.WriteLine($"A subtração dos numeros {num1}-{num2} \n foi de");
Console.WriteLine($"{num1 - num2}");
Console.WriteLine($"A multiplicação dos numeros {num1}*{num2} \n foi de");
Console.WriteLine($"{num1 * num2}");
Console.WriteLine($"A divisão dos numeros {num1}/{num2} \n foi de");
Console.WriteLine($"{num1 / num2}");


//concatenação

Console.WriteLine("O primeiro numero digitado foi:" + num1 + "!");
Console.WriteLine("O segundo numero digitado foi:" + num2 + "!");
Console.WriteLine("A soma dos numeros foi de:" + num1 + num2 +"!" );
Console.WriteLine("A subtração dos numeros foi de:" + (num1 - num2) +"!" );
Console.WriteLine("A multiplicação dos numeros foi de:" + (num1 * num2) +"!" );
Console.WriteLine("A divisão dos numeros foi de:" + (num1 / num2) +"!" );

//placeholder 
Console.WriteLine("O primeiro numero digitado foi :{0}!",num1);
Console.WriteLine("O segundo  numero digitado foi :{0}!",num2);
Console.WriteLine("A soma dos numeros deu :{0}!",num1 + num2);
Console.WriteLine("A subtração dos numeros deu :{0}!",num1 - num2);
Console.WriteLine("A multiplicação dos numeros deu :{0}!",num1 * num2);
Console.WriteLine("A divisão dos numeros deu :{0}!",num1 / num2);


Console.WriteLine("Se deu certo isso vai aparecer e nois");




