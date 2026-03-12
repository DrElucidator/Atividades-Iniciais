Console.WriteLine("Verificador de números primos");
Console.Write("Digite um número: ");
int num = Convert.ToInt32(Console.ReadLine());
bool primo = true;
if (num < 2)
{
    primo = false;
}
else
{
    for (int i = 2; i <= num - 1; i++)
    {
        if (num % i == 0)
        {
            primo = false;
            break;
        }
    }
}
if (primo)
{
    Console.WriteLine($"{num} é um número primo.");
}
else
{
    Console.WriteLine($"{num} não é um número primo.");
}