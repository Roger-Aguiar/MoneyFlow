# 💰 MoneyFlowDesktop

O **MoneyFlowDesktop** é uma aplicação **Desktop em .NET** para **controle financeiro de entradas e saídas**, permitindo a **importação automática de extratos em Excel**, armazenamento em **MySQL** e **geração de relatórios financeiros em PDF** com filtros por período.

O sistema foi projetado para ser simples, eficiente e extensível, atendendo tanto uso pessoal quanto profissional.

---

## 📌 Principais Funcionalidades

- 📥 Importação de extrato financeiro via **planilha Excel**
- 🔄 Leitura automática a partir da **linha 6**
- 📊 Classificação automática:
  - Valores **positivos** → Entradas
  - Valores **negativos** → Saídas
- 🗄️ Persistência dos dados em **MySQL**
- 📅 Consulta de registros por **período**
- 📄 Geração de **relatórios em PDF**
- 📉 Cálculos automáticos:
  - Total de entradas
  - Total de saídas
  - Percentual de saída sobre o total de entrada
- 🌍 Suporte a múltiplos idiomas:
  - 🇧🇷 Português (pt-BR)
  - 🇺🇸 Inglês (en-US)

---

## 🖥️ Interface do Sistema

A interface Desktop foi pensada para ser **intuitiva e objetiva**, permitindo que o usuário:

1. Selecione a planilha Excel
2. Visualize os registros importados
3. Escolha um período de consulta
4. Gere relatórios financeiros em PDF

*(Screenshots serão adicionados futuramente)*

---

## 🏗️ Arquitetura do Projeto

O projeto segue uma **arquitetura em camadas**, separando responsabilidades e facilitando manutenção, testes e evolução.

