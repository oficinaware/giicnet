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
    /// There are no comments for DataGiic_LiagoModel.WK_EMFILA in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// ORDFAB
    /// SEQ
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_EMFILA")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_EMFILA : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_EMFILA object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="oRDFAB">Initial value of ORDFAB.</param>
        /// <param name="sEQ">Initial value of SEQ.</param>
        public static WK_EMFILA CreateWK_EMFILA(int sPID, string oRDFAB, int sEQ)
        {
            WK_EMFILA wK_EMFILA = new WK_EMFILA();
            wK_EMFILA.SPID = sPID;
            wK_EMFILA.ORDFAB = oRDFAB;
            wK_EMFILA.SEQ = sEQ;
            return wK_EMFILA;
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
        /// There are no comments for SEQ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int SEQ
        {
            get
            {
                int value = _SEQ;
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
        private int _SEQ;
        partial void OnGetSEQ(ref int value);
        partial void OnSEQChanging(ref int value);
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
        /// There are no comments for QTFILA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QTFILA
        {
            get
            {
                global::System.Nullable<int> value = _QTFILA;
                OnGetQTFILA(ref value);
                return value;
            }
            set
            {
                if (_QTFILA != value)
                {
                  OnQTFILAChanging(ref value);
                  ReportPropertyChanging("QTFILA");
                  _QTFILA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTFILA");
                  OnQTFILAChanged();
              }
            }
        }
        private global::System.Nullable<int> _QTFILA = 0;
        partial void OnGetQTFILA(ref global::System.Nullable<int> value);
        partial void OnQTFILAChanging(ref global::System.Nullable<int> value);
        partial void OnQTFILAChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_EMFILA obj = new WK_EMFILA();
            obj.SPID = SPID;
            obj.ORDFAB = ORDFAB;
            obj.SEQ = SEQ;
            obj.OPERACAO = OPERACAO;
            obj.QTFILA = QTFILA;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_EMFILA toCompare = obj as WK_EMFILA;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.ORDFAB, toCompare.ORDFAB))
            return false;
          if (!Object.Equals(this.SEQ, toCompare.SEQ))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + ORDFAB.GetHashCode();
          hashCode = (hashCode * 7) + SEQ.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
