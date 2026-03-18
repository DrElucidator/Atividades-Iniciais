```markdown
# Leitor de Dimensões de Terreno

Este repositório contém um simples aplicativo de console em **C#** que calcula a área de um terreno retangular a partir das dimensões fornecidas pelo usuário.

---

## Funcionalidades

- Solicita ao usuário a largura do terreno.
- Solicita ao usuário o comprimento do terreno.
- Converte os valores digitados para o tipo `decimal`.
- Calcula a área utilizando a fórmula:
  ```
  área = largura * comprimento
  ```
- Exibe o resultado em metros quadrados.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Cálculo da área e exibição do resultado.

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
- Implementar cálculos matemáticos simples.
- Estruturar um programa básico em C#.
```