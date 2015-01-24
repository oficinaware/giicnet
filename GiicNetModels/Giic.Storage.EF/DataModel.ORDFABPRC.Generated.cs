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
    /// There are no comments for DataGiic_LiagoModel.ORDFABPRC in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ORDFAB
    /// IDOTAM
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="ORDFABPRC")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ORDFABPRC : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new ORDFABPRC object.
        /// </summary>
        /// <param name="oRDFAB">Initial value of ORDFAB.</param>
        /// <param name="iDOTAM">Initial value of IDOTAM.</param>
        /// <param name="iAOTAM">Initial value of IAOTAM.</param>
        public static ORDFABPRC CreateORDFABPRC(string oRDFAB, short iDOTAM, short iAOTAM)
        {
            ORDFABPRC oRDFABPRC = new ORDFABPRC();
            oRDFABPRC.ORDFAB = oRDFAB;
            oRDFABPRC.IDOTAM = iDOTAM;
            oRDFABPRC.IAOTAM = iAOTAM;
            return oRDFABPRC;
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
        /// There are no comments for IDOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public short IDOTAM
        {
            get
            {
                short value = _IDOTAM;
                OnGetIDOTAM(ref value);
                return value;
            }
            set
            {
                if (_IDOTAM != value)
                {
                  OnIDOTAMChanging(ref value);
                  ReportPropertyChanging("IDOTAM");
                  _IDOTAM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("IDOTAM");
                  OnIDOTAMChanged();
              }
            }
        }
        private short _IDOTAM;
        partial void OnGetIDOTAM(ref short value);
        partial void OnIDOTAMChanging(ref short value);
        partial void OnIDOTAMChanged();
    
        /// <summary>
        /// There are no comments for IAOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public short IAOTAM
        {
            get
            {
                short value = _IAOTAM;
                OnGetIAOTAM(ref value);
                return value;
            }
            set
            {
                if (_IAOTAM != value)
                {
                  OnIAOTAMChanging(ref value);
                  ReportPropertyChanging("IAOTAM");
                  _IAOTAM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("IAOTAM");
                  OnIAOTAMChanged();
              }
            }
        }
        private short _IAOTAM;
        partial void OnGetIAOTAM(ref short value);
        partial void OnIAOTAMChanging(ref short value);
        partial void OnIAOTAMChanged();
    
        /// <summary>
        /// There are no comments for DOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string DOTAM
        {
            get
            {
                string value = _DOTAM;
                OnGetDOTAM(ref value);
                return value;
            }
            set
            {
                if (_DOTAM != value)
                {
                  OnDOTAMChanging(ref value);
                  ReportPropertyChanging("DOTAM");
                  _DOTAM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DOTAM");
                  OnDOTAMChanged();
              }
            }
        }
        private string _DOTAM;
        partial void OnGetDOTAM(ref string value);
        partial void OnDOTAMChanging(ref string value);
        partial void OnDOTAMChanged();
    
        /// <summary>
        /// There are no comments for AOTAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string AOTAM
        {
            get
            {
                string value = _AOTAM;
                OnGetAOTAM(ref value);
                return value;
            }
            set
            {
                if (_AOTAM != value)
                {
                  OnAOTAMChanging(ref value);
                  ReportPropertyChanging("AOTAM");
                  _AOTAM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("AOTAM");
                  OnAOTAMChanged();
              }
            }
        }
        private string _AOTAM;
        partial void OnGetAOTAM(ref string value);
        partial void OnAOTAMChanging(ref string value);
        partial void OnAOTAMChanged();
    
        /// <summary>
        /// There are no comments for PRECO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> PRECO
        {
            get
            {
                global::System.Nullable<decimal> value = _PRECO;
                OnGetPRECO(ref value);
                return value;
            }
            set
            {
                if (_PRECO != value)
                {
                  OnPRECOChanging(ref value);
                  ReportPropertyChanging("PRECO");
                  _PRECO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRECO");
                  OnPRECOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _PRECO;
        partial void OnGetPRECO(ref global::System.Nullable<decimal> value);
        partial void OnPRECOChanging(ref global::System.Nullable<decimal> value);
        partial void OnPRECOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            ORDFABPRC obj = new ORDFABPRC();
            obj.ORDFAB = ORDFAB;
            obj.IDOTAM = IDOTAM;
            obj.IAOTAM = IAOTAM;
            obj.DOTAM = DOTAM;
            obj.AOTAM = AOTAM;
            obj.PRECO = PRECO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          ORDFABPRC toCompare = obj as ORDFABPRC;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ORDFAB, toCompare.ORDFAB))
            return false;
          if (!Object.Equals(this.IDOTAM, toCompare.IDOTAM))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ORDFAB.GetHashCode();
          hashCode = (hashCode * 7) + IDOTAM.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}