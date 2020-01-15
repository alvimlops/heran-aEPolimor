using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeHerançaPolimo.entities
{
    class OutssourceEmploye : employee
    {
        public double AdditionalCharge { get; set; }

        public OutssourceEmploye()
        {
        }

        public OutssourceEmploye(string name, int hours, double valuePerHours, double additionalCharge) : base (name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }















    }
}
