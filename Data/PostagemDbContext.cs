
using Microsoft.EntityFrameworkCore;

namespace TrabConteudoAcademico.Data;
public class PostagemDbContext : DbContext
{
    #region Contructor
    public PostagemDbContext(DbContextOptions<PostagemDbContext> options)
            : base(options)
    {
    }
    #endregion
    #region Public properties
    public DbSet<Postagem> Postagem { get; set; }
    #endregion
    #region Overidden methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Postagem>().HasData(GetPostagens());
        base.OnModelCreating(modelBuilder);
    }
    #endregion
    #region Private methods
    private List<Postagem> GetPostagens()
    {
        return new List<Postagem>
    {
        new Postagem { Id = 1001, IdUsuario = 1 , Descricao = "teste"},
        new Postagem { Id = 1002, IdUsuario = 1 , Descricao = "teste"},
        new Postagem { Id = 1003, IdUsuario = 1 , Descricao = "teste"},
        new Postagem { Id = 1004, IdUsuario = 1 , Descricao = "teste"}
    };
    }
    #endregion
}