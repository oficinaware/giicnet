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
    /// There are no comments for DataGiic_LiagoModel.CARACT_LNENCO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NRENCO
    /// LNENCO
    /// FAMILIA
    /// IDOTAM
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CARACT_LNENCO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CARACT_LNENCO : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CARACT_LNENCO object.
        /// </summary>
        /// <param name="nRENCO">Initial value of NRENCO.</param>
        /// <param name="lNENCO">Initial value of LNENCO.</param>
        /// <param name="fAMILIA">Initial value of FAMILIA.</param>
        /// <param name="iDOTAM">Initial value of IDOTAM.</param>
        /// <param name="iAOTAM">Initial value of IAOTAM.</param>
        /// <param name="dOTAM">Initial value of DOTAM.</param>
        /// <param name="aOTAM">Initial value of AOTAM.</param>
        /// <param name="pOS">Initial value of POS.</param>
        /// <param name="cOMPONENTE">Initial value of COMPONENTE.</param>
        /// <param name="cARTAZ">Initial value of CARTAZ.</param>
        /// <param name="cODCOR">Initial value of CODCOR.</param>
        /// <param name="cONSUMO_UN">Initial value of CONSUMO_UN.</param>
        /// <param name="oPERACAO">Initial value of OPERACAO.</param>
        /// <param name="tAMC">Initial value of TAMC.</param>
        /// <param name="iNTEGRADO">Initial value of INTEGRADO.</param>
        public static CARACT_LNENCO CreateCARACT_LNENCO(string nRENCO, int lNENCO, string fAMILIA, int iDOTAM, int iAOTAM, string dOTAM, string aOTAM, int pOS, string cOMPONENTE, string cARTAZ, string cODCOR, decimal cONSUMO_UN, string oPERACAO, string tAMC, bool iNTEGRADO)
        {
            CARACT_LNENCO cARACT_LNENCO = new CARACT_LNENCO();
            cARACT_LNENCO.NRENCO = nRENCO;
            cARACT_LNENCO.LNENCO = lNENCO;
            cARACT_LNENCO.FAMILIA = fAMILIA;
            cARACT_LNENCO.IDOTAM = iDOTAM;
            cARACT_LNENCO.IAOTAM = iAOTAM;
            cARACT_LNENCO.DOTAM = dOTAM;
            cARACT_LNENCO.AOTAM = aOTAM;
            cARACT_LNENCO.POS = pOS;
            cARACT_LNENCO.COMPONENTE = cOMPONENTE;
            cARACT_LNENCO.CARTAZ = cARTAZ;
            cARACT_LNENCO.CODCOR = cODCOR;
            cARACT_LNENCO.CONSUMO_UN = cONSUMO_UN;
            cARACT_LNENCO.OPERACAO = oPERACAO;
            cARACT_LNENCO.TAMC = tAMC;
            cARACT_LNENCO.INTEGRADO = iNTEGRADO;
            return cARACT_LNENCO;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for NRENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string NRENCO
        {
            get
            {
                string value = _NRENCO;
                OnGetNRENCO(ref value);
                return value;
            }
            set
            {
                if (_NRENCO != value)
                {
                  OnNRENCOChanging(ref value);
                  ReportPropertyChanging("NRENCO");
                  _NRENCO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("NRENCO");
                  OnNRENCOChanged();
              }
            }
        }
        private string _NRENCO;
        partial void OnGetNRENCO(ref string value);
        partial void OnNRENCOChanging(ref string value);
        partial void OnNRENCOChanged();
    
        /// <summary>
        /// There are no comments for LNENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LNENCO
        {
            get
            {
                int value = _LNENCO;
                OnGetLNENCO(ref value);
                return value;
            }
            set
            {
                if (_LNENCO != value)
                {
                  OnLNENCOChanging(ref value);
                  ReportPropertyChanging("LNENCO");
                  _LNENCO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNENCO");
                  OnLNENCOChanged();
              }
            }
        }
        private int _LNENCO;
        partial void OnGetLNENCO(ref int value);
        partial void OnLNENCOChanging(ref int value);
        partial void OnLNENCOChanged();
    
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
        /// There are no comments for IDOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int IDOTAM
        {
            get
            {
                int value = _IDOTAM;
                OnGetIDOTAM(ref value);
                return value;
            }
            set
            {
                if (_IDOTAM != value)
                {
                  OnIDOTAMChanging(ref value);
                  ReportPropertyChanging("IDOTAM");
                  _IDOTAM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("IDOTAM");
                  OnIDOTAMChanged();
              }
            }
        }
        private int _IDOTAM;
        partial void OnGetIDOTAM(ref int value);
        partial void OnIDOTAMChanging(ref int value);
        partial void OnIDOTAMChanged();
    
        /// <summary>
        /// There are no comments for IAOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public int IAOTAM
        {
            get
            {
                int value = _IAOTAM;
                OnGetIAOTAM(ref value);
                return value;
            }
            set
            {
                if (_IAOTAM != value)
                {
                  OnIAOTAMChanging(ref value);
                  ReportPropertyChanging("IAOTAM");
                  _IAOTAM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("IAOTAM");
                  OnIAOTAMChanged();
              }
            }
        }
        private int _IAOTAM;
        partial void OnGetIAOTAM(ref int value);
        partial void OnIAOTAMChanging(ref int value);
        partial void OnIAOTAMChanged();
    
        /// <summary>
        /// There are no comments for DOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string DOTAM
        {
            get
            {
                string value = _DOTAM;
                OnGetDOTAM(ref value);
                return value;
            }
            set
            {
                if (_DOTAM != value)
                {
                  OnDOTAMChanging(ref value);
                  ReportPropertyChanging("DOTAM");
                  _DOTAM = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("DOTAM");
                  OnDOTAMChanged();
              }
            }
        }
        private string _DOTAM;
        partial void OnGetDOTAM(ref string value);
        partial void OnDOTAMChanging(ref string value);
        partial void OnDOTAMChanged();
    
        /// <summary>
        /// There are no comments for AOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string AOTAM
        {
            get
            {
                string value = _AOTAM;
                OnGetAOTAM(ref value);
                return value;
            }
            set
            {
                if (_AOTAM != value)
                {
                  OnAOTAMChanging(ref value);
                  ReportPropertyChanging("AOTAM");
                  _AOTAM = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("AOTAM");
                  OnAOTAMChanged();
              }
            }
        }
        private string _AOTAM;
        partial void OnGetAOTAM(ref string value);
        partial void OnAOTAMChanging(ref string value);
        partial void OnAOTAMChanged();
    
        /// <summary>
        /// There are no comments for POS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public int POS
        {
            get
            {
                int value = _POS;
                OnGetPOS(ref value);
                return value;
            }
            set
            {
                if (_POS != value)
                {
                  OnPOSChanging(ref value);
                  ReportPropertyChanging("POS");
                  _POS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("POS");
                  OnPOSChanged();
              }
            }
        }
        private int _POS;
        partial void OnGetPOS(ref int value);
        partial void OnPOSChanging(ref int value);
        partial void OnPOSChanged();
    
        /// <summary>
        /// There are no comments for COMPONENTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string COMPONENTE
        {
            get
            {
                string value = _COMPONENTE;
                OnGetCOMPONENTE(ref value);
                return value;
            }
            set
            {
                if (_COMPONENTE != value)
                {
                  OnCOMPONENTEChanging(ref value);
                  ReportPropertyChanging("COMPONENTE");
                  _COMPONENTE = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("COMPONENTE");
                  OnCOMPONENTEChanged();
              }
            }
        }
        private string _COMPONENTE;
        partial void OnGetCOMPONENTE(ref string value);
        partial void OnCOMPONENTEChanging(ref string value);
        partial void OnCOMPONENTEChanged();
    
        /// <summary>
        /// There are no comments for CARTAZ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CARTAZ
        {
            get
            {
                string value = _CARTAZ;
                OnGetCARTAZ(ref value);
                return value;
            }
            set
            {
                if (_CARTAZ != value)
                {
                  OnCARTAZChanging(ref value);
                  ReportPropertyChanging("CARTAZ");
                  _CARTAZ = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CARTAZ");
                  OnCARTAZChanged();
              }
            }
        }
        private string _CARTAZ = @"space((5))";
        partial void OnGetCARTAZ(ref string value);
        partial void OnCARTAZChanging(ref string value);
        partial void OnCARTAZChanged();
    
        /// <summary>
        /// There are no comments for CODCOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODCOR
        {
            get
            {
                string value = _CODCOR;
                OnGetCODCOR(ref value);
                return value;
            }
            set
            {
                if (_CODCOR != value)
                {
                  OnCODCORChanging(ref value);
                  ReportPropertyChanging("CODCOR");
                  _CODCOR = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODCOR");
                  OnCODCORChanged();
              }
            }
        }
        private string _CODCOR = @"space((3))";
        partial void OnGetCODCOR(ref string value);
        partial void OnCODCORChanging(ref string value);
        partial void OnCODCORChanged();
    
        /// <summary>
        /// There are no comments for CONSUMO_UN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public decimal CONSUMO_UN
        {
            get
            {
                decimal value = _CONSUMO_UN;
                OnGetCONSUMO_UN(ref value);
                return value;
            }
            set
            {
                if (_CONSUMO_UN != value)
                {
                  OnCONSUMO_UNChanging(ref value);
                  ReportPropertyChanging("CONSUMO_UN");
                  _CONSUMO_UN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CONSUMO_UN");
                  OnCONSUMO_UNChanged();
              }
            }
        }
        private decimal _CONSUMO_UN;
        partial void OnGetCONSUMO_UN(ref decimal value);
        partial void OnCONSUMO_UNChanging(ref decimal value);
        partial void OnCONSUMO_UNChanged();
    
        /// <summary>
        /// There are no comments for CONSUMO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CONSUMO
        {
            get
            {
                global::System.Nullable<decimal> value = _CONSUMO;
                OnGetCONSUMO(ref value);
                return value;
            }
            set
            {
                if (_CONSUMO != value)
                {
                  OnCONSUMOChanging(ref value);
                  ReportPropertyChanging("CONSUMO");
                  _CONSUMO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CONSUMO");
                  OnCONSUMOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CONSUMO;
        partial void OnGetCONSUMO(ref global::System.Nullable<decimal> value);
        partial void OnCONSUMOChanging(ref global::System.Nullable<decimal> value);
        partial void OnCONSUMOChanged();
    
        /// <summary>
        /// There are no comments for OPERACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
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
        /// There are no comments for TAMC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TAMC
        {
            get
            {
                string value = _TAMC;
                OnGetTAMC(ref value);
                return value;
            }
            set
            {
                if (_TAMC != value)
                {
                  OnTAMCChanging(ref value);
                  ReportPropertyChanging("TAMC");
                  _TAMC = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TAMC");
                  OnTAMCChanged();
              }
            }
        }
        private string _TAMC = @"space((4))";
        partial void OnGetTAMC(ref string value);
        partial void OnTAMCChanging(ref string value);
        partial void OnTAMCChanged();
    
        /// <summary>
        /// There are no comments for INTEGRADO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public bool INTEGRADO
        {
            get
            {
                bool value = _INTEGRADO;
                OnGetINTEGRADO(ref value);
                return value;
            }
            set
            {
                if (_INTEGRADO != value)
                {
                  OnINTEGRADOChanging(ref value);
                  ReportPropertyChanging("INTEGRADO");
                  _INTEGRADO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("INTEGRADO");
                  OnINTEGRADOChanged();
              }
            }
        }
        private bool _INTEGRADO;
        partial void OnGetINTEGRADO(ref bool value);
        partial void OnINTEGRADOChanging(ref bool value);
        partial void OnINTEGRADOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CARACT_LNENCO obj = new CARACT_LNENCO();
            obj.NRENCO = NRENCO;
            obj.LNENCO = LNENCO;
            obj.FAMILIA = FAMILIA;
            obj.IDOTAM = IDOTAM;
            obj.IAOTAM = IAOTAM;
            obj.DOTAM = DOTAM;
            obj.AOTAM = AOTAM;
            obj.POS = POS;
            obj.COMPONENTE = COMPONENTE;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.CONSUMO_UN = CONSUMO_UN;
            obj.CONSUMO = CONSUMO;
            obj.OPERACAO = OPERACAO;
            obj.TAMC = TAMC;
            obj.INTEGRADO = INTEGRADO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CARACT_LNENCO toCompare = obj as CARACT_LNENCO;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.NRENCO, toCompare.NRENCO))
            return false;
          if (!Object.Equals(this.LNENCO, toCompare.LNENCO))
            return false;
          if (!Object.Equals(this.FAMILIA, toCompare.FAMILIA))
            return false;
          if (!Object.Equals(this.IDOTAM, toCompare.IDOTAM))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + NRENCO.GetHashCode();
          hashCode = (hashCode * 7) + LNENCO.GetHashCode();
          hashCode = (hashCode * 7) + FAMILIA.GetHashCode();
          hashCode = (hashCode * 7) + IDOTAM.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}