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
}