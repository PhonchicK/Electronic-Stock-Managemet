using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Entities.Concrete
{
    public class Capacitor : IEntity
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public float Value { get; set; }
        public float MaxVoltage { get; set; }
        public int PinTypeID { get; set; }

        public virtual PinType PinType { get; set; }
    }
}
