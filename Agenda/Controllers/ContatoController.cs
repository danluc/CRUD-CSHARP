using System;
using Agenda.Models;

namespace Agenda.Controllers
{
    class ContatoController
    {
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
    }
}
