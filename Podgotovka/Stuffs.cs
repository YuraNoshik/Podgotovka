//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppVetclinic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stuffs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stuffs()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int stuffID { get; set; }
        public string stuffSurname { get; set; }
        public string stuffName { get; set; }
        public string stuffPatronymic { get; set; }
        public string stuffLogin { get; set; }
        public string stuffPassword { get; set; }
        public int stuffRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Roles Roles { get; set; }
    }
}