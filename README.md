# HelpDesk

## 👤 Dev do Projeto

| Nome do Aluno        | RA       | Turma   |
|-----------------------|----------|---------|
| Henry Damasceno | G97CGE8 | DS4P48  |

## Status do Projeto 📊

## 📌 Status do Projeto

| Projeto          | Status        |
|------------------|---------------|
| HelpDesk | 🟡 Finalizando |

# Requisitos Levantados 📝

### Requisitos Funcionais
* Cadastro de usuário: Usufruidores podem cadastrar no sistema;
* Autenticação de login com diferentes níveis de acesso;
* Abertura de chamados: Usuários podem registrar requisições de suporte;
* Classificação inteligente: A IA analisa os chamados e, com base no histórico de chamados anteriores, sugere soluções às requisições antes de encaminhar ao suporte técnico adequado.

### Requisitos Não-Funcionais
* Banco de dados em Postgree SQL;
* Segurança do Sistema Token e Hash;
* Modularidade e Sistema integrado.

---


# Casos de Uso
[Casos de Uso]<img width="1536" height="785" alt="UseCase Diagram1" src="https://github.com/user-attachments/assets/71981944-1b43-4011-ad3c-5ea092f76702" />

O diagrama acima representa os principais fluxos do sistema HelpDesk e os diferentes papéis de usuários:

Cliente: pode autenticar-se via login, abrir chamados, editar chamados, acompanhar o andamento, e encerrar chamados quando resolvidos.

Administrador (Admin): possui permissões para encerrar chamados e gerar relatórios do sistema.

Colaborador: pode receber sugestões de soluções frequentes feitas pela IA e devolver a solução do chamado ao cliente.

---

# 🎯 Desafio do Projeto

Atualmente, empresas e usuários enfrentam dificuldades na abertura e gestão de chamados de suporte técnico. Muitas vezes, problemas de hardware e software não são classificados corretamente, causando:

- Atrasos na resolução dos chamados
- Retrabalho para a equipe de TI
- Acúmulo de chamados pendentes
- Insatisfação dos usuários

O desafio deste projeto é desenvolver um sistema de NeoCall inteligente, que permita:

- Registrar e acompanhar chamados de forma organizada, com papéis claros para cada tipo de usuário: Cliente, Administrador (Admin), Colaborador e IA.
- Garantir níveis de acesso diferenciados para cada usuário, conforme representado no diagrama:
- Clientes podem fazer login, abrir, editar e encerrar chamados.
- Administradores têm permissões para encerrar chamados e gerar relatórios.
- Colaboradores recebem sugestões de soluções da IA e devolvem respostas aos chamados.
- Integrar uma IA que sugere soluções frequentes automaticamente, agilizando a triagem e reduzindo o tempo de atendimento, conforme mostrado no fluxo entre IA e Colaborador.

---

# 📋 Backlog do Produto

Este Backlog do Produto resume as funcionalidades chave do sistema HelpDesk de Chamados, que utiliza **C#** (Backend), **Python** (Frontend/IA) e **PostgreSQL** (Banco de Dados).

O desenvolvimento será guiado pela metodologia ágil, com foco na entrega contínua de valor, priorizando as funcionalidades essenciais antes dos recursos avançados de IA.

## 👥 Perfis de Utilizador

O sistema possui três níveis de acesso:

1.  **Colaborador:** Abrir, acompanhar e resolver seus próprios chamados (autoatendimento).
2.  **Técnico:** Gerenciar, resolver e atualizar o status dos chamados atribuídos.
3.  **Administrador:** Configurar o sistema (filas, SLAs) e gerenciar utilizadores e relatórios.

---

## 🔝 Backlog do Produto

### Fase 1: Core do Sistema e MVP

Foco na estabilidade e nas funcionalidades básicas para abertura e gestão de chamados.

* **Autenticação e Autorização:** Login/Registo e definição dos 3 perfis de acesso.
* **Abertura de Chamados:** Formulário simples para Colaboradores (título, descrição, anexos).
* **Gestão Básica de Chamados:** Dashboards para Colaborador (Meus Chamados) e Técnico (Todos/Atribuídos).
* **Atualização de Status:** Funcionalidade para Técnicos alterarem o estado do chamado (Aberto, Em Andamento, Fechado).
* **Comunicação:** Sistema de comentários entre Colaborador e Técnico dentro do chamado.

### Fase 2: Integração de IA e Workflow

Foco na automação, eficiência e recursos de gestão.

