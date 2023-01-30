using Microsoft.Win32;
using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.FormUI.Models
{
    internal class ResistorViewModel
    {
        internal ResistorViewModel(Resistor resistor)
        {
            this.ID = resistor.ID;
            this.Resistance = string.Format("{0}Ω", resistor.Resistance);
            this.Tolerance = string.Format("%{0}", resistor.Tolerance);
            this.BandCount = resistor.BandCount;
            this.Power = resistor.Power;
        }
        public int ID { get; set; }
        public string Resistance { get; set; }
        public string Tolerance { get; set; }
        public int BandCount { get; set; }
        public float Power { get; set; }
    }
}
