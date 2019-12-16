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
    public partial class UpdateForm : Form
    {
        private int StaffId;
        private ClassManagement Business;
        public UpdateForm(int ID)
        {
            InitializeComponent();
            this.StaffId = ID;
            this.Business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += UpdateForm_Load;
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var staff = this.Business.GetStaff(this.StaffId);
            this.txtName.Text = staff.NAME;
            this.txtCode.Text = staff.CODE;
            this.txtHomeTown.Text = staff.HOMETOWN;
            this.txtSalary.Text = string.Format(staff.SALARY.ToString());
            this.cbbRoom.DataSource = this.Business.GetRooms();
            this.cbbRoom.DisplayMember = "Name";
            this.cbbRoom.ValueMember = "ID";
            this.cbbRoom.SelectedValue = staff.ROOM_ID;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var NAME = this.txtName.Text;
            var BIRTHDAY = this.dtpDay.Value;
            var CODE = this.txtCode.Text;
            var HOMETOWN = this.txtHomeTown.Text;
            var SALARY = int.Parse(this.txtSalary.Text);
            var ROOM_ID = (int)this.cbbRoom.SelectedValue;
            this.Business.EditStaff(this.StaffId, CODE, NAME, BIRTHDAY, HOMETOWN, ROOM_ID, SALARY);
            MessageBox.Show("Update thanh cong");
            this.Close();
        }
    }
}
