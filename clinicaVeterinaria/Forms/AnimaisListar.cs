using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace clinicaVeterinaria.Forms
{
    public partial class AnimaisListar : Form
    {
        public int idAnimal;

        public AnimaisListar()
        {
            InitializeComponent();
        }

        private void AnimaisListar_Load(object sender, EventArgs e)
        {
            Lista();
        }

        //Cria uma lista do tipo "Animal" para servirem como source para
        //a data grid

        public void Lista()
        {
            string filePath = "animais.txt";

            List<string> linhas = new List<string>();

            List<Animal> animais = new List<Animal>();

            linhas = File.ReadAllLines(filePath).ToList();

            foreach (string linha in linhas)
            {
                Animal registo = new Animal();

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
                            registo.dataNascimento = atributo;
                            break;
                        case 4:
                            registo.raca = atributo;
                            break;
                        case 5:
                            registo.idDono = Convert.ToInt32(atributo);
                            break;
                        case 6:
                            registo.nomeDono = atributo;
                            break;
                        case 7:
                            registo.emailDono = atributo;
                            break;
                    }
                }

                animais.Add(registo);
            }

            dataGridView1.DataSource = animais;
        }

        //Transforma a variável idAnimal no id do animal que foi selecionado pelo user

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            idAnimal = Convert.ToInt32(row.Cells[0].Value);
        }

        //Apaga o animal do ficheiro .txt cujo id iguala a variável idAnimal

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {

                string filePath = "animais.txt";

                string[] linhas = File.ReadAllLines(filePath);

                for (int i = 0; i < linhas.Length; i++)
                {
                    if (linhas[i].StartsWith(idAnimal.ToString()) == true)
                    {
                        linhas[i] = null;
                        linhas = linhas.Where(x => x != linhas[i]).ToArray();
                    }
                }

                File.WriteAllLines(filePath, linhas);

                MessageBox.Show("Dados apagados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar o conteúdo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
