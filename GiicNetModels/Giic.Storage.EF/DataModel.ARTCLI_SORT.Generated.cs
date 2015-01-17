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
    /// There are no comments for DataGiic_LiagoModel.ARTCLI_SORT in the schema.
    /// </summary>
    /// <KeyProperties>
    /// MODELO
    /// VARIANTE
    /// CLIENTE
    /// TIPSORT
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="ARTCLI_SORT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ARTCLI_SORT : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new ARTCLI_SORT object.
        /// </summary>
        /// <param name="mODELO">Initial value of MODELO.</param>
        /// <param name="vARIANTE">Initial value of VARIANTE.</param>
        /// <param name="cLIENTE">Initial value of CLIENTE.</param>
        /// <param name="tIPSORT">Initial value of TIPSORT.</param>
        /// <param name="rEFCLI">Initial value of REFCLI.</param>
        public static ARTCLI_SORT CreateARTCLI_SORT(string mODELO, string vARIANTE, string cLIENTE, string tIPSORT, string rEFCLI)
        {
            ARTCLI_SORT aRTCLI_SORT = new ARTCLI_SORT();
            aRTCLI_SORT.MODELO = mODELO;
            aRTCLI_SORT.VARIANTE = vARIANTE;
            aRTCLI_SORT.CLIENTE = cLIENTE;
            aRTCLI_SORT.TIPSORT = tIPSORT;
            aRTCLI_SORT.REFCLI = rEFCLI;
            return aRTCLI_SORT;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for MODELO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string MODELO
        {
            get
            {
                string value = _MODELO;
                OnGetMODELO(ref value);
                return value;
            }
            set
            {
                if (_MODELO != value)
                {
                  OnMODELOChanging(ref value);
                  ReportPropertyChanging("MODELO");
                  _MODELO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("MODELO");
                  OnMODELOChanged();
              }
            }
        }
        private string _MODELO;
        partial void OnGetMODELO(ref string value);
        partial void OnMODELOChanging(ref string value);
        partial void OnMODELOChanged();
    
        /// <summary>
        /// There are no comments for VARIANTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string VARIANTE
        {
            get
            {
                string value = _VARIANTE;
                OnGetVARIANTE(ref value);
                return value;
            }
            set
            {
                if (_VARIANTE != value)
                {
                  OnVARIANTEChanging(ref value);
                  ReportPropertyChanging("VARIANTE");
                  _VARIANTE = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("VARIANTE");
                  OnVARIANTEChanged();
              }
            }
        }
        private string _VARIANTE;
        partial void OnGetVARIANTE(ref string value);
        partial void OnVARIANTEChanging(ref string value);
        partial void OnVARIANTEChanged();
    
        /// <summary>
        /// There are no comments for CLIENTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CLIENTE
        {
            get
            {
                string value = _CLIENTE;
                OnGetCLIENTE(ref value);
                return value;
            }
            set
            {
                if (_CLIENTE != value)
                {
                  OnCLIENTEChanging(ref value);
                  ReportPropertyChanging("CLIENTE");
                  _CLIENTE = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CLIENTE");
                  OnCLIENTEChanged();
              }
            }
        }
        private string _CLIENTE;
        partial void OnGetCLIENTE(ref string value);
        partial void OnCLIENTEChanging(ref string value);
        partial void OnCLIENTEChanged();
    
        /// <summary>
        /// There are no comments for TIPSORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TIPSORT
        {
            get
            {
                string value = _TIPSORT;
                OnGetTIPSORT(ref value);
                return value;
            }
            set
            {
                if (_TIPSORT != value)
                {
                  OnTIPSORTChanging(ref value);
                  ReportPropertyChanging("TIPSORT");
                  _TIPSORT = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TIPSORT");
                  OnTIPSORTChanged();
              }
            }
        }
        private string _TIPSORT;
        partial void OnGetTIPSORT(ref string value);
        partial void OnTIPSORTChanging(ref string value);
        partial void OnTIPSORTChanged();
    
        /// <summary>
        /// There are no comments for REFCLI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string REFCLI
        {
            get
            {
                string value = _REFCLI;
                OnGetREFCLI(ref value);
                return value;
            }
            set
            {
                if (_REFCLI != value)
                {
                  OnREFCLIChanging(ref value);
                  ReportPropertyChanging("REFCLI");
                  _REFCLI = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("REFCLI");
                  OnREFCLIChanged();
              }
            }
        }
        private string _REFCLI;
        partial void OnGetREFCLI(ref string value);
        partial void OnREFCLIChanging(ref string value);
        partial void OnREFCLIChanged();
    
        /// <summary>
        /// There are no comments for CODBARRAS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string CODBARRAS
        {
            get
            {
                string value = _CODBARRAS;
                OnGetCODBARRAS(ref value);
                return value;
            }
            set
            {
                if (_CODBARRAS != value)
                {
                  OnCODBARRASChanging(ref value);
                  ReportPropertyChanging("CODBARRAS");
                  _CODBARRAS = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CODBARRAS");
                  OnCODBARRASChanged();
              }
            }
        }
        private string _CODBARRAS;
        partial void OnGetCODBARRAS(ref string value);
        partial void OnCODBARRASChanging(ref string value);
        partial void OnCODBARRASChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            ARTCLI_SORT obj = new ARTCLI_SORT();
            obj.MODELO = MODELO;
            obj.VARIANTE = VARIANTE;
            obj.CLIENTE = CLIENTE;
            obj.TIPSORT = TIPSORT;
            obj.REFCLI = REFCLI;
            obj.CODBARRAS = CODBARRAS;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          ARTCLI_SORT toCompare = obj as ARTCLI_SORT;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.MODELO, toCompare.MODELO))
            return false;
          if (!Object.Equals(this.VARIANTE, toCompare.VARIANTE))
            return false;
          if (!Object.Equals(this.CLIENTE, toCompare.CLIENTE))
            return false;
          if (!Object.Equals(this.TIPSORT, toCompare.TIPSORT))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + MODELO.GetHashCode();
          hashCode = (hashCode * 7) + VARIANTE.GetHashCode();
          hashCode = (hashCode * 7) + CLIENTE.GetHashCode();
          hashCode = (hashCode * 7) + TIPSORT.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
