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
    
    public partial class T_Place
    {
        public T_Place()
        {
            this.Enabled = true;
        }
    
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }
        public string PlaceType { get; set; }
        public int PlaceFatherID { get; set; }
        public bool Enabled { get; set; }
    }
}
