//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Execution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Execution()
        {
            this.ExecutionPlane = new HashSet<ExecutionPlane>();
        }
    
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public int IdScript { get; set; }
        public bool Active { get; set; }
    
        public virtual Script Script { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExecutionPlane> ExecutionPlane { get; set; }
    }
}
