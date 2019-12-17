using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class SortForm : Form
    {
        private ClassManagement Business;
        public SortForm()
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.Load += SortForm_Load;
        }

        void SortForm_Load(object sender, EventArgs e)
        {
            this.ShowAllSort();
        }
        private void ShowAllSort()
        {
            var sort = this.Business.getSort();
            var SortView = new SortView[sort.Length];
            for (int i = 0; i < sort.Length; i++)
                SortView[i] = new SortView(sort[i]);
            this.grdSort.DataSource = SortView.OrderBy(x => x.Room).ToList();

        }

    }
}
