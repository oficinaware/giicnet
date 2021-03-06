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
    /// There are no comments for DataGiic_LiagoModel.WK_PLN_MAT in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// LIN
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_PLN_MAT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_PLN_MAT : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_PLN_MAT object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="lIN">Initial value of LIN.</param>
        /// <param name="cOD">Initial value of COD.</param>
        /// <param name="nRENCO">Initial value of NRENCO.</param>
        /// <param name="lNENCO">Initial value of LNENCO.</param>
        public static WK_PLN_MAT CreateWK_PLN_MAT(int sPID, int lIN, string cOD, string nRENCO, int lNENCO)
        {
            WK_PLN_MAT wK_PLN_MAT = new WK_PLN_MAT();
            wK_PLN_MAT.SPID = sPID;
            wK_PLN_MAT.LIN = lIN;
            wK_PLN_MAT.COD = cOD;
            wK_PLN_MAT.NRENCO = nRENCO;
            wK_PLN_MAT.LNENCO = lNENCO;
            return wK_PLN_MAT;
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
        /// There are no comments for LIN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LIN
        {
            get
            {
                int value = _LIN;
                OnGetLIN(ref value);
                return value;
            }
            set
            {
                if (_LIN != value)
                {
                  OnLINChanging(ref value);
                  ReportPropertyChanging("LIN");
                  _LIN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LIN");
                  OnLINChanged();
              }
            }
        }
        private int _LIN;
        partial void OnGetLIN(ref int value);
        partial void OnLINChanging(ref int value);
        partial void OnLINChanged();
    
        /// <summary>
        /// There are no comments for COD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
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
                  _COD = StructuralObject.SetValidValue(value, false);
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
        /// There are no comments for NRENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
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
        /// There are no comments for DATA_PLN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_PLN
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_PLN;
                OnGetDATA_PLN(ref value);
                return value;
            }
            set
            {
                if (_DATA_PLN != value)
                {
                  OnDATA_PLNChanging(ref value);
                  ReportPropertyChanging("DATA_PLN");
                  _DATA_PLN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_PLN");
                  OnDATA_PLNChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_PLN;
        partial void OnGetDATA_PLN(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_PLNChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_PLNChanged();
    
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
        /// There are no comments for ARM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string ARM
        {
            get
            {
                string value = _ARM;
                OnGetARM(ref value);
                return value;
            }
            set
            {
                if (_ARM != value)
                {
                  OnARMChanging(ref value);
                  ReportPropertyChanging("ARM");
                  _ARM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ARM");
                  OnARMChanged();
              }
            }
        }
        private string _ARM;
        partial void OnGetARM(ref string value);
        partial void OnARMChanging(ref string value);
        partial void OnARMChanged();
    
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
        private string _CARTAZ;
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
        private string _CODCOR;
        partial void OnGetCODCOR(ref string value);
        partial void OnCODCORChanging(ref string value);
        partial void OnCODCORChanged();
    
        /// <summary>
        /// There are no comments for DCOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string DCOR
        {
            get
            {
                string value = _DCOR;
                OnGetDCOR(ref value);
                return value;
            }
            set
            {
                if (_DCOR != value)
                {
                  OnDCORChanging(ref value);
                  ReportPropertyChanging("DCOR");
                  _DCOR = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DCOR");
                  OnDCORChanged();
              }
            }
        }
        private string _DCOR;
        partial void OnGetDCOR(ref string value);
        partial void OnDCORChanging(ref string value);
        partial void OnDCORChanged();
    
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
        private string _TAM;
        partial void OnGetTAM(ref string value);
        partial void OnTAMChanging(ref string value);
        partial void OnTAMChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
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
        /// There are no comments for SALDO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> SALDO
        {
            get
            {
                global::System.Nullable<decimal> value = _SALDO;
                OnGetSALDO(ref value);
                return value;
            }
            set
            {
                if (_SALDO != value)
                {
                  OnSALDOChanging(ref value);
                  ReportPropertyChanging("SALDO");
                  _SALDO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SALDO");
                  OnSALDOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _SALDO;
        partial void OnGetSALDO(ref global::System.Nullable<decimal> value);
        partial void OnSALDOChanging(ref global::System.Nullable<decimal> value);
        partial void OnSALDOChanged();
    
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
        /// There are no comments for NSITUACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string NSITUACAO
        {
            get
            {
                string value = _NSITUACAO;
                OnGetNSITUACAO(ref value);
                return value;
            }
            set
            {
                if (_NSITUACAO != value)
                {
                  OnNSITUACAOChanging(ref value);
                  ReportPropertyChanging("NSITUACAO");
                  _NSITUACAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NSITUACAO");
                  OnNSITUACAOChanged();
              }
            }
        }
        private string _NSITUACAO;
        partial void OnGetNSITUACAO(ref string value);
        partial void OnNSITUACAOChanging(ref string value);
        partial void OnNSITUACAOChanged();
    
        /// <summary>
        /// There are no comments for SITUACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string SITUACAO
        {
            get
            {
                string value = _SITUACAO;
                OnGetSITUACAO(ref value);
                return value;
            }
            set
            {
                if (_SITUACAO != value)
                {
                  OnSITUACAOChanging(ref value);
                  ReportPropertyChanging("SITUACAO");
                  _SITUACAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("SITUACAO");
                  OnSITUACAOChanged();
              }
            }
        }
        private string _SITUACAO;
        partial void OnGetSITUACAO(ref string value);
        partial void OnSITUACAOChanging(ref string value);
        partial void OnSITUACAOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_PLN_MAT obj = new WK_PLN_MAT();
            obj.SPID = SPID;
            obj.LIN = LIN;
            obj.COD = COD;
            obj.NRENCO = NRENCO;
            obj.LNENCO = LNENCO;
            obj.DATA_PLN = DATA_PLN;
            obj.OPERACAO = OPERACAO;
            obj.SECCAO = SECCAO;
            obj.ARM = ARM;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.DCOR = DCOR;
            obj.TAM = TAM;
            obj.DESCRICAO = DESCRICAO;
            obj.SALDO = SALDO;
            obj.UNMED = UNMED;
            obj.NSITUACAO = NSITUACAO;
            obj.SITUACAO = SITUACAO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_PLN_MAT toCompare = obj as WK_PLN_MAT;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.LIN, toCompare.LIN))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + LIN.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
