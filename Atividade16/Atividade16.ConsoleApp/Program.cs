Console.WriteLine("Digite algum número para verificar a paridade: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
    Console.WriteLine("PAR");
else
Console.WriteLine("IMPAR");