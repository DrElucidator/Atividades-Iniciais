```markdown
# Calculadora Fatorial

Este repositório contém um simples aplicativo de console em **C#** que calcula o fatorial de um número informado pelo usuário e exibe o processo de cálculo passo a passo.

---

## Funcionalidades

- Solicita ao usuário um número inteiro.
- Converte o valor digitado para o tipo `int`.
- Calcula o fatorial utilizando um laço `for` que percorre do número informado até 1.
- Exibe a operação completa no formato:
  ```
  A! = A x (A-1) x ... x 1 = resultado
  ```
- Mostra o resultado final do fatorial.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine` e `Console.Write`: exibem mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToInt32`: converte a entrada para número inteiro.
  - Estrutura de repetição `for`: calcula o fatorial.
  - Estrutura condicional simples para formatar a saída.
  - Exibição do cálculo e do resultado final.

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
- Exibir operações matemáticas formatadas.
- Estruturar um programa básico em C#.
```