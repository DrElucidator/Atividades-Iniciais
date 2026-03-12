Console.WriteLine("Calculador de combustível");

Console.WriteLine("Digite a quilometragem inicial do veículo:");
decimal quilometragemInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quilometragem final do veículo:");
decimal quilometragemFinal = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de combustível consumida (litros):");
decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

decimal distanciaPercorrida = quilometragemFinal - quilometragemInicial;

decimal consumoMedio = distanciaPercorrida / combustivelConsumido;

Console.WriteLine($"A distância percorrida foi de {distanciaPercorrida} km.");
Console.WriteLine($"O consumo médio do veículo é de {consumoMedio} km/l.");