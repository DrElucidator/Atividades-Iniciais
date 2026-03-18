```markdown
# Comparador da Soma de Valores perante C

Este repositório contém um simples aplicativo de console em **C#** que compara a soma de dois valores (A e B) com um terceiro valor (C).

---

## Funcionalidades

- Solicita ao usuário o valor A.
- Solicita ao usuário o valor B.
- Solicita ao usuário o valor C.
- Converte os valores digitados para o tipo `decimal`.
- Calcula a soma de A e B.
- Compara a soma com o valor C:
  - Se `A + B < C`, informa que a soma é menor que C.
  - Caso contrário, informa que C é menor que a soma de A e B.
- Exibe o resultado no console.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine` e `Console.Write`: exibem mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Estrutura condicional `if/else`: realiza a comparação e exibe o resultado.

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