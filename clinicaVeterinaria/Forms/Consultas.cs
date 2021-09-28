using System;
using System.IO;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class Consultas : Form
    {
        private Form activeForm;

        public Consultas()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (File.Exists("clientes.txt"))
            {
                if (File.Exists("animais.txt"))
                {
                    if (File.Exists("medicos.txt"))
                    {
                        subform(new Forms.ConsultasInserir());
                    }
                    else
                    {
                        MessageBox.Show("Não tem nenhum médico/a inserido/a!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não tem nenhum animal inserido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não tem nenhum cliente inserido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            if (File.Exists("marcacoes.txt"))
            {
                subform(new Forms.ConsultasListar());
            }
            else
            {
                MessageBox.Show("Não tem nenhuma consulta inserida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Consultas_Load(object sender, EventArgs e)
        {

        }
    }
}
