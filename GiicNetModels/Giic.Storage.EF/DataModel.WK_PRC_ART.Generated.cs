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
    /// There are no comments for DataGiic_LiagoModel.WK_PRC_ART in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// ARTIGO
    /// CARTAZ
    /// CODCOR
    /// PTAM
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_PRC_ART")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_PRC_ART : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_PRC_ART object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        /// <param name="cARTAZ">Initial value of CARTAZ.</param>
        /// <param name="cODCOR">Initial value of CODCOR.</param>
        /// <param name="pTAM">Initial value of PTAM.</param>
        public static WK_PRC_ART CreateWK_PRC_ART(int sPID, string aRTIGO, string cARTAZ, string cODCOR, string pTAM)
        {
            WK_PRC_ART wK_PRC_ART = new WK_PRC_ART();
            wK_PRC_ART.SPID = sPID;
            wK_PRC_ART.ARTIGO = aRTIGO;
            wK_PRC_ART.CARTAZ = cARTAZ;
            wK_PRC_ART.CODCOR = cODCOR;
            wK_PRC_ART.PTAM = pTAM;
            return wK_PRC_ART;
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
        private string _CARTAZ = @"space((5))";
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
        /// There are no comments for PTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string PTAM
        {
            get
            {
                string value = _PTAM;
                OnGetPTAM(ref value);
                return value;
            }
            set
            {
                if (_PTAM != value)
                {
                  OnPTAMChanging(ref value);
                  ReportPropertyChanging("PTAM");
                  _PTAM = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("PTAM");
                  OnPTAMChanged();
              }
            }
        }
        private string _PTAM = @"space(4)";
        partial void OnGetPTAM(ref string value);
        partial void OnPTAMChanging(ref string value);
        partial void OnPTAMChanged();
    
        /// <summary>
        /// There are no comments for MPRCVND in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> MPRCVND
        {
            get
            {
                global::System.Nullable<decimal> value = _MPRCVND;
                OnGetMPRCVND(ref value);
                return value;
            }
            set
            {
                if (_MPRCVND != value)
                {
                  OnMPRCVNDChanging(ref value);
                  ReportPropertyChanging("MPRCVND");
                  _MPRCVND = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("MPRCVND");
                  OnMPRCVNDChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _MPRCVND = 0m;
        partial void OnGetMPRCVND(ref global::System.Nullable<decimal> value);
        partial void OnMPRCVNDChanging(ref global::System.Nullable<decimal> value);
        partial void OnMPRCVNDChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_PRC_ART obj = new WK_PRC_ART();
            obj.SPID = SPID;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.PTAM = PTAM;
            obj.MPRCVND = MPRCVND;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_PRC_ART toCompare = obj as WK_PRC_ART;
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
          if (!Object.Equals(this.PTAM, toCompare.PTAM))
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
          hashCode = (hashCode * 7) + PTAM.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
