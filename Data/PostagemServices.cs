using Microsoft.EntityFrameworkCore;

namespace TrabConteudoAcademico.Data;

public class PostagemServices
{
    #region Private members
    private PostagemDbContext dbContext;
    #endregion
    #region Constructor
    public PostagemServices(PostagemDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion
    #region Public methods
    /// <summary>
    /// This method returns the list of product
    /// </summary>
    /// <returns></returns>
    public async Task<List<Postagem>> GetPostagemAsync()
    {
        return await dbContext.Postagem.ToListAsync();
    }
    /// <summary>
    /// This method add a new product to the DbContext and saves it
    /// </summary>
    /// <param name="postagem"></param>
    /// <returns></returns>
    /// 

     
    public async Task<List<Postagem>> RetornaPostagemAsync()
    {
        return await dbContext.Postagem.ToListAsync();
    }




    public async Task<Postagem> AddPostagemAsync(Postagem postagem)
    {
        try
        {
            dbContext.Postagem.Add(postagem);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return postagem;
    }
    /// <summary>
    /// This method update and existing product and saves the changes
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    public async Task<Postagem> UpdatePostagemAsync(Postagem postagem)
    {
        try
        {
            var postagemExist = dbContext.Postagem.FirstOrDefault(p => p.Id == postagem.Id);
            if (postagemExist != null)
            {
                dbContext.Update(postagem);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return postagem;
    }

    
    /// <summary>
    /// This method removes and existing product from the DbContext and saves it
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    public async Task DeletePostagemAsync(Postagem postagem)
    {
        try
        {
            dbContext.Postagem.Remove(postagem);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}