* **IA: Classificação Inteligente:** Modelo em Python para categorizar automaticamente o chamado.
* **Atribuição Automática:** Encaminhamento do chamado para a fila/equipa correta com base na classificação da IA.
* **Gestão de Filas e Usuários:** Ferramentas para o Administrador configurar filas e gerenciar utilizadores.
* **Base de Conhecimento (BC):** Módulo para Técnicos criarem artigos e para Colaboradores consultarem (pesquisa simples).
* **Notificações:** Alertas por e-mail para eventos importantes (abertura, atribuição, atualização).

### Fase 3: Otimização e Recursos Avançados (Pós-MVP)

Foco na experiência do utilizador, agilidade na resolução e monitoramento de desempenho.

* **Configuração de SLA:** Definição de regras de tempo de resposta/solução pelo Administrador.
* **IA: Sugestão de Autoatendimento:** IA sugere artigos da BC ao Colaborador antes de abrir o chamado.
* **Relatórios e Dashboards:** Visualizações de métricas de suporte (TMA, volume) para Administradores e Técnicos.
* **Escalada de Chamados:** Funcionalidade para alertar gestores sobre chamados próximos ou fora do SLA.
* **Feedback do Usuário:** Pesquisa de satisfação (NPS/CSAT) após o fechamento do chamado.

## 📅 Cronograma de Evolucão do Projeto
 <img width="1024" height="683" alt="image" src="https://github.com/user-attachments/assets/212aeefc-c006-4c2e-bb1b-6d5277995cbc" />

### Sprints

Cronograma Consolidado por Sprints

Este cronograma está dividido em 5 Sprints principais, representando os marcos de evolução do projeto.

| Sprint | Duração Estimada | Objetivos e Funcionalidades Chave | Foco em IA / Níveis de Acesso |
| :----- | :--------------- | :------------------------------- | :----------------------------- |
| **Sprint 1: Informações** | 2 Semanas | **Planeamento & Setup:** Definição de requisitos, arquitetura e ambiente de desenvolvimento. <br> **Core do Colaborador (MVP Inicial):** Protótipo de Login/Registo e Formulário Básico de Abertura de Chamado. | Colaborador (Acesso Básico) |
| **Sprint 2: Cadastro e Autenticação** | 2 Semanas | **Funcionalidades de Acesso:** Implementação completa de Login/Registo e gestão de sessões para todos os perfis. <br> **Gestão Básica de Chamados:** Dashboards para Colaborador (seus chamados) e Técnico (lista de chamados). <br> **Atualização de Status:** Técnicos podem alterar o status do chamado. | Todos os Níveis de Acesso |
| **Sprint 3: Classificação e S.A.** | 3 Semanas | **IA: Triagem Inteligente:** Desenvolvimento e integração do modelo de IA (Python) para classificar automaticamente os chamados. <br> **Atribuição Automática:** Encaminhamento do chamado para a fila/equipa correta com base na IA. <br> **Gestão de Filas:** Administradores podem configurar e gerenciar filas de atendimento. | IA (Classificação, Atribuição), Administrador |
| **Sprint 4: Refinamento e Sugestão** | 3 Semanas | **Base de Conhecimento (BC):** Módulo completo para criar/consultar artigos de solução. <br> **IA: Autoatendimento Sugerido:** IA sugere artigos da BC ao Colaborador durante a abertura do chamado. <br> **Notificações & SLA:** Configuração de SLAs (Administrador) e sistema de notificações por e-mail. | IA (Autoatendimento), Colaborador, Técnico, Administrador |
| **Sprint 5: Entrega Final** | 1 Mês | **Relatórios & Dashboards:** Ferramentas de análise para Administradores e Técnicos. <br> **Testes Finais & Segurança:** Ciclo completo de testes (QA, segurança, performance). <br> **Implantação & Treinamento:** Preparação para Go-Live, documentação e treinamento de usuários. | Todos os Níveis (Monitoramento, Uso, Segurança) |


  ---

  
## 🛠️ Tecnologias Utilizadas
- *Linguagem:* C#  
- *Frameworks:* ASP.NET Core, Entity Framework  
- *Banco de Dados:* Postgree SQL  
- *Ferramentas de Apoio:* Figma (prototipagem) e Astah (modelagem de diagramas)

---
## 🖥️ Como Utilizar

O *HelpDesk* permite:  
- *Usuário:* criar conta, abrir chamados, acompanhar e encerrar chamados.  
- *Técnico:* visualizar, classificar, atualizar e fechar chamados.  
- *Administrador:* gerenciar usuários, permissões e acompanhar métricas.  

---

## 🚀 Como Executar Localmente

```bash
# clone o repositório
git clone https://github.com/HenryDamasceno01/Help_Desk_Desktop.git
cd help_desk_desktop

# restaure pacotes e crie o banco
dotnet restore
dotnet ef database update

# rode o projeto
dotnet run
