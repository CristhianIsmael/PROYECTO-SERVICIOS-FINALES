//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACCESODATOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buses()
        {
            this.Horarios = new List<Horarios>();
        }
    
        public int ID_Bus { get; set; }
        public string NumUnidadBus { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Nullable<int> Capacidad_Pasajeros { get; set; }
        public string Foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Horarios> Horarios { get; set; }
    }
}
