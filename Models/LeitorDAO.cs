using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Biblioteca.Database;
using System_Biblioteca.Helpers;
using MySql.Data.MySqlClient;

namespace System_Biblioteca.Models
{
    internal class LeitorDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Leitor leitor)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Leitor VALUES " +
                "(null, @codigo_acesso, @nome_leitor, @email, @endereco, @cpf, @rg, @telefone, @sexo, @data_nasc_leitor);";

                comando.Parameters.AddWithValue("@codigo_acesso", leitor.CodigoAcesso);
                comando.Parameters.AddWithValue("@nome_leitor", leitor.NomeLeitor);
                comando.Parameters.AddWithValue("@email", leitor.EmailLeitor);
                comando.Parameters.AddWithValue("@endereco", leitor.Endereco);
                comando.Parameters.AddWithValue("@cpf", leitor.CpfLeitor);
                comando.Parameters.AddWithValue("@rg", leitor.RgLeitor);
                comando.Parameters.AddWithValue("@telefone", leitor.TelefoneLeitor);
                comando.Parameters.AddWithValue("@sexo", leitor.SexoLeitor);
                comando.Parameters.AddWithValue("@data_nasc_leitor", leitor.DataNascimentoLeitor?.ToString("yyyy-MM-dd"));


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

        public List<Leitor> List()
        {
            try
            {
                var lista = new List<Leitor>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Leitor";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var leitor = new Leitor();

                    leitor.Id = reader.GetInt32("id_lei");
                    leitor.CodigoAcesso = DAOHelper.GetString(reader, "cod_acesso_lei");
                    leitor.NomeLeitor = DAOHelper.GetString(reader, "nome_lei");
                    leitor.EmailLeitor = DAOHelper.GetString(reader, "email_lei");
                    leitor.Endereco = DAOHelper.GetString(reader, "endereco_lei");
                    leitor.CpfLeitor = DAOHelper.GetString(reader, "cpf_lei");
                    leitor.RgLeitor = DAOHelper.GetString(reader, "rg_lei");
                    leitor.TelefoneLeitor = DAOHelper.GetString(reader, "telefone_lei");
                    leitor._sexo = DAOHelper.GetString(reader, "sexo_lei");
                    leitor.DataNascimentoLeitor = DAOHelper.GetDateTime(reader, "data_nasc_lei");

                    lista.Add(leitor);

                }
                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Leitor t)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "DELETE FROM Leitor WHERE id_lei = @id";

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
