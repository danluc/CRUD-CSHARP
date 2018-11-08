using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Agenda.Models
{
    class Contato : DB
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        MySqlCommand comando = null;

        /** Metodo Salvar */
        public void salvar(Contato contato)
        {
            try
            {
                openDB();
                comando = new MySqlCommand("INSERT INTO contatos (nome, telefone, celular) VALUES (@nome,@telefone, @celular)", conexao);
                comando.Parameters.AddWithValue("@nome", contato.Nome);
                comando.Parameters.AddWithValue("@telefone", contato.Telefone);
                comando.Parameters.AddWithValue("@celular", contato.Celular);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeDB();
            }
        }

        /** Listar Contatos */
        public DataTable listar()
        {
            try
            {
                openDB();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT * FROM contatos ORDER BY nome", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                closeDB();
            }
        }

        /** Metodo Editar */
        public void editar(Contato contato)
        {
            try
            {
                openDB();
                comando = new MySqlCommand("UPDATE contatos SET nome = @nome, telefone = @telefone, celular = @celular WHERE id = @id", conexao);
                comando.Parameters.AddWithValue("@id", contato.Id);
                comando.Parameters.AddWithValue("@nome", contato.Nome);
                comando.Parameters.AddWithValue("@telefone", contato.Telefone);
                comando.Parameters.AddWithValue("@celular", contato.Celular);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                closeDB();
            }
        }

    }
}
