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
}