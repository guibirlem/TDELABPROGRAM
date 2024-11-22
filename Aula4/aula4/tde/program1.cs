class livro{
    public string titulo;

    public string autor;

    public int ano;

    public int paginas;

    public void Informacoes()
    {
        Console.WriteLine($"Autor : {autor} \n titulo : {titulo} \n ano : {ano} \n paginas : {paginas} ");
        
    }
    public bool TemMaisDe300Paginas()
    {
        return paginas> 300;
    }

}