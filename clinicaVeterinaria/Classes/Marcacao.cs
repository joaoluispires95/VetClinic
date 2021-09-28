using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaVeterinaria
{
    public class Marcacao
    {
        public int idConsulta { get; set; }

        public string especialidade { get; set; }

        public int idAnimal { get; set; }

        public string nomeAnimal { get; set; }

        public int idCliente { get; set; }

        public string nomeCliente { get; set; }

        public string emailCliente { get; set; }

        public int idMedico { get; set; }

        public string nomeMedico { get; set; }

        public string data { get; set; }

        public string horas { get; set; }

        public string minutos { get; set; }

        public string sala { get; set; }
    }
}
