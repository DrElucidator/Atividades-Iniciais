```markdown
# Calculadora de Soma (A+B) e Multiplicação (A*B)

Este repositório contém um simples aplicativo de console em **C#** que realiza operações matemáticas condicionais entre dois números fornecidos pelo usuário.

---

## Funcionalidades

- Solicita ao usuário o valor de **A**.
- Solicita ao usuário o valor de **B**.
- Converte os valores digitados para o tipo `decimal`.
- Aplica a seguinte lógica:
  - Se **A** for igual a **B**, calcula a soma:
    ```
    valorC = valorA + valorB
    ```
  - Caso contrário, calcula a multiplicação:
    ```
    valorC = valorA * valorB
    ```
- Exibe o resultado final no console.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Estrutura condicional `if/else`: decide entre soma ou multiplicação.
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
- Utilizar conversão de tipos (`string` → `decimal`).
- Implementar lógica condicional simples.
- Estruturar um programa básico em C#.
```