using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace clinicaVeterinaria
{
    public class ListaClientes
    {

        public static List<Cliente> clientes = new List<Cliente>();

        public static string file = "clientes.txt";

        //Grava um cliente com os atributos cedidos no ficheiro clientes.txt

        public static void SaveCliente(int id, string nome, string morada, string telemovel, string email)
        {
            Cliente registo = new Cliente();

            registo.Id = id;
            registo.Nome = nome;
            registo.Morada = morada;
            registo.Telemovel = telemovel;
            registo.Email = email;

            clientes.Add(registo);

            StreamWriter sw = new StreamWriter(file, true, Encoding.UTF8);

            if (!File.Exists(file))
            {
                sw = File.CreateText(file);
            }

            sw.WriteLine($"{registo.Id};{registo.Nome};{registo.Morada};{registo.Telemovel};{registo.Email}");

            sw.Dispose();
        }

        //Substitiu a linha por um cliente com os novos atributos cedidos

        public static void EditarCliente(int idCliente, string nomeCliente, string morada, string telemovel, string email)
        {
            string filePath = "clientes.txt";

            string[] linhas = File.ReadAllLines(filePath);

            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].StartsWith(idCliente.ToString()))
                {
                    linhas[i] = $"{idCliente.ToString()};{nomeCliente};{morada};{telemovel};{email}";
                }
            }

            File.WriteAllLines(filePath, linhas);
        }

       

        
    }
}
