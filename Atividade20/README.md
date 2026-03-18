```markdown
# Gerador de Tabuada

Este repositório contém um simples aplicativo de console em **C#** que gera a tabuada de um número informado pelo usuário.

---

## Funcionalidades

- Solicita ao usuário um número inteiro.
- Converte o valor digitado para o tipo `int`.
- Utiliza um laço `for` para calcular a multiplicação do número informado por valores de 0 até 10.
- Exibe cada operação no formato:
  ```
  N x número = resultado
  ```

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.Write`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToInt32`: converte a entrada para número inteiro.
  - Estrutura de repetição `for`: gera a tabuada.
  - `Console.WriteLine`: exibe cada linha da tabuada.

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
- Estruturar um programa básico em C#.
```