livro livro1 = new livro();
livro1.titulo = "SPQR";
livro1.autor = "Mary Beard";
livro1.ano =2015;
livro1.paginas = 560;

livro1.Informacoes();

livro livro2 = new livro();
livro1. titulo = "ARTE DA Guerra";
livro1.autor = "Sunt Tzu";
livro1.ano =400;
livro1.paginas = 128;

livro2.Informacoes();
livro2.TemMaisDe300Paginas();

if(livro2.TemMaisDe300Paginas())
{
    Console.WriteLine("O livro tem mais de 300 paginas")
}
else
{
    Console.WriteLine("Tem menos de 300 paginas")
}


