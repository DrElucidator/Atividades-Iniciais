```markdown
# Calculadora de Salário de Vendedor Comissionado

Este repositório contém um simples aplicativo de console em **C#** que calcula o salário total de um vendedor comissionado a partir das informações fornecidas pelo usuário.

---

## Funcionalidades

- Solicita ao usuário o salário fixo do vendedor.
- Solicita o total de vendas realizadas.
- Solicita a porcentagem de comissão sobre as vendas.
- Converte os valores digitados para o tipo `decimal`.
- Calcula a comissão utilizando a fórmula:
  ```
  comissao = totalVendas * (porcentagemComissao / 100)
  ```
- Calcula o salário total:
  ```
  salarioTotal = salarioFixo + comissao
  ```
- Exibe o resultado formatado em moeda (`C2`).

---

## Estrutura do Projeto

- `Program.cs`: contém toda a lógica do aplicativo.
  - `Console.WriteLine` e `Console.Write`: exibem mensagens no console.
  - `Console.ReadLine`: captura entrada do usuário.
  - `Convert.ToDecimal`: converte a entrada para número decimal.
  - Cálculo da comissão e do salário total.
  - Exibição do resultado formatado.

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
- Implementar cálculos matemáticos simples com porcentagem.
- Estruturar um programa básico em C#.
```