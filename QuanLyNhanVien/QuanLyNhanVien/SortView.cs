using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class SortView
    {
        public int id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Hometown { get; set; }
        public string Room { get; set; }
        public int Salary { get; set; }
        public SortView(STAFF staff)
        {
            this.id = staff.ID;
            this.Code = staff.CODE;
            this.Name = staff.NAME;
            this.Birthday = staff.BIRTHDAY;
            this.Hometown = staff.HOMETOWN;
            this.Room = staff.ROOM.NAME;
            this.Salary = staff.SALARY;
        }
    }
}
