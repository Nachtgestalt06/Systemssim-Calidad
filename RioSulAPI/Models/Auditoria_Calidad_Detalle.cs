
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
    
public partial class Auditoria_Calidad_Detalle
{

    public int IdAuditoria_Calidad_Detalle { get; set; }

    public int IdAuditoria { get; set; }

    public int IdPosicion { get; set; }

    public int IdOperacion { get; set; }

    public int IdDefecto { get; set; }

    public int Recup { get; set; }

    public int Criterio { get; set; }

    public int Fin { get; set; }

    public string Aud_Imagen { get; set; }

    public Nullable<int> Id_Origen { get; set; }

    public string Nota { get; set; }

    public string Archivo { get; set; }

}

}
