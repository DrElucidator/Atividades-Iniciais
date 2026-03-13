Console.WriteLine("Calculador do volume de um cilindro");
Console.WriteLine("Digite o raio do cilindro: ");
double raio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura do cilindro: ");
double altura = Convert.ToDouble(Console.ReadLine());
double areaBase = Math.PI * Math.Pow(raio, 2);
double volume = areaBase * altura;
Console.WriteLine($"O volume do cilindro é: {volume.ToString("F2")}");