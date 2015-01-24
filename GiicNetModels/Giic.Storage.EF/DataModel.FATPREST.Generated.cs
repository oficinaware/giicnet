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
    /// There are no comments for DataGiic_LiagoModel.FATPREST in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TPDOC
    /// NRFACT
    /// NR_PREST
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="FATPREST")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class FATPREST : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new FATPREST object.
        /// </summary>
        /// <param name="tPDOC">Initial value of TPDOC.</param>
        /// <param name="nRFACT">Initial value of NRFACT.</param>
        /// <param name="nR_PREST">Initial value of NR_PREST.</param>
        public static FATPREST CreateFATPREST(string tPDOC, int nRFACT, int nR_PREST)
        {
            FATPREST fATPREST = new FATPREST();
            fATPREST.TPDOC = tPDOC;
            fATPREST.NRFACT = nRFACT;
            fATPREST.NR_PREST = nR_PREST;
            return fATPREST;
        }

        #endregion

        #region Properties
    
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
        /// There are no comments for NR_PREST in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int NR_PREST
        {
            get
            {
                int value = _NR_PREST;
                OnGetNR_PREST(ref value);
                return value;
            }
            set
            {
                if (_NR_PREST != value)
                {
                  OnNR_PRESTChanging(ref value);
                  ReportPropertyChanging("NR_PREST");
                  _NR_PREST = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NR_PREST");
                  OnNR_PRESTChanged();
              }
            }
        }
        private int _NR_PREST;
        partial void OnGetNR_PREST(ref int value);
        partial void OnNR_PRESTChanging(ref int value);
        partial void OnNR_PRESTChanged();
    
        /// <summary>
        /// There are no comments for DTVENC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DTVENC
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DTVENC;
                OnGetDTVENC(ref value);
                return value;
            }
            set
            {
                if (_DTVENC != value)
                {
                  OnDTVENCChanging(ref value);
                  ReportPropertyChanging("DTVENC");
                  _DTVENC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DTVENC");
                  OnDTVENCChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DTVENC;
        partial void OnGetDTVENC(ref global::System.Nullable<System.DateTime> value);
        partial void OnDTVENCChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDTVENCChanged();
    
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

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            FATPREST obj = new FATPREST();
            obj.TPDOC = TPDOC;
            obj.NRFACT = NRFACT;
            obj.NR_PREST = NR_PREST;
            obj.DTVENC = DTVENC;
            obj.VALOR = VALOR;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          FATPREST toCompare = obj as FATPREST;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.TPDOC, toCompare.TPDOC))
            return false;
          if (!Object.Equals(this.NRFACT, toCompare.NRFACT))
            return false;
          if (!Object.Equals(this.NR_PREST, toCompare.NR_PREST))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + TPDOC.GetHashCode();
          hashCode = (hashCode * 7) + NRFACT.GetHashCode();
          hashCode = (hashCode * 7) + NR_PREST.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}