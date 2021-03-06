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
    /// There are no comments for DataGiic_LiagoModel.STKMOVPHIST in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ARMORIG
    /// CODMOV
    /// NRDOCI
    /// LNDOC
    /// nrreg
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="STKMOVPHIST")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class STKMOVPHIST : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new STKMOVPHIST object.
        /// </summary>
        /// <param name="aRMORIG">Initial value of ARMORIG.</param>
        /// <param name="cODMOV">Initial value of CODMOV.</param>
        /// <param name="nRDOCI">Initial value of NRDOCI.</param>
        /// <param name="lNDOC">Initial value of LNDOC.</param>
        /// <param name="nrreg">Initial value of nrreg.</param>
        /// <param name="iDSORT">Initial value of IDSORT.</param>
        public static STKMOVPHIST CreateSTKMOVPHIST(string aRMORIG, string cODMOV, string nRDOCI, int lNDOC, int nrreg, string iDSORT)
        {
            STKMOVPHIST sTKMOVPHIST = new STKMOVPHIST();
            sTKMOVPHIST.ARMORIG = aRMORIG;
            sTKMOVPHIST.CODMOV = cODMOV;
            sTKMOVPHIST.NRDOCI = nRDOCI;
            sTKMOVPHIST.LNDOC = lNDOC;
            sTKMOVPHIST.nrreg = nrreg;
            sTKMOVPHIST.IDSORT = iDSORT;
            return sTKMOVPHIST;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ARMORIG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ARMORIG
        {
            get
            {
                string value = _ARMORIG;
                OnGetARMORIG(ref value);
                return value;
            }
            set
            {
                if (_ARMORIG != value)
                {
                  OnARMORIGChanging(ref value);
                  ReportPropertyChanging("ARMORIG");
                  _ARMORIG = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ARMORIG");
                  OnARMORIGChanged();
              }
            }
        }
        private string _ARMORIG;
        partial void OnGetARMORIG(ref string value);
        partial void OnARMORIGChanging(ref string value);
        partial void OnARMORIGChanged();
    
        /// <summary>
        /// There are no comments for CODMOV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODMOV
        {
            get
            {
                string value = _CODMOV;
                OnGetCODMOV(ref value);
                return value;
            }
            set
            {
                if (_CODMOV != value)
                {
                  OnCODMOVChanging(ref value);
                  ReportPropertyChanging("CODMOV");
                  _CODMOV = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODMOV");
                  OnCODMOVChanged();
              }
            }
        }
        private string _CODMOV;
        partial void OnGetCODMOV(ref string value);
        partial void OnCODMOVChanging(ref string value);
        partial void OnCODMOVChanged();
    
        /// <summary>
        /// There are no comments for NRDOCI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string NRDOCI
        {
            get
            {
                string value = _NRDOCI;
                OnGetNRDOCI(ref value);
                return value;
            }
            set
            {
                if (_NRDOCI != value)
                {
                  OnNRDOCIChanging(ref value);
                  ReportPropertyChanging("NRDOCI");
                  _NRDOCI = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("NRDOCI");
                  OnNRDOCIChanged();
              }
            }
        }
        private string _NRDOCI;
        partial void OnGetNRDOCI(ref string value);
        partial void OnNRDOCIChanging(ref string value);
        partial void OnNRDOCIChanged();
    
        /// <summary>
        /// There are no comments for LNDOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LNDOC
        {
            get
            {
                int value = _LNDOC;
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
        private int _LNDOC;
        partial void OnGetLNDOC(ref int value);
        partial void OnLNDOCChanging(ref int value);
        partial void OnLNDOCChanged();
    
        /// <summary>
        /// There are no comments for nrreg in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int nrreg
        {
            get
            {
                int value = _nrreg;
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
        private int _nrreg;
        partial void OnGetnrreg(ref int value);
        partial void OnnrregChanging(ref int value);
        partial void OnnrregChanged();
    
        /// <summary>
        /// There are no comments for TERCEIRO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string TERCEIRO
        {
            get
            {
                string value = _TERCEIRO;
                OnGetTERCEIRO(ref value);
                return value;
            }
            set
            {
                if (_TERCEIRO != value)
                {
                  OnTERCEIROChanging(ref value);
                  ReportPropertyChanging("TERCEIRO");
                  _TERCEIRO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TERCEIRO");
                  OnTERCEIROChanged();
              }
            }
        }
        private string _TERCEIRO;
        partial void OnGetTERCEIRO(ref string value);
        partial void OnTERCEIROChanging(ref string value);
        partial void OnTERCEIROChanged();
    
        /// <summary>
        /// There are no comments for DTMOV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DTMOV
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DTMOV;
                OnGetDTMOV(ref value);
                return value;
            }
            set
            {
                if (_DTMOV != value)
                {
                  OnDTMOVChanging(ref value);
                  ReportPropertyChanging("DTMOV");
                  _DTMOV = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DTMOV");
                  OnDTMOVChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DTMOV;
        partial void OnGetDTMOV(ref global::System.Nullable<System.DateTime> value);
        partial void OnDTMOVChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDTMOVChanged();
    
        /// <summary>
        /// There are no comments for NRDOCE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string NRDOCE
        {
            get
            {
                string value = _NRDOCE;
                OnGetNRDOCE(ref value);
                return value;
            }
            set
            {
                if (_NRDOCE != value)
                {
                  OnNRDOCEChanging(ref value);
                  ReportPropertyChanging("NRDOCE");
                  _NRDOCE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NRDOCE");
                  OnNRDOCEChanged();
              }
            }
        }
        private string _NRDOCE;
        partial void OnGetNRDOCE(ref string value);
        partial void OnNRDOCEChanging(ref string value);
        partial void OnNRDOCEChanged();
    
        /// <summary>
        /// There are no comments for ENTID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public string ENTID
        {
            get
            {
                string value = _ENTID;
                OnGetENTID(ref value);
                return value;
            }
            set
            {
                if (_ENTID != value)
                {
                  OnENTIDChanging(ref value);
                  ReportPropertyChanging("ENTID");
                  _ENTID = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ENTID");
                  OnENTIDChanged();
              }
            }
        }
        private string _ENTID;
        partial void OnGetENTID(ref string value);
        partial void OnENTIDChanging(ref string value);
        partial void OnENTIDChanged();
    
        /// <summary>
        /// There are no comments for ARMDEST in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string ARMDEST
        {
            get
            {
                string value = _ARMDEST;
                OnGetARMDEST(ref value);
                return value;
            }
            set
            {
                if (_ARMDEST != value)
                {
                  OnARMDESTChanging(ref value);
                  ReportPropertyChanging("ARMDEST");
                  _ARMDEST = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ARMDEST");
                  OnARMDESTChanged();
              }
            }
        }
        private string _ARMDEST;
        partial void OnGetARMDEST(ref string value);
        partial void OnARMDESTChanging(ref string value);
        partial void OnARMDESTChanged();
    
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
        /// There are no comments for ITAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<short> ITAM
        {
            get
            {
                global::System.Nullable<short> value = _ITAM;
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
        private global::System.Nullable<short> _ITAM;
        partial void OnGetITAM(ref global::System.Nullable<short> value);
        partial void OnITAMChanging(ref global::System.Nullable<short> value);
        partial void OnITAMChanged();
    
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
        /// There are no comments for IDSORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string IDSORT
        {
            get
            {
                string value = _IDSORT;
                OnGetIDSORT(ref value);
                return value;
            }
            set
            {
                if (_IDSORT != value)
                {
                  OnIDSORTChanging(ref value);
                  ReportPropertyChanging("IDSORT");
                  _IDSORT = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("IDSORT");
                  OnIDSORTChanged();
              }
            }
        }
        private string _IDSORT = @"0";
        partial void OnGetIDSORT(ref string value);
        partial void OnIDSORTChanging(ref string value);
        partial void OnIDSORTChanged();
    
        /// <summary>
        /// There are no comments for QTMOV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> QTMOV
        {
            get
            {
                global::System.Nullable<decimal> value = _QTMOV;
                OnGetQTMOV(ref value);
                return value;
            }
            set
            {
                if (_QTMOV != value)
                {
                  OnQTMOVChanging(ref value);
                  ReportPropertyChanging("QTMOV");
                  _QTMOV = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTMOV");
                  OnQTMOVChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _QTMOV = 0m;
        partial void OnGetQTMOV(ref global::System.Nullable<decimal> value);
        partial void OnQTMOVChanging(ref global::System.Nullable<decimal> value);
        partial void OnQTMOVChanged();
    
        /// <summary>
        /// There are no comments for QTPACK in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QTPACK
        {
            get
            {
                global::System.Nullable<int> value = _QTPACK;
                OnGetQTPACK(ref value);
                return value;
            }
            set
            {
                if (_QTPACK != value)
                {
                  OnQTPACKChanging(ref value);
                  ReportPropertyChanging("QTPACK");
                  _QTPACK = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTPACK");
                  OnQTPACKChanged();
              }
            }
        }
        private global::System.Nullable<int> _QTPACK = 0;
        partial void OnGetQTPACK(ref global::System.Nullable<int> value);
        partial void OnQTPACKChanging(ref global::System.Nullable<int> value);
        partial void OnQTPACKChanged();
    
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
        private global::System.Nullable<decimal> _VALOR = 0m;
        partial void OnGetVALOR(ref global::System.Nullable<decimal> value);
        partial void OnVALORChanging(ref global::System.Nullable<decimal> value);
        partial void OnVALORChanged();
    
        /// <summary>
        /// There are no comments for TPCC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string TPCC
        {
            get
            {
                string value = _TPCC;
                OnGetTPCC(ref value);
                return value;
            }
            set
            {
                if (_TPCC != value)
                {
                  OnTPCCChanging(ref value);
                  ReportPropertyChanging("TPCC");
                  _TPCC = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TPCC");
                  OnTPCCChanged();
              }
            }
        }
        private string _TPCC;
        partial void OnGetTPCC(ref string value);
        partial void OnTPCCChanging(ref string value);
        partial void OnTPCCChanged();
    
        /// <summary>
        /// There are no comments for CCUSTO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string CCUSTO
        {
            get
            {
                string value = _CCUSTO;
                OnGetCCUSTO(ref value);
                return value;
            }
            set
            {
                if (_CCUSTO != value)
                {
                  OnCCUSTOChanging(ref value);
                  ReportPropertyChanging("CCUSTO");
                  _CCUSTO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CCUSTO");
                  OnCCUSTOChanged();
              }
            }
        }
        private string _CCUSTO;
        partial void OnGetCCUSTO(ref string value);
        partial void OnCCUSTOChanging(ref string value);
        partial void OnCCUSTOChanged();
    
        /// <summary>
        /// There are no comments for CCUSTOLN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> CCUSTOLN
        {
            get
            {
                global::System.Nullable<int> value = _CCUSTOLN;
                OnGetCCUSTOLN(ref value);
                return value;
            }
            set
            {
                if (_CCUSTOLN != value)
                {
                  OnCCUSTOLNChanging(ref value);
                  ReportPropertyChanging("CCUSTOLN");
                  _CCUSTOLN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CCUSTOLN");
                  OnCCUSTOLNChanged();
              }
            }
        }
        private global::System.Nullable<int> _CCUSTOLN;
        partial void OnGetCCUSTOLN(ref global::System.Nullable<int> value);
        partial void OnCCUSTOLNChanging(ref global::System.Nullable<int> value);
        partial void OnCCUSTOLNChanged();
    
        /// <summary>
        /// There are no comments for nrenco in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string nrenco
        {
            get
            {
                string value = _nrenco;
                OnGetnrenco(ref value);
                return value;
            }
            set
            {
                if (_nrenco != value)
                {
                  OnnrencoChanging(ref value);
                  ReportPropertyChanging("nrenco");
                  _nrenco = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("nrenco");
                  OnnrencoChanged();
              }
            }
        }
        private string _nrenco;
        partial void OnGetnrenco(ref string value);
        partial void OnnrencoChanging(ref string value);
        partial void OnnrencoChanged();
    
        /// <summary>
        /// There are no comments for lnenco in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> lnenco
        {
            get
            {
                global::System.Nullable<int> value = _lnenco;
                OnGetlnenco(ref value);
                return value;
            }
            set
            {
                if (_lnenco != value)
                {
                  OnlnencoChanging(ref value);
                  ReportPropertyChanging("lnenco");
                  _lnenco = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("lnenco");
                  OnlnencoChanged();
              }
            }
        }
        private global::System.Nullable<int> _lnenco;
        partial void OnGetlnenco(ref global::System.Nullable<int> value);
        partial void OnlnencoChanging(ref global::System.Nullable<int> value);
        partial void OnlnencoChanged();
    
        /// <summary>
        /// There are no comments for SINAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string SINAL
        {
            get
            {
                string value = _SINAL;
                OnGetSINAL(ref value);
                return value;
            }
            set
            {
                if (_SINAL != value)
                {
                  OnSINALChanging(ref value);
                  ReportPropertyChanging("SINAL");
                  _SINAL = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("SINAL");
                  OnSINALChanged();
              }
            }
        }
        private string _SINAL;
        partial void OnGetSINAL(ref string value);
        partial void OnSINALChanging(ref string value);
        partial void OnSINALChanged();
    
        /// <summary>
        /// There are no comments for STAT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string STAT
        {
            get
            {
                string value = _STAT;
                OnGetSTAT(ref value);
                return value;
            }
            set
            {
                if (_STAT != value)
                {
                  OnSTATChanging(ref value);
                  ReportPropertyChanging("STAT");
                  _STAT = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("STAT");
                  OnSTATChanged();
              }
            }
        }
        private string _STAT;
        partial void OnGetSTAT(ref string value);
        partial void OnSTATChanging(ref string value);
        partial void OnSTATChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            STKMOVPHIST obj = new STKMOVPHIST();
            obj.ARMORIG = ARMORIG;
            obj.CODMOV = CODMOV;
            obj.NRDOCI = NRDOCI;
            obj.LNDOC = LNDOC;
            obj.nrreg = nrreg;
            obj.TERCEIRO = TERCEIRO;
            obj.DTMOV = DTMOV;
            obj.NRDOCE = NRDOCE;
            obj.ENTID = ENTID;
            obj.ARMDEST = ARMDEST;
            obj.ARTIGO = ARTIGO;
            obj.ITAM = ITAM;
            obj.TAM = TAM;
            obj.IDSORT = IDSORT;
            obj.QTMOV = QTMOV;
            obj.QTPACK = QTPACK;
            obj.VALOR = VALOR;
            obj.TPCC = TPCC;
            obj.CCUSTO = CCUSTO;
            obj.CCUSTOLN = CCUSTOLN;
            obj.nrenco = nrenco;
            obj.lnenco = lnenco;
            obj.SINAL = SINAL;
            obj.STAT = STAT;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          STKMOVPHIST toCompare = obj as STKMOVPHIST;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ARMORIG, toCompare.ARMORIG))
            return false;
          if (!Object.Equals(this.CODMOV, toCompare.CODMOV))
            return false;
          if (!Object.Equals(this.NRDOCI, toCompare.NRDOCI))
            return false;
          if (!Object.Equals(this.LNDOC, toCompare.LNDOC))
            return false;
          if (!Object.Equals(this.nrreg, toCompare.nrreg))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ARMORIG.GetHashCode();
          hashCode = (hashCode * 7) + CODMOV.GetHashCode();
          hashCode = (hashCode * 7) + NRDOCI.GetHashCode();
          hashCode = (hashCode * 7) + LNDOC.GetHashCode();
          hashCode = (hashCode * 7) + nrreg.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
