﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TacServicios : DbContext
    {
        public TacServicios()
            : base("name=TacServicios")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Buses> Buses { get; set; }
        public virtual DbSet<Conductores> Conductores { get; set; }
        public virtual DbSet<Horarios> Horarios { get; set; }
        public virtual DbSet<Opiniones> Opiniones { get; set; }
        public virtual DbSet<Pasajeros> Pasajeros { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<Rutas> Rutas { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
    
        public virtual int AddNewBus(string numUnidadBus, string marca, string modelo, Nullable<int> capacidad_Pasajeros, string foto)
        {
            var numUnidadBusParameter = numUnidadBus != null ?
                new ObjectParameter("NumUnidadBus", numUnidadBus) :
                new ObjectParameter("NumUnidadBus", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("Modelo", modelo) :
                new ObjectParameter("Modelo", typeof(string));
    
            var capacidad_PasajerosParameter = capacidad_Pasajeros.HasValue ?
                new ObjectParameter("Capacidad_Pasajeros", capacidad_Pasajeros) :
                new ObjectParameter("Capacidad_Pasajeros", typeof(int));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddNewBus", numUnidadBusParameter, marcaParameter, modeloParameter, capacidad_PasajerosParameter, fotoParameter);
        }
    
        public virtual int UpdateConductorPhone(Nullable<int> iD_Conductor, string conduTelefono)
        {
            var iD_ConductorParameter = iD_Conductor.HasValue ?
                new ObjectParameter("ID_Conductor", iD_Conductor) :
                new ObjectParameter("ID_Conductor", typeof(int));
    
            var conduTelefonoParameter = conduTelefono != null ?
                new ObjectParameter("ConduTelefono", conduTelefono) :
                new ObjectParameter("ConduTelefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateConductorPhone", iD_ConductorParameter, conduTelefonoParameter);
        }
    }
}
