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
    /// There are no comments for DataGiic_LiagoModel.wkstocks in the schema.
    /// </summary>
    /// <KeyProperties>
    /// nrreg
    /// spid
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wkstocks")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wkstocks : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wkstocks object.
        /// </summary>
        /// <param name="nrreg">Initial value of nrreg.</param>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="lN">Initial value of LN.</param>
        public static wkstocks Createwkstocks(global::System.Guid nrreg, int spid, int lN)
        {
            wkstocks wkstocks = new wkstocks();
            wkstocks.nrreg = nrreg;
            wkstocks.spid = spid;
            wkstocks.LN = lN;
            return wkstocks;
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
        /// There are no comments for spid in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int spid
        {
            get
            {
                int value = _spid;
                OnGetspid(ref value);
                return value;
            }
            set
            {
                if (_spid != value)
                {
                  OnspidChanging(ref value);
                  ReportPropertyChanging("spid");
                  _spid = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("spid");
                  OnspidChanged();
              }
            }
        }
        private int _spid;
        partial void OnGetspid(ref int value);
        partial void OnspidChanging(ref int value);
        partial void OnspidChanged();
    
        /// <summary>
        /// There are no comments for ARM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
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
        /// There are no comments for IDSORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
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
                  _IDSORT = StructuralObject.SetValidValue(value, true);
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
        private string _TAM = @"space(4)";
        partial void OnGetTAM(ref string value);
        partial void OnTAMChanging(ref string value);
        partial void OnTAMChanged();
    
        /// <summary>
        /// There are no comments for IDLOTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> IDLOTE
        {
            get
            {
                global::System.Nullable<int> value = _IDLOTE;
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
        private global::System.Nullable<int> _IDLOTE = 0;
        partial void OnGetIDLOTE(ref global::System.Nullable<int> value);
        partial void OnIDLOTEChanging(ref global::System.Nullable<int> value);
        partial void OnIDLOTEChanged();
    
        /// <summary>
        /// There are no comments for IDLOCAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
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
                  _IDLOCAL = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for QTEXIS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> QTEXIS
        {
            get
            {
                global::System.Nullable<decimal> value = _QTEXIS;
                OnGetQTEXIS(ref value);
                return value;
            }
            set
            {
                if (_QTEXIS != value)
                {
                  OnQTEXISChanging(ref value);
                  ReportPropertyChanging("QTEXIS");
                  _QTEXIS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTEXIS");
                  OnQTEXISChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _QTEXIS;
        partial void OnGetQTEXIS(ref global::System.Nullable<decimal> value);
        partial void OnQTEXISChanging(ref global::System.Nullable<decimal> value);
        partial void OnQTEXISChanged();
    
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
        /// There are no comments for CUSTMED in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CUSTMED
        {
            get
            {
                global::System.Nullable<decimal> value = _CUSTMED;
                OnGetCUSTMED(ref value);
                return value;
            }
            set
            {
                if (_CUSTMED != value)
                {
                  OnCUSTMEDChanging(ref value);
                  ReportPropertyChanging("CUSTMED");
                  _CUSTMED = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CUSTMED");
                  OnCUSTMEDChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CUSTMED;
        partial void OnGetCUSTMED(ref global::System.Nullable<decimal> value);
        partial void OnCUSTMEDChanging(ref global::System.Nullable<decimal> value);
        partial void OnCUSTMEDChanged();
    
        /// <summary>
        /// There are no comments for ULCUST in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> ULCUST
        {
            get
            {
                global::System.Nullable<decimal> value = _ULCUST;
                OnGetULCUST(ref value);
                return value;
            }
            set
            {
                if (_ULCUST != value)
                {
                  OnULCUSTChanging(ref value);
                  ReportPropertyChanging("ULCUST");
                  _ULCUST = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ULCUST");
                  OnULCUSTChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _ULCUST;
        partial void OnGetULCUST(ref global::System.Nullable<decimal> value);
        partial void OnULCUSTChanging(ref global::System.Nullable<decimal> value);
        partial void OnULCUSTChanged();
    
        /// <summary>
        /// There are no comments for VALORSTK in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VALORSTK
        {
            get
            {
                global::System.Nullable<decimal> value = _VALORSTK;
                OnGetVALORSTK(ref value);
                return value;
            }
            set
            {
                if (_VALORSTK != value)
                {
                  OnVALORSTKChanging(ref value);
                  ReportPropertyChanging("VALORSTK");
                  _VALORSTK = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VALORSTK");
                  OnVALORSTKChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VALORSTK;
        partial void OnGetVALORSTK(ref global::System.Nullable<decimal> value);
        partial void OnVALORSTKChanging(ref global::System.Nullable<decimal> value);
        partial void OnVALORSTKChanged();
    
        /// <summary>
        /// There are no comments for LN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LN
        {
            get
            {
                int value = _LN;
                OnGetLN(ref value);
                return value;
            }
            set
            {
                if (_LN != value)
                {
                  OnLNChanging(ref value);
                  ReportPropertyChanging("LN");
                  _LN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LN");
                  OnLNChanged();
              }
            }
        }
        private int _LN;
        partial void OnGetLN(ref int value);
        partial void OnLNChanging(ref int value);
        partial void OnLNChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wkstocks obj = new wkstocks();
            obj.nrreg = nrreg;
            obj.spid = spid;
            obj.ARM = ARM;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.IDSORT = IDSORT;
            obj.ITAM = ITAM;
            obj.TAM = TAM;
            obj.IDLOTE = IDLOTE;
            obj.IDLOCAL = IDLOCAL;
            obj.QTEXIS = QTEXIS;
            obj.QTPACK = QTPACK;
            obj.CUSTMED = CUSTMED;
            obj.ULCUST = ULCUST;
            obj.VALORSTK = VALORSTK;
            obj.LN = LN;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wkstocks toCompare = obj as wkstocks;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.nrreg, toCompare.nrreg))
            return false;
          if (!Object.Equals(this.spid, toCompare.spid))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + nrreg.GetHashCode();
          hashCode = (hashCode * 7) + spid.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
