//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataMould
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_User
    {
        public T_User()
        {
            this.Enabled = true;
            this.T_PostAddress = new HashSet<T_PostAddress>();
            this.T_UserOrders = new HashSet<T_UserOrders>();
        }
    
        public int UserID { get; set; }
        public string UserName { get; set; }
        public System.DateTime Birthday { get; set; }
        public byte Sex { get; set; }
        public string Email { get; set; }
        public string LoginNum { get; set; }
        public string PassWord { get; set; }
        public string Phone { get; set; }
        public bool Enabled { get; set; }
    
        public virtual ICollection<T_PostAddress> T_PostAddress { get; set; }
        public virtual ICollection<T_UserOrders> T_UserOrders { get; set; }
    }
}
