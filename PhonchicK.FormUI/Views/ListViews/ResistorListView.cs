using PhonchicK.Entities.Concrete;
using PhonchicK.FormUI.Helpers;
using PhonchicK.FormUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonchicK.FormUI.Views.ListViews
{
    public partial class ResistorListView : Form
    {
        public ResistorListView()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetResistorByPage(1);
        }
        private List<ResistorViewModel> GetResistorByPage(int page)
        {
            List<ResistorViewModel> result = new List<ResistorViewModel>();
            foreach (var item in ServiceHelper.ResistorService().GetByPage(page))
            {
                result.Add(new ResistorViewModel(item));
            }

            return result;
        }
    }
}
