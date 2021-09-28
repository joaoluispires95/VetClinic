using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaVeterinaria
{
    public class ListaAnimais
    {

        public static List<Animal> animais = new List<Animal>();

        public static string file = "animais.txt";

        public static void SaveAnimais(int id, string nome, string dataNascimento, string raca, int idDono, string nomeDono, string emailDono)
        {
            Animal registo = new Animal();

            registo.id = id;
            registo.nome = nome;
            registo.dataNascimento = dataNascimento;
            registo.raca = raca;
            registo.idDono = idDono;
            registo.nomeDono = nomeDono;
            registo.emailDono = emailDono;

            animais.Add(registo);

            StreamWriter sw = new StreamWriter(file, true, Encoding.UTF8);

            if (!File.Exists(file))
            {
                sw = File.CreateText(file);
            }

            sw.WriteLine($"{registo.id};{registo.nome};{registo.dataNascimento};{registo.raca};{registo.idDono};{registo.nomeDono};{registo.emailDono}");

            sw.Dispose();
        }
    }
}
