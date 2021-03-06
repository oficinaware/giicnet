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
    /// There are no comments for DataGiic_LiagoModel.sys_familias in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FAMILIA
    /// SUBFAM
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="sys_familias")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sys_familias : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new sys_familias object.
        /// </summary>
        /// <param name="fAMILIA">Initial value of FAMILIA.</param>
        /// <param name="sUBFAM">Initial value of SUBFAM.</param>
        public static sys_familias Createsys_familias(string fAMILIA, string sUBFAM)
        {
            sys_familias sys_familias = new sys_familias();
            sys_familias.FAMILIA = fAMILIA;
            sys_familias.SUBFAM = sUBFAM;
            return sys_familias;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for FAMILIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string FAMILIA
        {
            get
            {
                string value = _FAMILIA;
                OnGetFAMILIA(ref value);
                return value;
            }
            set
            {
                if (_FAMILIA != value)
                {
                  OnFAMILIAChanging(ref value);
                  ReportPropertyChanging("FAMILIA");
                  _FAMILIA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("FAMILIA");
                  OnFAMILIAChanged();
              }
            }
        }
        private string _FAMILIA;
        partial void OnGetFAMILIA(ref string value);
        partial void OnFAMILIAChanging(ref string value);
        partial void OnFAMILIAChanged();
    
        /// <summary>
        /// There are no comments for SUBFAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string SUBFAM
        {
            get
            {
                string value = _SUBFAM;
                OnGetSUBFAM(ref value);
                return value;
            }
            set
            {
                if (_SUBFAM != value)
                {
                  OnSUBFAMChanging(ref value);
                  ReportPropertyChanging("SUBFAM");
                  _SUBFAM = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("SUBFAM");
                  OnSUBFAMChanged();
              }
            }
        }
        private string _SUBFAM;
        partial void OnGetSUBFAM(ref string value);
        partial void OnSUBFAMChanging(ref string value);
        partial void OnSUBFAMChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
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

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            sys_familias obj = new sys_familias();
            obj.FAMILIA = FAMILIA;
            obj.SUBFAM = SUBFAM;
            obj.DESCRICAO = DESCRICAO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          sys_familias toCompare = obj as sys_familias;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.FAMILIA, toCompare.FAMILIA))
            return false;
          if (!Object.Equals(this.SUBFAM, toCompare.SUBFAM))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + FAMILIA.GetHashCode();
          hashCode = (hashCode * 7) + SUBFAM.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
