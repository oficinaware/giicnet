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
    /// There are no comments for DataGiic_LiagoModel.TabCodPostais in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CodDistrito
    /// CodPostal
    /// CodPostal_Ext
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TabCodPostais")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TabCodPostais : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TabCodPostais object.
        /// </summary>
        /// <param name="codDistrito">Initial value of CodDistrito.</param>
        /// <param name="codPostal">Initial value of CodPostal.</param>
        /// <param name="codPostal_Ext">Initial value of CodPostal_Ext.</param>
        /// <param name="codPostal_Localidade">Initial value of CodPostal_Localidade.</param>
        public static TabCodPostais CreateTabCodPostais(string codDistrito, string codPostal, string codPostal_Ext, string codPostal_Localidade)
        {
            TabCodPostais tabCodPostais = new TabCodPostais();
            tabCodPostais.CodDistrito = codDistrito;
            tabCodPostais.CodPostal = codPostal;
            tabCodPostais.CodPostal_Ext = codPostal_Ext;
            tabCodPostais.CodPostal_Localidade = codPostal_Localidade;
            return tabCodPostais;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CodDistrito in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CodDistrito
        {
            get
            {
                string value = _CodDistrito;
                OnGetCodDistrito(ref value);
                return value;
            }
            set
            {
                if (_CodDistrito != value)
                {
                  OnCodDistritoChanging(ref value);
                  ReportPropertyChanging("CodDistrito");
                  _CodDistrito = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CodDistrito");
                  OnCodDistritoChanged();
              }
            }
        }
        private string _CodDistrito;
        partial void OnGetCodDistrito(ref string value);
        partial void OnCodDistritoChanging(ref string value);
        partial void OnCodDistritoChanged();
    
        /// <summary>
        /// There are no comments for CodPostal in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CodPostal
        {
            get
            {
                string value = _CodPostal;
                OnGetCodPostal(ref value);
                return value;
            }
            set
            {
                if (_CodPostal != value)
                {
                  OnCodPostalChanging(ref value);
                  ReportPropertyChanging("CodPostal");
                  _CodPostal = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CodPostal");
                  OnCodPostalChanged();
              }
            }
        }
        private string _CodPostal;
        partial void OnGetCodPostal(ref string value);
        partial void OnCodPostalChanging(ref string value);
        partial void OnCodPostalChanged();
    
        /// <summary>
        /// There are no comments for CodPostal_Ext in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CodPostal_Ext
        {
            get
            {
                string value = _CodPostal_Ext;
                OnGetCodPostal_Ext(ref value);
                return value;
            }
            set
            {
                if (_CodPostal_Ext != value)
                {
                  OnCodPostal_ExtChanging(ref value);
                  ReportPropertyChanging("CodPostal_Ext");
                  _CodPostal_Ext = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CodPostal_Ext");
                  OnCodPostal_ExtChanged();
              }
            }
        }
        private string _CodPostal_Ext;
        partial void OnGetCodPostal_Ext(ref string value);
        partial void OnCodPostal_ExtChanging(ref string value);
        partial void OnCodPostal_ExtChanged();
    
        /// <summary>
        /// There are no comments for CodPostal_Localidade in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CodPostal_Localidade
        {
            get
            {
                string value = _CodPostal_Localidade;
                OnGetCodPostal_Localidade(ref value);
                return value;
            }
            set
            {
                if (_CodPostal_Localidade != value)
                {
                  OnCodPostal_LocalidadeChanging(ref value);
                  ReportPropertyChanging("CodPostal_Localidade");
                  _CodPostal_Localidade = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CodPostal_Localidade");
                  OnCodPostal_LocalidadeChanged();
              }
            }
        }
        private string _CodPostal_Localidade;
        partial void OnGetCodPostal_Localidade(ref string value);
        partial void OnCodPostal_LocalidadeChanging(ref string value);
        partial void OnCodPostal_LocalidadeChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TabCodPostais obj = new TabCodPostais();
            obj.CodDistrito = CodDistrito;
            obj.CodPostal = CodPostal;
            obj.CodPostal_Ext = CodPostal_Ext;
            obj.CodPostal_Localidade = CodPostal_Localidade;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TabCodPostais toCompare = obj as TabCodPostais;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CodDistrito, toCompare.CodDistrito))
            return false;
          if (!Object.Equals(this.CodPostal, toCompare.CodPostal))
            return false;
          if (!Object.Equals(this.CodPostal_Ext, toCompare.CodPostal_Ext))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CodDistrito.GetHashCode();
          hashCode = (hashCode * 7) + CodPostal.GetHashCode();
          hashCode = (hashCode * 7) + CodPostal_Ext.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
