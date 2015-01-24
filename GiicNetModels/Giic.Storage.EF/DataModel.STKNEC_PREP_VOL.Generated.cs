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
    /// There are no comments for DataGiic_LiagoModel.STKNEC_PREP_VOL in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NRPREP
    /// SEQ
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="STKNEC_PREP_VOL")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class STKNEC_PREP_VOL : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new STKNEC_PREP_VOL object.
        /// </summary>
        /// <param name="nRPREP">Initial value of NRPREP.</param>
        /// <param name="sEQ">Initial value of SEQ.</param>
        public static STKNEC_PREP_VOL CreateSTKNEC_PREP_VOL(int nRPREP, int sEQ)
        {
            STKNEC_PREP_VOL sTKNEC_PREP_VOL = new STKNEC_PREP_VOL();
            sTKNEC_PREP_VOL.NRPREP = nRPREP;
            sTKNEC_PREP_VOL.SEQ = sEQ;
            return sTKNEC_PREP_VOL;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for NRPREP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int NRPREP
        {
            get
            {
                int value = _NRPREP;
                OnGetNRPREP(ref value);
                return value;
            }
            set
            {
                if (_NRPREP != value)
                {
                  OnNRPREPChanging(ref value);
                  ReportPropertyChanging("NRPREP");
                  _NRPREP = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRPREP");
                  OnNRPREPChanged();
              }
            }
        }
        private int _NRPREP;
        partial void OnGetNRPREP(ref int value);
        partial void OnNRPREPChanging(ref int value);
        partial void OnNRPREPChanged();
    
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
        /// There are no comments for tpdoc in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string tpdoc
        {
            get
            {
                string value = _tpdoc;
                OnGettpdoc(ref value);
                return value;
            }
            set
            {
                if (_tpdoc != value)
                {
                  OntpdocChanging(ref value);
                  ReportPropertyChanging("tpdoc");
                  _tpdoc = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("tpdoc");
                  OntpdocChanged();
              }
            }
        }
        private string _tpdoc;
        partial void OnGettpdoc(ref string value);
        partial void OntpdocChanging(ref string value);
        partial void OntpdocChanged();
    
        /// <summary>
        /// There are no comments for nrfact in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> nrfact
        {
            get
            {
                global::System.Nullable<int> value = _nrfact;
                OnGetnrfact(ref value);
                return value;
            }
            set
            {
                if (_nrfact != value)
                {
                  OnnrfactChanging(ref value);
                  ReportPropertyChanging("nrfact");
                  _nrfact = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("nrfact");
                  OnnrfactChanged();
              }
            }
        }
        private global::System.Nullable<int> _nrfact;
        partial void OnGetnrfact(ref global::System.Nullable<int> value);
        partial void OnnrfactChanging(ref global::System.Nullable<int> value);
        partial void OnnrfactChanged();
    
        /// <summary>
        /// There are no comments for lnfact in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> lnfact
        {
            get
            {
                global::System.Nullable<int> value = _lnfact;
                OnGetlnfact(ref value);
                return value;
            }
            set
            {
                if (_lnfact != value)
                {
                  OnlnfactChanging(ref value);
                  ReportPropertyChanging("lnfact");
                  _lnfact = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("lnfact");
                  OnlnfactChanged();
              }
            }
        }
        private global::System.Nullable<int> _lnfact;
        partial void OnGetlnfact(ref global::System.Nullable<int> value);
        partial void OnlnfactChanging(ref global::System.Nullable<int> value);
        partial void OnlnfactChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            STKNEC_PREP_VOL obj = new STKNEC_PREP_VOL();
            obj.NRPREP = NRPREP;
            obj.SEQ = SEQ;
            obj.QT = QT;
            obj.tpdoc = tpdoc;
            obj.nrfact = nrfact;
            obj.lnfact = lnfact;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          STKNEC_PREP_VOL toCompare = obj as STKNEC_PREP_VOL;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.NRPREP, toCompare.NRPREP))
            return false;
          if (!Object.Equals(this.SEQ, toCompare.SEQ))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + NRPREP.GetHashCode();
          hashCode = (hashCode * 7) + SEQ.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}