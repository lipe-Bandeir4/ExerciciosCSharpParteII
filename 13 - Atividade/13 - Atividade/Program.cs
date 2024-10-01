int numero;
do
{
    Console.Write("Adivinhe o número secreto (somente números inteiros) ");
    numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"Você digitou o número: {numero}");
} while (numero != 7);

Console.WriteLine("Você acertou o número secreto");
Console.ReadKey();