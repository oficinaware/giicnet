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
    /// There are no comments for DataGiic_LiagoModel.dimensoes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// cod_dim
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="dimensoes")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class dimensoes : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new dimensoes object.
        /// </summary>
        /// <param name="cod_dim">Initial value of cod_dim.</param>
        public static dimensoes Createdimensoes(string cod_dim)
        {
            dimensoes dimensoes = new dimensoes();
            dimensoes.cod_dim = cod_dim;
            return dimensoes;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for cod_dim in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string cod_dim
        {
            get
            {
                string value = _cod_dim;
                OnGetcod_dim(ref value);
                return value;
            }
            set
            {
                if (_cod_dim != value)
                {
                  Oncod_dimChanging(ref value);
                  ReportPropertyChanging("cod_dim");
                  _cod_dim = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("cod_dim");
                  Oncod_dimChanged();
              }
            }
        }
        private string _cod_dim;
        partial void OnGetcod_dim(ref string value);
        partial void Oncod_dimChanging(ref string value);
        partial void Oncod_dimChanged();
    
        /// <summary>
        /// There are no comments for comp in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> comp
        {
            get
            {
                global::System.Nullable<double> value = _comp;
                OnGetcomp(ref value);
                return value;
            }
            set
            {
                if (_comp != value)
                {
                  OncompChanging(ref value);
                  ReportPropertyChanging("comp");
                  _comp = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("comp");
                  OncompChanged();
              }
            }
        }
        private global::System.Nullable<double> _comp;
        partial void OnGetcomp(ref global::System.Nullable<double> value);
        partial void OncompChanging(ref global::System.Nullable<double> value);
        partial void OncompChanged();
    
        /// <summary>
        /// There are no comments for larg in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> larg
        {
            get
            {
                global::System.Nullable<double> value = _larg;
                OnGetlarg(ref value);
                return value;
            }
            set
            {
                if (_larg != value)
                {
                  OnlargChanging(ref value);
                  ReportPropertyChanging("larg");
                  _larg = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("larg");
                  OnlargChanged();
              }
            }
        }
        private global::System.Nullable<double> _larg;
        partial void OnGetlarg(ref global::System.Nullable<double> value);
        partial void OnlargChanging(ref global::System.Nullable<double> value);
        partial void OnlargChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            dimensoes obj = new dimensoes();
            obj.cod_dim = cod_dim;
            obj.comp = comp;
            obj.larg = larg;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          dimensoes toCompare = obj as dimensoes;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.cod_dim, toCompare.cod_dim))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + cod_dim.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}