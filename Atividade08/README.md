```markdown
# Verificador de Números Primos

Este repositório contém um simples aplicativo de console em **C#** que verifica se um número informado pelo usuário é primo ou não.

---

## Funcionalidades

- Solicita ao usuário um número inteiro.
- Converte o valor digitado para o tipo `int`.
- Verifica se o número é menor que 2 (não primo).
- Utiliza um laço `for` para testar divisores entre 2 e o número informado.
- Determina se o número é primo ou não.
- Exibe o resultado no console.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine` e `Console.Write`: exibem mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToInt32`: converte a entrada para número inteiro.
  - Estrutura condicional `if/else`: valida se o número é menor que 2.
  - Estrutura de repetição `for`: verifica divisores do número.
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
- Implementar lógica condicional para validação de números.
- Trabalhar com estruturas de repetição (`for`).
- Estruturar um programa básico em C#.
```