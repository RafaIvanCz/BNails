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
    /// There are no comments for Domain.Configuraciones, Domain in the schema.
    /// </summary>
    public partial class Configuraciones {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for Configuraciones constructor in the schema.
        /// </summary>
        public Configuraciones()
        {
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
        /// There are no comments for ProvinciaID in the schema.
        /// </summary>
        public virtual System.Nullable<int> ProvinciaID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for LocalidadID in the schema.
        /// </summary>
        public virtual System.Nullable<int> LocalidadID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for CalleID in the schema.
        /// </summary>
        public virtual System.Nullable<int> CalleID
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Altura in the schema.
        /// </summary>
        public virtual System.Nullable<int> Altura
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Latitud in the schema.
        /// </summary>
        public virtual string Latitud
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Longitud in the schema.
        /// </summary>
        public virtual string Longitud
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NombreConsorcio in the schema.
        /// </summary>
        public virtual string NombreConsorcio
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for IPEventos in the schema.
        /// </summary>
        public virtual string IPEventos
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for PortEventos in the schema.
        /// </summary>
        public virtual System.Nullable<int> PortEventos
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SMTPServer in the schema.
        /// </summary>
        public virtual string SMTPServer
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SMPTUser in the schema.
        /// </summary>
        public virtual string SMPTUser
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SMTPPwd in the schema.
        /// </summary>
        public virtual string SMTPPwd
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SMTPPort in the schema.
        /// </summary>
        public virtual System.Nullable<int> SMTPPort
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SMTPFrom in the schema.
        /// </summary>
        public virtual string SMTPFrom
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for URLSitio in the schema.
        /// </summary>
        public virtual string URLSitio
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for EmailInfo in the schema.
        /// </summary>
        public virtual string EmailInfo
        {
            get;
            set;
        }
    }

}