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
    internal class AutorDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Autor autor)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Autor VALUES " +
                "(null, @nome_autor, @nacionalidade, @email, @sexo, @contato, @data_nasc_autor);";

                comando.Parameters.AddWithValue("@nome_autor", autor.NomeAutor);
                comando.Parameters.AddWithValue("@nacionalidade", autor.NacionalidadeAutor);
                comando.Parameters.AddWithValue("@email", autor.EmailAutor);
                comando.Parameters.AddWithValue("@sexo", autor.SexoAutor);
                comando.Parameters.AddWithValue("@contato", autor.ContatoAutor);
                comando.Parameters.AddWithValue("@data_nasc_autor", autor.DataNascimentoAutor?.ToString("yyyy-MM-dd"));


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

        public List<Autor> List()
        {
            try
            {
                var lista = new List<Autor>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Autor";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var autor = new Autor();

                    autor.Id = reader.GetInt32("id_aut");
                    autor.NomeAutor = DAOHelper.GetString(reader, "nome_aut");
                    autor.NacionalidadeAutor = DAOHelper.GetString(reader, "nacionalidade_aut");
                    autor.EmailAutor = DAOHelper.GetString(reader, "email_aut");
                    autor._sexo = DAOHelper.GetString(reader, "sexo_aut");
                    autor.ContatoAutor = DAOHelper.GetString(reader, "contato_aut");
                    autor.DataNascimentoAutor = DAOHelper.GetDateTime(reader, "data_nasc_aut");
                    
                    

                    lista.Add(autor);

                }
                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Autor t)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "DELETE FROM Autor WHERE id_aut = @id";

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
