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
    /// There are no comments for DataGiic_LiagoModel.ROTEIRO_PLAN in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ORDFAB
    /// LOTE
    /// OPERACAO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="ROTEIRO_PLAN")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ROTEIRO_PLAN : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new ROTEIRO_PLAN object.
        /// </summary>
        /// <param name="oRDFAB">Initial value of ORDFAB.</param>
        /// <param name="lOTE">Initial value of LOTE.</param>
        /// <param name="oPERACAO">Initial value of OPERACAO.</param>
        public static ROTEIRO_PLAN CreateROTEIRO_PLAN(string oRDFAB, int lOTE, string oPERACAO)
        {
            ROTEIRO_PLAN rOTEIRO_PLAN = new ROTEIRO_PLAN();
            rOTEIRO_PLAN.ORDFAB = oRDFAB;
            rOTEIRO_PLAN.LOTE = lOTE;
            rOTEIRO_PLAN.OPERACAO = oPERACAO;
            return rOTEIRO_PLAN;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ORDFAB in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ORDFAB
        {
            get
            {
                string value = _ORDFAB;
                OnGetORDFAB(ref value);
                return value;
            }
            set
            {
                if (_ORDFAB != value)
                {
                  OnORDFABChanging(ref value);
                  ReportPropertyChanging("ORDFAB");
                  _ORDFAB = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ORDFAB");
                  OnORDFABChanged();
              }
            }
        }
        private string _ORDFAB;
        partial void OnGetORDFAB(ref string value);
        partial void OnORDFABChanging(ref string value);
        partial void OnORDFABChanged();
    
        /// <summary>
        /// There are no comments for LOTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LOTE
        {
            get
            {
                int value = _LOTE;
                OnGetLOTE(ref value);
                return value;
            }
            set
            {
                if (_LOTE != value)
                {
                  OnLOTEChanging(ref value);
                  ReportPropertyChanging("LOTE");
                  _LOTE = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LOTE");
                  OnLOTEChanged();
              }
            }
        }
        private int _LOTE;
        partial void OnGetLOTE(ref int value);
        partial void OnLOTEChanging(ref int value);
        partial void OnLOTEChanged();
    
        /// <summary>
        /// There are no comments for OPERACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string OPERACAO
        {
            get
            {
                string value = _OPERACAO;
                OnGetOPERACAO(ref value);
                return value;
            }
            set
            {
                if (_OPERACAO != value)
                {
                  OnOPERACAOChanging(ref value);
                  ReportPropertyChanging("OPERACAO");
                  _OPERACAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("OPERACAO");
                  OnOPERACAOChanged();
              }
            }
        }
        private string _OPERACAO;
        partial void OnGetOPERACAO(ref string value);
        partial void OnOPERACAOChanging(ref string value);
        partial void OnOPERACAOChanged();
    
        /// <summary>
        /// There are no comments for SECCAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
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
                  _SECCAO = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for DATA_PLAN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_PLAN
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_PLAN;
                OnGetDATA_PLAN(ref value);
                return value;
            }
            set
            {
                if (_DATA_PLAN != value)
                {
                  OnDATA_PLANChanging(ref value);
                  ReportPropertyChanging("DATA_PLAN");
                  _DATA_PLAN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_PLAN");
                  OnDATA_PLANChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_PLAN;
        partial void OnGetDATA_PLAN(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_PLANChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_PLANChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            ROTEIRO_PLAN obj = new ROTEIRO_PLAN();
            obj.ORDFAB = ORDFAB;
            obj.LOTE = LOTE;
            obj.OPERACAO = OPERACAO;
            obj.SECCAO = SECCAO;
            obj.DATA_PLAN = DATA_PLAN;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          ROTEIRO_PLAN toCompare = obj as ROTEIRO_PLAN;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ORDFAB, toCompare.ORDFAB))
            return false;
          if (!Object.Equals(this.LOTE, toCompare.LOTE))
            return false;
          if (!Object.Equals(this.OPERACAO, toCompare.OPERACAO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ORDFAB.GetHashCode();
          hashCode = (hashCode * 7) + LOTE.GetHashCode();
          hashCode = (hashCode * 7) + OPERACAO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
