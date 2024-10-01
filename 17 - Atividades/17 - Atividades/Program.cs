int num;

Console.Write("Digite um numero inteiro positivo: ");

while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
{
    Console.WriteLine("Por favor, insira um numero inteiro positivo: ");
    Console.Write("Digite um numero inteiro positivo");
}

Console.WriteLine($"Numeros impares ate {num} são: ");
for (int i = 1; i <= num; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Pressione uma tecla para encerrar o programa");
Console.ReadKey();
