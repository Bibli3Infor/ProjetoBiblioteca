using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Biblioteca.Models
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string NomeFuncionario { get; set; }
        public string EmailFuncionario { get; set; }
        public string CpfFuncionario { get; set; }
        public string RgFuncionario { get; set; }
        public string EnderecoFuncionario { get; set; }
        public string CodigoAcesso { get; set; }
        public string TelefoneFuncionario { get; set; }
        public string Turno { get; set; }
        public string _sexo;
        public string SexoFuncinario => _sexo;
        public void SetSexo(bool t)
        {
            _sexo = t ? "Feminino" : "Masculino";
        }
        public DateTime? DataNascimentoFuncionario { get; set; }
    }
}
