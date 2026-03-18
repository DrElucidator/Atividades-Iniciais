```markdown
# Calculadora de Ganhos da Padaria HotPão

Este repositório contém um simples aplicativo de console em **C#** que calcula o faturamento diário da padaria HotPão e sugere o valor a ser guardado na poupança.

---

## Funcionalidades

- Define os preços fixos de pães e broas:
  - Pão: R$0,12
  - Broa: R$1,50
- Solicita ao usuário a quantidade de pães vendidos.
- Solicita ao usuário a quantidade de broas vendidas.
- Converte os valores digitados para o tipo `decimal`.
- Calcula o faturamento total:
  ```
  vendasGerais = (unPaes * precopao) + (unBroas * precobroa)
  ```
- Calcula o valor sugerido para poupança (10% do faturamento):
  ```
  resultado = vendasGerais * 0.1
  ```
- Exibe o faturamento total e o valor sugerido para poupança formatados em moeda.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Cálculo do faturamento e do valor para poupança.
  - Exibição dos resultados formatados.

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
- Implementar cálculos matemáticos simples com porcentagem.
- Estruturar um programa básico em C#.
```