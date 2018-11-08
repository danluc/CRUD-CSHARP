using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Agenda.Models
{
    class DB
    {
        string conectaDB = "SERVER=localhost; DATABASE=agenda; UID=root; PWD=;";
        protected MySqlConnection conexao = null;

        public void openDB()
        {
            try
            {
                conexao = new MySqlConnection(conectaDB);
                conexao.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void closeDB()
        {
            try
            {
                conexao = new MySqlConnection(conectaDB);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
