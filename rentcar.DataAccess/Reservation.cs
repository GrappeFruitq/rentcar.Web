//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rentcar.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int RId { get; set; }
        public string RUserName { get; set; }
        public string RUserEmail { get; set; }
        public string RUserMark { get; set; }
        public string RUserModel { get; set; }
        public string RPickUpDateTime { get; set; }
        public string RDropOffDateTime { get; set; }
    }
}
