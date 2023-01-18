using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.DataAccess.Concrete.EntityFramework
{
    public class StockContext : DbContext
    {
        public StockContext () : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=electronicstock;Integrated Security=True;")
        {
            this.Database.CreateIfNotExists();
        }

        public DbSet<Capacitor> Capacitors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Datasheet> Datasheets { get; set; }
        public DbSet<IntegratedCircuit> IntegratedCircuits { get; set; }
        public DbSet<OtherObject> OtherObjects { get; set; }
        public DbSet<PinType> PinTypes { get; set; }
        public DbSet<Resistor> Resistors { get; set; }
        public DbSet<Transistor> Transistors { get; set; }
    }
}
