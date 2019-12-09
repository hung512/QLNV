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
            //var @class = this.Business.GetClass(this.RoomId);
            //this.txtCode = @class.Name;
            //this.txtDescription.Text = @class.Description;
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
