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
    internal class FuncionarioDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Funcionario funcionario)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Funcionario VALUES " +
                "(null, @nome_funcionario, @email, @cpf, @rg, @endereco, @telefone, @turno, @sexo, @data_nascimento);";

                comando.Parameters.AddWithValue("@nome_funcionario", funcionario.NomeFuncionario);
                comando.Parameters.AddWithValue("@email", funcionario.EmailFuncionario);
                comando.Parameters.AddWithValue("@cpf", funcionario.CpfFuncionario);
                comando.Parameters.AddWithValue("@rg", funcionario.RgFuncionario);
                comando.Parameters.AddWithValue("@endereco", funcionario.EnderecoFuncionario);
                //comando.Parameters.AddWithValue("@codigo_acesso", funcionario.CodigoAcesso);
                comando.Parameters.AddWithValue("@telefone", funcionario.TelefoneFuncionario);
                comando.Parameters.AddWithValue("@turno", funcionario.Turno);
                comando.Parameters.AddWithValue("@sexo", funcionario.SexoFuncinario);
                comando.Parameters.AddWithValue("@data_nascimento", funcionario.DataNascimentoFuncionario?.ToString("yyyy-MM-dd"));


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

        public List<Funcionario> List()
        {
            try
            {
                var lista = new List<Funcionario>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Funcionario";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var funcionario = new Funcionario();

                    funcionario.Id = reader.GetInt32("id_fun");
                    funcionario.NomeFuncionario = DAOHelper.GetString(reader, "nome_fun");
                    funcionario.EmailFuncionario = DAOHelper.GetString(reader, "email_fun");
                    funcionario.CpfFuncionario = DAOHelper.GetString(reader, "cpf_fun");
                    funcionario.RgFuncionario = DAOHelper.GetString(reader, "rg_fun");
                    funcionario.EnderecoFuncionario = DAOHelper.GetString(reader, "endereco_fun");
                    funcionario.TelefoneFuncionario = DAOHelper.GetString(reader, "telefone_fun");
                    funcionario.Turno = DAOHelper.GetString(reader, "turno_fun");
                    funcionario._sexo = DAOHelper.GetString(reader, "sexo_fun");
                    funcionario.DataNascimentoFuncionario = DAOHelper.GetDateTime(reader, "data_nasc_fun");

                    lista.Add(funcionario);

                }
                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Funcionario t)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "DELETE FROM Funcionario WHERE id_fun = @id";

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
