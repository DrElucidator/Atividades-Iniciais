Console.WriteLine("Calculadora de média de notas");
Console.WriteLine("Digite a quantidade de notas:");
int quantidadeNotas = Convert.ToInt32(Console.ReadLine());
int[] notas = new int[quantidadeNotas];
int[] pesos = new int[quantidadeNotas];
for (int i = 0; i < quantidadeNotas; i++)
{
    Console.WriteLine($"Digite a nota {i + 1}:");
    notas[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Digite o peso da nota {i + 1}:");
    pesos[i] = Convert.ToInt32(Console.ReadLine());
}
int mediaPonderada = 0;
int somaPesos = 0;
for (int i = 0; i < quantidadeNotas; i++)
{
    mediaPonderada += notas[i] * pesos[i];
    somaPesos += pesos[i];
}
mediaPonderada /= somaPesos;
Console.WriteLine($"A média ponderada é: {mediaPonderada:F2}");