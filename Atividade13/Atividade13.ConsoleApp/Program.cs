Console.WriteLine("Comparador da soma de valores perante valor C");
Console.WriteLine("Digite o valor A a ser somado: ");
decimal valorA = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor B a ser somado: ");
decimal valorB = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor C a ser comparado: ");
decimal valorC = Convert.ToDecimal(Console.ReadLine());
if (valorA + valorB < valorC)
    Console.WriteLine("A Soma dos valores A & B são menores que C");
else
    Console.WriteLine("Valor de C é menor que a soma de A & B");