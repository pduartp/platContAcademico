namespace TrabConteudoAcademico.Data;

public class StateContainer{
    public Usuario? usuario{get; set;}
    public void AtualizaValor(Usuario valor){
        this.usuario = valor;
    }
}