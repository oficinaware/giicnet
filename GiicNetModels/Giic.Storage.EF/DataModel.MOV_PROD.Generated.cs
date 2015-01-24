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
    /// There are no comments for DataGiic_LiagoModel.MOV_PROD in the schema.
    /// </summary>
    /// <KeyProperties>
    /// nrreg
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="MOV_PROD")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MOV_PROD : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new MOV_PROD object.
        /// </summary>
        /// <param name="nrreg">Initial value of nrreg.</param>
        public static MOV_PROD CreateMOV_PROD(global::System.Guid nrreg)
        {
            MOV_PROD mOV_PROD = new MOV_PROD();
            mOV_PROD.nrreg = nrreg;
            return mOV_PROD;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for nrreg in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.Guid nrreg
        {
            get
            {
                global::System.Guid value = _nrreg;
                OnGetnrreg(ref value);
                return value;
            }
            set
            {
                if (_nrreg != value)
                {
                  OnnrregChanging(ref value);
                  ReportPropertyChanging("nrreg");
                  _nrreg = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("nrreg");
                  OnnrregChanged();
              }
            }
        }
        private global::System.Guid _nrreg;
        partial void OnGetnrreg(ref global::System.Guid value);
        partial void OnnrregChanging(ref global::System.Guid value);
        partial void OnnrregChanged();
    
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
        /// There are no comments for LOTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LOTE
        {
            get
            {
                global::System.Nullable<int> value = _LOTE;
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
        private global::System.Nullable<int> _LOTE;
        partial void OnGetLOTE(ref global::System.Nullable<int> value);
        partial void OnLOTEChanging(ref global::System.Nullable<int> value);
        partial void OnLOTEChanged();
    
        /// <summary>
        /// There are no comments for SUBLOTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> SUBLOTE
        {
            get
            {
                global::System.Nullable<int> value = _SUBLOTE;
                OnGetSUBLOTE(ref value);
                return value;
            }
            set
            {
                if (_SUBLOTE != value)
                {
                  OnSUBLOTEChanging(ref value);
                  ReportPropertyChanging("SUBLOTE");
                  _SUBLOTE = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SUBLOTE");
                  OnSUBLOTEChanged();
              }
            }
        }
        private global::System.Nullable<int> _SUBLOTE;
        partial void OnGetSUBLOTE(ref global::System.Nullable<int> value);
        partial void OnSUBLOTEChanging(ref global::System.Nullable<int> value);
        partial void OnSUBLOTEChanged();
    
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
        /// There are no comments for ITAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> ITAM
        {
            get
            {
                global::System.Nullable<int> value = _ITAM;
                OnGetITAM(ref value);
                return value;
            }
            set
            {
                if (_ITAM != value)
                {
                  OnITAMChanging(ref value);
                  ReportPropertyChanging("ITAM");
                  _ITAM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ITAM");
                  OnITAMChanged();
              }
            }
        }
        private global::System.Nullable<int> _ITAM;
        partial void OnGetITAM(ref global::System.Nullable<int> value);
        partial void OnITAMChanging(ref global::System.Nullable<int> value);
        partial void OnITAMChanged();
    
        /// <summary>
        /// There are no comments for QT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QT
        {
            get
            {
                global::System.Nullable<int> value = _QT;
                OnGetQT(ref value);
                return value;
            }
            set
            {
                if (_QT != value)
                {
                  OnQTChanging(ref value);
                  ReportPropertyChanging("QT");
                  _QT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QT");
                  OnQTChanged();
              }
            }
        }
        private global::System.Nullable<int> _QT;
        partial void OnGetQT(ref global::System.Nullable<int> value);
        partial void OnQTChanging(ref global::System.Nullable<int> value);
        partial void OnQTChanged();
    
        /// <summary>
        /// There are no comments for TIPOMOV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string TIPOMOV
        {
            get
            {
                string value = _TIPOMOV;
                OnGetTIPOMOV(ref value);
                return value;
            }
            set
            {
                if (_TIPOMOV != value)
                {
                  OnTIPOMOVChanging(ref value);
                  ReportPropertyChanging("TIPOMOV");
                  _TIPOMOV = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TIPOMOV");
                  OnTIPOMOVChanged();
              }
            }
        }
        private string _TIPOMOV;
        partial void OnGetTIPOMOV(ref string value);
        partial void OnTIPOMOVChanging(ref string value);
        partial void OnTIPOMOVChanged();
    
        /// <summary>
        /// There are no comments for DATAMOV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATAMOV
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATAMOV;
                OnGetDATAMOV(ref value);
                return value;
            }
            set
            {
                if (_DATAMOV != value)
                {
                  OnDATAMOVChanging(ref value);
                  ReportPropertyChanging("DATAMOV");
                  _DATAMOV = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATAMOV");
                  OnDATAMOVChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATAMOV;
        partial void OnGetDATAMOV(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAMOVChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAMOVChanged();
    
        /// <summary>
        /// There are no comments for HORA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> HORA
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _HORA;
                OnGetHORA(ref value);
                return value;
            }
            set
            {
                if (_HORA != value)
                {
                  OnHORAChanging(ref value);
                  ReportPropertyChanging("HORA");
                  _HORA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("HORA");
                  OnHORAChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _HORA;
        partial void OnGetHORA(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORAChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORAChanged();
    
        /// <summary>
        /// There are no comments for PRECO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> PRECO
        {
            get
            {
                global::System.Nullable<decimal> value = _PRECO;
                OnGetPRECO(ref value);
                return value;
            }
            set
            {
                if (_PRECO != value)
                {
                  OnPRECOChanging(ref value);
                  ReportPropertyChanging("PRECO");
                  _PRECO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRECO");
                  OnPRECOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _PRECO = 0m;
        partial void OnGetPRECO(ref global::System.Nullable<decimal> value);
        partial void OnPRECOChanging(ref global::System.Nullable<decimal> value);
        partial void OnPRECOChanged();
    
        /// <summary>
        /// There are no comments for TEMPO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> TEMPO
        {
            get
            {
                global::System.Nullable<decimal> value = _TEMPO;
                OnGetTEMPO(ref value);
                return value;
            }
            set
            {
                if (_TEMPO != value)
                {
                  OnTEMPOChanging(ref value);
                  ReportPropertyChanging("TEMPO");
                  _TEMPO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TEMPO");
                  OnTEMPOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _TEMPO = 0m;
        partial void OnGetTEMPO(ref global::System.Nullable<decimal> value);
        partial void OnTEMPOChanging(ref global::System.Nullable<decimal> value);
        partial void OnTEMPOChanged();
    
        /// <summary>
        /// There are no comments for TPDOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string TPDOC
        {
            get
            {
                string value = _TPDOC;
                OnGetTPDOC(ref value);
                return value;
            }
            set
            {
                if (_TPDOC != value)
                {
                  OnTPDOCChanging(ref value);
                  ReportPropertyChanging("TPDOC");
                  _TPDOC = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TPDOC");
                  OnTPDOCChanged();
              }
            }
        }
        private string _TPDOC;
        partial void OnGetTPDOC(ref string value);
        partial void OnTPDOCChanging(ref string value);
        partial void OnTPDOCChanged();
    
        /// <summary>
        /// There are no comments for NRDOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NRDOC
        {
            get
            {
                global::System.Nullable<int> value = _NRDOC;
                OnGetNRDOC(ref value);
                return value;
            }
            set
            {
                if (_NRDOC != value)
                {
                  OnNRDOCChanging(ref value);
                  ReportPropertyChanging("NRDOC");
                  _NRDOC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRDOC");
                  OnNRDOCChanged();
              }
            }
        }
        private global::System.Nullable<int> _NRDOC;
        partial void OnGetNRDOC(ref global::System.Nullable<int> value);
        partial void OnNRDOCChanging(ref global::System.Nullable<int> value);
        partial void OnNRDOCChanged();
    
        /// <summary>
        /// There are no comments for LNDOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNDOC
        {
            get
            {
                global::System.Nullable<int> value = _LNDOC;
                OnGetLNDOC(ref value);
                return value;
            }
            set
            {
                if (_LNDOC != value)
                {
                  OnLNDOCChanging(ref value);
                  ReportPropertyChanging("LNDOC");
                  _LNDOC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNDOC");
                  OnLNDOCChanged();
              }
            }
        }
        private global::System.Nullable<int> _LNDOC;
        partial void OnGetLNDOC(ref global::System.Nullable<int> value);
        partial void OnLNDOCChanging(ref global::System.Nullable<int> value);
        partial void OnLNDOCChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            MOV_PROD obj = new MOV_PROD();
            obj.nrreg = nrreg;
            obj.ORDFAB = ORDFAB;
            obj.LOTE = LOTE;
            obj.SUBLOTE = SUBLOTE;
            obj.SEQ = SEQ;
            obj.OPERACAO = OPERACAO;
            obj.SECCAO = SECCAO;
            obj.TAM = TAM;
            obj.ITAM = ITAM;
            obj.QT = QT;
            obj.TIPOMOV = TIPOMOV;
            obj.DATAMOV = DATAMOV;
            obj.HORA = HORA;
            obj.PRECO = PRECO;
            obj.TEMPO = TEMPO;
            obj.TPDOC = TPDOC;
            obj.NRDOC = NRDOC;
            obj.LNDOC = LNDOC;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          MOV_PROD toCompare = obj as MOV_PROD;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.nrreg, toCompare.nrreg))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + nrreg.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}