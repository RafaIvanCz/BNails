﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 7/3/2024 11:47:22
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
    /// There are no comments for Domain.TelefonoTipo, Domain in the schema.
    /// </summary>
    public partial class TelefonoTipo {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for TelefonoTipo constructor in the schema.
        /// </summary>
        public TelefonoTipo()
        {
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
        /// There are no comments for Tipo in the schema.
        /// </summary>
        public virtual string Tipo
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Observacion in the schema.
        /// </summary>
        public virtual string Observacion
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
