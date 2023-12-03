public class Postagem{

    public Postagem(){}
    public Postagem(int idusuario, string descricao){
        
        this.IdUsuario = idusuario;
        this.Descricao = descricao;
    }

    public int Id {get; set;}
    public int IdUsuario {get; set;}
    public string? Descricao {get; set;}


}
