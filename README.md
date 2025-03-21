# OrdemPlusAPI

Projeto OrdemPlus

O OrdemPlus é um sistema de gerenciamento de ordens de serviço desenvolvido em .NET 8.0, que visa otimizar e automatizar processos operacionais de empresas. A aplicação é composta por uma API robusta, que se integra a um banco de dados SQL Server, permitindo o gerenciamento centralizado de informações essenciais.

-Principais Funcionalidades

Gerenciamento de Serviços: Cadastro e consulta de serviços oferecidos, facilitando a organização e a definição das operações realizadas pela empresa.
Gestão de Equipes: Controle das equipes responsáveis pela execução dos serviços, permitindo a visualização e alocação de recursos de forma eficiente.
Cadastro de Funcionários: Armazenamento de dados dos colaboradores, incluindo informações pessoais e profissionais, garantindo uma visão completa dos recursos humanos.
Controle de Pedidos: Registro e acompanhamento dos pedidos de serviço, com informações sobre data, observações, e vinculação aos serviços e equipes responsáveis.
Administração de Usuários e Empresas: Gerenciamento de usuários que acessam o sistema e das empresas associadas, possibilitando uma administração hierárquica e segura.

- Arquitetura e Tecnologias

Backend: Desenvolvido com .NET 8.0 e Entity Framework Core, garantindo alta performance e facilidade de manutenção.
Banco de Dados: Utiliza SQL Server para armazenar e gerenciar os dados das diversas entidades, como serviços, equipes, funcionários, pedidos, usuários e empresas.
Design Modular: A aplicação segue os princípios SOLID, organizando o código em camadas (Controllers, Services, Repositories, Models) para promover a separação de responsabilidades e facilitar futuras expansões.
Contêineres e Deploy: O projeto conta com um arquivo Docker Compose, que possibilita a execução do SQL Server e da API em contêineres, facilitando a implantação e a escalabilidade do sistema.


- Benefícios

Escalabilidade: Estrutura modular que permite a adição de novas funcionalidades sem comprometer a integridade do sistema.
Manutenibilidade: Código organizado e aderente aos princípios SOLID, facilitando a manutenção e a evolução do projeto.
Automação de Processos: Otimização dos fluxos operacionais, proporcionando maior controle e agilidade na gestão de ordens de serviço.
Flexibilidade: Integração fácil com outras aplicações e serviços, graças à arquitetura baseada em APIs RESTful.
