//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectionAutomationSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Neighbourhood
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Neighbourhood()
        {
            this.BallotBoxes = new HashSet<BallotBox>();
        }
    
        public int NeighbourhoodId { get; set; }
        public string NeighbourhoodName { get; set; }
        public Nullable<int> DistrictId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BallotBox> BallotBoxes { get; set; }
        public virtual District District { get; set; }
    }
}
