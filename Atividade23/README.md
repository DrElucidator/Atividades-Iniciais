```markdown
# FizzBuzz

Este repositório contém um simples aplicativo de console em **C#** que implementa o clássico exercício de programação **FizzBuzz**.

---

## Funcionalidades

- Utiliza um laço `for` para percorrer os números de 1 até 100.
- Aplica a seguinte lógica:
  - Se o número for múltiplo de **3 e 5**, exibe **"FizzBuzz"**.
  - Se o número for múltiplo de **3**, exibe **"Fizz"**.
  - Se o número for múltiplo de **5**, exibe **"Buzz"**.
  - Caso contrário, exibe o próprio número.
- Exibe os resultados no console linha por linha.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - Estrutura de repetição `for`: percorre os números de 1 a 100.
  - Estruturas condicionais `if/else if/else`: aplicam as regras do FizzBuzz.
  - `Console.WriteLine`: exibe o resultado de cada verificação.

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
- Utilizar operadores matemáticos (`%`) para verificar múltiplos.
- Implementar lógica condicional composta.
- Estruturar um programa básico em C#.
```