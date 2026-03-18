```markdown
# Calculadora de Aumento de Salário

Este repositório contém um simples aplicativo de console em **C#** que calcula o novo salário de um funcionário após aplicar aumento e descontos.

---

## Funcionalidades

- Solicita ao usuário o valor do salário atual.
- Converte o valor digitado para o tipo `decimal`.
- Aplica um aumento de 15% sobre o salário base.
- Aplica um desconto de 8% sobre o salário atualizado.
- Calcula o novo salário líquido.
- Exibe o resultado formatado em moeda (`C`).

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Cálculo do aumento salarial e dos descontos.
  - Exibição do resultado final formatado.

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
- Implementar cálculos matemáticos com porcentagem.
- Estruturar um programa básico em C#.
```