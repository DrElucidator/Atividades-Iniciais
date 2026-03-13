Console.WriteLine("Calculadora de soma (A+B) e divisão (A/B)");
Console.WriteLine("Atribua um valor ao número A: ");
decimal valorA = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Atribua um valor ao número B: ");
decimal valorB = Convert.ToDecimal(Console.ReadLine());
decimal valorC;
if(valorA == valorB)
valorC = valorA + valorB;
else
valorC = valorA * valorB;
Console.WriteLine("O resultado do número C é: " + valorC);