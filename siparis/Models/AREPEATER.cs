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
    
    public partial class AREPEATER
    {
        public int R_CODE { get; set; }
        public int ACTIVITY_CODE { get; set; }
        public Nullable<System.DateTime> FIRST_START_DATE { get; set; }
        public Nullable<System.DateTime> LAST_DATE { get; set; }
        public Nullable<int> R_TYPE { get; set; }
        public Nullable<int> R_PERIOD { get; set; }
        public Nullable<int> R_FIX_DAY { get; set; }
        public string R_WEEK_DAYS { get; set; }
        public Nullable<int> R_WEEK_DAY { get; set; }
        public Nullable<int> R_MONTH { get; set; }
        public Nullable<int> R_WEEK { get; set; }
        public Nullable<int> R_TIMES { get; set; }
        public string LAST_UPDATE_USER { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
    }
}
