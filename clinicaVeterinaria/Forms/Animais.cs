using System;
using System.IO;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class Animais : Form
    {
        private Form activeForm;

        public Animais()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (File.Exists("clientes.txt"))
            {
                subform(new Forms.AnimaisInserir());
            }
            else
            {
                MessageBox.Show("Tem de inserir primeiro o dono deste animal!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            if (File.Exists("animais.txt"))
            {
                subform(new Forms.AnimaisListar());
            }
            else
            {
                MessageBox.Show("Não tem nenhum animal inserido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
