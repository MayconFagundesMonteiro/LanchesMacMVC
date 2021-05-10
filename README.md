# LanchesMacMVC
Site simples de venda de lanches com foco no back-end, desenvolvido em Asp Net Core MVC, usando frameworks e conceitos como: Entity Framework Core, Identity, Session state, Areas, PartialViews, viewcomponent e mais, ainda se encontra em desenvolvimento, aberto a criticas construtivas.

Como Executar o Site pela primeira vez?
O mesmo usa o MySql, na primeira execução ele está programado para criar o banco de dados com suas tabelas principais, na segunda execução ele ira criar os perfis e atribuir os usuarios  usando a tabela aspnetroles e aspnetuserroles.
Dessa forma ao executar na segunda vez, certificasse de finalizar o mesmo no processo do iis express, caso esteja usando o Visual Studios.
No MySql o projeto usa um usuario com nome 'Maycon', você pode criar o mesmo ou se prefirir pode alterar a connection strings do mesmo, que fica em appsettings na raiz do projeto,
"ConnectionStrings": { "DefaultConnection": "Server=localhost;user id=Maycon;password=admin;persist security info=True;database=LanchesMacMVC" }.
Dessa forma o site já está pronto para uso.

Como acessar a Area de Admin?
Faça login com o super usuario de nome 'admin' e senha 'Numsey#109@vx' sem aspas.
Ao logar, clique no botão Admin na navbar, dessa forma você estará na area de administração.
Ainda na navbar você terá acesso a lanches, categorias e pedidos em forma de CRUD.

Espero seu feedback caso tenha críticas construtivas, ou encontre algum problema.
