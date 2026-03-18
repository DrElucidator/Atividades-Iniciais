```markdown
# Ordenador de Números Decrescentes

Este repositório contém um simples aplicativo de console em **C#** que lê três valores informados pelo usuário e os ordena em ordem decrescente.

---

## Funcionalidades

- Solicita ao usuário três valores inteiros.
- Converte os valores digitados para o tipo `int`.
- Armazena os valores em um array.
- Utiliza `Array.Sort` para ordenar os valores em ordem crescente.
- Utiliza `Array.Reverse` para inverter a ordem, resultando em ordem decrescente.
- Exibe os valores ordenados separados por vírgula.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToInt32`: converte a entrada para número inteiro.
  - `Array.Sort`: ordena os valores em ordem crescente.
  - `Array.Reverse`: inverte a ordem para decrescente.
  - `string.Join`: exibe os valores formatados em uma única linha.

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
- Trabalhar com arrays e métodos de ordenação.
- Estruturar um programa básico em C#.
```