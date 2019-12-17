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
            this.btnStatistic.Click += btnStatistic_Click;
            this.btnSort.Click += btnSort_Click;
        }

        void btnSort_Click(object sender, EventArgs e)
        {
            new SortForm().ShowDialog();
            this.showStaFF();
        }

        void btnStatistic_Click(object sender, EventArgs e)
        {
            new StatisticForm().ShowDialog();
        }

        void grdDataStaff_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdDataStaff.SelectedRows.Count == 1)
            {
                var row = this.grdDataStaff.SelectedRows[0];
                var staffView = (StaffView)row.DataBoundItem;

                new UpdateForm(staffView.id).ShowDialog();
                this.showStaFF();
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdDataStaff.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Ban co muon xoa khong?", "Chap nhan",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @class = (STAFF)this.grdDataStaff.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteStaff(@class.ID);
                    MessageBox.Show("Xoa thanh cong.");
                    this.showStaFF();
                }
            }
        }

        void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new CreateForm();
            createForm.ShowDialog();
            this.showStaFF();
        }

        void IndexStaffForm_Load(object sender, EventArgs e)
        {
            this.showStaFF();
        }
        private void showStaFF()
        {
            this.grdDataStaff.DataSource = this.Business.GetStaffs();
            var staffs = this.Business.GetStaffs();
            var staffsviews = new StaffView[staffs.Length];
            for (int i = 0; i < staffs.Length; i++)
                staffsviews[i] = new StaffView(staffs[i]);
            this.grdDataStaff.DataSource = staffsviews;
        }

    }
}
