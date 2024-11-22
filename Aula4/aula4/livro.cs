class livro{
    public string titulo;

    public string autor;

    public int ano;

    public int paginas;

    public void Informacoes()
    {
        Console.WriteLine($"Autor : {autor} \n Autor : {titulo} \n Autor : {ano} \n Autor : {paginas} ");
        
    }
    public bool TemMaisDe300Paginas()
    {
        return paginas > 300;
    }

}