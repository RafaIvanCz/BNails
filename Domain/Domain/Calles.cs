﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 7/3/2024 11:35:48
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
    /// There are no comments for Domain.Calles, Domain in the schema.
    /// </summary>
    public partial class Calles {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for Calles constructor in the schema.
        /// </summary>
        public Calles()
        {
            this.ClienteDomicilios = new HashSet<ClienteDomicilio>();
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
        /// There are no comments for Nombre in the schema.
        /// </summary>
        public virtual string Nombre
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Activa in the schema.
        /// </summary>
        public virtual bool Activa
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Localidades in the schema.
        /// </summary>
        public virtual Localidades Localidades
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for ClienteDomicilios in the schema.
        /// </summary>
        public virtual ISet<ClienteDomicilio> ClienteDomicilios
        {
            get;
            set;
        }
    }

}
