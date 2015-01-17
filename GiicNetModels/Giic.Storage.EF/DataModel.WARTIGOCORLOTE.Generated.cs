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
    /// There are no comments for DataGiic_LiagoModel.WARTIGOCORLOTE in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// ARTIGO
    /// CARTAZ
    /// CODCOR
    /// IDLOTE
    /// REFLOTE
    /// IDLOCAL
    /// NRREG
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WARTIGOCORLOTE")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WARTIGOCORLOTE : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WARTIGOCORLOTE object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        /// <param name="cARTAZ">Initial value of CARTAZ.</param>
        /// <param name="cODCOR">Initial value of CODCOR.</param>
        /// <param name="iDLOTE">Initial value of IDLOTE.</param>
        /// <param name="rEFLOTE">Initial value of REFLOTE.</param>
        /// <param name="iDLOCAL">Initial value of IDLOCAL.</param>
        /// <param name="nRREG">Initial value of NRREG.</param>
        public static WARTIGOCORLOTE CreateWARTIGOCORLOTE(int sPID, string aRTIGO, string cARTAZ, string cODCOR, int iDLOTE, string rEFLOTE, string iDLOCAL, global::System.Guid nRREG)
        {
            WARTIGOCORLOTE wARTIGOCORLOTE = new WARTIGOCORLOTE();
            wARTIGOCORLOTE.SPID = sPID;
            wARTIGOCORLOTE.ARTIGO = aRTIGO;
            wARTIGOCORLOTE.CARTAZ = cARTAZ;
            wARTIGOCORLOTE.CODCOR = cODCOR;
            wARTIGOCORLOTE.IDLOTE = iDLOTE;
            wARTIGOCORLOTE.REFLOTE = rEFLOTE;
            wARTIGOCORLOTE.IDLOCAL = iDLOCAL;
            wARTIGOCORLOTE.NRREG = nRREG;
            return wARTIGOCORLOTE;
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
        /// There are no comments for ARTIGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        [System.ComponentModel.DataAnnotations.Required()]
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
                  _ARTIGO = StructuralObject.SetValidValue(value, false);
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
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
        private string _CARTAZ = @"space(5)";
        partial void OnGetCARTAZ(ref string value);
        partial void OnCARTAZChanging(ref string value);
        partial void OnCARTAZChanged();
    
        /// <summary>
        /// There are no comments for CODCOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
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
        private string _CODCOR = @"space(3)";
        partial void OnGetCODCOR(ref string value);
        partial void OnCODCORChanging(ref string value);
        partial void OnCODCORChanged();
    
        /// <summary>
        /// There are no comments for IDLOTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int IDLOTE
        {
            get
            {
                int value = _IDLOTE;
                OnGetIDLOTE(ref value);
                return value;
            }
            set
            {
                if (_IDLOTE != value)
                {
                  OnIDLOTEChanging(ref value);
                  ReportPropertyChanging("IDLOTE");
                  _IDLOTE = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("IDLOTE");
                  OnIDLOTEChanged();
              }
            }
        }
        private int _IDLOTE = 0;
        partial void OnGetIDLOTE(ref int value);
        partial void OnIDLOTEChanging(ref int value);
        partial void OnIDLOTEChanged();
    
        /// <summary>
        /// There are no comments for REFLOTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string REFLOTE
        {
            get
            {
                string value = _REFLOTE;
                OnGetREFLOTE(ref value);
                return value;
            }
            set
            {
                if (_REFLOTE != value)
                {
                  OnREFLOTEChanging(ref value);
                  ReportPropertyChanging("REFLOTE");
                  _REFLOTE = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("REFLOTE");
                  OnREFLOTEChanged();
              }
            }
        }
        private string _REFLOTE = @"";
        partial void OnGetREFLOTE(ref string value);
        partial void OnREFLOTEChanging(ref string value);
        partial void OnREFLOTEChanged();
    
        /// <summary>
        /// There are no comments for IDLOCAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string IDLOCAL
        {
            get
            {
                string value = _IDLOCAL;
                OnGetIDLOCAL(ref value);
                return value;
            }
            set
            {
                if (_IDLOCAL != value)
                {
                  OnIDLOCALChanging(ref value);
                  ReportPropertyChanging("IDLOCAL");
                  _IDLOCAL = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("IDLOCAL");
                  OnIDLOCALChanged();
              }
            }
        }
        private string _IDLOCAL = @"";
        partial void OnGetIDLOCAL(ref string value);
        partial void OnIDLOCALChanging(ref string value);
        partial void OnIDLOCALChanged();
    
        /// <summary>
        /// There are no comments for NRREG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.Guid NRREG
        {
            get
            {
                global::System.Guid value = _NRREG;
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
        private global::System.Guid _NRREG;
        partial void OnGetNRREG(ref global::System.Guid value);
        partial void OnNRREGChanging(ref global::System.Guid value);
        partial void OnNRREGChanged();
    
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
        private global::System.Nullable<int> _ITAM = 0;
        partial void OnGetITAM(ref global::System.Nullable<int> value);
        partial void OnITAMChanging(ref global::System.Nullable<int> value);
        partial void OnITAMChanged();
    
        /// <summary>
        /// There are no comments for nseq in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> nseq
        {
            get
            {
                global::System.Nullable<int> value = _nseq;
                OnGetnseq(ref value);
                return value;
            }
            set
            {
                if (_nseq != value)
                {
                  OnnseqChanging(ref value);
                  ReportPropertyChanging("nseq");
                  _nseq = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("nseq");
                  OnnseqChanged();
              }
            }
        }
        private global::System.Nullable<int> _nseq;
        partial void OnGetnseq(ref global::System.Nullable<int> value);
        partial void OnnseqChanging(ref global::System.Nullable<int> value);
        partial void OnnseqChanged();
    
        /// <summary>
        /// There are no comments for QT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> QT
        {
            get
            {
                global::System.Nullable<decimal> value = _QT;
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
        private global::System.Nullable<decimal> _QT;
        partial void OnGetQT(ref global::System.Nullable<decimal> value);
        partial void OnQTChanging(ref global::System.Nullable<decimal> value);
        partial void OnQTChanged();
    
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
        private global::System.Nullable<decimal> _PRECO;
        partial void OnGetPRECO(ref global::System.Nullable<decimal> value);
        partial void OnPRECOChanging(ref global::System.Nullable<decimal> value);
        partial void OnPRECOChanged();
    
        /// <summary>
        /// There are no comments for DESCL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> DESCL
        {
            get
            {
                global::System.Nullable<decimal> value = _DESCL;
                OnGetDESCL(ref value);
                return value;
            }
            set
            {
                if (_DESCL != value)
                {
                  OnDESCLChanging(ref value);
                  ReportPropertyChanging("DESCL");
                  _DESCL = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DESCL");
                  OnDESCLChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _DESCL;
        partial void OnGetDESCL(ref global::System.Nullable<decimal> value);
        partial void OnDESCLChanging(ref global::System.Nullable<decimal> value);
        partial void OnDESCLChanged();
    
        /// <summary>
        /// There are no comments for STOCK in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> STOCK
        {
            get
            {
                global::System.Nullable<decimal> value = _STOCK;
                OnGetSTOCK(ref value);
                return value;
            }
            set
            {
                if (_STOCK != value)
                {
                  OnSTOCKChanging(ref value);
                  ReportPropertyChanging("STOCK");
                  _STOCK = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("STOCK");
                  OnSTOCKChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _STOCK;
        partial void OnGetSTOCK(ref global::System.Nullable<decimal> value);
        partial void OnSTOCKChanging(ref global::System.Nullable<decimal> value);
        partial void OnSTOCKChanged();
    
        /// <summary>
        /// There are no comments for LOTEFORN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string LOTEFORN
        {
            get
            {
                string value = _LOTEFORN;
                OnGetLOTEFORN(ref value);
                return value;
            }
            set
            {
                if (_LOTEFORN != value)
                {
                  OnLOTEFORNChanging(ref value);
                  ReportPropertyChanging("LOTEFORN");
                  _LOTEFORN = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("LOTEFORN");
                  OnLOTEFORNChanged();
              }
            }
        }
        private string _LOTEFORN;
        partial void OnGetLOTEFORN(ref string value);
        partial void OnLOTEFORNChanging(ref string value);
        partial void OnLOTEFORNChanged();
    
        /// <summary>
        /// There are no comments for DATAREG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATAREG
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATAREG;
                OnGetDATAREG(ref value);
                return value;
            }
            set
            {
                if (_DATAREG != value)
                {
                  OnDATAREGChanging(ref value);
                  ReportPropertyChanging("DATAREG");
                  _DATAREG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATAREG");
                  OnDATAREGChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATAREG;
        partial void OnGetDATAREG(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAREGChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAREGChanged();
    
        /// <summary>
        /// There are no comments for LRENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LRENCO
        {
            get
            {
                global::System.Nullable<int> value = _LRENCO;
                OnGetLRENCO(ref value);
                return value;
            }
            set
            {
                if (_LRENCO != value)
                {
                  OnLRENCOChanging(ref value);
                  ReportPropertyChanging("LRENCO");
                  _LRENCO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LRENCO");
                  OnLRENCOChanged();
              }
            }
        }
        private global::System.Nullable<int> _LRENCO;
        partial void OnGetLRENCO(ref global::System.Nullable<int> value);
        partial void OnLRENCOChanging(ref global::System.Nullable<int> value);
        partial void OnLRENCOChanged();
    
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
        /// There are no comments for SEQNEC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> SEQNEC
        {
            get
            {
                global::System.Nullable<int> value = _SEQNEC;
                OnGetSEQNEC(ref value);
                return value;
            }
            set
            {
                if (_SEQNEC != value)
                {
                  OnSEQNECChanging(ref value);
                  ReportPropertyChanging("SEQNEC");
                  _SEQNEC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SEQNEC");
                  OnSEQNECChanged();
              }
            }
        }
        private global::System.Nullable<int> _SEQNEC;
        partial void OnGetSEQNEC(ref global::System.Nullable<int> value);
        partial void OnSEQNECChanging(ref global::System.Nullable<int> value);
        partial void OnSEQNECChanged();
    
        /// <summary>
        /// There are no comments for NR_REG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<long> NR_REG
        {
            get
            {
                global::System.Nullable<long> value = _NR_REG;
                OnGetNR_REG(ref value);
                return value;
            }
            set
            {
                if (_NR_REG != value)
                {
                  OnNR_REGChanging(ref value);
                  ReportPropertyChanging("NR_REG");
                  _NR_REG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NR_REG");
                  OnNR_REGChanged();
              }
            }
        }
        private global::System.Nullable<long> _NR_REG;
        partial void OnGetNR_REG(ref global::System.Nullable<long> value);
        partial void OnNR_REGChanging(ref global::System.Nullable<long> value);
        partial void OnNR_REGChanged();
    
        /// <summary>
        /// There are no comments for NRVOLS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NRVOLS
        {
            get
            {
                global::System.Nullable<int> value = _NRVOLS;
                OnGetNRVOLS(ref value);
                return value;
            }
            set
            {
                if (_NRVOLS != value)
                {
                  OnNRVOLSChanging(ref value);
                  ReportPropertyChanging("NRVOLS");
                  _NRVOLS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRVOLS");
                  OnNRVOLSChanged();
              }
            }
        }
        private global::System.Nullable<int> _NRVOLS;
        partial void OnGetNRVOLS(ref global::System.Nullable<int> value);
        partial void OnNRVOLSChanging(ref global::System.Nullable<int> value);
        partial void OnNRVOLSChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WARTIGOCORLOTE obj = new WARTIGOCORLOTE();
            obj.SPID = SPID;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.IDLOTE = IDLOTE;
            obj.REFLOTE = REFLOTE;
            obj.IDLOCAL = IDLOCAL;
            obj.NRREG = NRREG;
            obj.TAM = TAM;
            obj.ITAM = ITAM;
            obj.nseq = nseq;
            obj.QT = QT;
            obj.PRECO = PRECO;
            obj.DESCL = DESCL;
            obj.STOCK = STOCK;
            obj.LOTEFORN = LOTEFORN;
            obj.DATAREG = DATAREG;
            obj.LRENCO = LRENCO;
            obj.LNENCO = LNENCO;
            obj.COD = COD;
            obj.NRENCO = NRENCO;
            obj.SEQNEC = SEQNEC;
            obj.NR_REG = NR_REG;
            obj.NRVOLS = NRVOLS;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WARTIGOCORLOTE toCompare = obj as WARTIGOCORLOTE;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.ARTIGO, toCompare.ARTIGO))
            return false;
          if (!Object.Equals(this.CARTAZ, toCompare.CARTAZ))
            return false;
          if (!Object.Equals(this.CODCOR, toCompare.CODCOR))
            return false;
          if (!Object.Equals(this.IDLOTE, toCompare.IDLOTE))
            return false;
          if (!Object.Equals(this.REFLOTE, toCompare.REFLOTE))
            return false;
          if (!Object.Equals(this.IDLOCAL, toCompare.IDLOCAL))
            return false;
          if (!Object.Equals(this.NRREG, toCompare.NRREG))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + ARTIGO.GetHashCode();
          hashCode = (hashCode * 7) + CARTAZ.GetHashCode();
          hashCode = (hashCode * 7) + CODCOR.GetHashCode();
          hashCode = (hashCode * 7) + IDLOTE.GetHashCode();
          hashCode = (hashCode * 7) + REFLOTE.GetHashCode();
          hashCode = (hashCode * 7) + IDLOCAL.GetHashCode();
          hashCode = (hashCode * 7) + NRREG.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
