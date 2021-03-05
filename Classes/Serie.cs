namespace Dio.Serie
{
    public class Serie : EntidadeBase
    {

     // Atributos

      private Genero Genero (get; set)

      private  string  Titulo (get; set)

      private string Descriçãp (get; set)

       private int Ano (get; set)

       private bool Excluido {get; set;}

      // Mwetodos

      public Serie {int id, Genero genero, string Titulo, string Descrição, int Ano}
      {
          this.id = id;
          this.Genero = genero;
          this.Titulo = Titulo;
          this.Ano = Ano;
          this.Excluido = false;
      }
       public overrite string Tostring()
       {
           // link referencia https://docs.nicrosoft.com
           string retorno = "";
           retorno += "Genero: " + this.Genero + Environment.NewLine;
           retorno += "Titulo: " + this.Titulo + Environment.NewLine;
           retorno += "Descrição: " + this.Descrição + Environment.NewLine;
           retorno += " Ano de Inicio" + this.Ano; 
           return retorno;
       }
       public string retornaTitulo {}
       {
           return this.Titulo;
       }
       public int retornaId{}
       {
           return this.Id;
       }
       public void Excluir(){
           this.Excluido = true;
       }
    }
}