using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class AnimaisInserir : Form
    {
        public int id, idDono;

        public string emailDono;

        public AnimaisInserir()
        {
            InitializeComponent();
        }

        //Carrega todos os clientes possíveis que o animal pode ter

        private void AnimaisInserir_Load(object sender, EventArgs e)
        {
            string filePath = "clientes.txt";

            List<string> linhas = new List<string>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                string[] atributos = linha.Split(';');

                cb_dono.Items.Add(atributos[1]);
            }
        }

        private void btn_inserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_raca.Text) || cb_dono.SelectedItem == null)
                {
                    MessageBox.Show("Tem de inserir todo os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    setId();

                    ListaAnimais.SaveAnimais(id, tb_nome.Text, dateTimePicker1.Value.ToShortDateString(), tb_raca.Text,
                        idDono, cb_dono.SelectedItem.ToString(), emailDono);

                    MessageBox.Show("Dados gravados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_nome.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
                    tb_raca.Text = "";
                    cb_dono.ResetText();
                }

                
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao gravar dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Consoante o dono escolhido é guardado o id e email do mesmo para serem utilizados posteriormente
        //no registo e durante as marcações

        private void cb_dono_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = "clientes.txt";

            List<string> linhas = new List<string>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                string[] atributos = linha.Split(';');

                if (atributos[1] == cb_dono.SelectedItem.ToString())
                {
                    idDono = Convert.ToInt32(atributos[0]);
                    emailDono = atributos[4];
                    break;
                }
            }
        }

        private void setId()
        {
            string file = "animais.txt";

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
