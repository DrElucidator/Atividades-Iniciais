Console.WriteLine("Conversor de Temperatura - Celsius para Fahrenheit");
Console.WriteLine("Digite a temperatura em Celsius:");
decimal celsius = Convert.ToDecimal(Console.ReadLine());
decimal fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");