//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace siparis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RIVALPRODUCTDETAIL
    {
        public int RIVAL_PRODUCT_CODE { get; set; }
        public int COMPANY_CODE { get; set; }
        public int RIVAL_COMPANY_CODE { get; set; }
        public int VERSION { get; set; }
        public Nullable<int> CUR_TYPE { get; set; }
        public Nullable<int> PEYMENT_TYPE { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public string EQUIVALENT_PRODUCT_CODE { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public Nullable<int> UNIT { get; set; }
        public Nullable<int> PERIOD { get; set; }
        public string LAST_UPDATE_USER { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public string EQUIVALENT_PRODUCT_NAME { get; set; }
    }
}
