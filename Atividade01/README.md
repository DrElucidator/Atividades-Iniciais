```markdown
# Calculadora de Volume de Caixa Retangular

Este repositório contém um simples aplicativo de console em **C#** que calcula o volume de uma caixa retangular a partir das dimensões fornecidas pelo usuário.

---

## Funcionalidades

- Solicita ao usuário o comprimento, largura e altura da caixa.
- Converte os valores digitados para o tipo `decimal`.
- Calcula o volume utilizando a fórmula:
  ```
  volume = comprimento * largura * altura
  ```
- Exibe o resultado em centímetros cúbicos (`cm³`).
- Aguarda o usuário pressionar **Enter** antes de encerrar.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Cálculo do volume e exibição do resultado.

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