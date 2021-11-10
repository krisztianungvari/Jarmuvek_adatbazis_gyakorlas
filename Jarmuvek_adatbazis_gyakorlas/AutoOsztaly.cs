using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarmuvek_adatbazis_gyakorlas
{
    public enum Autotipus
    {
        Limuzin,
        Kombi,
        Cabrio
    }
    class AutoOsztaly : JarmuvekOsztaly
    {
        string szin;
        Autotipus autoTipus;

        public AutoOsztaly(string marka, int km, DateTime gyartasido, string szin, Autotipus autoTipus) : base(marka,km,gyartasido)
        {
            this.szin = szin;
            this.autoTipus = autoTipus;
        }

        public string Szin { get => szin; set => szin = value; }
        public Autotipus AutoTipus { get => autoTipus; set => autoTipus = value; }

        public override string ToString()
        {
            return szin + autoTipus + Marka + Km + Gyartasido;
        }

        internal static DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
