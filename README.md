<h1 align="center">LanchesMacMVC</h1>
<h1><img src="https://ik.imagekit.io/xguomcqgelu/ApresentacaoLancheMVC__1__NUtIihl2A.gif"/></h1>

## 📚 Sobre

---

O projeto é um e-commerce simples com o foco na venda de lanches, o mesmo teve um foco maior no **back-end**, onde foi desenvolvido com [ASP.NET Core MVC](https://docs.microsoft.com/pt-br/aspnet/core/mvc/overview?view=aspnetcore-5.0).

---

## 🚀 Tecnologias  Usadas

O projeto fez uso de varias tecnologias e conceitos, dentre eles se destaca
- [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/)
- [Identity](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio)
- [Bootstrap](https://getbootstrap.com/)
- [Session state](https://www.c-sharpcorner.com/UploadFile/484ad3/session-state-in-Asp-Net/)
- [Areas](https://docs.microsoft.com/pt-br/aspnet/core/mvc/controllers/areas?view=aspnetcore-5.0)
- [PartialViews](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/partial?view=aspnetcore-5.0)
- [ViewModels](http://www.macoratti.net/17/05/aspn_vwmd1.htm)
- [Repositories](https://docs.microsoft.com/pt-br/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
- [MySQL](https://www.mysql.com/)

---

## 👩‍🏫 Como Executar o Projeto
- Após clonar o projeto certifique se de estar usando a versão 3.1 do .Net Core, feito isso altere a connection string de forma que o mesmo se comunique com o banco, depois é só executar com Ctrl + F5 ou no botão executar. <br/>
Você pode encontrar a string de conexão no arquivo appsettings.json na raiz do projeto.

-  Na primeira execução ele irá criar o banco de dados com suas tabelas principais, na segunda execução ele irá criar os perfis e atribuir os usuarios usando a tabela aspnetroles e aspnetuserroles. Dessa forma ao executar na segunda vez, certifique se de finalizar o mesmo no processo do iis express, caso esteja usando o Visual Studios

- Após isso o mesmo está pronto para uso.

---

## 🔍 Funcionalidades
No projeto, estando sem login você pode navegar pelo site normalmente, ao adicionar um lanche ao carrinho o mesmo irá pedir para fazer login ou se registrar, após isso seu carrinho de compras estará disponivel, podendo adicionar mais itens ou simplesmente fechar o pedido.

Como Administrador você tem acesso a area de admin, onde você pode editar tudo do site em CRUDs.
Para isso faça login com a conta 'admin' e senha 'Numsey#109@vx'.

---

## Agradeço por ter vindo 😁✌👍