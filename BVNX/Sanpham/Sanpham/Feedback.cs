//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sanpham
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int FeedbackID { get; set; }
        public int NewsID { get; set; }
        public string Email { get; set; }
        public string NameReader { get; set; }
        public string Contents { get; set; }
        public int Status { get; set; }
        public System.DateTime DateComment { get; set; }
    
        public virtual News News { get; set; }
    }
}
