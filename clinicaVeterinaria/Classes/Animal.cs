using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaVeterinaria
{
    public class Animal
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string dataNascimento { get; set; }

        public string raca { get; set; }

        public int idDono { get; set; }

        public string nomeDono { get; set; }

        public string emailDono { get; set; }


    }
}
