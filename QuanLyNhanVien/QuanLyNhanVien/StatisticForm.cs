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
    public partial class StatisticForm : Form
    {
        private ClassManagement Business;
        public StatisticForm()
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.Load += StatisticForm_Load;
        }

        void StatisticForm_Load(object sender, EventArgs e)
        {
            this.ShowRoom();
        }
        private void ShowRoom()
        {
            this.grdStatistic.DataSource = this.Business.GetRooms();
            var room = this.Business.GetRooms();
            var roomviews = new RoomView[room.Length];
            for (int i = 0; i < roomviews.Length; i++)
            {
                roomviews[i] = new RoomView(room[i]);
            }
            this.grdStatistic.DataSource = roomviews;
        }
    }
}
