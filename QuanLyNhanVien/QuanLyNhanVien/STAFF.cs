//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class STAFF
    {
        public int ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public System.DateTime BIRTHDAY { get; set; }
        public string HOMETOWN { get; set; }
        public int ROOM_ID { get; set; }
        public int SALARY { get; set; }
    
        public virtual ROOM ROOM { get; set; }
    }
}
