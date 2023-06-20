using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Biblioteca.Models
{
    internal class Leitor
    {
        public int Id { get; set; }
        public string CodigoAcesso { get; set; }
        public string NomeLeitor { get; set; }
        public string EmailLeitor { get; set; }
        public string Endereco { get; set; }
        public string CpfLeitor { get; set; }
        public string RgLeitor { get; set; }
        public string TelefoneLeitor { get; set; }
        public string _sexo;
        public string SexoLeitor => _sexo;
        public void SetSexo(bool t)
        {
            _sexo = t ? "Feminino" : "Masculino";
        }
        public DateTime? DataNascimentoLeitor { get; set; }
    }
}
