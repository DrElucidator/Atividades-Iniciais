```markdown
# Calculadora de Média Harmônica

Este repositório contém um simples aplicativo de console em **C#** que calcula a média harmônica das notas de um aluno a partir das informações fornecidas pelo usuário.

---

## Funcionalidades

- Solicita ao usuário a quantidade de notas.
- Solicita cada nota individualmente.
- Converte os valores digitados para o tipo `int`.
- Calcula a soma dos inversos das notas (exceto quando a nota é zero).
- Calcula a média harmônica utilizando a fórmula:
  ```
  média harmônica = quantidadeNotas / somaInversa
  ```
- Exibe o resultado formatado com duas casas decimais.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToInt32`: converte a entrada para número inteiro.
  - Estrutura de repetição `for`: coleta as notas e calcula a soma dos inversos.
  - Cálculo da média harmônica e exibição do resultado.

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
- Implementar cálculos matemáticos com médias.
- Trabalhar com estruturas de repetição (`for`).
- Estruturar um programa básico em C#.
```