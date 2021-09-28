using System;
using System.IO;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class ClientesInserir : Form
    {

        public int id;

        public ClientesInserir()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_morada.Text) || string.IsNullOrEmpty(tb_telemovel.Text) || string.IsNullOrEmpty(tb_email.Text))
                {
                    MessageBox.Show("Tem de inserir todo os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    setId();

                    ListaClientes.SaveCliente(id, tb_nome.Text, tb_morada.Text, tb_telemovel.Text, tb_email.Text);

                    MessageBox.Show("Dados gravados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_nome.Text = "";
                    tb_morada.Text = "";
                    tb_telemovel.Text = "";
                    tb_email.Text = "";
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao gravar dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void setId()
        {
            string file = "clientes.txt";

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
