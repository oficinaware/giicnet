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
    /// There are no comments for DataGiic_LiagoModel.tabeuro in the schema.
    /// </summary>
    /// <KeyProperties>
    /// MOEDA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="tabeuro")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tabeuro : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new tabeuro object.
        /// </summary>
        /// <param name="mOEDA">Initial value of MOEDA.</param>
        /// <param name="uEM">Initial value of UEM.</param>
        public static tabeuro Createtabeuro(string mOEDA, bool uEM)
        {
            tabeuro tabeuro = new tabeuro();
            tabeuro.MOEDA = mOEDA;
            tabeuro.UEM = uEM;
            return tabeuro;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for MOEDA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string MOEDA
        {
            get
            {
                string value = _MOEDA;
                OnGetMOEDA(ref value);
                return value;
            }
            set
            {
                if (_MOEDA != value)
                {
                  OnMOEDAChanging(ref value);
                  ReportPropertyChanging("MOEDA");
                  _MOEDA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("MOEDA");
                  OnMOEDAChanged();
              }
            }
        }
        private string _MOEDA;
        partial void OnGetMOEDA(ref string value);
        partial void OnMOEDAChanging(ref string value);
        partial void OnMOEDAChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
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
        /// There are no comments for COMPRA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> COMPRA
        {
            get
            {
                global::System.Nullable<decimal> value = _COMPRA;
                OnGetCOMPRA(ref value);
                return value;
            }
            set
            {
                if (_COMPRA != value)
                {
                  OnCOMPRAChanging(ref value);
                  ReportPropertyChanging("COMPRA");
                  _COMPRA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("COMPRA");
                  OnCOMPRAChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _COMPRA;
        partial void OnGetCOMPRA(ref global::System.Nullable<decimal> value);
        partial void OnCOMPRAChanging(ref global::System.Nullable<decimal> value);
        partial void OnCOMPRAChanged();
    
        /// <summary>
        /// There are no comments for VENDA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VENDA
        {
            get
            {
                global::System.Nullable<decimal> value = _VENDA;
                OnGetVENDA(ref value);
                return value;
            }
            set
            {
                if (_VENDA != value)
                {
                  OnVENDAChanging(ref value);
                  ReportPropertyChanging("VENDA");
                  _VENDA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VENDA");
                  OnVENDAChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VENDA;
        partial void OnGetVENDA(ref global::System.Nullable<decimal> value);
        partial void OnVENDAChanging(ref global::System.Nullable<decimal> value);
        partial void OnVENDAChanged();
    
        /// <summary>
        /// There are no comments for DTCAMBIO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DTCAMBIO
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DTCAMBIO;
                OnGetDTCAMBIO(ref value);
                return value;
            }
            set
            {
                if (_DTCAMBIO != value)
                {
                  OnDTCAMBIOChanging(ref value);
                  ReportPropertyChanging("DTCAMBIO");
                  _DTCAMBIO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DTCAMBIO");
                  OnDTCAMBIOChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DTCAMBIO;
        partial void OnGetDTCAMBIO(ref global::System.Nullable<System.DateTime> value);
        partial void OnDTCAMBIOChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDTCAMBIOChanged();
    
        /// <summary>
        /// There are no comments for COD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string COD
        {
            get
            {
                string value = _COD;
                OnGetCOD(ref value);
                return value;
            }
            set
            {
                if (_COD != value)
                {
                  OnCODChanging(ref value);
                  ReportPropertyChanging("COD");
                  _COD = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COD");
                  OnCODChanged();
              }
            }
        }
        private string _COD;
        partial void OnGetCOD(ref string value);
        partial void OnCODChanging(ref string value);
        partial void OnCODChanged();
    
        /// <summary>
        /// There are no comments for UEM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public bool UEM
        {
            get
            {
                bool value = _UEM;
                OnGetUEM(ref value);
                return value;
            }
            set
            {
                if (_UEM != value)
                {
                  OnUEMChanging(ref value);
                  ReportPropertyChanging("UEM");
                  _UEM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("UEM");
                  OnUEMChanged();
              }
            }
        }
        private bool _UEM;
        partial void OnGetUEM(ref bool value);
        partial void OnUEMChanging(ref bool value);
        partial void OnUEMChanged();
    
        /// <summary>
        /// There are no comments for FACTOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> FACTOR
        {
            get
            {
                global::System.Nullable<decimal> value = _FACTOR;
                OnGetFACTOR(ref value);
                return value;
            }
            set
            {
                if (_FACTOR != value)
                {
                  OnFACTORChanging(ref value);
                  ReportPropertyChanging("FACTOR");
                  _FACTOR = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("FACTOR");
                  OnFACTORChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _FACTOR = 1m;
        partial void OnGetFACTOR(ref global::System.Nullable<decimal> value);
        partial void OnFACTORChanging(ref global::System.Nullable<decimal> value);
        partial void OnFACTORChanged();
    
        /// <summary>
        /// There are no comments for DECIMAIS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> DECIMAIS
        {
            get
            {
                global::System.Nullable<decimal> value = _DECIMAIS;
                OnGetDECIMAIS(ref value);
                return value;
            }
            set
            {
                if (_DECIMAIS != value)
                {
                  OnDECIMAISChanging(ref value);
                  ReportPropertyChanging("DECIMAIS");
                  _DECIMAIS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DECIMAIS");
                  OnDECIMAISChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _DECIMAIS = 0m;
        partial void OnGetDECIMAIS(ref global::System.Nullable<decimal> value);
        partial void OnDECIMAISChanging(ref global::System.Nullable<decimal> value);
        partial void OnDECIMAISChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            tabeuro obj = new tabeuro();
            obj.MOEDA = MOEDA;
            obj.DESCRICAO = DESCRICAO;
            obj.COMPRA = COMPRA;
            obj.VENDA = VENDA;
            obj.DTCAMBIO = DTCAMBIO;
            obj.COD = COD;
            obj.UEM = UEM;
            obj.FACTOR = FACTOR;
            obj.DECIMAIS = DECIMAIS;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          tabeuro toCompare = obj as tabeuro;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.MOEDA, toCompare.MOEDA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + MOEDA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
