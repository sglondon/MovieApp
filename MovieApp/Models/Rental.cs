//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public int MovieID { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Movy Movy { get; set; }
        public virtual Rental Rentals1 { get; set; }
        public virtual Rental Rental1 { get; set; }
    }
}
