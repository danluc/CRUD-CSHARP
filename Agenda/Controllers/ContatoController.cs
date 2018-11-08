using System;
using System.Data;
using Agenda.Models;

namespace Agenda.Controllers
{
    class ContatoController
    {
        Contato contato = new Contato();
        /** Salvar */
        public void Salvar(Contato c)
        {
            try
            {
                c.salvar(c);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        /** Listar */
        public DataTable listar()
        {
            DataTable dt = new DataTable();
            dt = contato.listar();
            return dt;
        }
    }
}
