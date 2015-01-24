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
    /// There are no comments for DataGiic_LiagoModel.WKMRP0 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// NRREG
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WKMRP0")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WKMRP0 : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WKMRP0 object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="nRREG">Initial value of NRREG.</param>
        public static WKMRP0 CreateWKMRP0(int sPID, decimal nRREG)
        {
            WKMRP0 wKMRP0 = new WKMRP0();
            wKMRP0.SPID = sPID;
            wKMRP0.NRREG = nRREG;
            return wKMRP0;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for SPID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int SPID
        {
            get
            {
                int value = _SPID;
                OnGetSPID(ref value);
                return value;
            }
            set
            {
                if (_SPID != value)
                {
                  OnSPIDChanging(ref value);
                  ReportPropertyChanging("SPID");
                  _SPID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SPID");
                  OnSPIDChanged();
              }
            }
        }
        private int _SPID;
        partial void OnGetSPID(ref int value);
        partial void OnSPIDChanging(ref int value);
        partial void OnSPIDChanged();
    
        /// <summary>
        /// There are no comments for NRREG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public decimal NRREG
        {
            get
            {
                decimal value = _NRREG;
                OnGetNRREG(ref value);
                return value;
            }
            set
            {
                if (_NRREG != value)
                {
                  OnNRREGChanging(ref value);
                  ReportPropertyChanging("NRREG");
                  _NRREG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRREG");
                  OnNRREGChanged();
              }
            }
        }
        private decimal _NRREG;
        partial void OnGetNRREG(ref decimal value);
        partial void OnNRREGChanging(ref decimal value);
        partial void OnNRREGChanged();
    
        /// <summary>
        /// There are no comments for SEQ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> SEQ
        {
            get
            {
                global::System.Nullable<int> value = _SEQ;
                OnGetSEQ(ref value);
                return value;
            }
            set
            {
                if (_SEQ != value)
                {
                  OnSEQChanging(ref value);
                  ReportPropertyChanging("SEQ");
                  _SEQ = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SEQ");
                  OnSEQChanged();
              }
            }
        }
        private global::System.Nullable<int> _SEQ;
        partial void OnGetSEQ(ref global::System.Nullable<int> value);
        partial void OnSEQChanging(ref global::System.Nullable<int> value);
        partial void OnSEQChanged();
    
        /// <summary>
        /// There are no comments for OPERACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
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
                  _OPERACAO = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for ARTIGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string ARTIGO
        {
            get
            {
                string value = _ARTIGO;
                OnGetARTIGO(ref value);
                return value;
            }
            set
            {
                if (_ARTIGO != value)
                {
                  OnARTIGOChanging(ref value);
                  ReportPropertyChanging("ARTIGO");
                  _ARTIGO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ARTIGO");
                  OnARTIGOChanged();
              }
            }
        }
        private string _ARTIGO;
        partial void OnGetARTIGO(ref string value);
        partial void OnARTIGOChanging(ref string value);
        partial void OnARTIGOChanged();
    
        /// <summary>
        /// There are no comments for CARTAZ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
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
                  _CARTAZ = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CARTAZ");
                  OnCARTAZChanged();
              }
            }
        }
        private string _CARTAZ = @"space(5)";
        partial void OnGetCARTAZ(ref string value);
        partial void OnCARTAZChanging(ref string value);
        partial void OnCARTAZChanged();
    
        /// <summary>
        /// There are no comments for CODCOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
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
                  _CODCOR = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CODCOR");
                  OnCODCORChanged();
              }
            }
        }
        private string _CODCOR = @"space(3)";
        partial void OnGetCODCOR(ref string value);
        partial void OnCODCORChanging(ref string value);
        partial void OnCODCORChanged();
    
        /// <summary>
        /// There are no comments for TAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string TAM
        {
            get
            {
                string value = _TAM;
                OnGetTAM(ref value);
                return value;
            }
            set
            {
                if (_TAM != value)
                {
                  OnTAMChanging(ref value);
                  ReportPropertyChanging("TAM");
                  _TAM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TAM");
                  OnTAMChanged();
              }
            }
        }
        private string _TAM = @"space(4)";
        partial void OnGetTAM(ref string value);
        partial void OnTAMChanging(ref string value);
        partial void OnTAMChanged();
    
        /// <summary>
        /// There are no comments for ORDFAB in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
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
                  _ORDFAB = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for NRENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
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
                  _NRENCO = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNENCO
        {
            get
            {
                global::System.Nullable<int> value = _LNENCO;
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
        private global::System.Nullable<int> _LNENCO;
        partial void OnGetLNENCO(ref global::System.Nullable<int> value);
        partial void OnLNENCOChanging(ref global::System.Nullable<int> value);
        partial void OnLNENCOChanged();
    
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
        /// There are no comments for DESCCOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string DESCCOR
        {
            get
            {
                string value = _DESCCOR;
                OnGetDESCCOR(ref value);
                return value;
            }
            set
            {
                if (_DESCCOR != value)
                {
                  OnDESCCORChanging(ref value);
                  ReportPropertyChanging("DESCCOR");
                  _DESCCOR = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DESCCOR");
                  OnDESCCORChanged();
              }
            }
        }
        private string _DESCCOR;
        partial void OnGetDESCCOR(ref string value);
        partial void OnDESCCORChanging(ref string value);
        partial void OnDESCCORChanged();
    
        /// <summary>
        /// There are no comments for UNMED in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string UNMED
        {
            get
            {
                string value = _UNMED;
                OnGetUNMED(ref value);
                return value;
            }
            set
            {
                if (_UNMED != value)
                {
                  OnUNMEDChanging(ref value);
                  ReportPropertyChanging("UNMED");
                  _UNMED = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("UNMED");
                  OnUNMEDChanged();
              }
            }
        }
        private string _UNMED;
        partial void OnGetUNMED(ref string value);
        partial void OnUNMEDChanging(ref string value);
        partial void OnUNMEDChanged();
    
        /// <summary>
        /// There are no comments for TAMANHOS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string TAMANHOS
        {
            get
            {
                string value = _TAMANHOS;
                OnGetTAMANHOS(ref value);
                return value;
            }
            set
            {
                if (_TAMANHOS != value)
                {
                  OnTAMANHOSChanging(ref value);
                  ReportPropertyChanging("TAMANHOS");
                  _TAMANHOS = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TAMANHOS");
                  OnTAMANHOSChanged();
              }
            }
        }
        private string _TAMANHOS;
        partial void OnGetTAMANHOS(ref string value);
        partial void OnTAMANHOSChanging(ref string value);
        partial void OnTAMANHOSChanged();
    
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
        /// There are no comments for preco in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> preco
        {
            get
            {
                global::System.Nullable<decimal> value = _preco;
                OnGetpreco(ref value);
                return value;
            }
            set
            {
                if (_preco != value)
                {
                  OnprecoChanging(ref value);
                  ReportPropertyChanging("preco");
                  _preco = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("preco");
                  OnprecoChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _preco;
        partial void OnGetpreco(ref global::System.Nullable<decimal> value);
        partial void OnprecoChanging(ref global::System.Nullable<decimal> value);
        partial void OnprecoChanged();
    
        /// <summary>
        /// There are no comments for vl in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> vl
        {
            get
            {
                global::System.Nullable<decimal> value = _vl;
                OnGetvl(ref value);
                return value;
            }
            set
            {
                if (_vl != value)
                {
                  OnvlChanging(ref value);
                  ReportPropertyChanging("vl");
                  _vl = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("vl");
                  OnvlChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _vl;
        partial void OnGetvl(ref global::System.Nullable<decimal> value);
        partial void OnvlChanging(ref global::System.Nullable<decimal> value);
        partial void OnvlChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WKMRP0 obj = new WKMRP0();
            obj.SPID = SPID;
            obj.NRREG = NRREG;
            obj.SEQ = SEQ;
            obj.OPERACAO = OPERACAO;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.TAM = TAM;
            obj.ORDFAB = ORDFAB;
            obj.NRENCO = NRENCO;
            obj.LNENCO = LNENCO;
            obj.DESCRICAO = DESCRICAO;
            obj.DESCCOR = DESCCOR;
            obj.UNMED = UNMED;
            obj.TAMANHOS = TAMANHOS;
            obj.CONSUMO = CONSUMO;
            obj.preco = preco;
            obj.vl = vl;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WKMRP0 toCompare = obj as WKMRP0;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.NRREG, toCompare.NRREG))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + NRREG.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}