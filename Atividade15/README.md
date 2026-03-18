```markdown
# Calculadora de IMC - Índice de Massa Corporal para Adultos

Este repositório contém um simples aplicativo de console em **C#** que calcula o Índice de Massa Corporal (IMC) de um adulto a partir da altura e do peso informados pelo usuário.

---

## Funcionalidades

- Solicita ao usuário a altura em metros.
- Solicita ao usuário o peso em quilogramas.
- Converte os valores digitados para o tipo `decimal`.
- Calcula o IMC utilizando a fórmula:
  ```
  IMC = peso / (altura * altura)
  ```
- Classifica o resultado em três categorias:
  - Abaixo de 18,5: **Abaixo do peso ideal**
  - Entre 18,5 e 25: **Peso saudável**
  - Acima de 25: **Obeso**
- Exibe a classificação correspondente no console.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Estrutura condicional `if/else if/else`: classifica o IMC.
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
- Implementar cálculos matemáticos com fórmulas.
- Trabalhar com estruturas condicionais.
- Estruturar um programa básico em C#.
```