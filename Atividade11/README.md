```markdown
# Contador de Dias Vividos

Este repositório contém um simples aplicativo de console em **C#** que calcula quantos dias uma pessoa já viveu a partir da sua data de nascimento.

---

## Funcionalidades

- Solicita ao usuário o nome.
- Solicita a data de nascimento no formato `dd/MM/yyyy`.
- Converte a entrada para o tipo `DateTime`.
- Calcula a diferença entre a data atual e a data de nascimento.
- Exibe o nome, a data de nascimento formatada e o total de dias vividos.
- Valida se a data informada é válida.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDateTime`: converte a entrada para data.
  - `DateTime.Now`: obtém a data e hora atuais.
  - `TimeSpan`: calcula a diferença entre duas datas.
  - Estrutura condicional `if/else`: valida a entrada e exibe o resultado.

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
- Utilizar conversão de tipos (`string` → `DateTime`).
- Trabalhar com manipulação de datas e intervalos (`TimeSpan`).
- Estruturar um programa básico em C#.
```