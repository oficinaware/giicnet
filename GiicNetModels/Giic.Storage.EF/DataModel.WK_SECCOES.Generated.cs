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
    /// There are no comments for DataGiic_LiagoModel.WK_SECCOES in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SECCAO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_SECCOES")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_SECCOES : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_SECCOES object.
        /// </summary>
        /// <param name="sECCAO">Initial value of SECCAO.</param>
        public static WK_SECCOES CreateWK_SECCOES(string sECCAO)
        {
            WK_SECCOES wK_SECCOES = new WK_SECCOES();
            wK_SECCOES.SECCAO = sECCAO;
            return wK_SECCOES;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for SECCAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string SECCAO
        {
            get
            {
                string value = _SECCAO;
                OnGetSECCAO(ref value);
                return value;
            }
            set
            {
                if (_SECCAO != value)
                {
                  OnSECCAOChanging(ref value);
                  ReportPropertyChanging("SECCAO");
                  _SECCAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("SECCAO");
                  OnSECCAOChanged();
              }
            }
        }
        private string _SECCAO;
        partial void OnGetSECCAO(ref string value);
        partial void OnSECCAOChanging(ref string value);
        partial void OnSECCAOChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string DESCRICAO
        {
            get
            {
                string value = _DESCRICAO;
                OnGetDESCRICAO(ref value);
                return value;
            }
            set
            {
                if (_DESCRICAO != value)
                {
                  OnDESCRICAOChanging(ref value);
                  ReportPropertyChanging("DESCRICAO");
                  _DESCRICAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DESCRICAO");
                  OnDESCRICAOChanged();
              }
            }
        }
        private string _DESCRICAO;
        partial void OnGetDESCRICAO(ref string value);
        partial void OnDESCRICAOChanging(ref string value);
        partial void OnDESCRICAOChanged();
    
        /// <summary>
        /// There are no comments for STAT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> STAT
        {
            get
            {
                global::System.Nullable<bool> value = _STAT;
                OnGetSTAT(ref value);
                return value;
            }
            set
            {
                if (_STAT != value)
                {
                  OnSTATChanging(ref value);
                  ReportPropertyChanging("STAT");
                  _STAT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("STAT");
                  OnSTATChanged();
              }
            }
        }
        private global::System.Nullable<bool> _STAT;
        partial void OnGetSTAT(ref global::System.Nullable<bool> value);
        partial void OnSTATChanging(ref global::System.Nullable<bool> value);
        partial void OnSTATChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_SECCOES obj = new WK_SECCOES();
            obj.SECCAO = SECCAO;
            obj.DESCRICAO = DESCRICAO;
            obj.STAT = STAT;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_SECCOES toCompare = obj as WK_SECCOES;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SECCAO, toCompare.SECCAO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SECCAO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
