//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passengers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passengers()
        {
            this.Passengers_to_track = new HashSet<Passengers_to_track>();
            this.Travels = new HashSet<Travels>();
        }
    
        public int Passenger_s_code { get; set; }
        public int Group_s_code { get; set; }
        public string Passenger_s_name { get; set; }
        public string Passenger_s_address { get; set; }
    
        public virtual Customers Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passengers_to_track> Passengers_to_track { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Travels> Travels { get; set; }
    }
}
