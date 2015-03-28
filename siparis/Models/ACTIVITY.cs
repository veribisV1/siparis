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
    
    public partial class ACTIVITY
    {
        public int ACTIVITY_CODE { get; set; }
        public Nullable<int> CONTACT_CODE { get; set; }
        public Nullable<int> COMPANY_CODE { get; set; }
        public int OWNER { get; set; }
        public Nullable<int> ACTIVITY_TYPE { get; set; }
        public Nullable<System.DateTime> SDATE { get; set; }
        public Nullable<System.DateTime> EDATE { get; set; }
        public Nullable<decimal> DURATION { get; set; }
        public Nullable<int> TRANSPORTINCLUDE { get; set; }
        public Nullable<decimal> TRANSFER_TIME { get; set; }
        public Nullable<int> REGARDING { get; set; }
        public string NOTE { get; set; }
        public string SUBJECT { get; set; }
        public Nullable<int> LOCATION { get; set; }
        public Nullable<int> PRIORITY { get; set; }
        public Nullable<int> REMEMBER { get; set; }
        public Nullable<int> COLOR { get; set; }
        public Nullable<int> PROJECT { get; set; }
        public Nullable<int> ACTIVITY_GROUP { get; set; }
        public Nullable<int> APPOINTED_USER_CODE { get; set; }
        public int OPENORCLOSE { get; set; }
        public Nullable<decimal> COST { get; set; }
        public string COST_UNIT { get; set; }
        public string LAST_UPDATE_USER { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public Nullable<int> R_CODE { get; set; }
        public Nullable<int> SOURCEACTIVITY_CODE { get; set; }
        public string DOCUMENT_NO1 { get; set; }
        public string DOCUMENT_NO2 { get; set; }
        public string EXT1 { get; set; }
        public string EXT2 { get; set; }
        public Nullable<int> BASE_TYPE { get; set; }
    }
}
