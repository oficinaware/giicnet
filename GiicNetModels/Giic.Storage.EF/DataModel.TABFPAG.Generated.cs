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
    /// There are no comments for DataGiic_LiagoModel.TABFPAG in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FPAG
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABFPAG")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABFPAG : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABFPAG object.
        /// </summary>
        /// <param name="fPAG">Initial value of FPAG.</param>
        public static TABFPAG CreateTABFPAG(string fPAG)
        {
            TABFPAG tABFPAG = new TABFPAG();
            tABFPAG.FPAG = fPAG;
            return tABFPAG;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for FPAG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string FPAG
        {
            get
            {
                string value = _FPAG;
                OnGetFPAG(ref value);
                return value;
            }
            set
            {
                if (_FPAG != value)
                {
                  OnFPAGChanging(ref value);
                  ReportPropertyChanging("FPAG");
                  _FPAG = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("FPAG");
                  OnFPAGChanged();
              }
            }
        }
        private string _FPAG;
        partial void OnGetFPAG(ref string value);
        partial void OnFPAGChanging(ref string value);
        partial void OnFPAGChanged();
    
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
    
        /// <summary>
        /// There are no comments for TD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string TD
        {
            get
            {
                string value = _TD;
                OnGetTD(ref value);
                return value;
            }
            set
            {
                if (_TD != value)
                {
                  OnTDChanging(ref value);
                  ReportPropertyChanging("TD");
                  _TD = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TD");
                  OnTDChanged();
              }
            }
        }
        private string _TD;
        partial void OnGetTD(ref string value);
        partial void OnTDChanging(ref string value);
        partial void OnTDChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TABFPAG obj = new TABFPAG();
            obj.FPAG = FPAG;
            obj.DESCRICAO = DESCRICAO;
            obj.TD = TD;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABFPAG toCompare = obj as TABFPAG;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.FPAG, toCompare.FPAG))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + FPAG.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}