using System;

public abstract class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Celular(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public abstract void FazerChamada(string numero);
    public abstract void TirarFoto();
}

public class Samsung : Celular
{
    public Samsung(string modelo) : base("Samsung", modelo) { }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Chamada feita do {Marca} {Modelo} para {numero}.");
    }

    public override void TirarFoto()
    {
        Console.WriteLine($"Foto tirada com a câmera do {Marca} {Modelo}.");
    }
}

public class Apple : Celular
{
    public Apple(string modelo) : base("Apple", modelo) { }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Chamada feita do {Marca} {Modelo} para {numero}.");
    }

    public override void TirarFoto()
    {
        Console.WriteLine($"Foto tirada com a câmera do {Marca} {Modelo}.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Celular meuSamsung = new Samsung("Galaxy S21");
        meuSamsung.FazerChamada("123456789");
        meuSamsung.TirarFoto();

        Celular meuApple = new Apple("iPhone 13");
        meuApple.FazerChamada("987654321");
        meuApple.TirarFoto();
    }
}
