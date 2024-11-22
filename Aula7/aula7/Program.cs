Cachorro cachorro = new Cachorro();
cachorro.nome = "Bilu";
cachorro.SetIdade(15);
cachorro.Comer();
cachorro.Latir();

Console.WriteLine("idade do cachorro:" + cachorro.Getidade());

Gato gato= new Gato();
gato.nome = "Frajola";
gato.SetIdade(15); 
gato.numVidas = 7;
gato.Comer();
gato.Miar();
