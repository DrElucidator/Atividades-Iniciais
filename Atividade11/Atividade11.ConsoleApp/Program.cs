Console.WriteLine("Contador de dias vividos");
Console.WriteLine("Digite o seu nome: ");
string? nome = Console.ReadLine();
DateTime agora = DateTime.Now;
Console.WriteLine("Digite a data de nascimento no formato [dd/MM/aaaa]: ");
DateTime nascimento = Convert.ToDateTime((Console.ReadLine()));
TimeSpan diasVividos = agora - nascimento;
Console.WriteLine($"{nome}  nascido(a) em:  {nascimento.ToString("dd/MM/yyyy")}");
if (nascimento != null)
{
    Console.WriteLine($"{nome}  viveu  {diasVividos.Days} dias.");
}
else
{
    Console.WriteLine("Digite uma data válida.");
    return;
}
Console.ReadLine();