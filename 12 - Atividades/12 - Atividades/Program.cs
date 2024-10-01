int num1;

Console.WriteLine("Informe sua nota de 0 a 100: ");
int.TryParse(Console.ReadLine(), out num1);

if (num1 >= 90 && num1 <= 100)
    Console.WriteLine($"\n A nota foi de {num1} então é um A :) ");

else if (num1 >= 80 && num1 <= 89)
    Console.WriteLine($"\n A nota foi de {num1} então é um B !!! ");

else if (num1 >= 70 && num1 <= 79)
    Console.WriteLine($"\n A nota foi de {num1} então é um C !! ");

else if (num1 >= 60 && num1 <= 69)
    Console.WriteLine($"\n A nota foi de {num1} então é um D ! ");

else
    Console.WriteLine($"\n A nota foi de {num1} então é um F :( ");

Console.ReadKey();