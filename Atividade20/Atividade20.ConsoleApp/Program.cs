Console.Write("Digite um número para gerar a tabuada: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int N = 0; N <= 10; N++)
{
    int resultadoTabuada = n * N;
    string operacaoTabuada = N + " x " + n + " = " + resultadoTabuada;
    Console.WriteLine(operacaoTabuada);
}