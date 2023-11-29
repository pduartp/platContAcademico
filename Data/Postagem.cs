public class Postagem{

    public Postagem(){}
    public Postagem(int id,int idusuario, string descricao){
        this.Id = id;
        this.IdUsuario = idusuario;
        this.Descricao = descricao;
    }

    public int Id {get; set;}
    public int IdUsuario {get; set;}
    public string? Descricao {get; set;}


}