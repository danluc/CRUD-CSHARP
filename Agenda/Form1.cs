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
            Listar();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCode.Clear();
            mskTelefone.Clear();
            mskCelula.Clear();
        }

        private void Salvar(Contato contato)
        {
            ContatoController c = new ContatoController();
            contato.Nome        = txtNome.Text;
            contato.Telefone    = mskTelefone.Text;
            contato.Celular     = mskCelula.Text;
            c.Salvar(contato);
            MessageBox.Show("CONTATO SALVO.");
            Listar();
            LimparCampos();

        }

        private void Listar()
        {
            ContatoController c = new ContatoController();
            dgDados.DataSource = c.Listar();
        }

        private void Editar(Contato contato)
        {
            ContatoController c = new ContatoController();
            contato.Id          = Convert.ToInt32(txtCode.Text);
            contato.Nome        = txtNome.Text;
            contato.Telefone    = mskTelefone.Text;
            contato.Celular     = mskCelula.Text;
            c.Editar(contato);
            MessageBox.Show("CONTATO SALVO.");
            Listar();
            LimparCampos();
        }

        private void Excluir(Contato contato)
        {
            ContatoController c = new ContatoController();
            contato.Id = Convert.ToInt32(txtCode.Text);
            c.Excluir(contato);
            MessageBox.Show("CONTATO DELETADO.");
            Listar();
            LimparCampos();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            Salvar(contato);
        }

        private void dgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text        = dgDados.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text        = dgDados.CurrentRow.Cells[1].Value.ToString();
            mskTelefone.Text    = dgDados.CurrentRow.Cells[2].Value.ToString();
            mskCelula.Text      = dgDados.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            Editar(contato);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            Excluir(contato);
        }
    }
}
