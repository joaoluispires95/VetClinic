using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class ComunicacaoCancelar : Form
    {
        public ComunicacaoCancelar()
        {
            InitializeComponent();
        }

        //Faz o carregamento de todos os médicos para a respetiva combo box

        private void ComunicacaoCancelar_Load(object sender, EventArgs e)
        {
            string filePath = "medicos.txt";

            List<string> linhas = new List<string>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                string[] atributos = linha.Split(';');

                cb_medicos.Items.Add(atributos[1]);
            }
        }

        //Caso um cliente possua uma marcação com o médico selecionado no
        //dia selecionado, é chamado o método EnviaEmail e ApagarMarcacao
        //e são passados os dados do/s cliente/s em questão

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_medicos.SelectedItem == null)
                {
                    MessageBox.Show("Tem de inserir todos os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string filePath = "marcacoes.txt";

                    List<string> linhas = new List<string>();

                    linhas = File.ReadAllLines(filePath).ToList();

                    foreach (string linha in linhas)
                    {
                        string[] atributos = linha.Split(';');

                        if (dateTimePicker1.Value.ToString("yyyy,MM,dd") == atributos[9] && cb_medicos.SelectedItem.ToString() == atributos[8])
                        {
                            EnviaEmail(atributos[6], atributos[8]);

                            ApagaMarcacao(dateTimePicker1.Value.ToString("yyyy,MM,dd"), cb_medicos.SelectedItem.ToString());
                        }
                    }

                    MessageBox.Show("Email/s enviado/s com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cb_medicos.ResetText();
                    dateTimePicker1.Value = DateTime.Today;


                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao enviar email/s!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Envia um email dinâmico ao/s cliente/s a informar o cancelamento da marcação

        private void EnviaEmail(string email, string medico)
        {
            var smtpClient = new SmtpClient("smtp.office365.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("joao.luis.pires@formandos.cinel.pt", "Skateandcreate02"),
                EnableSsl = true,
            };

            smtpClient.Send("joao.luis.pires@formandos.cinel.pt", email, "Aviso!",
                $"Caro cliente, informamos que a sua consulta com o/a Dr/a.{medico}, marcada para dia: " +
                $"{dateTimePicker1.Value.ToString("dd/MM/yyyy")}, foi cancelada.");
        }

        //Apaga todas as marcações do médico selecionado no dia selecionado do ficheiro .txt

        private void ApagaMarcacao(string data, string nome)
        {
            string filePath = "marcacoes.txt";

            string[] linhas = File.ReadAllLines(filePath);

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] arrayAux = linhas[i].Split(';');

                if(arrayAux[9] == data && arrayAux[8] == nome)
                {
                    linhas[i] = null;
                    linhas = linhas.Where(x => x != linhas[i]).ToArray();
                }
            }

            File.WriteAllLines(filePath, linhas);
        }
    }
}
