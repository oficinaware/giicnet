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
    /// There are no comments for DataGiic_LiagoModel.WKPACK in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// IDPACK
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WKPACK")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WKPACK : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WKPACK object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="iDPACK">Initial value of IDPACK.</param>
        public static WKPACK CreateWKPACK(int sPID, string iDPACK)
        {
            WKPACK wKPACK = new WKPACK();
            wKPACK.SPID = sPID;
            wKPACK.IDPACK = iDPACK;
            return wKPACK;
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
        /// There are no comments for IDPACK in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(14)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string IDPACK
        {
            get
            {
                string value = _IDPACK;
                OnGetIDPACK(ref value);
                return value;
            }
            set
            {
                if (_IDPACK != value)
                {
                  OnIDPACKChanging(ref value);
                  ReportPropertyChanging("IDPACK");
                  _IDPACK = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("IDPACK");
                  OnIDPACKChanged();
              }
            }
        }
        private string _IDPACK;
        partial void OnGetIDPACK(ref string value);
        partial void OnIDPACKChanging(ref string value);
        partial void OnIDPACKChanged();
    
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
        private global::System.Nullable<System.DateTime> _DATAREG = DateTime.Now;
        partial void OnGetDATAREG(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAREGChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAREGChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WKPACK obj = new WKPACK();
            obj.SPID = SPID;
            obj.IDPACK = IDPACK;
            obj.DATAREG = DATAREG;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WKPACK toCompare = obj as WKPACK;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.IDPACK, toCompare.IDPACK))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + IDPACK.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}