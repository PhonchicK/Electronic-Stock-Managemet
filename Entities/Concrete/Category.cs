using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Entities.Concrete
{
    public class Category : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryID { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<OtherObject> OtherObjects { get; set; }
    }
}
