using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class ClassManagement
    {
        public STAFF[] GetStaffs()
        {
            var db = new MyRoomEntities();
            return db.STAFFs.ToArray();
        }
        public ROOM[] GetRooms()
        {
            var db = new MyRoomEntities();
            return db.ROOMs.ToArray();
        }

        public void AddStaff(string CODE, string NAME, DateTime BIRTHDAY, string HOMETOWN, int ROOM_ID, int SALARY)
        {
            var newClass = new STAFF();
            newClass.CODE = CODE;
            newClass.NAME = NAME;
            newClass.BIRTHDAY = BIRTHDAY;
            newClass.HOMETOWN = HOMETOWN;
            newClass.ROOM_ID = ROOM_ID;
            newClass.SALARY = SALARY;

            var db = new MyRoomEntities();
            db.STAFFs.Add(newClass);
            db.SaveChanges();
        }
        public void EditStaff(int ID, string CODE, string NAME, DateTime BIRTHDAY, string HOMETOWN, int ROOM_ID, int SALARY)
        {
            var db = new MyRoomEntities();
            var oldClass = db.STAFFs.Find(ID);

            oldClass.CODE = CODE;
            oldClass.NAME = NAME;
            oldClass.BIRTHDAY = BIRTHDAY;
            oldClass.HOMETOWN = HOMETOWN;
            oldClass.ROOM_ID = ROOM_ID;
            oldClass.SALARY = SALARY;
            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteStaff(int id)
        {
            var db = new MyRoomEntities();
            var @class = db.STAFFs.Find(id);
            db.STAFFs.Remove(@class);
            db.SaveChanges();
        }

        public STAFF GetStaff(int id)
        {
            var db = new MyRoomEntities();
            return db.STAFFs.Find(id);
        }
    }
}