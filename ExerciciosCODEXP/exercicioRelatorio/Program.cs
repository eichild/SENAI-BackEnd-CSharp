using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace exercicioRelatorio
{
    class Program
    {
        static void Main(string[] args)
        {
           #region Criação de documento
               Document relatorio = new Document();
           #endregion

           #region seção de conteudo
                //Criando a seção do conteudo 1
               Section secaoConteudo1 = relatorio.AddSection();
           #endregion

           #region Criando paragrafo titulo
                Paragraph titulo = secaoConteudo1.AddParagraph();
           #endregion

           #region Texto do paragrafo titulo
               titulo.AppendText("EXERCICIO RELATORIO\n\n\n");
           #endregion

           #region Estilizando texto do titulo
                titulo.Format.HorizontalAlignment=HorizontalAlignment.Center;

                ParagraphStyle estilo01= new ParagraphStyle(relatorio);
                estilo01.Name="Cor do titulo";
                estilo01.CharacterFormat.TextColor=Color.Pink;
                relatorio.Styles.Add(estilo01);
                estilo01.CharacterFormat.FontSize=30;
           #endregion

           #region Adicionando paragrafo para o texto
               Paragraph texto= secaoConteudo1.AddParagraph();
           #endregion

            #region Texto do paragrafo do texto
               texto.AppendText("\tHoje eu achei minha prometida no LINKDIN, Linda linda linda\n");
           #endregion


        }
    }
}
