
using Chapter.Models;
using Microsoft.EntityFrameworkCore;


namespace Chapter.Contexts
{
    public class ChapterContext:DbContext
    {
       public ChapterContext()
        {

        }

        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options) 
        { 

        } 
        //vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sitaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = LAPTOP-BFCJC1OV\\SQLEXPRESS ; Initial catalog = Chapter; Integrated Security = True");
            }
        }
        //dbset respresenta as entidades que serão utilizadas nas operações de leitura, criação, atualização e exclusão
         public DbSet<Livro> Livros  { get; set; }
         public DbSet<Usuario> Usuarios { get; set; }

    }
}
