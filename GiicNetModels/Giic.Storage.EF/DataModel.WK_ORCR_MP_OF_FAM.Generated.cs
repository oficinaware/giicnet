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
    /// There are no comments for DataGiic_LiagoModel.WK_ORCR_MP_OF_FAM in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ORDFAB
    /// FAMILIA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_ORCR_MP_OF_FAM")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_ORCR_MP_OF_FAM : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_ORCR_MP_OF_FAM object.
        /// </summary>
        /// <param name="oRDFAB">Initial value of ORDFAB.</param>
        /// <param name="fAMILIA">Initial value of FAMILIA.</param>
        public static WK_ORCR_MP_OF_FAM CreateWK_ORCR_MP_OF_FAM(string oRDFAB, string fAMILIA)
        {
            WK_ORCR_MP_OF_FAM wK_ORCR_MP_OF_FAM = new WK_ORCR_MP_OF_FAM();
            wK_ORCR_MP_OF_FAM.ORDFAB = oRDFAB;
            wK_ORCR_MP_OF_FAM.FAMILIA = fAMILIA;
            return wK_ORCR_MP_OF_FAM;
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
        /// There are no comments for FAMILIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string FAMILIA
        {
            get
            {
                string value = _FAMILIA;
                OnGetFAMILIA(ref value);
                return value;
            }
            set
            {
                if (_FAMILIA != value)
                {
                  OnFAMILIAChanging(ref value);
                  ReportPropertyChanging("FAMILIA");
                  _FAMILIA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("FAMILIA");
                  OnFAMILIAChanged();
              }
            }
        }
        private string _FAMILIA;
        partial void OnGetFAMILIA(ref string value);
        partial void OnFAMILIAChanging(ref string value);
        partial void OnFAMILIAChanged();
    
        /// <summary>
        /// There are no comments for VLMAT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> VLMAT
        {
            get
            {
                global::System.Nullable<double> value = _VLMAT;
                OnGetVLMAT(ref value);
                return value;
            }
            set
            {
                if (_VLMAT != value)
                {
                  OnVLMATChanging(ref value);
                  ReportPropertyChanging("VLMAT");
                  _VLMAT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VLMAT");
                  OnVLMATChanged();
              }
            }
        }
        private global::System.Nullable<double> _VLMAT;
        partial void OnGetVLMAT(ref global::System.Nullable<double> value);
        partial void OnVLMATChanging(ref global::System.Nullable<double> value);
        partial void OnVLMATChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
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
    
        /// <summary>
        /// There are no comments for CODCTB in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string CODCTB
        {
            get
            {
                string value = _CODCTB;
                OnGetCODCTB(ref value);
                return value;
            }
            set
            {
                if (_CODCTB != value)
                {
                  OnCODCTBChanging(ref value);
                  ReportPropertyChanging("CODCTB");
                  _CODCTB = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CODCTB");
                  OnCODCTBChanged();
              }
            }
        }
        private string _CODCTB;
        partial void OnGetCODCTB(ref string value);
        partial void OnCODCTBChanging(ref string value);
        partial void OnCODCTBChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_ORCR_MP_OF_FAM obj = new WK_ORCR_MP_OF_FAM();
            obj.ORDFAB = ORDFAB;
            obj.FAMILIA = FAMILIA;
            obj.VLMAT = VLMAT;
            obj.DESCRICAO = DESCRICAO;
            obj.CODCTB = CODCTB;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_ORCR_MP_OF_FAM toCompare = obj as WK_ORCR_MP_OF_FAM;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ORDFAB, toCompare.ORDFAB))
            return false;
          if (!Object.Equals(this.FAMILIA, toCompare.FAMILIA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ORDFAB.GetHashCode();
          hashCode = (hashCode * 7) + FAMILIA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
