using System.Globalization;

try
{
    Console.Write("Digite seu Primeiro número: ");
    double num1;
    //! é = diferente
    {
        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out num1))
            Console.WriteLine("Digite um número válido: ");
        Console.Write("Digite o primeiro número");
    }

    {
        Console.Write("\nDigite o seu Segundo número: ");
        double num2;
        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out num2))
            Console.WriteLine("Digite um número válido: ");
        Console.Write("Digite o segundo número");

        if (num2 == 0)
        {
            throw new DivideByZeroException();
        }

        double resultado = num1 + num2;
        Console.WriteLine($"\nO resultado da soma é: {resultado}");
    }
}
catch (DivideByZeroException)

{
    Console.WriteLine("\nErro: Não foi possível somar esses números");
}
//catch (FormatException)
//{
//    Console.WriteLine("\nPorfavor digite números válidos");
//}

Console.ReadKey();
