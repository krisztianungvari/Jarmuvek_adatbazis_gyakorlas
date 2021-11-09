using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek_adatbazis_gyakorlas
{
    public enum MotorTipus
    {
        robogó,
        Túra,
        Chopper,
        Sport
    }
    class MotorOsztaly : JarmuvekOsztaly
    {
        MotorTipus motorTipus;

        public MotorOsztaly(string marka, int km, DateTime gyartasido, MotorTipus motorTipus):base(marka,km,gyartasido)
        {
            this.MotorTipus = motorTipus;
        }

        public MotorTipus MotorTipus { get => motorTipus; set => motorTipus = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
