```markdown
# Classificador de Números Ímpares Múltiplos de 3 entre 1 e 500

Este repositório contém um simples aplicativo de console em **C#** que imprime todos os números ímpares e múltiplos de 3 no intervalo de 1 a 500.

---

## Funcionalidades

- Utiliza um laço `for` para percorrer os números de 1 até 500.
- Verifica se o número é ímpar utilizando o operador módulo:
  ```
  num % 2 != 0
  ```
- Verifica se o número é múltiplo de 3:
  ```
  num % 3 == 0
  ```
- Exibe no console apenas os números que satisfazem ambas as condições.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - Estrutura de repetição `for`: percorre os números de 1 a 500.
  - Estruturas condicionais `if`: verificam se o número é ímpar e múltiplo de 3.
  - `Console.WriteLine`: exibe os números que atendem aos critérios.

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

- Praticar estruturas de repetição (`for`).
- Utilizar operadores matemáticos (`%`) para verificar múltiplos e paridade.
- Implementar lógica condicional composta.
- Estruturar um programa básico em C#.
```