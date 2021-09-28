using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class ClientesListar : Form
    {
        public int idCliente;

        public string nome;
        public ClientesListar()
        {
            InitializeComponent();
        }

        private void ClientesListar_Load(object sender, EventArgs e)
        {
            Lista();
        }

        //Cria uma lista do tipo "Cliente" para servirem como source para
        //a data grid

        public void Lista()
        {
            string filePath = "clientes.txt";

            List<string> linhas = new List<string>();

            List<Cliente> clientes = new List<Cliente>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                Cliente registo = new Cliente();

                int i = 0;

                string[] atributos = linha.Split(';');

                foreach (var atributo in atributos)
                {
                    i++;

                    switch (i)
                    {
                        case 1:
                            registo.Id = Convert.ToInt32(atributo);
                            break;
                        case 2:
                            registo.Nome = atributo;
                            break;
                        case 3:
                            registo.Morada = atributo;
                            break;
                        case 4:
                            registo.Telemovel = atributo;
                            break;
                        case 5:
                            registo.Email = atributo;
                            break;
                    }
                }

                clientes.Add(registo);

            }

            dataGridView1.DataSource = clientes;
        }

        //Torna visíveis os dados possíveis de editar do cliente selecionado e transforma 
        //a variável idCliente no id do cliente que foi selecionado pelo user

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_morada.Visible = true;
            lbl_email.Visible = true;
            lbl_telemovel.Visible = true;
            tb_morada.Visible = true;
            tb_email.Visible = true;
            tb_telemovel.Visible = true;

            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            idCliente = Convert.ToInt32(row.Cells[0].Value);
            nome = row.Cells[1].Value.ToString();
            tb_morada.Text = row.Cells[2].Value.ToString();
            tb_email.Text = row.Cells[4].Value.ToString();
            tb_telemovel.Text = row.Cells[3].Value.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(tb_morada.Text) || string.IsNullOrEmpty(tb_telemovel.Text) || string.IsNullOrEmpty(tb_email.Text))
                {
                    MessageBox.Show("Tem de inserir todo os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ListaClientes.EditarCliente(idCliente, nome, tb_morada.Text, tb_telemovel.Text, tb_email.Text);

                    tb_morada.Text = "";
                    tb_telemovel.Text = "";
                    tb_email.Text = "";

                    MessageBox.Show("Dados editados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao editar o conteúdo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Apaga o cliente do ficheiro .txt cujo id iguala a variável idAnimal

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "clientes.txt";

                string[] linhas = File.ReadAllLines(filePath);

                for (int i = 0; i < linhas.Length; i++)
                {
                    if (linhas[i].StartsWith(idCliente.ToString()) == true)
                    {
                        linhas[i] = null;
                        linhas = linhas.Where(x => x != linhas[i]).ToArray();
                    }
                }

                File.WriteAllLines(filePath, linhas);

                tb_morada.Text = "";
                tb_telemovel.Text = "";
                tb_email.Text = "";

                MessageBox.Show("Dados apagados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar o conteúdo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
