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
    
    public partial class payment_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public payment_tbl()
        {
            this.tenant_payment_tbl = new HashSet<tenant_payment_tbl>();
        }
    
        public int id { get; set; }
        public int building_id { get; set; }
        public double sum { get; set; }
        public System.DateTime date_payment { get; set; }
    
        public virtual building_tbl building_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tenant_payment_tbl> tenant_payment_tbl { get; set; }
    }
}
