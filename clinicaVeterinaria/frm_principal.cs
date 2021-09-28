using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace clinicaVeterinaria
{
    public partial class frm_principal : Form
    {
        private Form activeForm;

        public DateTime today = new DateTime();

        public int login = 0;

        //login: joao pires
        //password: cinel

        private void frm_principal_Load(object sender, EventArgs e)
        {
            timer1.Start();

            lbl_versao.Text = "PetClinic Pro v1.3 por João Pires - " + DateTime.Today.ToShortDateString();
        }

        public frm_principal()
        {
            InitializeComponent();
        }

        //Se o login tiver sido feito a variável login tem o valor 1 e é criado um 
        //"subform" dentro do panelPrincipal do Form principal de acordo com o botão pressionado.

        private void buttonAnimais_Click_1(object sender, EventArgs e)
        {
            if(login == 1)
            {
                resetCorBotoes();
                buttonClientes.BackColor = Color.FromArgb(108, 196, 176);

                subform(new Forms.Clientes());
            }
            else
            {
                MessageBox.Show("Tem de efetuar primeiro o Login!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            if(login == 1)
            {
                resetCorBotoes();
                buttonAnimais.BackColor = Color.FromArgb(108, 196, 176);

                subform(new Forms.Animais());
            }
            else
            {
                MessageBox.Show("Tem de efetuar primeiro o Login!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonMedicos_Click(object sender, EventArgs e)
        {
            if(login == 1)
            {
                resetCorBotoes();
                buttonMedicos.BackColor = Color.FromArgb(108, 196, 176);

                subform(new Forms.Medicos());
            }
            else
            {
                MessageBox.Show("Tem de efetuar primeiro o Login!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            if(login == 1)
            {
                resetCorBotoes();
                buttonConsultas.BackColor = Color.FromArgb(108, 196, 176);

                subform(new Forms.Consultas());
            }
            else
            {
                MessageBox.Show("Tem de efetuar primeiro o Login!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonComunicacao_Click(object sender, EventArgs e)
        {
            if (login == 1)
            {
                resetCorBotoes();
                buttonComunicacao.BackColor = Color.FromArgb(108, 196, 176);

                subform(new Forms.Comunicacao());
            }
            else
            {
                MessageBox.Show("Tem de efetuar primeiro o Login!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Clique de botão para fechar qualquer subform e retornar ao Home

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                resetCorBotoes();
            }

            lbl_home.Text = "Home";
            buttonClose.Visible = false;
        }

        public void resetCorBotoes()
        {
            buttonClientes.BackColor = Color.FromArgb(46, 82, 140);
            buttonAnimais.BackColor = Color.FromArgb(46, 82, 140);
            buttonMedicos.BackColor = Color.FromArgb(46, 82, 140);
            buttonConsultas.BackColor = Color.FromArgb(46, 82, 140);
            buttonComunicacao.BackColor = Color.FromArgb(46, 82, 140);
        }

        // Cria um "subform" dentro do panel panelPrincipal utilizando um Form existente

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
            lbl_home.Text = childForm.Text;
            buttonClose.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_relogio.Text = DateTime.Now.ToString("T");

            Avisa();
        }

        //Método que avisa um cliente por email caso a sua consulta for no dia seguinte e cria um
        //ficheiro de prenvenção cujo nome é a data do dia em que o aviso é enviado e apaga
        //o ficheiro com o nome do dia anterior. O ficheiro corre uma vez por dia e, embora seja chamado a cada tick
        //do relógio apenas corre por completo se o ficheiro de prevenção não existir.

        private void Avisa()
        {
            string filePath = "marcacoes.txt";

            today = DateTime.Today;

            string fileSafety = today.ToString("yyyyMMdd") + ".txt";

            string fileDelete = today.AddDays(-1).ToString("yyyyMMdd") + ".txt";

            if (File.Exists(filePath))
            {
                if (!File.Exists(fileSafety))
                {
                    List<string> linhas = new List<string>();

                    linhas = File.ReadAllLines(filePath).ToList();

                    foreach (string linha in linhas)
                    {
                        string[] atributos = linha.Split(';');

                        string[] datas = atributos[9].Split(',');

                        int ano = Convert.ToInt32(datas[0]);

                        int mes = Convert.ToInt32(datas[1]);

                        int dia = Convert.ToInt32(datas[2]);

                        DateTime dataConsulta = new DateTime(ano, mes, dia);

                        if ((dataConsulta - today).Days <= 1 && (dataConsulta != today))
                            ListaEmails(atributos[6], atributos[1], atributos[3], atributos[10], atributos[11], atributos[12]);
                    }

                    StreamWriter sw = new StreamWriter(fileSafety, true, Encoding.UTF8);

                    if (File.Exists(fileDelete))
                        File.Delete(fileDelete);

                    sw.Dispose();
                }
            }
        }

        //Método que envia o email dinâmico para o cliente.

        private void ListaEmails(string email, string especialidade, string animal, string horas, string minutos, string sala)
        {
            var smtpClient = new SmtpClient("smtp.office365.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("joao.luis.pires@formandos.cinel.pt", "Skateandcreate02"),
                EnableSsl = true,
            };

            smtpClient.Send("joao.luis.pires@formandos.cinel.pt", email, "Consulta!",
                $"Não se esqueça da consulta amanhã de {especialidade} do/a {animal} pelas {horas}:{minutos}," +
                $" na sala {sala}.");
        }

        //Método que encripta a string do user e password para poderem ser comparados com o user
        //e password encriptados no ficheiro existente

        public string EncryptString(string Message)
        {
            string Passphrase = "cet58";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            //MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            SHA256CryptoServiceProvider HashProvider = new SHA256CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            AesCryptoServiceProvider TDESAlgorithm = new AesCryptoServiceProvider();
            //TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Step 6. Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 7. Return the encrypted string as a base64 encoded string
            string result = Convert.ToBase64String(Results);
            Console.WriteLine(result.Length);

            return result;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string filePath = "login.txt";

            string[] user = File.ReadAllLines(filePath);

            if(EncryptString(tb_username.Text) == user[0] && EncryptString(tb_password.Text) == user[1])
            {
                login = 1;

                lbl_login.Visible = true;

                btn_logout.Visible = true;

                lbl_user.Visible = false;
                lbl_password.Visible = false;
                lbl_conteudos.Visible = true;
                tb_username.Visible = false;
                tb_password.Visible = false;

                btn_login.Visible = false;

                tb_username.Text = "";
                tb_password.Text = "";
            }
            else
            {
                MessageBox.Show("Utilizador ou palavra-passe errados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login = 0;

            btn_logout.Visible = false;
            btn_login.Visible = true;
            tb_username.Visible = true;
            tb_password.Visible = true;
            lbl_user.Visible = true;
            lbl_password.Visible = true;
            lbl_conteudos.Visible = false;
            lbl_login.Visible = false;
        }
    }
}
