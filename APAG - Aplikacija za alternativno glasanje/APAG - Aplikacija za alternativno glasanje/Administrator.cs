//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APAG___Aplikacija_za_alternativno_glasanje
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administrator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Administrator()
        {
            this.Glasanje = new HashSet<Glasanje>();
        }
    
        public int ID_administrator { get; set; }
        public int Tip_korisnikaID_tipa { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Lozinka { get; set; }
    
        public virtual TipKorisnika TipKorisnika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Glasanje> Glasanje { get; set; }
    }
}
