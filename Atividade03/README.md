```markdown
# Calculadora de Consumo de Combustível

Este repositório contém um simples aplicativo de console em **C#** que calcula o consumo médio de combustível de um veículo a partir das informações fornecidas pelo usuário.

---

## Funcionalidades

- Solicita ao usuário a quilometragem inicial e final do veículo.
- Solicita a quantidade de combustível consumida em litros.
- Converte os valores digitados para o tipo `decimal`.
- Calcula a distância percorrida:
  ```
  distanciaPercorrida = quilometragemFinal - quilometragemInicial
  ```
- Calcula o consumo médio:
  ```
  consumoMedio = distanciaPercorrida / combustivelConsumido
  ```
- Exibe a distância percorrida e o consumo médio em km/l.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Cálculo da distância percorrida e do consumo médio.
  - Exibição dos resultados.

---

## Como Executar

1. Abra o terminal na pasta do projeto.
2. Compile o projeto com o comando:
   ```bash
   dotnet build
   ```
3. Execute o aplicativo:
   ```bash
   dotnet run
   ```

---

## Requisitos

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download).

---

## Objetivos de Aprendizado

- Praticar entrada e saída de dados em console.
- Utilizar conversão de tipos (`string` → `decimal`).
- Implementar cálculos matemáticos simples.
- Estruturar um programa básico em C#.
```