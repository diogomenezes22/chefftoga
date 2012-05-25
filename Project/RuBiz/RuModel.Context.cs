﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace RuBiz
{
    public partial class CheffTogaEntities : ObjectContext
    {
        public const string ConnectionString = "name=CheffTogaEntities";
        public const string ContainerName = "CheffTogaEntities";
    
        #region Constructors
    
        public CheffTogaEntities()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public CheffTogaEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public CheffTogaEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // Creating proxies requires the use of the ProxyDataContractResolver and
            // may allow lazy loading which can expand the loaded graph during serialization.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Curso> Curso
        {
            get { return _curso  ?? (_curso = CreateObjectSet<Curso>("Curso")); }
        }
        private ObjectSet<Curso> _curso;
    
        public ObjectSet<InstituicaoEnsino> InstituicaoEnsino
        {
            get { return _instituicaoEnsino  ?? (_instituicaoEnsino = CreateObjectSet<InstituicaoEnsino>("InstituicaoEnsino")); }
        }
        private ObjectSet<InstituicaoEnsino> _instituicaoEnsino;
    
        public ObjectSet<sysdiagrams> sysdiagrams
        {
            get { return _sysdiagrams  ?? (_sysdiagrams = CreateObjectSet<sysdiagrams>("sysdiagrams")); }
        }
        private ObjectSet<sysdiagrams> _sysdiagrams;
    
        public ObjectSet<TipoUsuario> TipoUsuario
        {
            get { return _tipoUsuario  ?? (_tipoUsuario = CreateObjectSet<TipoUsuario>("TipoUsuario")); }
        }
        private ObjectSet<TipoUsuario> _tipoUsuario;
    
        public ObjectSet<Usuario> Usuario
        {
            get { return _usuario  ?? (_usuario = CreateObjectSet<Usuario>("Usuario")); }
        }
        private ObjectSet<Usuario> _usuario;

        #endregion
    }
}
