
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RioSulAPI.Models
{

using System;
    using System.Collections.Generic;
    
public partial class T_Sg_Pantallas
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public T_Sg_Pantallas()
    {

        this.C_Sg_PantallasOperaciones = new HashSet<C_Sg_PantallasOperaciones>();

    }


    public int ID { get; set; }

    public Nullable<int> Pantalla_ID { get; set; }

    public string Pantalla { get; set; }

    public string SubMenu { get; set; }

    public Nullable<bool> Activo { get; set; }

    public string Ruta { get; set; }

    public string Icon { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<C_Sg_PantallasOperaciones> C_Sg_PantallasOperaciones { get; set; }

}

}
