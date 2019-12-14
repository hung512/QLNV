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
        private int RoomId;
        private ClassManagement Business;
        public UpdateForm(int ID)
        {
            InitializeComponent();
            this.RoomId = ID;
            this.Business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += UpdateForm_Load;
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var staff = this.Business.GetStaff(this.RoomId);
            this.txtName.Text = staff.NAME;
            this.cbbRoom.DataSource = this.Business.GetRooms();
            this.cbbRoom.DisplayMember = "Name";
            this.cbbRoom.ValueMember = "ID";
            // chạy thử ô. okey tui sửa này cái
            // còn code homwtown vs salary i vậy hả ô
            this.cbbRoom.SelectedValue = staff.ROOM_ID;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
