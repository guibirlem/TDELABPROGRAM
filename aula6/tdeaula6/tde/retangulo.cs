public class Retangulo
{
    public double altura ;

    public double largura;





    public Retangulo ()
    {
    altura= 0;
    largura = 0 ;

    }

    public Retangulo ( double valor)

    {
        altura = valor;
        largura = valor;
    }


    public Retangulo (double altura, double Largura)
    {
        this.altura = altura;
        this.largura= Largura;

    }

    public double CalcularArea ()
    {
    return largura * altura;
    }
      public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }   
    public void Redimensionar()
    {
    }

    public void Redimensionar(double fator)
    {
        largura *= fator;
        altura *= fator;
    }

    public void Redimensionar(double Largura, double Altura)
    {
        this.largura = Largura;
        this.altura = Altura;
    }

    
}