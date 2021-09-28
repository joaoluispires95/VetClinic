using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaVeterinaria
{
    public class ListaMedicos
    {
        public static List<Medico> medicos = new List<Medico>();

        public static string file = "medicos.txt";

        //Grava um médico com os atributos cedidos no ficheiro medicos.txt

        public static void SaveMedico(int id, string nome, string especializacao, string sala)
        {
            Medico registo = new Medico();

            registo.id = id;
            registo.nome = nome;
            registo.especializacao = especializacao;
            registo.sala = sala;

            medicos.Add(registo);

            StreamWriter sw = new StreamWriter(file, true, Encoding.UTF8);

            if (!File.Exists(file))
            {
                sw = File.CreateText(file);
            }

            sw.WriteLine($"{registo.id};{registo.nome};{registo.especializacao};{registo.sala}");

            sw.Dispose();
        }

        //Substitiu a linha por um médico com os novos atributos cedidos

        public static void EditarMedico(int idMedico, string nomeMedico, string especializacao, string sala)
        {
            string filePath = "medicos.txt";

            string[] linhas = File.ReadAllLines(filePath);

            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].StartsWith(idMedico.ToString()))
                {
                    linhas[i] = $"{idMedico};{nomeMedico};{especializacao};{sala}";
                }
            }

            File.WriteAllLines(filePath, linhas);
        }
    }
}
