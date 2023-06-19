using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Biblioteca.Models
{
    internal class Fornecedor
    {
        public int Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Descricao { get; set; }
        public string RazaoSocial { get; set; }
        
    }
}
