namespace MyProject;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double largura, altura, area, preco, precoMetroQuadrado;

        Console.WriteLine("Digite a largura do terreno: ");
        altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a altura do terreno: ");
        largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Valor do metro quadrado do terreno:");
        precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        area = largura * altura;
        preco = area * precoMetroQuadrado;

        Console.WriteLine("A área do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("O preço do terreno é: " + preco.ToString("F2", CultureInfo.InvariantCulture));


        Console.ReadKey();
    }
}


