```markdown
# Calculadora de Volume de Cilindro

Este repositório contém um simples aplicativo de console em **C#** que calcula o volume de um cilindro a partir das dimensões fornecidas pelo usuário.

---

## Funcionalidades

- Solicita ao usuário o raio e a altura do cilindro.
- Converte os valores digitados para o tipo `double`.
- Calcula a área da base utilizando a fórmula:
  ```
  areaBase = π * raio²
  ```
- Calcula o volume utilizando a fórmula:
  ```
  volume = areaBase * altura
  ```
- Exibe o resultado formatado com duas casas decimais.
- Aguarda o usuário pressionar **Enter** antes de encerrar.

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine`: exibe mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDouble`: converte a entrada para número decimal.
  - `Math.PI` e `Math.Pow`: utilizados para calcular a área da base.
  - Cálculo do volume e exibição do resultado.

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
- Utilizar conversão de tipos (`string` → `double`).
- Implementar cálculos matemáticos com funções da biblioteca `Math`.
- Estruturar um programa básico em C#.
```