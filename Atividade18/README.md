```markdown
# Classificador de Números Ímpares entre 100 e 200

Este repositório contém um simples aplicativo de console em **C#** que imprime todos os números ímpares no intervalo de 100 a 200.

---

## Funcionalidades

- Utiliza um laço `for` para percorrer os números de 100 até 200.
- Verifica a paridade de cada número utilizando o operador módulo:
  ```
  num % 2 != 0
  ```
- Exibe apenas os números ímpares no console.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - Estrutura de repetição `for`: percorre os números de 100 a 200.
  - Estrutura condicional `if`: verifica se o número é ímpar.
  - `Console.WriteLine`: exibe os números ímpares encontrados.

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
- Utilizar operadores matemáticos (`%`) para verificar paridade.
- Estruturar um programa básico em C#.
```