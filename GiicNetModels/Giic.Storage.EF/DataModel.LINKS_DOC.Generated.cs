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
    /// There are no comments for DataGiic_LiagoModel.LINKS_DOC in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TPDOC
    /// NRFACT
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="LINKS_DOC")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LINKS_DOC : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new LINKS_DOC object.
        /// </summary>
        /// <param name="tPDOC">Initial value of TPDOC.</param>
        /// <param name="nRFACT">Initial value of NRFACT.</param>
        public static LINKS_DOC CreateLINKS_DOC(string tPDOC, int nRFACT)
        {
            LINKS_DOC lINKS_DOC = new LINKS_DOC();
            lINKS_DOC.TPDOC = tPDOC;
            lINKS_DOC.NRFACT = nRFACT;
            return lINKS_DOC;
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
        /// There are no comments for TERCEIRO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string TERCEIRO
        {
            get
            {
                string value = _TERCEIRO;
                OnGetTERCEIRO(ref value);
                return value;
            }
            set
            {
                if (_TERCEIRO != value)
                {
                  OnTERCEIROChanging(ref value);
                  ReportPropertyChanging("TERCEIRO");
                  _TERCEIRO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TERCEIRO");
                  OnTERCEIROChanged();
              }
            }
        }
        private string _TERCEIRO;
        partial void OnGetTERCEIRO(ref string value);
        partial void OnTERCEIROChanging(ref string value);
        partial void OnTERCEIROChanged();
    
        /// <summary>
        /// There are no comments for ENTIDADE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string ENTIDADE
        {
            get
            {
                string value = _ENTIDADE;
                OnGetENTIDADE(ref value);
                return value;
            }
            set
            {
                if (_ENTIDADE != value)
                {
                  OnENTIDADEChanging(ref value);
                  ReportPropertyChanging("ENTIDADE");
                  _ENTIDADE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ENTIDADE");
                  OnENTIDADEChanged();
              }
            }
        }
        private string _ENTIDADE;
        partial void OnGetENTIDADE(ref string value);
        partial void OnENTIDADEChanging(ref string value);
        partial void OnENTIDADEChanged();
    
        /// <summary>
        /// There are no comments for LINK in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(250)]
        public string LINK
        {
            get
            {
                string value = _LINK;
                OnGetLINK(ref value);
                return value;
            }
            set
            {
                if (_LINK != value)
                {
                  OnLINKChanging(ref value);
                  ReportPropertyChanging("LINK");
                  _LINK = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("LINK");
                  OnLINKChanged();
              }
            }
        }
        private string _LINK;
        partial void OnGetLINK(ref string value);
        partial void OnLINKChanging(ref string value);
        partial void OnLINKChanged();
    
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
    
        /// <summary>
        /// There are no comments for UTENTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string UTENTE
        {
            get
            {
                string value = _UTENTE;
                OnGetUTENTE(ref value);
                return value;
            }
            set
            {
                if (_UTENTE != value)
                {
                  OnUTENTEChanging(ref value);
                  ReportPropertyChanging("UTENTE");
                  _UTENTE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("UTENTE");
                  OnUTENTEChanged();
              }
            }
        }
        private string _UTENTE;
        partial void OnGetUTENTE(ref string value);
        partial void OnUTENTEChanging(ref string value);
        partial void OnUTENTEChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            LINKS_DOC obj = new LINKS_DOC();
            obj.TPDOC = TPDOC;
            obj.NRFACT = NRFACT;
            obj.TERCEIRO = TERCEIRO;
            obj.ENTIDADE = ENTIDADE;
            obj.LINK = LINK;
            obj.DATAREG = DATAREG;
            obj.UTENTE = UTENTE;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          LINKS_DOC toCompare = obj as LINKS_DOC;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.TPDOC, toCompare.TPDOC))
            return false;
          if (!Object.Equals(this.NRFACT, toCompare.NRFACT))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + TPDOC.GetHashCode();
          hashCode = (hashCode * 7) + NRFACT.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
