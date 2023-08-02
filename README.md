Camadas da Arquitetura
O projeto ClearArch utiliza a abordagem da Clean Architecture, organizando o código em diferentes camadas com responsabilidades bem definidas:

Camada de Aplicação (Application): Responsável por conter as regras de negócio e coordenação das ações do sistema. Essa camada faz uso dos serviços da camada de domínio para executar as operações.

Camada de Domínio (Domain): Contém as entidades, interfaces de serviços e contratos que definem a lógica central do negócio. Essa camada não possui dependências externas e é independente das tecnologias usadas na infraestrutura.

Camada de Infraestrutura de Dados (Infra.Data): Responsável por implementar as interfaces definidas na camada de domínio para acesso a dados, utilizando o Entity Framework para a persistência.

Camada de Injeção de Dependência (Infra.Ioc): Essa camada é responsável por configurar a injeção de dependência do sistema, conectando as interfaces da camada de aplicação com as implementações concretas da camada de infraestrutura de dados.

Camada de Interface do Usuário (MVC): Implementa a interface do usuário utilizando o padrão MVC (Model-View-Controller) para interagir com o sistema. Essa camada faz uso dos serviços da camada de aplicação para realizar as operações do CRUD.
