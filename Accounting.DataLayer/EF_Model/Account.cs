//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting.DataLayer.EF_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int TypeID { get; set; }
        public int CustomerID { get; set; }
        public int ID { get; set; }
        public int Amount { get; set; }
        public System.DateTime DateTime { get; set; }
        public string Description { get; set; }
    
        public virtual AccountingType AccountingType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
