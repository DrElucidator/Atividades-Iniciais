Console.WriteLine("Escreva um número para gerar a tabela Fibonacci até ele: ");
int limite = Convert.ToInt32(Console.ReadLine());
int x = 0; int y = 1;
while(x <= limite)
{
    Console.Write(x + " ");
    int z = x;
    x = y;
    y = z + y;
}