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
    internal class LivroDAO
    {

        private static Conexao _conn = new Conexao();

        public void Insert(Livro livro)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Livro VALUES " +
                "(null, @codigo_livro, @titulo, @sinopse, @localizao, @data_publicacao, @edicao);";

                comando.Parameters.AddWithValue("@codigo_livro", livro.CodigoLivro);
                comando.Parameters.AddWithValue("@titulo", livro.TituloLivro);
                comando.Parameters.AddWithValue("@sinopse", livro.SinopseLivro);
                comando.Parameters.AddWithValue("@localizao", livro.LocalizaoLivro);
                comando.Parameters.AddWithValue("@data_publicacao", livro.DataPublicacaoLivro?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@edicao", livro.Edicao);

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

        public List<Livro> List()
        {
            try
            {
                var lista = new List<Livro>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Livro";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var livro = new Livro();

                    livro.Id = reader.GetInt32("id_liv");
                    livro.CodigoLivro = DAOHelper.GetString(reader, "codigo_liv");
                    livro.TituloLivro = DAOHelper.GetString(reader, "titulo_liv");
                    livro.SinopseLivro = DAOHelper.GetString(reader, "sinopse_liv");
                    livro.LocalizaoLivro = DAOHelper.GetString(reader, "localizacao_liv");
                    livro.DataPublicacaoLivro = DAOHelper.GetDateTime(reader, "data_publicacao_liv");
                    livro.Edicao = DAOHelper.GetString(reader, "edicao_liv");

                    lista.Add(livro);

                }
                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Livro t)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "DELETE FROM Livro WHERE id_liv = @id";

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
