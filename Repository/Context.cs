using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    //Herdar da classe DbContext
    public class Context : DbContext
    {
        //Nomear o banco de dados
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        //Definir as classes que vão virar tabelas no banco
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ProdutoFinal> ProdutosFinais{ get; set; }
<<<<<<< HEAD
        public DbSet<Produto> Produtos{ get; set; }
=======
        public DbSet<Produto> Produtos { get; set; }
>>>>>>> a7b8d2ec176f0ac39bbab5a76ff6ce99716bac37
        public DbSet<Receita> Receitas{ get; set; }
    }
}
