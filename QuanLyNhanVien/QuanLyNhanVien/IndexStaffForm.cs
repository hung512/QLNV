﻿using System;
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
        }

        void btnStatistic_Click(object sender, EventArgs e)
        {
            new StatisticForm().ShowDialog();
        }

        void grdDataStaff_DoubleClick(object sender, EventArgs e)
        {
            var @class = (STAFF)this.grdDataStaff.SelectedRows[0].DataBoundItem;
            var updateForm = new UpdateForm(@class.ID);
            updateForm.ShowDialog();
            this.showStaFF();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdDataStaff.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @class = (STAFF)this.grdDataStaff.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteClass(@class.ID);
                    MessageBox.Show("Delete class successfully.");
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
            this.grdDataStaff.DataSource = this.Business.GetClasses();
        }

    }
}