using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class ComunicacaoHorario : Form
    {
        public string texto, mensagemAdicional = "";

        public ComunicacaoHorario()
        {
            InitializeComponent();
        }

        private void cb_motivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_motivo.SelectedItem.ToString() == "Abertura tardia" ||
                cb_motivo.SelectedItem.ToString() == "Fecho antecipado")
            {
                cb_horas.Enabled = true;
                cb_minutos.Enabled = true;
            }
            else
            {
                cb_horas.Enabled = false;
                cb_minutos.Enabled = false;
            }
        }

        //É chamado o método EnviaEmail fornecendo-lhe a razão da comunicação
        //por cada cliente que existe. Todos os clientes são notificados.

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_motivo.SelectedItem == null)
                {
                    MessageBox.Show("Tem de inserir todos os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (tb_mensagemAdicional.Text != "Mensagem adicional (opcional)")
                        mensagemAdicional = tb_mensagemAdicional.Text;

                    switch (cb_motivo.SelectedItem.ToString())
                    {
                        case "Encerrado":
                            texto = "vai estar encerrada.";
                            break;
                        case "Abertura tardia":
                            texto = $"vai estar aberta apenas a partir das {cb_horas.SelectedItem.ToString()}:" +
                                $"{cb_minutos.SelectedItem.ToString()} horas.";
                            break;
                        case "Fecho antecipado":
                            texto = $"vai encerrar mais cedo por volta das {cb_horas.SelectedItem.ToString()}:" +
                                $"{cb_minutos.SelectedItem.ToString()} horas.";
                            break;
                    }

                    string filePath = "clientes.txt";

                    List<string> linhas = new List<string>();

                    linhas = File.ReadAllLines(filePath).ToList();

                    foreach (string linha in linhas)
                    {
                        string[] atributos = linha.Split(';');

                        EnviaEmail(atributos[4]);
                    }

                    MessageBox.Show("Email/s enviado/s com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cb_motivo.ResetText();
                    dateTimePicker1.Value = DateTime.Today;
                    cb_horas.ResetText();
                    cb_minutos.ResetText();
                    tb_mensagemAdicional.Text = "Mensagem adicional (opcional)";
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao enviar email/s!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Envia um email com a mensagem passada pretendida

        private void EnviaEmail(string email)
        {
            var smtpClient = new SmtpClient("smtp.office365.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("joao.luis.pires@formandos.cinel.pt", "Skateandcreate02"),
                EnableSsl = true,
            };

            smtpClient.Send("joao.luis.pires@formandos.cinel.pt", email, "Aviso!",
                $"Caro cliente, informamos que a nossa clínica durante o dia {dateTimePicker1.Value.ToShortDateString()} {texto}" +
                $" {mensagemAdicional}");
        }
    }
}
