```markdown
# Gerador da Sequência de Fibonacci

Este repositório contém um simples aplicativo de console em **C#** que gera a sequência de Fibonacci até um número limite informado pelo usuário.

---

## Funcionalidades

- Solicita ao usuário um número inteiro como limite.
- Converte o valor digitado para o tipo `int`.
- Utiliza um laço `while` para gerar a sequência de Fibonacci até que o valor atual seja menor ou igual ao limite.
- Exibe os números da sequência separados por espaço.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine` e `Console.Write`: exibem mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToInt32`: converte a entrada para número inteiro.
  - Variáveis `x` e `y`: representam os dois últimos números da sequência.
  - Estrutura de repetição `while`: gera a sequência até o limite.
  - Exibição dos números da sequência no console.

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
- Utilizar conversão de tipos (`string` → `int`).
- Implementar cálculos matemáticos com laços de repetição.
- Trabalhar com lógica de geração de sequências numéricas.
- Estruturar um programa básico em C#.
```