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
    /// There are no comments for DataGiic_LiagoModel.CATSORT in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CATALOGO
    /// ESCALA
    /// TIPSORT
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CATSORT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CATSORT : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CATSORT object.
        /// </summary>
        /// <param name="cATALOGO">Initial value of CATALOGO.</param>
        /// <param name="eSCALA">Initial value of ESCALA.</param>
        /// <param name="tIPSORT">Initial value of TIPSORT.</param>
        public static CATSORT CreateCATSORT(string cATALOGO, string eSCALA, string tIPSORT)
        {
            CATSORT cATSORT = new CATSORT();
            cATSORT.CATALOGO = cATALOGO;
            cATSORT.ESCALA = eSCALA;
            cATSORT.TIPSORT = tIPSORT;
            return cATSORT;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CATALOGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CATALOGO
        {
            get
            {
                string value = _CATALOGO;
                OnGetCATALOGO(ref value);
                return value;
            }
            set
            {
                if (_CATALOGO != value)
                {
                  OnCATALOGOChanging(ref value);
                  ReportPropertyChanging("CATALOGO");
                  _CATALOGO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CATALOGO");
                  OnCATALOGOChanged();
              }
            }
        }
        private string _CATALOGO;
        partial void OnGetCATALOGO(ref string value);
        partial void OnCATALOGOChanging(ref string value);
        partial void OnCATALOGOChanged();
    
        /// <summary>
        /// There are no comments for ESCALA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ESCALA
        {
            get
            {
                string value = _ESCALA;
                OnGetESCALA(ref value);
                return value;
            }
            set
            {
                if (_ESCALA != value)
                {
                  OnESCALAChanging(ref value);
                  ReportPropertyChanging("ESCALA");
                  _ESCALA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ESCALA");
                  OnESCALAChanged();
              }
            }
        }
        private string _ESCALA;
        partial void OnGetESCALA(ref string value);
        partial void OnESCALAChanging(ref string value);
        partial void OnESCALAChanged();
    
        /// <summary>
        /// There are no comments for TIPSORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TIPSORT
        {
            get
            {
                string value = _TIPSORT;
                OnGetTIPSORT(ref value);
                return value;
            }
            set
            {
                if (_TIPSORT != value)
                {
                  OnTIPSORTChanging(ref value);
                  ReportPropertyChanging("TIPSORT");
                  _TIPSORT = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TIPSORT");
                  OnTIPSORTChanged();
              }
            }
        }
        private string _TIPSORT;
        partial void OnGetTIPSORT(ref string value);
        partial void OnTIPSORTChanging(ref string value);
        partial void OnTIPSORTChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CATSORT obj = new CATSORT();
            obj.CATALOGO = CATALOGO;
            obj.ESCALA = ESCALA;
            obj.TIPSORT = TIPSORT;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CATSORT toCompare = obj as CATSORT;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CATALOGO, toCompare.CATALOGO))
            return false;
          if (!Object.Equals(this.ESCALA, toCompare.ESCALA))
            return false;
          if (!Object.Equals(this.TIPSORT, toCompare.TIPSORT))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CATALOGO.GetHashCode();
          hashCode = (hashCode * 7) + ESCALA.GetHashCode();
          hashCode = (hashCode * 7) + TIPSORT.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
