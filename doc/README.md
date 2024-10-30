
### 1. Introdução

Este documento apresenta uma implementação de um sistema hospitalar que utiliza padrões de projeto para garantir uma estrutura escalável e de fácil manutenção. Os padrões escolhidos foram Singleton, Builder, Adapter e Observer, aplicados de acordo com as necessidades do sistema.

---
### 2. Design Patterns e Aplicabilidade

### Singleton

- **Descrição**: O padrão Singleton garante que uma classe tenha uma única instância e fornece um ponto de acesso global a ela.
- **Aplicabilidade**: Utilizado para a conexão com o banco de dados. Em sistemas hospitalares, onde várias partes do sistema precisam acessar os mesmos dados, uma única instância de conexão é eficiente, pois evita o overhead de múltiplas conexões ao banco.
- **Justificativa**: Esse padrão evita duplicidade de instâncias de conexão, economizando recursos e prevenindo inconsistências de dados. Ele é essencial em sistemas onde a integridade e a performance do banco de dados são cruciais.

![Singleton](/doc/diagrams/singleton.png)


---
### Builder

- **Descrição**: O padrão Builder separa a construção de um objeto complexo da sua representação, permitindo criar objetos passo a passo e com configurações opcionais.
- **Aplicabilidade**: Utilizado para a criação de objetos de pacientes, onde é necessário lidar com atributos opcionais, como histórico médico, idade e endereço.
- **Justificativa**: O Builder torna o processo de criação de objetos flexível, facilitando a personalização dos dados de cada paciente. Esse padrão é útil para sistemas médicos, onde nem todos os dados de um paciente são sempre necessários para o processamento.


![Builder](/doc/diagrams/builder.png)

---

### Adapter

- **Descrição**: O padrão Adapter permite que uma interface incompatível com o sistema seja convertida para uma interface que o sistema entende, facilitando a integração de APIs externas.
- **Aplicabilidade**: Utilizado para conectar o sistema hospitalar a serviços de dados médicos externos (por exemplo, um serviço de histórico médico de terceiros). Ele adapta a API de terceiros para uma interface interna que o sistema pode utilizar.
- **Justificativa**: O Adapter torna o sistema flexível para interagir com diversas APIs externas, sem alterar o código base. Em um sistema hospitalar, essa capacidade de adaptação é essencial para integrar novos serviços de maneira ágil e consistente.

![adapter](/doc/diagrams/adapter.png)

---

### Observer

- **Descrição**: O padrão Observer permite que um objeto notifique automaticamente uma lista de observadores sobre mudanças em seu estado.
- **Aplicabilidade**: Usado para gerenciar notificações de atualizações em tratamentos médicos. Quando o estado de um paciente é alterado, como no início de um novo tratamento, notificações são enviadas para médicos e familiares.
- **Justificativa**: O Observer permite que diferentes partes interessadas (observadores) recebam atualizações sem que o sistema precise gerenciar manualmente o envio de notificações. Essa automação melhora a comunicação no sistema hospitalar, mantendo médicos e familiares informados sobre o tratamento do paciente de forma eficiente.


![observer](/doc/diagrams/observer.png)

---

### 3. Conclusão

Os padrões de projeto Singleton, Builder, Adapter e Observer são aplicados para melhorar a estrutura e a flexibilidade de um sistema hospitalar. Cada padrão atende a uma necessidade específica, desde o gerenciamento de conexão com o banco de dados (Singleton) até a atualização automática de status de pacientes (Observer). Esses padrões garantem que o sistema possa ser expandido, facilitando a integração de novos serviços e a modificação das funcionalidades existentes.
