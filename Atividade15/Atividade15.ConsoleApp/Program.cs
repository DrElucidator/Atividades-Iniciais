Console.WriteLine("Calculador de IMC - Indice de Massa Corporal para adultos");
Console.WriteLine("Digite sua altura: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite seu peso: ");
decimal peso = Convert.ToDecimal(Console.ReadLine());
decimal IMCAdult = peso / (altura * altura);
if (IMCAdult < 18.5m)
Console.WriteLine("Abaixo do peso ideal");
else if (IMCAdult <= 25m)
Console.WriteLine("Peso saudável");
else
Console.WriteLine("Obeso");