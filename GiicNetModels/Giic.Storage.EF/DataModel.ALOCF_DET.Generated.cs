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
    /// There are no comments for DataGiic_LiagoModel.ALOCF_DET in the schema.
    /// </summary>
    /// <KeyProperties>
    /// nrreg
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="ALOCF_DET")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ALOCF_DET : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new ALOCF_DET object.
        /// </summary>
        /// <param name="nrreg">Initial value of nrreg.</param>
        public static ALOCF_DET CreateALOCF_DET(global::System.Guid nrreg)
        {
            ALOCF_DET aLOCF_DET = new ALOCF_DET();
            aLOCF_DET.nrreg = nrreg;
            return aLOCF_DET;
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
        /// There are no comments for SERIE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string SERIE
        {
            get
            {
                string value = _SERIE;
                OnGetSERIE(ref value);
                return value;
            }
            set
            {
                if (_SERIE != value)
                {
                  OnSERIEChanging(ref value);
                  ReportPropertyChanging("SERIE");
                  _SERIE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("SERIE");
                  OnSERIEChanged();
              }
            }
        }
        private string _SERIE;
        partial void OnGetSERIE(ref string value);
        partial void OnSERIEChanging(ref string value);
        partial void OnSERIEChanged();
    
        /// <summary>
        /// There are no comments for NRFACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NRFACT
        {
            get
            {
                global::System.Nullable<int> value = _NRFACT;
                OnGetNRFACT(ref value);
                return value;
            }
            set
            {
                if (_NRFACT != value)
                {
                  OnNRFACTChanging(ref value);
                  ReportPropertyChanging("NRFACT");
                  _NRFACT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRFACT");
                  OnNRFACTChanged();
              }
            }
        }
        private global::System.Nullable<int> _NRFACT;
        partial void OnGetNRFACT(ref global::System.Nullable<int> value);
        partial void OnNRFACTChanging(ref global::System.Nullable<int> value);
        partial void OnNRFACTChanged();
    
        /// <summary>
        /// There are no comments for LNFACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNFACT
        {
            get
            {
                global::System.Nullable<int> value = _LNFACT;
                OnGetLNFACT(ref value);
                return value;
            }
            set
            {
                if (_LNFACT != value)
                {
                  OnLNFACTChanging(ref value);
                  ReportPropertyChanging("LNFACT");
                  _LNFACT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNFACT");
                  OnLNFACTChanged();
              }
            }
        }
        private global::System.Nullable<int> _LNFACT;
        partial void OnGetLNFACT(ref global::System.Nullable<int> value);
        partial void OnLNFACTChanging(ref global::System.Nullable<int> value);
        partial void OnLNFACTChanged();
    
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
        /// There are no comments for NROC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NROC
        {
            get
            {
                global::System.Nullable<int> value = _NROC;
                OnGetNROC(ref value);
                return value;
            }
            set
            {
                if (_NROC != value)
                {
                  OnNROCChanging(ref value);
                  ReportPropertyChanging("NROC");
                  _NROC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NROC");
                  OnNROCChanged();
              }
            }
        }
        private global::System.Nullable<int> _NROC;
        partial void OnGetNROC(ref global::System.Nullable<int> value);
        partial void OnNROCChanging(ref global::System.Nullable<int> value);
        partial void OnNROCChanged();
    
        /// <summary>
        /// There are no comments for LNOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNOC
        {
            get
            {
                global::System.Nullable<int> value = _LNOC;
                OnGetLNOC(ref value);
                return value;
            }
            set
            {
                if (_LNOC != value)
                {
                  OnLNOCChanging(ref value);
                  ReportPropertyChanging("LNOC");
                  _LNOC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNOC");
                  OnLNOCChanged();
              }
            }
        }
        private global::System.Nullable<int> _LNOC;
        partial void OnGetLNOC(ref global::System.Nullable<int> value);
        partial void OnLNOCChanging(ref global::System.Nullable<int> value);
        partial void OnLNOCChanged();
    
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
        /// There are no comments for tam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string tam
        {
            get
            {
                string value = _tam;
                OnGettam(ref value);
                return value;
            }
            set
            {
                if (_tam != value)
                {
                  OntamChanging(ref value);
                  ReportPropertyChanging("tam");
                  _tam = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("tam");
                  OntamChanged();
              }
            }
        }
        private string _tam;
        partial void OnGettam(ref string value);
        partial void OntamChanging(ref string value);
        partial void OntamChanged();
    
        /// <summary>
        /// There are no comments for itam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> itam
        {
            get
            {
                global::System.Nullable<int> value = _itam;
                OnGetitam(ref value);
                return value;
            }
            set
            {
                if (_itam != value)
                {
                  OnitamChanging(ref value);
                  ReportPropertyChanging("itam");
                  _itam = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("itam");
                  OnitamChanged();
              }
            }
        }
        private global::System.Nullable<int> _itam;
        partial void OnGetitam(ref global::System.Nullable<int> value);
        partial void OnitamChanging(ref global::System.Nullable<int> value);
        partial void OnitamChanged();
    
        /// <summary>
        /// There are no comments for qtnec in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> qtnec
        {
            get
            {
                global::System.Nullable<decimal> value = _qtnec;
                OnGetqtnec(ref value);
                return value;
            }
            set
            {
                if (_qtnec != value)
                {
                  OnqtnecChanging(ref value);
                  ReportPropertyChanging("qtnec");
                  _qtnec = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("qtnec");
                  OnqtnecChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _qtnec;
        partial void OnGetqtnec(ref global::System.Nullable<decimal> value);
        partial void OnqtnecChanging(ref global::System.Nullable<decimal> value);
        partial void OnqtnecChanged();
    
        /// <summary>
        /// There are no comments for qtaloc in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> qtaloc
        {
            get
            {
                global::System.Nullable<decimal> value = _qtaloc;
                OnGetqtaloc(ref value);
                return value;
            }
            set
            {
                if (_qtaloc != value)
                {
                  OnqtalocChanging(ref value);
                  ReportPropertyChanging("qtaloc");
                  _qtaloc = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("qtaloc");
                  OnqtalocChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _qtaloc;
        partial void OnGetqtaloc(ref global::System.Nullable<decimal> value);
        partial void OnqtalocChanging(ref global::System.Nullable<decimal> value);
        partial void OnqtalocChanged();
    
        /// <summary>
        /// There are no comments for qtaloc_doc in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> qtaloc_doc
        {
            get
            {
                global::System.Nullable<decimal> value = _qtaloc_doc;
                OnGetqtaloc_doc(ref value);
                return value;
            }
            set
            {
                if (_qtaloc_doc != value)
                {
                  Onqtaloc_docChanging(ref value);
                  ReportPropertyChanging("qtaloc_doc");
                  _qtaloc_doc = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("qtaloc_doc");
                  Onqtaloc_docChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _qtaloc_doc;
        partial void OnGetqtaloc_doc(ref global::System.Nullable<decimal> value);
        partial void Onqtaloc_docChanging(ref global::System.Nullable<decimal> value);
        partial void Onqtaloc_docChanged();
    
        /// <summary>
        /// There are no comments for coment in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        public string coment
        {
            get
            {
                string value = _coment;
                OnGetcoment(ref value);
                return value;
            }
            set
            {
                if (_coment != value)
                {
                  OncomentChanging(ref value);
                  ReportPropertyChanging("coment");
                  _coment = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("coment");
                  OncomentChanged();
              }
            }
        }
        private string _coment;
        partial void OnGetcoment(ref string value);
        partial void OncomentChanging(ref string value);
        partial void OncomentChanged();
    
        /// <summary>
        /// There are no comments for status in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string status
        {
            get
            {
                string value = _status;
                OnGetstatus(ref value);
                return value;
            }
            set
            {
                if (_status != value)
                {
                  OnstatusChanging(ref value);
                  ReportPropertyChanging("status");
                  _status = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("status");
                  OnstatusChanged();
              }
            }
        }
        private string _status;
        partial void OnGetstatus(ref string value);
        partial void OnstatusChanging(ref string value);
        partial void OnstatusChanged();
    
        /// <summary>
        /// There are no comments for DataReg in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DataReg
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DataReg;
                OnGetDataReg(ref value);
                return value;
            }
            set
            {
                if (_DataReg != value)
                {
                  OnDataRegChanging(ref value);
                  ReportPropertyChanging("DataReg");
                  _DataReg = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DataReg");
                  OnDataRegChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DataReg = DateTime.Now;
        partial void OnGetDataReg(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataRegChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataRegChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            ALOCF_DET obj = new ALOCF_DET();
            obj.nrreg = nrreg;
            obj.TPDOC = TPDOC;
            obj.SERIE = SERIE;
            obj.NRFACT = NRFACT;
            obj.LNFACT = LNFACT;
            obj.COD = COD;
            obj.NRENCO = NRENCO;
            obj.LNENCO = LNENCO;
            obj.NROC = NROC;
            obj.LNOC = LNOC;
            obj.ARM = ARM;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.tam = tam;
            obj.itam = itam;
            obj.qtnec = qtnec;
            obj.qtaloc = qtaloc;
            obj.qtaloc_doc = qtaloc_doc;
            obj.coment = coment;
            obj.status = status;
            obj.DataReg = DataReg;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          ALOCF_DET toCompare = obj as ALOCF_DET;
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
