using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaVeterinaria
{
    public class ListaMarcacoes
    {
        public static List<Marcacao> marcacoes = new List<Marcacao>();

        public static string file = "marcacoes.txt";

        //Grava uma marcação com os atributos cedidos no ficheiro marcações.txt

        public static void SaveMarcacao(int id, string especializacao, 
            int idAnimal, string nomeAnimal, int idCliente, string nomeCliente,
            string emailCliente, int idMedico, string nomeMedico, string data, string horas,
            string minutos, string sala)
        {
            Marcacao registo = new Marcacao();

            registo.idConsulta = id;
            registo.especialidade = especializacao;
            registo.idAnimal = idAnimal;
            registo.nomeAnimal = nomeAnimal;
            registo.idCliente = idCliente;
            registo.nomeCliente = nomeCliente;
            registo.emailCliente = emailCliente;
            registo.idMedico = idMedico;
            registo.nomeMedico = nomeMedico;
            registo.data = data;
            registo.horas = horas;
            registo.minutos = minutos;
            registo.sala = sala;

            marcacoes.Add(registo);

            StreamWriter sw = new StreamWriter(file, true, Encoding.UTF8);

            if (!File.Exists(file))
            {
                sw = File.CreateText(file);
            }

            sw.WriteLine($"{registo.idConsulta};{registo.especialidade};{registo.idAnimal};" +
                $"{registo.nomeAnimal};{registo.idCliente};{registo.nomeCliente};{registo.emailCliente};" +
                $"{registo.idMedico};{registo.nomeMedico};{registo.data};{registo.horas};" +
                $"{registo.minutos};{registo.sala}");

            sw.Dispose();
        }

        //Substitiu a linha por uma marcação com os novos atributos cedidos

        public static void EditarMarcacao(int id, string especializacao,
            int idAnimal, string nomeAnimal, int idCliente, string nomeCliente,
            string emailCliente, int idMedico, string nomeMedico, string data, string horas,
            string minutos, string sala)
        {
            string filePath = "marcacoes.txt";

            string[] linhas = File.ReadAllLines(filePath);

            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].StartsWith(id.ToString()))
                {
                    linhas[i] = $"{id.ToString()};{especializacao};{idAnimal.ToString()};" +
                        $"{nomeAnimal};{idCliente.ToString()};{nomeCliente};{emailCliente};" +
                        $"{idMedico.ToString()};{nomeMedico};{data};{horas};{minutos};{sala}";
                }
            }

            File.WriteAllLines(filePath, linhas);
        }

    }
}
