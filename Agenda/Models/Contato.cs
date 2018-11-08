using System;
using MySql.Data.MySqlClient;

namespace Agenda.Models
{
    class Contato : DB
    {
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

    }
}
