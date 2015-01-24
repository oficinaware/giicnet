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
    /// There are no comments for DataGiic_LiagoModel.WKORC_SIMULACOES in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// DONR
    /// ATENR
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WKORC_SIMULACOES")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WKORC_SIMULACOES : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WKORC_SIMULACOES object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="dONR">Initial value of DONR.</param>
        /// <param name="aTENR">Initial value of ATENR.</param>
        public static WKORC_SIMULACOES CreateWKORC_SIMULACOES(int sPID, string dONR, string aTENR)
        {
            WKORC_SIMULACOES wKORC_SIMULACOES = new WKORC_SIMULACOES();
            wKORC_SIMULACOES.SPID = sPID;
            wKORC_SIMULACOES.DONR = dONR;
            wKORC_SIMULACOES.ATENR = aTENR;
            return wKORC_SIMULACOES;
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
        /// There are no comments for DONR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string DONR
        {
            get
            {
                string value = _DONR;
                OnGetDONR(ref value);
                return value;
            }
            set
            {
                if (_DONR != value)
                {
                  OnDONRChanging(ref value);
                  ReportPropertyChanging("DONR");
                  _DONR = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("DONR");
                  OnDONRChanged();
              }
            }
        }
        private string _DONR;
        partial void OnGetDONR(ref string value);
        partial void OnDONRChanging(ref string value);
        partial void OnDONRChanged();
    
        /// <summary>
        /// There are no comments for ATENR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ATENR
        {
            get
            {
                string value = _ATENR;
                OnGetATENR(ref value);
                return value;
            }
            set
            {
                if (_ATENR != value)
                {
                  OnATENRChanging(ref value);
                  ReportPropertyChanging("ATENR");
                  _ATENR = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ATENR");
                  OnATENRChanged();
              }
            }
        }
        private string _ATENR;
        partial void OnGetATENR(ref string value);
        partial void OnATENRChanging(ref string value);
        partial void OnATENRChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WKORC_SIMULACOES obj = new WKORC_SIMULACOES();
            obj.SPID = SPID;
            obj.DONR = DONR;
            obj.ATENR = ATENR;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WKORC_SIMULACOES toCompare = obj as WKORC_SIMULACOES;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.DONR, toCompare.DONR))
            return false;
          if (!Object.Equals(this.ATENR, toCompare.ATENR))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + DONR.GetHashCode();
          hashCode = (hashCode * 7) + ATENR.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}