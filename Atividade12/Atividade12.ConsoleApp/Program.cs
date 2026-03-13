Console.WriteLine("Calculadora de aumento de salário");
Console.WriteLine("Digite o valor do salário atual: ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
decimal aumento = 0.15m; decimal descontos = 0.08m; decimal aumentoSalarial = salarioBase * aumento; decimal salarioAtual = aumentoSalarial + salarioBase; decimal descontoBase = salarioAtual * descontos; decimal novoSalario = salarioAtual - descontoBase;
Console.WriteLine("O salário atualizado do funcionário é: " + novoSalario.ToString("C"));