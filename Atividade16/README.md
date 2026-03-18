```markdown
# Verificador de Paridade

Este repositório contém um simples aplicativo de console em **C#** que verifica se um número informado pelo usuário é par ou ímpar.

---

## Funcionalidades

- Solicita ao usuário um número inteiro.
- Converte o valor digitado para o tipo `int`.
- Verifica a paridade utilizando o operador módulo:
  ```
  num % 2 == 0
  ```
- Exibe no console:
  - **PAR** se o número for divisível por 2.
  - **IMPAR** caso contrário.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToInt32`: converte a entrada para número inteiro.
  - Estrutura condicional `if/else`: determina a paridade.
  - Exibição do resultado final.

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
- Implementar lógica condicional simples.
- Trabalhar com operadores matemáticos (`%`).
- Estruturar um programa básico em C#.
```