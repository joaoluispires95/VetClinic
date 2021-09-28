using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{

    public partial class ConsultasInserir : Form
    {

        public int idConsulta, idAnimal, idCliente, idMedico;

        public string emailCliente, sala;

        public ConsultasInserir()
        {
            InitializeComponent();
        }

        private void ConsultasInserir_Load(object sender, EventArgs e)
        {
            Insere("animais.txt", cb_animal);

        }

        //Coloca o cliente do animal selecionado visível e atribui os respetivos ids 
        //as variáveis

        private void cb_animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = "animais.txt";

            List<string> linhas = new List<string>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                string[] atributos = linha.Split(';');

                if (atributos[1] == cb_animal.SelectedItem.ToString())
                {
                    idAnimal = Convert.ToInt32(atributos[0]);
                    idCliente = Convert.ToInt32(atributos[4]);
                    tb_cliente.Text = atributos[5];
                    emailCliente = atributos[6];
                    break;
                }
            }
        }

        //Consoante a seleção do médico guarda em variáveis a sua sala e id

        private void cb_medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = "medicos.txt";

            List<string> linhas = new List<string>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                string[] atributos = linha.Split(';');

                if (atributos[1] == cb_medico.SelectedItem.ToString())
                {
                    idMedico = Convert.ToInt32(atributos[0]);
                    sala = atributos[3];

                    break;
                }
            }
        }

        //Faz load de todos os médicos que pertecem especificamente a especialidade escolhida

        private void cb_especialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_medico.Items.Clear();

            string filePath = "medicos.txt";

            List<string> linhas = new List<string>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                string[] atributos = linha.Split(';');

                if (atributos[2] == cb_especialidade.SelectedItem.ToString())
                {
                    cb_medico.Items.Add(atributos[1]);
                }
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_especialidade.SelectedItem == null || cb_animal.SelectedItem == null || cb_medico.SelectedItem == null
                    || cb_horas.SelectedItem == null || cb_minutos.SelectedItem == null)
                {
                    MessageBox.Show("Tem de inserir todo os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    setId();

                    ListaMarcacoes.SaveMarcacao(idConsulta, cb_especialidade.SelectedItem.ToString(),
                        idAnimal, cb_animal.SelectedItem.ToString(), idCliente, tb_cliente.Text,
                        emailCliente, idMedico, cb_medico.SelectedItem.ToString(), dateTimePicker1.Value.ToString("yyyy,MM,dd"),
                        cb_horas.SelectedItem.ToString(), cb_minutos.SelectedItem.ToString(), sala);

                    MessageBox.Show("Dados gravados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cb_especialidade.ResetText();
                    cb_animal.ResetText();
                    tb_cliente.Text = "";
                    cb_medico.ResetText();
                    dateTimePicker1.Value = DateTime.Today;
                    cb_horas.ResetText();
                    cb_minutos.ResetText();
                }
                

            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao gravar dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Utilizado para inserir no load do form todos os animais existentes na sua respetiva combo box

        public void Insere(string filePath, ComboBox cb)
        {
            List<string> linhas = new List<string>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                string[] atributos = linha.Split(';');

                cb.Items.Add(atributos[1]);
            }
        }

        private void setId()
        {
            string file = "marcacoes.txt";

            if (!File.Exists(file))
            {
                idConsulta = 1;
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

                idConsulta = lineCount + 1;
            }
        }
    }
}
