using System;
using System.IO;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class MedicosInserir : Form
    {
        public int id;

        public MedicosInserir()
        {
            InitializeComponent();
        }

        //Cada especialização tem as suas salas específicas. Como se diferentes
        //salas tivessem equipamentos e recursos diferentes. Ao selecionar a especialização
        //são carregadas diferentes salas

        private void cb_especializacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_sala.Items.Clear();

            switch (cb_especializacao.SelectedIndex)
            {
                case 0:
                    cb_sala.Items.Add("1");
                    cb_sala.Items.Add("2");
                    break;
                case 1:
                    cb_sala.Items.Add("3");
                    cb_sala.Items.Add("4");
                    break;
                case 2:
                    cb_sala.Items.Add("5");
                    cb_sala.Items.Add("6");
                    break;
                case 3:
                    cb_sala.Items.Add("7");
                    cb_sala.Items.Add("8");
                    break;
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tb_nome.Text) || cb_especializacao.SelectedItem == null || cb_sala.SelectedItem == null)
                {
                    MessageBox.Show("Tem de inserir todo os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    setId();

                    ListaMedicos.SaveMedico(id, tb_nome.Text, cb_especializacao.SelectedItem.ToString(), cb_sala.SelectedItem.ToString());

                    MessageBox.Show("Dados gravados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_nome.Text = "";

                    cb_especializacao.ResetText();

                    cb_sala.ResetText();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao gravar dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void setId()
        {
            string file = "medicos.txt";

            if (!File.Exists(file))
            {
                id = 1;
            }
            else
            {
                var lineCount = 0;

                using (var reader = File.OpenText(file))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }

                id = lineCount + 1;
            }
        }
    }
}
