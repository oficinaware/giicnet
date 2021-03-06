﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework EntityObject template.
// Code is generated on: 08-11-2014 10:46:01
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

namespace DataGiic_LiagoModel
{

    /// <summary>
    /// There are no comments for DataGiic_LiagoModel.ProductCAD in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Key
    /// Version
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="ProductCAD")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ProductCAD : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new ProductCAD object.
        /// </summary>
        /// <param name="key">Initial value of Key.</param>
        /// <param name="version">Initial value of Version.</param>
        public static ProductCAD CreateProductCAD(string key, string version)
        {
            ProductCAD productCAD = new ProductCAD();
            productCAD.Key = key;
            productCAD.Version = version;
            return productCAD;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for Key in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(13)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string Key
        {
            get
            {
                string value = _Key;
                OnGetKey(ref value);
                return value;
            }
            set
            {
                if (_Key != value)
                {
                  OnKeyChanging(ref value);
                  ReportPropertyChanging("Key");
                  _Key = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Key");
                  OnKeyChanged();
              }
            }
        }
        private string _Key;
        partial void OnGetKey(ref string value);
        partial void OnKeyChanging(ref string value);
        partial void OnKeyChanged();
    
        /// <summary>
        /// There are no comments for Version in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string Version
        {
            get
            {
                string value = _Version;
                OnGetVersion(ref value);
                return value;
            }
            set
            {
                if (_Version != value)
                {
                  OnVersionChanging(ref value);
                  ReportPropertyChanging("Version");
                  _Version = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Version");
                  OnVersionChanged();
              }
            }
        }
        private string _Version;
        partial void OnGetVersion(ref string value);
        partial void OnVersionChanging(ref string value);
        partial void OnVersionChanged();
    
        /// <summary>
        /// There are no comments for Forma in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Forma
        {
            get
            {
                string value = _Forma;
                OnGetForma(ref value);
                return value;
            }
            set
            {
                if (_Forma != value)
                {
                  OnFormaChanging(ref value);
                  ReportPropertyChanging("Forma");
                  _Forma = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Forma");
                  OnFormaChanged();
              }
            }
        }
        private string _Forma = @"";
        partial void OnGetForma(ref string value);
        partial void OnFormaChanging(ref string value);
        partial void OnFormaChanged();
    
        /// <summary>
        /// There are no comments for Solado in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Solado
        {
            get
            {
                string value = _Solado;
                OnGetSolado(ref value);
                return value;
            }
            set
            {
                if (_Solado != value)
                {
                  OnSoladoChanging(ref value);
                  ReportPropertyChanging("Solado");
                  _Solado = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Solado");
                  OnSoladoChanged();
              }
            }
        }
        private string _Solado = @"";
        partial void OnGetSolado(ref string value);
        partial void OnSoladoChanging(ref string value);
        partial void OnSoladoChanged();
    
        /// <summary>
        /// There are no comments for Cor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Cor
        {
            get
            {
                string value = _Cor;
                OnGetCor(ref value);
                return value;
            }
            set
            {
                if (_Cor != value)
                {
                  OnCorChanging(ref value);
                  ReportPropertyChanging("Cor");
                  _Cor = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Cor");
                  OnCorChanged();
              }
            }
        }
        private string _Cor = @"";
        partial void OnGetCor(ref string value);
        partial void OnCorChanging(ref string value);
        partial void OnCorChanged();
    
        /// <summary>
        /// There are no comments for Pele in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Pele
        {
            get
            {
                string value = _Pele;
                OnGetPele(ref value);
                return value;
            }
            set
            {
                if (_Pele != value)
                {
                  OnPeleChanging(ref value);
                  ReportPropertyChanging("Pele");
                  _Pele = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Pele");
                  OnPeleChanged();
              }
            }
        }
        private string _Pele = @"";
        partial void OnGetPele(ref string value);
        partial void OnPeleChanging(ref string value);
        partial void OnPeleChanged();
    
        /// <summary>
        /// There are no comments for Forro in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Forro
        {
            get
            {
                string value = _Forro;
                OnGetForro(ref value);
                return value;
            }
            set
            {
                if (_Forro != value)
                {
                  OnForroChanging(ref value);
                  ReportPropertyChanging("Forro");
                  _Forro = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Forro");
                  OnForroChanged();
              }
            }
        }
        private string _Forro = @"";
        partial void OnGetForro(ref string value);
        partial void OnForroChanging(ref string value);
        partial void OnForroChanged();
    
        /// <summary>
        /// There are no comments for DataHora in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DataHora
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DataHora;
                OnGetDataHora(ref value);
                return value;
            }
            set
            {
                if (_DataHora != value)
                {
                  OnDataHoraChanging(ref value);
                  ReportPropertyChanging("DataHora");
                  _DataHora = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DataHora");
                  OnDataHoraChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DataHora = DateTime.Now;
        partial void OnGetDataHora(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataHoraChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataHoraChanged();
    
        /// <summary>
        /// There are no comments for Integrado in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> Integrado
        {
            get
            {
                global::System.Nullable<bool> value = _Integrado;
                OnGetIntegrado(ref value);
                return value;
            }
            set
            {
                if (_Integrado != value)
                {
                  OnIntegradoChanging(ref value);
                  ReportPropertyChanging("Integrado");
                  _Integrado = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Integrado");
                  OnIntegradoChanged();
              }
            }
        }
        private global::System.Nullable<bool> _Integrado;
        partial void OnGetIntegrado(ref global::System.Nullable<bool> value);
        partial void OnIntegradoChanging(ref global::System.Nullable<bool> value);
        partial void OnIntegradoChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            ProductCAD obj = new ProductCAD();
            obj.Key = Key;
            obj.Version = Version;
            obj.Forma = Forma;
            obj.Solado = Solado;
            obj.Cor = Cor;
            obj.Pele = Pele;
            obj.Forro = Forro;
            obj.DataHora = DataHora;
            obj.Integrado = Integrado;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          ProductCAD toCompare = obj as ProductCAD;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Key, toCompare.Key))
            return false;
          if (!Object.Equals(this.Version, toCompare.Version))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Key.GetHashCode();
          hashCode = (hashCode * 7) + Version.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
