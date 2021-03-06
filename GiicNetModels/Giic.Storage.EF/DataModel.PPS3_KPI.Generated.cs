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
    /// There are no comments for DataGiic_LiagoModel.PPS3_KPI in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID_SESSAO
    /// COD_KPI
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="PPS3_KPI")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PPS3_KPI : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new PPS3_KPI object.
        /// </summary>
        /// <param name="iD_SESSAO">Initial value of ID_SESSAO.</param>
        /// <param name="cOD_KPI">Initial value of COD_KPI.</param>
        public static PPS3_KPI CreatePPS3_KPI(string iD_SESSAO, string cOD_KPI)
        {
            PPS3_KPI pPS3_KPI = new PPS3_KPI();
            pPS3_KPI.ID_SESSAO = iD_SESSAO;
            pPS3_KPI.COD_KPI = cOD_KPI;
            return pPS3_KPI;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID_SESSAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ID_SESSAO
        {
            get
            {
                string value = _ID_SESSAO;
                OnGetID_SESSAO(ref value);
                return value;
            }
            set
            {
                if (_ID_SESSAO != value)
                {
                  OnID_SESSAOChanging(ref value);
                  ReportPropertyChanging("ID_SESSAO");
                  _ID_SESSAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ID_SESSAO");
                  OnID_SESSAOChanged();
              }
            }
        }
        private string _ID_SESSAO;
        partial void OnGetID_SESSAO(ref string value);
        partial void OnID_SESSAOChanging(ref string value);
        partial void OnID_SESSAOChanged();
    
        /// <summary>
        /// There are no comments for COD_KPI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string COD_KPI
        {
            get
            {
                string value = _COD_KPI;
                OnGetCOD_KPI(ref value);
                return value;
            }
            set
            {
                if (_COD_KPI != value)
                {
                  OnCOD_KPIChanging(ref value);
                  ReportPropertyChanging("COD_KPI");
                  _COD_KPI = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("COD_KPI");
                  OnCOD_KPIChanged();
              }
            }
        }
        private string _COD_KPI;
        partial void OnGetCOD_KPI(ref string value);
        partial void OnCOD_KPIChanging(ref string value);
        partial void OnCOD_KPIChanged();
    
        /// <summary>
        /// There are no comments for VALOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VALOR
        {
            get
            {
                global::System.Nullable<decimal> value = _VALOR;
                OnGetVALOR(ref value);
                return value;
            }
            set
            {
                if (_VALOR != value)
                {
                  OnVALORChanging(ref value);
                  ReportPropertyChanging("VALOR");
                  _VALOR = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VALOR");
                  OnVALORChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VALOR;
        partial void OnGetVALOR(ref global::System.Nullable<decimal> value);
        partial void OnVALORChanging(ref global::System.Nullable<decimal> value);
        partial void OnVALORChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            PPS3_KPI obj = new PPS3_KPI();
            obj.ID_SESSAO = ID_SESSAO;
            obj.COD_KPI = COD_KPI;
            obj.VALOR = VALOR;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          PPS3_KPI toCompare = obj as PPS3_KPI;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ID_SESSAO, toCompare.ID_SESSAO))
            return false;
          if (!Object.Equals(this.COD_KPI, toCompare.COD_KPI))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ID_SESSAO.GetHashCode();
          hashCode = (hashCode * 7) + COD_KPI.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
