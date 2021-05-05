using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMacMVC.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) VALUES('Normal','Lanche feito com ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) VALUES('Natural','Lanche feito com ingredientes integrais e naturais')");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'https://casa.abril.com.br/wp-content/uploads/2016/11/cheese-salada-01-credito-mauro-holanda.jpeg?quality=70&strip=all','https://lh3.googleusercontent.com/proxy/x8moWP7cVws89mgi3oxPms5jy3XtWyej24eRjbflomQiviMVM-HvBSpGPv2umD20WVV6qrNcdcEuDAl_ypRxEWw-L93qGikTMyl0CekWLw3gvKqhpzFNum20qb58V_Vzyw', 0 ,'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, presunto, mussarela e tomate','Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.',1,'https://www.hellmanns.com.br/content/dam/unilever/global/recipe_image/116/11673/116733-default.jpg/_jcr_content/renditions/cq5dam.web.800.600.jpeg','https://guiadaculinaria.com/wp-content/uploads/2019/07/Misto-quente-de-forn.jpg',0,'Misto Quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(1,'Pão, hambúrger, presunto, mussarela e batalha palha','Pão de hambúrger especial com hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha.',1,'https://www.foodrepublic.com/wp-content/uploads/2012/03/033_FR11785.jpg','https://restaurants.accor.com/media/images/visuel-1-abe-e0a6_320x165.jpg',0,'Cheese Burger', 11.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) VALUES(2,'Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte','Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural.',1,'http://lanchoneteoficinadosabor.com.br/static/uploads/produto/be75ae2723bafcbaa5264b029ec9da05.jpg','http://lanchoneteoficinadosabor.com.br/static/uploads/produto/be75ae2723bafcbaa5264b029ec9da05.jpg',0,'Lanche Natural Peito Peru', 15.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
