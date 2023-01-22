using PhonchicK.Business.Abstract;
using PhonchicK.Business.Concrete;
using PhonchicK.ConsoleUI.Helpers;
using PhonchicK.DataAccess.Concrete.EntityFramework;
using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetCategories();
            Console.ReadKey();
        }

        private static void GetCategories()
        {
            foreach (var item in ServiceHelper.CategoryService().GetByPage())
            {
                Console.WriteLine(item.Name);
                foreach (var category in ServiceHelper.CategoryService().GetChilderen(item.ID))
                {
                    Console.WriteLine("----" + category.Name);
                }
            }
        }
    }
}
