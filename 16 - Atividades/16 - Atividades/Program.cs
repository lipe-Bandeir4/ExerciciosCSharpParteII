﻿Console.Write("Digite um número: ");

if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
{
    long fatorial = 1;


    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i;
    }


    Console.WriteLine($"O fatorial de {numero} é  = {fatorial}");
}
else
{
    Console.WriteLine("insira um número inteiro positivo.");
}

Console.WriteLine("Digite qualquer tecla para encerrar!");
Console.ReadKey();