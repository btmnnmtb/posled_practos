//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace posled_practos
{
    using System;
    using System.Collections.Generic;
    
    public partial class postavchik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public postavchik()
        {
            this.mesto_dobich = new HashSet<mesto_dobich>();
            this.rolee = new HashSet<rolee>();
        }
    
        public int id_post { get; set; }
        public string name_post { get; set; }
        public string surname_post { get; set; }
        public string otchestvo_post { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mesto_dobich> mesto_dobich { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rolee> rolee { get; set; }
    }
}
