using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Biblioteca.Models
{
    internal class Autor
    {
        public int Id { get; set; }
        public string NomeAutor { get; set; }
        public string NacionalidadeAutor { get; set; }
        public string EmailAutor { get; set; }
        public string _sexo;
        public string SexoAutor => _sexo;
        public void SetSexo(bool t)
        {
            _sexo = t ? "Feminino" : "Masculino";
        }
        public string ContatoAutor { get; set; }
        public DateTime? DataNascimentoAutor { get; set; }
    }
}
