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
    /// There are no comments for DataGiic_LiagoModel.LOTES in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ORDFAB
    /// LOTE
    /// ITAM
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="LOTES")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LOTES : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new LOTES object.
        /// </summary>
        /// <param name="oRDFAB">Initial value of ORDFAB.</param>
        /// <param name="lOTE">Initial value of LOTE.</param>
        /// <param name="iTAM">Initial value of ITAM.</param>
        public static LOTES CreateLOTES(string oRDFAB, int lOTE, short iTAM)
        {
            LOTES lOTES = new LOTES();
            lOTES.ORDFAB = oRDFAB;
            lOTES.LOTE = lOTE;
            lOTES.ITAM = iTAM;
            return lOTES;
        }

        #endregion

        #region Properties
    
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
        /// There are no comments for LOTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LOTE
        {
            get
            {
                int value = _LOTE;
                OnGetLOTE(ref value);
                return value;
            }
            set
            {
                if (_LOTE != value)
                {
                  OnLOTEChanging(ref value);
                  ReportPropertyChanging("LOTE");
                  _LOTE = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LOTE");
                  OnLOTEChanged();
              }
            }
        }
        private int _LOTE;
        partial void OnGetLOTE(ref int value);
        partial void OnLOTEChanging(ref int value);
        partial void OnLOTEChanged();
    
        /// <summary>
        /// There are no comments for ITAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public short ITAM
        {
            get
            {
                short value = _ITAM;
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
        private short _ITAM;
        partial void OnGetITAM(ref short value);
        partial void OnITAMChanging(ref short value);
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
        /// There are no comments for QT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QT
        {
            get
            {
                global::System.Nullable<int> value = _QT;
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
        private global::System.Nullable<int> _QT;
        partial void OnGetQT(ref global::System.Nullable<int> value);
        partial void OnQTChanging(ref global::System.Nullable<int> value);
        partial void OnQTChanged();
    
        /// <summary>
        /// There are no comments for QTEA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QTEA
        {
            get
            {
                global::System.Nullable<int> value = _QTEA;
                OnGetQTEA(ref value);
                return value;
            }
            set
            {
                if (_QTEA != value)
                {
                  OnQTEAChanging(ref value);
                  ReportPropertyChanging("QTEA");
                  _QTEA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTEA");
                  OnQTEAChanged();
              }
            }
        }
        private global::System.Nullable<int> _QTEA;
        partial void OnGetQTEA(ref global::System.Nullable<int> value);
        partial void OnQTEAChanging(ref global::System.Nullable<int> value);
        partial void OnQTEAChanged();
    
        /// <summary>
        /// There are no comments for DATAEA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATAEA
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATAEA;
                OnGetDATAEA(ref value);
                return value;
            }
            set
            {
                if (_DATAEA != value)
                {
                  OnDATAEAChanging(ref value);
                  ReportPropertyChanging("DATAEA");
                  _DATAEA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATAEA");
                  OnDATAEAChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATAEA;
        partial void OnGetDATAEA(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAEAChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAEAChanged();
    
        /// <summary>
        /// There are no comments for SERIE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> SERIE
        {
            get
            {
                global::System.Nullable<int> value = _SERIE;
                OnGetSERIE(ref value);
                return value;
            }
            set
            {
                if (_SERIE != value)
                {
                  OnSERIEChanging(ref value);
                  ReportPropertyChanging("SERIE");
                  _SERIE = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SERIE");
                  OnSERIEChanged();
              }
            }
        }
        private global::System.Nullable<int> _SERIE;
        partial void OnGetSERIE(ref global::System.Nullable<int> value);
        partial void OnSERIEChanging(ref global::System.Nullable<int> value);
        partial void OnSERIEChanged();
    
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
        private global::System.Nullable<int> _LNENCO = 0;
        partial void OnGetLNENCO(ref global::System.Nullable<int> value);
        partial void OnLNENCOChanging(ref global::System.Nullable<int> value);
        partial void OnLNENCOChanged();
    
        /// <summary>
        /// There are no comments for NRPREP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string NRPREP
        {
            get
            {
                string value = _NRPREP;
                OnGetNRPREP(ref value);
                return value;
            }
            set
            {
                if (_NRPREP != value)
                {
                  OnNRPREPChanging(ref value);
                  ReportPropertyChanging("NRPREP");
                  _NRPREP = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NRPREP");
                  OnNRPREPChanged();
              }
            }
        }
        private string _NRPREP = @"0";
        partial void OnGetNRPREP(ref string value);
        partial void OnNRPREPChanging(ref string value);
        partial void OnNRPREPChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            LOTES obj = new LOTES();
            obj.ORDFAB = ORDFAB;
            obj.LOTE = LOTE;
            obj.ITAM = ITAM;
            obj.TAM = TAM;
            obj.QT = QT;
            obj.QTEA = QTEA;
            obj.DATAEA = DATAEA;
            obj.SERIE = SERIE;
            obj.NRENCO = NRENCO;
            obj.LNENCO = LNENCO;
            obj.NRPREP = NRPREP;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          LOTES toCompare = obj as LOTES;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ORDFAB, toCompare.ORDFAB))
            return false;
          if (!Object.Equals(this.LOTE, toCompare.LOTE))
            return false;
          if (!Object.Equals(this.ITAM, toCompare.ITAM))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ORDFAB.GetHashCode();
          hashCode = (hashCode * 7) + LOTE.GetHashCode();
          hashCode = (hashCode * 7) + ITAM.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
