using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{

    public partial class ConsultasListar : Form
    {
        public string especializacao, nomeAnimal, nomeCliente, emailCliente, nomeMedico, sala;

        public int idMarcacao, idAnimal, idCliente, idMedico;

        public ConsultasListar()
        {
            InitializeComponent();
        }

        private void ConsultasListar_Load(object sender, EventArgs e)
        {
            Lista();
        }

        //Cria uma lista do tipo "Marcacao" para servirem como source para
        //a data grid

        public void Lista()
        {
            string filePath = "marcacoes.txt";

            List<string> linhas = new List<string>();

            List<Marcacao> marcacoes = new List<Marcacao>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                Marcacao registo = new Marcacao();

                int i = 0;

                string[] atributos = linha.Split(';');

                foreach (var atributo in atributos)
                {
                    i++;

                    switch (i)
                    {
                        case 1:
                            registo.idConsulta = Convert.ToInt32(atributo);
                            break;
                        case 2:
                            registo.especialidade = atributo;
                            break;
                        case 3:
                            registo.idAnimal = Convert.ToInt32(atributo);
                            break;
                        case 4:
                            registo.nomeAnimal = atributo;
                            break;
                        case 5:
                            registo.idCliente = Convert.ToInt32(atributo);
                            break;
                        case 6:
                            registo.nomeCliente = atributo;
                            break;
                        case 7:
                            registo.emailCliente = atributo;
                            break;
                        case 8:
                            registo.idMedico = Convert.ToInt32(atributo);
                            break;
                        case 9:
                            registo.nomeMedico = atributo;
                            break;
                        case 10:
                            registo.data = atributo;
                            break;
                        case 11:
                            registo.horas = atributo;
                            break;
                        case 12:
                            registo.minutos = atributo;
                            break;
                        case 13:
                            registo.sala = atributo;
                            break;
                    }
                }

                marcacoes.Add(registo);
            }

            dataGridView1.DataSource = marcacoes;
        }

        //Torna visíveis os dados possíveis de editar da consulta selecionada e guarda
        //os ids nas respetivas variáveis

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_data.Visible = true;
            lbl_horas.Visible = true;
            dateTimePicker1.Visible = true;
            cb_horas.Visible = true;
            cb_minutos.Visible = true;
            label1.Visible = true;

            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            cb_horas.SelectedItem = row.Cells[10].Value.ToString();
            cb_minutos.SelectedItem = row.Cells[11].Value.ToString();
            idMarcacao = Convert.ToInt32(row.Cells[0].Value);
            especializacao = row.Cells[1].Value.ToString();
            idAnimal = Convert.ToInt32(row.Cells[2].Value);
            nomeAnimal = row.Cells[3].Value.ToString();
            idCliente = Convert.ToInt32(row.Cells[4].Value);
            nomeCliente = row.Cells[5].Value.ToString();
            emailCliente = row.Cells[6].Value.ToString();
            idMedico = Convert.ToInt32(row.Cells[7].Value);
            nomeMedico = row.Cells[8].Value.ToString();
            sala = row.Cells[12].Value.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_horas.SelectedItem == null || cb_minutos.SelectedItem == null)
                {
                    MessageBox.Show("Tem de inserir todos os dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ListaMarcacoes.EditarMarcacao(idMarcacao, especializacao, idAnimal, nomeAnimal, idCliente, nomeCliente,
                    emailCliente, idMedico, nomeMedico, dateTimePicker1.Value.ToString("yyyy,MM,dd"), cb_horas.SelectedItem.ToString(),
                    cb_minutos.SelectedItem.ToString(), sala);

                    dateTimePicker1.Value = DateTime.Today;
                    cb_horas.ResetText();
                    cb_minutos.ResetText();

                    MessageBox.Show("Dados editados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao editar o conteúdo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Apaga a consulta do ficheiro .txt cujo id iguala a variável idMarcacao

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "marcacoes.txt";

                string[] linhas = File.ReadAllLines(filePath);

                for (int i = 0; i < linhas.Length; i++)
                {
                    if (linhas[i].StartsWith(idMarcacao.ToString()) == true)
                    {
                        linhas[i] = null;
                        linhas = linhas.Where(x => x != linhas[i]).ToArray();
                    }
                }

                File.WriteAllLines(filePath, linhas);

                dateTimePicker1.Value = DateTime.Today;
                cb_horas.ResetText();
                cb_minutos.ResetText();

                MessageBox.Show("Dados apagados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar o conteúdo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
