namespace Modulo1;

public class ModuloIniciante
{
    public void Exercicio1000()
    {
        Console.WriteLine("Hello World!");
    }

    public void Exercicio1001()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int X = A + B;

        Console.WriteLine($"X = {X}");
    }

    public void Exercicio1002()
    {
        double n = 3.14159;
        double raio = double.Parse(Console.ReadLine());

        double area = Math.Pow(raio, 2) * n;

        Console.WriteLine($"A={area.ToString("F4")}");
    }

    public void Exercicio1003()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int SOMA = A + B;

        Console.WriteLine($"SOMA = {SOMA}");
    }

    public void Exercicio1004()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int PROD = A * B;

        Console.WriteLine($"PROD = {PROD}");
    }

    public void Exercicio1005()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double MEDIA = (A * 3.5 + B * 7.5) / 11;

        Console.WriteLine($"MEDIA = {MEDIA.ToString("F5")}");
    }

    public void Exercicio1006()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        double MEDIA = (A * 2 + B * 3 + C * 5) / 10;

        Console.WriteLine($"MEDIA = {MEDIA.ToString("F1")}");
    }

    public void Exercicio1007()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        int DIFERENCA  = (A * B - C * D);

        Console.WriteLine($"DIFERENCA = {DIFERENCA}");
    }
}