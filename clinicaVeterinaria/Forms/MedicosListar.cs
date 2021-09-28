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
    public partial class MedicosListar : Form
    {
        public int idMedico;

        public string nome, especializacao;

        public MedicosListar()
        {
            InitializeComponent();
        }

        private void MedicosListar_Load(object sender, EventArgs e)
        {
            Lista();
        }

        //Cria uma lista do tipo "Medico" para servirem como source para
        //a data grid

        public void Lista()
        {
            string filePath = "medicos.txt";

            List<string> linhas = new List<string>();

            List<Medico> clientes = new List<Medico>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                Medico registo = new Medico();

                int i = 0;

                string[] atributos = linha.Split(';');

                foreach (var atributo in atributos)
                {
                    i++;

                    switch (i)
                    {
                        case 1:
                            registo.id = Convert.ToInt32(atributo);
                            break;
                        case 2:
                            registo.nome = atributo;
                            break;
                        case 3:
                            registo.especializacao = atributo;
                            break;
                        case 4:
                            registo.sala = atributo;
                            break;
                    }
                }

                clientes.Add(registo);

            }

            dataGridView1.DataSource = clientes;
        }

        //Torna visíveis os dados possíveis de editar do médico selecionado e guarda os
        // respetivos valores nas variáveis

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_sala.Visible = true;
            tb_sala.Visible = true;

            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            idMedico = Convert.ToInt32(row.Cells[0].Value);
            nome = row.Cells[1].Value.ToString();
            especializacao = row.Cells[2].Value.ToString();
            tb_sala.Text = row.Cells[3].Value.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_sala.Text))
                {
                    MessageBox.Show("Tem de inserir todos os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ListaMedicos.EditarMedico(idMedico, nome, especializacao, tb_sala.Text);

                    tb_sala.Text = "";

                    MessageBox.Show("Dados editados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao editar o conteúdo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Apaga o médico do ficheiro .txt cujo id iguala a variável idMedico

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "medicos.txt";

                string[] linhas = File.ReadAllLines(filePath);

                for (int i = 0; i < linhas.Length; i++)
                {
                    if (linhas[i].StartsWith(idMedico.ToString()) == true)
                    {
                        linhas[i] = null;
                        linhas = linhas.Where(x => x != linhas[i]).ToArray();
                    }
                }

                File.WriteAllLines(filePath, linhas);

                tb_sala.Text = "";

                MessageBox.Show("Dados apagados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar o conteúdo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
