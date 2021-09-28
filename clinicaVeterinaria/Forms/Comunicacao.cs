using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class Comunicacao : Form
    {

        private Form activeForm;

        public Comunicacao()
        {
            InitializeComponent();
        }

        private void btn_horario_Click(object sender, EventArgs e)
        {
            if (File.Exists("clientes.txt"))
            {
                subform(new Forms.ComunicacaoHorario());
            }
            else
            {
                MessageBox.Show("Não tem nenhum cliente inserido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (File.Exists("medicos.txt"))
            {
                if (File.Exists("marcacoes.txt")){
                    subform(new Forms.ComunicacaoCancelar());
                }
                else
                {
                    MessageBox.Show("Não tem nenhuma marcação para cancelar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não tem nenhum médico inserido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
