string[] diasSemana = new string[] {


    "Segunda",
    "Terça",
    "Quarta ",
    "Quinta",
    "Sexta",
    "Sabado",
    "Domingo" };

string[] tarefa = new string[7];

for (int i = 0; i < diasSemana.Length; i++)
{
    Console.Write($"Digite a tarefa para {diasSemana[i]}: ");
    tarefa[i] = Console.ReadLine();
}

Console.WriteLine("\nTarefas da semana:");
for (int i = 0; i < diasSemana.Length; i++)
{

    Console.WriteLine($"{diasSemana[i]}: {tarefa[i]}");

}

Console.ReadKey();
