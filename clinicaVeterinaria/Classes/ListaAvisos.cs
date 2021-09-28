using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaVeterinaria.Classes
{
    class ListaAvisos
    {
        public static string ano = "2020";

        public static string mes = "11";

        public static string dia = "11";

        public static DateTime ola = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), Convert.ToInt32(dia));



        public static List<DateTime> avisos = new List<DateTime>();

        public static string file = "avisos.txt";
    }
}
