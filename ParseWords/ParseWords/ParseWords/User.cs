//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParseWords
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Words = new HashSet<Word>();
        }
    
        public string ID_Login { get; set; }
        public string Name { get; set; }
        public string UserPassword { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Mail { get; set; }
        public Nullable<int> AmoutOfBlock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Word> Words { get; set; }
    }
}
