using PhonchicK.FormUI.Views.ListViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonchicK.FormUI.Views
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateForm(Form form)
        {
            Form openForm = this.MdiChildren.FirstOrDefault(f => f.Name == form.Name);
            if (openForm == null)
            {
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form.Dispose();
            }
        }

        private void resistorToolStripButton_Click(object sender, EventArgs e)
        {
            NavigateForm(new ResistorListView());
        }
    }
}
