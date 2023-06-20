using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Biblioteca.Models
{
    internal class Livro
    {
        public int Id { get; set; }
        public string CodigoLivro { get; set; }
        public string TituloLivro { get; set; }
        public string SinopseLivro { get; set; }
        public string LocalizaoLivro { get; set; }
        public DateTime? DataPublicacaoLivro { get; set; }
        public string Edicao { get; set; }
    }
}
