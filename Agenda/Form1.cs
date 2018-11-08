using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Models;
using Agenda.Controllers;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Salvar(Contato contato)
        {
            ContatoController c = new ContatoController();
            contato.Nome        = txtNome.Text;
            contato.Telefone    = mskTefone.Text;
            contato.Celular     = mskCelula.Text;

            c.Salvar(contato);
            MessageBox.Show("CONTATO SALVO.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            Salvar(contato);
        }
    }
}
