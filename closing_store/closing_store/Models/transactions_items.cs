//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace closing_store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class transactions_items
    {
        public string items { get; set; }
        public Nullable<int> transaction_id { get; set; }
    
        public virtual transaction transaction { get; set; }
    }
}
