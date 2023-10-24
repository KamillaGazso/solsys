using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztaly
{
    internal class osztalyos
    {
        public string BolygoNeve { get; set; }
        public int HoldakSzama { get; set; }
        public double TerfogatAranya { get; set; }

        public osztalyos(string sor)
        {
            var v = sor.Split(";");
            BolygoNeve = v[0];
            HoldakSzama = Convert.ToInt32(v[1]);
            TerfogatAranya = double.Parse(v[2]);

        }
        
    }
   
}
