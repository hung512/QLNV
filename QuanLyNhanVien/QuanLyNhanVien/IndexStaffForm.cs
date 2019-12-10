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
    public partial class IndexStaffForm : Form
    {
        private ClassManagement Business;
        public IndexStaffForm()
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.Load += IndexStaffForm_Load;
            this.btnCreate.Click += btnCreate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.grdDataStaff.DoubleClick += grdDataStaff_DoubleClick;
        }

        void grdDataStaff_DoubleClick(object sender, EventArgs e)
        {
            //var @class = (STAFF)this.grdDataStaff.SelectedRows[0].DataBoundItem;
            //var updateForm = new UpdateForm(@class.ID);
            //updateForm.ShowDialog();
            //this.Load();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateForm().ShowDialog();
        }

        void IndexStaffForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
