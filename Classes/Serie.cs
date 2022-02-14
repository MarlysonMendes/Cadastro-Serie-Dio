namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        private String Titulo {get; set;}
        private String Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Ano = ano;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Excluido = false;
            
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Id: " + this.Id + Environment.NewLine;
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido" + this.Exclui;
            return retorno;
        }

        public string retornoTitulo()
        {
            return this.Titulo;
        }
        public string retornoId()
        {
            return this.Id.ToString();
        }
        public void Exclui ()
        {
            this.Excluido = true;
        }

    }
}