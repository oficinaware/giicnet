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
    /// There are no comments for DataGiic_LiagoModel.CCAT_TARIFAS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CATALOGO
    /// TARIFA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CCAT_TARIFAS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CCAT_TARIFAS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CCAT_TARIFAS object.
        /// </summary>
        /// <param name="cATALOGO">Initial value of CATALOGO.</param>
        /// <param name="tARIFA">Initial value of TARIFA.</param>
        public static CCAT_TARIFAS CreateCCAT_TARIFAS(string cATALOGO, string tARIFA)
        {
            CCAT_TARIFAS cCAT_TARIFAS = new CCAT_TARIFAS();
            cCAT_TARIFAS.CATALOGO = cATALOGO;
            cCAT_TARIFAS.TARIFA = tARIFA;
            return cCAT_TARIFAS;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CATALOGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CATALOGO
        {
            get
            {
                string value = _CATALOGO;
                OnGetCATALOGO(ref value);
                return value;
            }
            set
            {
                if (_CATALOGO != value)
                {
                  OnCATALOGOChanging(ref value);
                  ReportPropertyChanging("CATALOGO");
                  _CATALOGO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CATALOGO");
                  OnCATALOGOChanged();
              }
            }
        }
        private string _CATALOGO;
        partial void OnGetCATALOGO(ref string value);
        partial void OnCATALOGOChanging(ref string value);
        partial void OnCATALOGOChanged();
    
        /// <summary>
        /// There are no comments for TARIFA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TARIFA
        {
            get
            {
                string value = _TARIFA;
                OnGetTARIFA(ref value);
                return value;
            }
            set
            {
                if (_TARIFA != value)
                {
                  OnTARIFAChanging(ref value);
                  ReportPropertyChanging("TARIFA");
                  _TARIFA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TARIFA");
                  OnTARIFAChanged();
              }
            }
        }
        private string _TARIFA;
        partial void OnGetTARIFA(ref string value);
        partial void OnTARIFAChanging(ref string value);
        partial void OnTARIFAChanged();
    
        /// <summary>
        /// There are no comments for COEF in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> COEF
        {
            get
            {
                global::System.Nullable<decimal> value = _COEF;
                OnGetCOEF(ref value);
                return value;
            }
            set
            {
                if (_COEF != value)
                {
                  OnCOEFChanging(ref value);
                  ReportPropertyChanging("COEF");
                  _COEF = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("COEF");
                  OnCOEFChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _COEF;
        partial void OnGetCOEF(ref global::System.Nullable<decimal> value);
        partial void OnCOEFChanging(ref global::System.Nullable<decimal> value);
        partial void OnCOEFChanged();
    
        /// <summary>
        /// There are no comments for COMISSAO_AG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> COMISSAO_AG
        {
            get
            {
                global::System.Nullable<decimal> value = _COMISSAO_AG;
                OnGetCOMISSAO_AG(ref value);
                return value;
            }
            set
            {
                if (_COMISSAO_AG != value)
                {
                  OnCOMISSAO_AGChanging(ref value);
                  ReportPropertyChanging("COMISSAO_AG");
                  _COMISSAO_AG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("COMISSAO_AG");
                  OnCOMISSAO_AGChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _COMISSAO_AG;
        partial void OnGetCOMISSAO_AG(ref global::System.Nullable<decimal> value);
        partial void OnCOMISSAO_AGChanging(ref global::System.Nullable<decimal> value);
        partial void OnCOMISSAO_AGChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CCAT_TARIFAS obj = new CCAT_TARIFAS();
            obj.CATALOGO = CATALOGO;
            obj.TARIFA = TARIFA;
            obj.COEF = COEF;
            obj.COMISSAO_AG = COMISSAO_AG;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CCAT_TARIFAS toCompare = obj as CCAT_TARIFAS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CATALOGO, toCompare.CATALOGO))
            return false;
          if (!Object.Equals(this.TARIFA, toCompare.TARIFA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CATALOGO.GetHashCode();
          hashCode = (hashCode * 7) + TARIFA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}