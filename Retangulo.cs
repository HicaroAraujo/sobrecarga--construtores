using System.Security.Cryptography.X509Certificates;

public class Retangulo
{
    public double Largura  {get; set;} 
    public double Altura {get; set;} 

    public Retangulo()
    {
        Altura = 0;
        Largura = 0;

        
    }

    public Retangulo(double altura)
    {
       Altura = altura;
       Largura = altura;
    }

    public Retangulo(double altura, double largura)
    {
       Largura = altura;
       Altura= largura;
    }

    public double CalcularArea()
    {

        double area = Largura * Altura;
        return area;
    }

     public double CalcularPerimetro()
    {

        double perimetro = 2 * (Largura + Altura);
        return perimetro;
    }


    public void Redimencionar()
    {
    }

     public void Redimencionar(double fator)
    {
        // Largura = Largura * fator
        Largura *= fator;
        // Altura = Altura * fator
        Altura *=  fator;
    }

     public void Redimencionar(double novaLargura, double novaAltura)
    {
        Largura = novaLargura;
        Altura = novaAltura;

    }






}