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
    
    public partial class USERSALARY
    {
        public int ID { get; set; }
        public string USER_CODE { get; set; }
        public float SALARY { get; set; }
        public System.DateTime DATE { get; set; }
        public string CUR_TYPE { get; set; }
        public float CUR_VALUE { get; set; }
        public int MONTHLY_HOUR { get; set; }
    }
}