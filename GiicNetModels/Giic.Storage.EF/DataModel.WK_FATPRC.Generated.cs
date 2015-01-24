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
    /// There are no comments for DataGiic_LiagoModel.WK_FATPRC in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// TPDOC
    /// NRFACT
    /// LNFACT
    /// IDOTAM
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_FATPRC")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_FATPRC : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_FATPRC object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="tPDOC">Initial value of TPDOC.</param>
        /// <param name="nRFACT">Initial value of NRFACT.</param>
        /// <param name="lNFACT">Initial value of LNFACT.</param>
        /// <param name="iDOTAM">Initial value of IDOTAM.</param>
        public static WK_FATPRC CreateWK_FATPRC(int sPID, string tPDOC, int nRFACT, int lNFACT, short iDOTAM)
        {
            WK_FATPRC wK_FATPRC = new WK_FATPRC();
            wK_FATPRC.SPID = sPID;
            wK_FATPRC.TPDOC = tPDOC;
            wK_FATPRC.NRFACT = nRFACT;
            wK_FATPRC.LNFACT = lNFACT;
            wK_FATPRC.IDOTAM = iDOTAM;
            return wK_FATPRC;
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
        /// There are no comments for TPDOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
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
                  _TPDOC = StructuralObject.SetValidValue(value, false);
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
        /// There are no comments for NRFACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int NRFACT
        {
            get
            {
                int value = _NRFACT;
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
        private int _NRFACT;
        partial void OnGetNRFACT(ref int value);
        partial void OnNRFACTChanging(ref int value);
        partial void OnNRFACTChanged();
    
        /// <summary>
        /// There are no comments for LNFACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LNFACT
        {
            get
            {
                int value = _LNFACT;
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
        private int _LNFACT;
        partial void OnGetLNFACT(ref int value);
        partial void OnLNFACTChanging(ref int value);
        partial void OnLNFACTChanged();
    
        /// <summary>
        /// There are no comments for IDOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public short IDOTAM
        {
            get
            {
                short value = _IDOTAM;
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
        private short _IDOTAM;
        partial void OnGetIDOTAM(ref short value);
        partial void OnIDOTAMChanging(ref short value);
        partial void OnIDOTAMChanged();
    
        /// <summary>
        /// There are no comments for DOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
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
                  _DOTAM = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
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
                  _AOTAM = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for IAOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<short> IAOTAM
        {
            get
            {
                global::System.Nullable<short> value = _IAOTAM;
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
        private global::System.Nullable<short> _IAOTAM;
        partial void OnGetIAOTAM(ref global::System.Nullable<short> value);
        partial void OnIAOTAMChanging(ref global::System.Nullable<short> value);
        partial void OnIAOTAMChanged();
    
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

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_FATPRC obj = new WK_FATPRC();
            obj.SPID = SPID;
            obj.TPDOC = TPDOC;
            obj.NRFACT = NRFACT;
            obj.LNFACT = LNFACT;
            obj.IDOTAM = IDOTAM;
            obj.DOTAM = DOTAM;
            obj.AOTAM = AOTAM;
            obj.IAOTAM = IAOTAM;
            obj.PRECO = PRECO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_FATPRC toCompare = obj as WK_FATPRC;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.TPDOC, toCompare.TPDOC))
            return false;
          if (!Object.Equals(this.NRFACT, toCompare.NRFACT))
            return false;
          if (!Object.Equals(this.LNFACT, toCompare.LNFACT))
            return false;
          if (!Object.Equals(this.IDOTAM, toCompare.IDOTAM))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + TPDOC.GetHashCode();
          hashCode = (hashCode * 7) + NRFACT.GetHashCode();
          hashCode = (hashCode * 7) + LNFACT.GetHashCode();
          hashCode = (hashCode * 7) + IDOTAM.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}