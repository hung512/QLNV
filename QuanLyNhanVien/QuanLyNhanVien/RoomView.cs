using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class RoomView
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Staff { get; set; }
        public RoomView(ROOM room)
        {
            this.id = room.Id;
            this.Name = room.NAME;
            this.Staff = room.STAFFs.Count;
        }
    }
}
