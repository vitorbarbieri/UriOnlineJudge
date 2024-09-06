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

        int DIFERENCA = (A * B - C * D);

        Console.WriteLine($"DIFERENCA = {DIFERENCA}");
    }

    public void Exercicio1008()
    {
        int id = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        double valor = double.Parse(Console.ReadLine());

        double salario = horas * valor;

        Console.WriteLine($"NUMBER = {id}");
        Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
    }

    public void Exercicio1009()
    {
        string nome = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());

        double total = salario + vendas * 0.15;

        Console.WriteLine($"TOTAL = R$ {total.ToString("F2")}");
    }

    public void Exercicio1010()
    {
        double valor = 0;
        for (int i = 0; i < 2; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int codigo = int.Parse(entrada[0]);
            int quantidade = int.Parse(entrada[1]);
            double valorUnitario = double.Parse(entrada[2]);

            valor += quantidade * valorUnitario;
        }

        Console.WriteLine($"VALOR A PAGAR: R$ {valor.ToString("F2")}");
    }

    public void Exercicio1011()
    {
        double raio = double.Parse(Console.ReadLine());

        double volume = (double)4 / 3 * 3.14159 * Math.Pow(raio, 3);

        Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
    }

    public void Exercicio1012()
    {
        string[] entrada = Console.ReadLine().Split(' ');
        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);

        double triangulo = (a * c) / 2;
        double circulo = 3.14159 * Math.Pow(c, 2);
        double trapezio = ((a + b) * c) / 2;
        double quadrado = Math.Pow(b, 2);
        double retangulo = a * b;

        Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
        Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
        Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
        Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
    }

    public void Exercicio1013()
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int n1 = int.Parse(entrada[0]);
        int n2 = int.Parse(entrada[1]);
        int n3 = int.Parse(entrada[2]);

        if (n1 > n2 && n1 > n3)
        {
            Console.WriteLine($"{n1} eh o maior");
        }
        else if (n2 > n3)
        {
            Console.WriteLine($"{n2} eh o maior");
        }
        else
        {
            Console.WriteLine($"{n3} eh o maior");
        }
    }

    public void Exercicio1014()
    {
        int distancia = int.Parse(Console.ReadLine());
        double valorLitro = double.Parse(Console.ReadLine());

        double consumo = distancia / valorLitro;

        Console.WriteLine($"{consumo.ToString("F3")} km/l");
    }

    public void Exercicio1015()
    {
        string[] valoresX = Console.ReadLine().Split(' ');
        double x1 = double.Parse(valoresX[0]);
        double y1 = double.Parse(valoresX[1]);
        string[] valoresY = Console.ReadLine().Split(' ');
        double x2 = double.Parse(valoresY[0]);
        double y2 = double.Parse(valoresY[1]);

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine(distancia.ToString("F4"));
    }

    public void Exercicio1016()
    {
        int distancia = int.Parse(Console.ReadLine());

        int tempo = distancia * 2;

        Console.WriteLine($"{tempo} minutos");
    }

    public void Exercicio1017()
    {
        int tempo = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());

        double distancia = (double) velocidade * tempo;
        double litros = distancia / 12;

        Console.WriteLine(litros.ToString("F3"));
    }
}