//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace RuBiz
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Usuario))]
    public partial class MovtoFinanceira: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int Id_Movto
        {
            get { return _id_Movto; }
            set
            {
                if (_id_Movto != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'Id_Movto' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _id_Movto = value;
                    OnPropertyChanged("Id_Movto");
                }
            }
        }
        private int _id_Movto;
    
        [DataMember]
        public int Id_Usuario
        {
            get { return _id_Usuario; }
            set
            {
                if (_id_Usuario != value)
                {
                    ChangeTracker.RecordOriginalValue("Id_Usuario", _id_Usuario);
                    if (!IsDeserializing)
                    {
                        if (Usuario != null && Usuario.Id_Usuario != value)
                        {
                            Usuario = null;
                        }
                    }
                    _id_Usuario = value;
                    OnPropertyChanged("Id_Usuario");
                }
            }
        }
        private int _id_Usuario;
    
        [DataMember]
        public System.DateTime DataMovto
        {
            get { return _dataMovto; }
            set
            {
                if (_dataMovto != value)
                {
                    _dataMovto = value;
                    OnPropertyChanged("DataMovto");
                }
            }
        }
        private System.DateTime _dataMovto;
    
        [DataMember]
        public decimal Valor
        {
            get { return _valor; }
            set
            {
                if (_valor != value)
                {
                    _valor = value;
                    OnPropertyChanged("Valor");
                }
            }
        }
        private decimal _valor;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Usuario Usuario
        {
            get { return _usuario; }
            set
            {
                if (!ReferenceEquals(_usuario, value))
                {
                    var previousValue = _usuario;
                    _usuario = value;
                    FixupUsuario(previousValue);
                    OnNavigationPropertyChanged("Usuario");
                }
            }
        }
        private Usuario _usuario;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            Usuario = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupUsuario(Usuario previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.MovtoFinanceira.Contains(this))
            {
                previousValue.MovtoFinanceira.Remove(this);
            }
    
            if (Usuario != null)
            {
                if (!Usuario.MovtoFinanceira.Contains(this))
                {
                    Usuario.MovtoFinanceira.Add(this);
                }
    
                Id_Usuario = Usuario.Id_Usuario;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Usuario")
                    && (ChangeTracker.OriginalValues["Usuario"] == Usuario))
                {
                    ChangeTracker.OriginalValues.Remove("Usuario");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Usuario", previousValue);
                }
                if (Usuario != null && !Usuario.ChangeTracker.ChangeTrackingEnabled)
                {
                    Usuario.StartTracking();
                }
            }
        }

        #endregion
    }
}