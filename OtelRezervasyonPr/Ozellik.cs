//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezervasyonPr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ozellik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ozellik()
        {
            this.OdaOzellik = new HashSet<OdaOzellik>();
            this.OtelOzellik = new HashSet<OtelOzellik>();
        }
    
        public int OzellikID { get; set; }
        public string OzellikAd { get; set; }
        public int OzellikTip { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OdaOzellik> OdaOzellik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtelOzellik> OtelOzellik { get; set; }
    }
}