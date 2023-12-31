//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public long id_reservation { get; set; }
        public System.DateTime date_start { get; set; }
        public System.DateTime date_end { get; set; }
        public string status { get; set; }
        public long id_room { get; set; }
        public long id_client { get; set; }
        public Nullable<long> id_service { get; set; }
        public double price { get; set; }
        public Nullable<long> deleted { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Room Room { get; set; }
        public virtual Service Service { get; set; }
    }
}
