using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHopital.Metier
{
    public class Payements
    {
        public int numticket { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public int numpayement { get; set; }
        public DateTime date { get; set; }
        public int montant { get; set; }
    }
}
