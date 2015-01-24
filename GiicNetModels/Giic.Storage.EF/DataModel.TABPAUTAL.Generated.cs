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
    /// There are no comments for DataGiic_LiagoModel.TABPAUTAL in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CODPAUTAL
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABPAUTAL")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABPAUTAL : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABPAUTAL object.
        /// </summary>
        /// <param name="cODPAUTAL">Initial value of CODPAUTAL.</param>
        public static TABPAUTAL CreateTABPAUTAL(string cODPAUTAL)
        {
            TABPAUTAL tABPAUTAL = new TABPAUTAL();
            tABPAUTAL.CODPAUTAL = cODPAUTAL;
            return tABPAUTAL;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CODPAUTAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODPAUTAL
        {
            get
            {
                string value = _CODPAUTAL;
                OnGetCODPAUTAL(ref value);
                return value;
            }
            set
            {
                if (_CODPAUTAL != value)
                {
                  OnCODPAUTALChanging(ref value);
                  ReportPropertyChanging("CODPAUTAL");
                  _CODPAUTAL = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODPAUTAL");
                  OnCODPAUTALChanged();
              }
            }
        }
        private string _CODPAUTAL;
        partial void OnGetCODPAUTAL(ref string value);
        partial void OnCODPAUTALChanging(ref string value);
        partial void OnCODPAUTALChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        public string DESCRICAO
        {
            get
            {
                string value = _DESCRICAO;
                OnGetDESCRICAO(ref value);
                return value;
            }
            set
            {
                if (_DESCRICAO != value)
                {
                  OnDESCRICAOChanging(ref value);
                  ReportPropertyChanging("DESCRICAO");
                  _DESCRICAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DESCRICAO");
                  OnDESCRICAOChanged();
              }
            }
        }
        private string _DESCRICAO;
        partial void OnGetDESCRICAO(ref string value);
        partial void OnDESCRICAOChanging(ref string value);
        partial void OnDESCRICAOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TABPAUTAL obj = new TABPAUTAL();
            obj.CODPAUTAL = CODPAUTAL;
            obj.DESCRICAO = DESCRICAO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABPAUTAL toCompare = obj as TABPAUTAL;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CODPAUTAL, toCompare.CODPAUTAL))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CODPAUTAL.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}