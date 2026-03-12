Console.WriteLine("Calculadora de Média Harmônica");
Console.WriteLine("Digite a quantidade de notas do aluno: ");
int quantidadeNotas = Convert.ToInt32(Console.ReadLine());
int[] notas = new int[quantidadeNotas];
double somaInversa = 0;
for (int i = 0; i < quantidadeNotas; i++)
{
    Console.WriteLine($"Digite a nota {i + 1}: ");
    notas[i] = Convert.ToInt32(Console.ReadLine());

    if (notas[i] != 0)
        somaInversa += 1.0 / notas[i];
    else
        Console.WriteLine("Nota zero é inválida para o cálculo da média harmônica.");
}
double mediaHarmonica = quantidadeNotas / somaInversa;
Console.WriteLine($"A média harmônica é: {mediaHarmonica:F2}");