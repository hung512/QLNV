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
    public partial class CreateForm : Form
    {
        private ClassManagement Business;

        public CreateForm()
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var NAME = this.txtName.Text;
            var CODE = this.txtCode.Text;
            var BIRTHDAY = this.dtbDay.Value;
            var HOMETOWN = this.txtHomeTown.Text;
            var ROOM_ID = (int)this.cbbRoom.SelectedValue;
            var SALARY = int.Parse(txtSalary.Text);
            this.Business.AddClass(CODE, NAME, BIRTHDAY, HOMETOWN, ROOM_ID, SALARY);
            MessageBox.Show("Create class successfully");
            this.Close();
        }
        void CreateForm_Load(object sender, EventArgs e)
        {
            this.cbbRoom.DataSource = this.Business.GetRooms();
            this.cbbRoom.DisplayMember = "Name";
            this.cbbRoom.ValueMember = "id";
        }
    }
}
