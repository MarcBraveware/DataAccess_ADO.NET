# ADO.NET
Acesso e manipulação de dados através de métodos criados que utilizem ADO.NET, código C# e comandos SQL. 
Criado na plataforma VS2013.

Este projeto tem como objetivo a criação de métodos para manipulação de dados presentes numa base de dados 
utilizando o ADO.NET (Entity Framework) através de formulário em ambiente web.

A estrutura do projeto foi dividia em duas camadas (classes) de desenvolvimento e 
uma de interação com o utilizador em ambiente WEB, sendo elas: 

1- "ClassLibDB" - Camada (ou classe) de base de dados (ligação ADO.NET [Entity Framework] ou com utilização do LINQ): 
  A ligação à base de dados é feita através do ADO.NET e todo o código 
  e configurações associadas(i.e. "using ClassLibMTD", ConnectionString);

2- "ClassLibMTD" - Camada (ou classe) de métodos: 
  A utilização das diferentes tabelas presente na base de dados é feita através dessa ligação, 
  instanciando a base de dados na camada de métodos. 
  Toda a manipulação dos dados é feita através de comandos T-SQL presente nos métodos 
  utilizando variáveis declaradas nos seus parâmetros ao invês de utilizar diretamente os recursos 
  para uma maior adaptabilidade do código. 
  
  A principal função dos métodos criados são: 
    - Preenchimento de (entre outros) dropdown lists (no page_load); 
    - Updates; 
    - Uploads; 
    - Drops; 
    - Seleções simples e filtradas.

3- "WebApp_GUIProjetoII" - Camada do interface com o utilizador (ambiente WEB): 
  Esta camada de interface com o utilizador faz o uso dos métodos criados.
