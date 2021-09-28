using System;
using System.IO;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class Medicos : Form
    {
        private Form activeForm;

        public Medicos()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            subform(new Forms.MedicosInserir());
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            if (File.Exists("medicos.txt"))
            {
                subform(new Forms.MedicosListar());
            }
            else
            {
                MessageBox.Show("Não tem nenhum médico/a inserido/a!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
