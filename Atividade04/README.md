```markdown
# Conversor de Temperatura - Celsius para Fahrenheit

Este repositório contém um simples aplicativo de console em **C#** que converte uma temperatura informada em graus Celsius para graus Fahrenheit.

---

## Funcionalidades

- Solicita ao usuário a temperatura em Celsius.
- Converte o valor digitado para o tipo `decimal`.
- Calcula a temperatura em Fahrenheit utilizando a fórmula:
  ```
  fahrenheit = (celsius * 9 / 5) + 32
  ```
- Exibe o resultado da conversão no console.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Cálculo da conversão de Celsius para Fahrenheit.
  - Exibição do resultado.

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