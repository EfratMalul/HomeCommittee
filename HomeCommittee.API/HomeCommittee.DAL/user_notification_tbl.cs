//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeCommittee.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_notification_tbl
    {
        public int id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> notification_id { get; set; }
        public Nullable<bool> is_read { get; set; }
    
        public virtual notification_tbl notification_tbl { get; set; }
        public virtual user_tbl user_tbl { get; set; }
    }
}
