//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scrap_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offer()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int offerID { get; set; }
        public Nullable<int> sellerID { get; set; }
        public Nullable<int> partsID { get; set; }
        public System.DateTime offerDate { get; set; }
        public Nullable<int> ostat { get; set; }
        public decimal price { get; set; }
    
        public virtual OfferStat OfferStat { get; set; }
        public virtual Part Part { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}