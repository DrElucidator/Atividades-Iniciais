Console.WriteLine("Digite um número para fazer o cálculo fatorial: ");
int A = Convert.ToInt32(Console.ReadLine());
int fatorial = 1;
Console.Write($"{A}! = ");
for(int a = A ; a >= 1; a--)
{
    fatorial *= a;
    if (a > 1)
        Console.Write($"{a} x ");
    else
        Console.Write($"{a} ");
}
Console.WriteLine($"= {fatorial}");