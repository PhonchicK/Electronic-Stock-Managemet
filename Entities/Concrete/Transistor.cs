using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Entities.Concrete
{
    public class Transistor : IEntity
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public float Amper { get; set; }
        public float Voltage { get; set; }
        public string Description { get; set; }
        public int DatasheetID { get; set; }
        public int PinTypeID { get; set; }

        public virtual Datasheet Datasheet { get; set; }
        public virtual PinType PinType { get; set; }
    }
}
