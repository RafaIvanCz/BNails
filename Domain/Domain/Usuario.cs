﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 5/3/2024 17:22:17
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Domain
{

    /// <summary>
    /// There are no comments for Domain.Usuario, Domain in the schema.
    /// </summary>
    public partial class Usuario {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for Usuario constructor in the schema.
        /// </summary>
        public Usuario()
        {
            this.Activo = true;
            this.Clientes = new HashSet<Clientes>();
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual int Id
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Username in the schema.
        /// </summary>
        public virtual string Username
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        public virtual string Password
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Nombre in the schema.
        /// </summary>
        public virtual string Nombre
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Apellido in the schema.
        /// </summary>
        public virtual string Apellido
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Telefono in the schema.
        /// </summary>
        public virtual string Telefono
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        public virtual string Email
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Confirmacion in the schema.
        /// </summary>
        public virtual string Confirmacion
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Eliminado in the schema.
        /// </summary>
        public virtual bool Eliminado
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Activo in the schema.
        /// </summary>
        public virtual bool Activo
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for PrimerIngreso in the schema.
        /// </summary>
        public virtual System.Nullable<bool> PrimerIngreso
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for UltimoIngreso in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> UltimoIngreso
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for IngresoActual in the schema.
        /// </summary>
        public virtual System.Nullable<System.DateTime> IngresoActual
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Clientes in the schema.
        /// </summary>
        public virtual ISet<Clientes> Clientes
        {
            get;
            set;
        }
    }

}
