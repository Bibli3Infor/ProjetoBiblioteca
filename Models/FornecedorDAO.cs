using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Biblioteca.Database;
using MySql.Data.MySqlClient;

namespace System_Biblioteca.Models
{
    internal class FornecedorDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Fornecedor fornecedor)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Fornecedor VALUES " +
                "(null, @nome_empresa, @telefone, @email, @cnpj, @endereco, @descricao, @razaosocial);";

                comando.Parameters.AddWithValue("@nome_empresa", fornecedor.NomeEmpresa);
                comando.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                comando.Parameters.AddWithValue("@email", fornecedor.Email);
                comando.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                comando.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                comando.Parameters.AddWithValue("@descricao", fornecedor.Descricao);
                comando.Parameters.AddWithValue("@razaosocial", fornecedor.RazaoSocial);


                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Fornecedor t)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "DELETE FROM Fornecedor WHERE id_for = @id";

                comando.Parameters.AddWithValue("@id", t.Id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                    throw new Exception("Registro não removido da base de dados." +
                        "Verifique e tente novamente");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}

