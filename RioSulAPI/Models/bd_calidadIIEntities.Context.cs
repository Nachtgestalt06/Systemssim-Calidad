﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class bd_calidadIIEntities : DbContext
{
    public bd_calidadIIEntities()
        : base("name=bd_calidadIIEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Auditoria> Auditorias { get; set; }

    public virtual DbSet<Auditoria_Calidad_Detalle> Auditoria_Calidad_Detalle { get; set; }

    public virtual DbSet<Auditoria_Confeccion_Detalle> Auditoria_Confeccion_Detalle { get; set; }

    public virtual DbSet<Auditoria_Corte_Detalle> Auditoria_Corte_Detalle { get; set; }

    public virtual DbSet<Auditoria_Lavanderia_Detalle> Auditoria_Lavanderia_Detalle { get; set; }

    public virtual DbSet<Auditoria_Proc_Esp_Detalle> Auditoria_Proc_Esp_Detalle { get; set; }

    public virtual DbSet<Auditoria_Tendido_Detalle> Auditoria_Tendido_Detalle { get; set; }

    public virtual DbSet<Auditoria_Terminado_Detalle> Auditoria_Terminado_Detalle { get; set; }

    public virtual DbSet<C_Areas> C_Areas { get; set; }

    public virtual DbSet<C_ClienteMarca> C_ClienteMarca { get; set; }

    public virtual DbSet<C_Clientes> C_Clientes { get; set; }

    public virtual DbSet<C_ClientesReferencia> C_ClientesReferencia { get; set; }

    public virtual DbSet<C_Conf_Confeccion> C_Conf_Confeccion { get; set; }

    public virtual DbSet<C_CorreosElectronicos> C_CorreosElectronicos { get; set; }

    public virtual DbSet<C_Cort_Cortadores> C_Cort_Cortadores { get; set; }

    public virtual DbSet<C_Cort_Tendido> C_Cort_Tendido { get; set; }

    public virtual DbSet<C_Lavanderia> C_Lavanderia { get; set; }

    public virtual DbSet<C_Modulos> C_Modulos { get; set; }

    public virtual DbSet<C_Operacion_Confeccion> C_Operacion_Confeccion { get; set; }

    public virtual DbSet<C_Operacion_Lavanderia> C_Operacion_Lavanderia { get; set; }

    public virtual DbSet<C_Operacion_ProcesosEspeciales> C_Operacion_ProcesosEspeciales { get; set; }

    public virtual DbSet<C_Operacion_Terminado> C_Operacion_Terminado { get; set; }

    public virtual DbSet<C_Origen_Terminado> C_Origen_Terminado { get; set; }

    public virtual DbSet<C_Plantas_Areas> C_Plantas_Areas { get; set; }

    public virtual DbSet<C_Plantas_Dynamic> C_Plantas_Dynamic { get; set; }

    public virtual DbSet<C_Posicion_Cortador> C_Posicion_Cortador { get; set; }

    public virtual DbSet<C_Posicion_Lavanderia> C_Posicion_Lavanderia { get; set; }

    public virtual DbSet<C_Posicion_ProcesosEsp> C_Posicion_ProcesosEsp { get; set; }

    public virtual DbSet<C_Posicion_Terminado> C_Posicion_Terminado { get; set; }

    public virtual DbSet<C_Procesos_Especiales> C_Procesos_Especiales { get; set; }

    public virtual DbSet<C_Segundas> C_Segundas { get; set; }

    public virtual DbSet<C_Sg_Operaciones> C_Sg_Operaciones { get; set; }

    public virtual DbSet<C_Sg_PantallasOperaciones> C_Sg_PantallasOperaciones { get; set; }

    public virtual DbSet<C_Sg_Usuarios> C_Sg_Usuarios { get; set; }

    public virtual DbSet<C_SubModulos> C_SubModulos { get; set; }

    public virtual DbSet<C_Terminado> C_Terminado { get; set; }

    public virtual DbSet<C_Tolerancia_Corte> C_Tolerancia_Corte { get; set; }

    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

    public virtual DbSet<T_Sg_Pantallas> T_Sg_Pantallas { get; set; }

    public virtual DbSet<T_Sg_UsuariosOperaciones> T_Sg_UsuariosOperaciones { get; set; }

    public virtual DbSet<T_Sg_Bitacora> T_Sg_Bitacora { get; set; }

    public virtual DbSet<VST_AUDITORIA> VST_AUDITORIA { get; set; }

    public virtual DbSet<VST_AUDITORIA_CALIDAD_DETALLE> VST_AUDITORIA_CALIDAD_DETALLE { get; set; }

    public virtual DbSet<VST_AUDITORIA_CORTE_DETALLE> VST_AUDITORIA_CORTE_DETALLE { get; set; }

    public virtual DbSet<VST_AUDITORIA_LAVANDERIA_DETALLE> VST_AUDITORIA_LAVANDERIA_DETALLE { get; set; }

    public virtual DbSet<VST_AUDITORIA_PROC_ESP_DETALLE> VST_AUDITORIA_PROC_ESP_DETALLE { get; set; }

    public virtual DbSet<VST_AUDITORIA_TENDIDO_DETALLE> VST_AUDITORIA_TENDIDO_DETALLE { get; set; }

    public virtual DbSet<VST_AUDITORIA_TERMINADO_DETALLE> VST_AUDITORIA_TERMINADO_DETALLE { get; set; }

    public virtual DbSet<VST_CONFECCION> VST_CONFECCION { get; set; }

    public virtual DbSet<VST_CORREOS_AUDITORIA> VST_CORREOS_AUDITORIA { get; set; }

    public virtual DbSet<VST_CORTADORES> VST_CORTADORES { get; set; }

    public virtual DbSet<VST_LAVANDERIA> VST_LAVANDERIA { get; set; }

    public virtual DbSet<VST_OPERACION_CONFECCION> VST_OPERACION_CONFECCION { get; set; }

    public virtual DbSet<VST_PERMISOS> VST_PERMISOS { get; set; }

    public virtual DbSet<VST_PERMISOS_OPERACIONES> VST_PERMISOS_OPERACIONES { get; set; }

    public virtual DbSet<VST_PLANTAS_AREAS> VST_PLANTAS_AREAS { get; set; }

    public virtual DbSet<VST_POSICION_CORTADOR> VST_POSICION_CORTADOR { get; set; }

    public virtual DbSet<VST_POSICION_LAVANDERIA> VST_POSICION_LAVANDERIA { get; set; }

    public virtual DbSet<VST_POSICION_PROCESOS_ESPECIALES> VST_POSICION_PROCESOS_ESPECIALES { get; set; }

    public virtual DbSet<VST_PROCESOS_ESPECIALES> VST_PROCESOS_ESPECIALES { get; set; }

    public virtual DbSet<VST_TERMINADO> VST_TERMINADO { get; set; }


    public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var new_diagramnameParameter = new_diagramname != null ?
            new ObjectParameter("new_diagramname", new_diagramname) :
            new ObjectParameter("new_diagramname", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
    }


    public virtual int sp_upgraddiagrams()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
    }

}

}

