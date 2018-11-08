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
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            dt = contato.listar();
            return dt;
        }
        /** Editar */
        public void Editar(Contato c)
        {
            try
            {
                c.editar(c);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        /** Excluir */
        public void Excluir(Contato c)
        {
            try
            {
                c.excluir(c);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
