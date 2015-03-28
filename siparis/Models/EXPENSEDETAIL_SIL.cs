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
    
    public partial class EXPENSEDETAIL_SIL
    {
        public int EXPENSE_CODE { get; set; }
        public int ROW_ORDER_NO { get; set; }
        public int COMPANY_CODE { get; set; }
        public int PROJECT_CODE { get; set; }
        public int CONTRACT_CODE { get; set; }
        public string VERSION { get; set; }
        public string STOK_CODE { get; set; }
        public string PRODUCT_NAME { get; set; }
        public Nullable<float> QUANTITY { get; set; }
        public Nullable<float> UNIT_PRICE { get; set; }
        public Nullable<float> TAX_PERCENT { get; set; }
        public Nullable<float> TOTAL { get; set; }
        public Nullable<float> TOTAL_UNTAX { get; set; }
        public Nullable<float> TOTAL_UPBK { get; set; }
        public Nullable<float> TOTAL_UPBK_UNTAX { get; set; }
        public string CUR_TYPE { get; set; }
        public Nullable<float> CUR_VALUE { get; set; }
        public string UNIT { get; set; }
        public Nullable<float> DISCOUNT_PERCENT { get; set; }
        public Nullable<float> DISCOUNT_TOTAL { get; set; }
        public Nullable<float> EXPENSE_PERCENT { get; set; }
        public Nullable<float> EXPENSE_TOTAL { get; set; }
        public string EXPLANATION { get; set; }
        public string LAST_UPDATE_USER { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public string CODE2 { get; set; }
        public Nullable<float> DISCOUNT_UNIT_PRICE { get; set; }
        public Nullable<float> BUYING_PRICE { get; set; }
        public Nullable<float> BUYING_DISCOUNT_PERCENT { get; set; }
        public string DETAILDESCRIPTION { get; set; }
    }
}
