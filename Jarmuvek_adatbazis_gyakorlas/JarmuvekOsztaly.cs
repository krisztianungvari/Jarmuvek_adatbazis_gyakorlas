using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek_adatbazis_gyakorlas
{
    class JarmuvekOsztaly
    {
        string marka;
        int km;
        DateTime gyartasido;

        public JarmuvekOsztaly(string marka, int km, DateTime gyartasido)
        {
            this.Marka = marka;
            this.Km = km;
            this.Gyartasido = gyartasido;
        }

        public string Marka { get => marka; set => marka = value; }
        public int Km { get => km; set => km = value; }
        public DateTime Gyartasido { get => gyartasido; set => gyartasido = value; }

        public override string ToString()
        {
            return marka;
        }
    }
   
}
