using MySql.Data.EntityFramework;
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
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class StockContext : DbContext
    {
        public StockContext () : base("server=sql105.epizy.com;port=3306;database=epiz_30375782_stock;uid=epiz_30375782;pass=xWTcAHhAKkmvuv")
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
