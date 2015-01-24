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
    /// There are no comments for DataGiic_LiagoModel.WK_SELECT_OF_EC in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// ORDFAB
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_SELECT_OF_EC")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_SELECT_OF_EC : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_SELECT_OF_EC object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="oRDFAB">Initial value of ORDFAB.</param>
        public static WK_SELECT_OF_EC CreateWK_SELECT_OF_EC(int sPID, string oRDFAB)
        {
            WK_SELECT_OF_EC wK_SELECT_OF_EC = new WK_SELECT_OF_EC();
            wK_SELECT_OF_EC.SPID = sPID;
            wK_SELECT_OF_EC.ORDFAB = oRDFAB;
            return wK_SELECT_OF_EC;
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
        /// There are no comments for ORDFAB in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
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
                  _ORDFAB = StructuralObject.SetValidValue(value, false);
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
        /// There are no comments for DATAFIM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATAFIM
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATAFIM;
                OnGetDATAFIM(ref value);
                return value;
            }
            set
            {
                if (_DATAFIM != value)
                {
                  OnDATAFIMChanging(ref value);
                  ReportPropertyChanging("DATAFIM");
                  _DATAFIM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATAFIM");
                  OnDATAFIMChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATAFIM;
        partial void OnGetDATAFIM(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAFIMChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAFIMChanged();
    
        /// <summary>
        /// There are no comments for DATAORD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATAORD
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATAORD;
                OnGetDATAORD(ref value);
                return value;
            }
            set
            {
                if (_DATAORD != value)
                {
                  OnDATAORDChanging(ref value);
                  ReportPropertyChanging("DATAORD");
                  _DATAORD = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATAORD");
                  OnDATAORDChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATAORD;
        partial void OnGetDATAORD(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAORDChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAORDChanged();
    
        /// <summary>
        /// There are no comments for CODROTA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string CODROTA
        {
            get
            {
                string value = _CODROTA;
                OnGetCODROTA(ref value);
                return value;
            }
            set
            {
                if (_CODROTA != value)
                {
                  OnCODROTAChanging(ref value);
                  ReportPropertyChanging("CODROTA");
                  _CODROTA = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CODROTA");
                  OnCODROTAChanged();
              }
            }
        }
        private string _CODROTA;
        partial void OnGetCODROTA(ref string value);
        partial void OnCODROTAChanging(ref string value);
        partial void OnCODROTAChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_SELECT_OF_EC obj = new WK_SELECT_OF_EC();
            obj.SPID = SPID;
            obj.ORDFAB = ORDFAB;
            obj.DATAFIM = DATAFIM;
            obj.DATAORD = DATAORD;
            obj.CODROTA = CODROTA;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_SELECT_OF_EC toCompare = obj as WK_SELECT_OF_EC;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.ORDFAB, toCompare.ORDFAB))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + ORDFAB.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}