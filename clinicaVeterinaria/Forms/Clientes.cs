using System;
using System.IO;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class Clientes : Form
    {
        private Form activeForm;

        public Clientes()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            subform(new Forms.ClientesInserir());
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            if (File.Exists("clientes.txt"))
            {
                subform(new Forms.ClientesListar());
            }
            else
            {
                MessageBox.Show("Não tem nenhum cliente inserido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subform(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(childForm);
            this.panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
