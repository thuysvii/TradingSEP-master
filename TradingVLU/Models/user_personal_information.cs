//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradingVLU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_personal_information
    {
        public int id { get; set; }
        public int id_user { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string update_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    
        public virtual user user { get; set; }
    }
}
