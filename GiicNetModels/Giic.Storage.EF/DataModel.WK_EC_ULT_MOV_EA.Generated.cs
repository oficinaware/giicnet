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
    /// There are no comments for DataGiic_LiagoModel.WK_EC_ULT_MOV_EA in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NRDOCI
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_EC_ULT_MOV_EA")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_EC_ULT_MOV_EA : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_EC_ULT_MOV_EA object.
        /// </summary>
        /// <param name="nRDOCI">Initial value of NRDOCI.</param>
        public static WK_EC_ULT_MOV_EA CreateWK_EC_ULT_MOV_EA(string nRDOCI)
        {
            WK_EC_ULT_MOV_EA wK_EC_ULT_MOV_EA = new WK_EC_ULT_MOV_EA();
            wK_EC_ULT_MOV_EA.NRDOCI = nRDOCI;
            return wK_EC_ULT_MOV_EA;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for NRDOCI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string NRDOCI
        {
            get
            {
                string value = _NRDOCI;
                OnGetNRDOCI(ref value);
                return value;
            }
            set
            {
                if (_NRDOCI != value)
                {
                  OnNRDOCIChanging(ref value);
                  ReportPropertyChanging("NRDOCI");
                  _NRDOCI = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("NRDOCI");
                  OnNRDOCIChanged();
              }
            }
        }
        private string _NRDOCI;
        partial void OnGetNRDOCI(ref string value);
        partial void OnNRDOCIChanging(ref string value);
        partial void OnNRDOCIChanged();
    
        /// <summary>
        /// There are no comments for MaxDeDTMOV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> MaxDeDTMOV
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _MaxDeDTMOV;
                OnGetMaxDeDTMOV(ref value);
                return value;
            }
            set
            {
                if (_MaxDeDTMOV != value)
                {
                  OnMaxDeDTMOVChanging(ref value);
                  ReportPropertyChanging("MaxDeDTMOV");
                  _MaxDeDTMOV = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("MaxDeDTMOV");
                  OnMaxDeDTMOVChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _MaxDeDTMOV;
        partial void OnGetMaxDeDTMOV(ref global::System.Nullable<System.DateTime> value);
        partial void OnMaxDeDTMOVChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnMaxDeDTMOVChanged();
    
        /// <summary>
        /// There are no comments for SomaDeQtMov in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> SomaDeQtMov
        {
            get
            {
                global::System.Nullable<int> value = _SomaDeQtMov;
                OnGetSomaDeQtMov(ref value);
                return value;
            }
            set
            {
                if (_SomaDeQtMov != value)
                {
                  OnSomaDeQtMovChanging(ref value);
                  ReportPropertyChanging("SomaDeQtMov");
                  _SomaDeQtMov = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SomaDeQtMov");
                  OnSomaDeQtMovChanged();
              }
            }
        }
        private global::System.Nullable<int> _SomaDeQtMov;
        partial void OnGetSomaDeQtMov(ref global::System.Nullable<int> value);
        partial void OnSomaDeQtMovChanging(ref global::System.Nullable<int> value);
        partial void OnSomaDeQtMovChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_EC_ULT_MOV_EA obj = new WK_EC_ULT_MOV_EA();
            obj.NRDOCI = NRDOCI;
            obj.MaxDeDTMOV = MaxDeDTMOV;
            obj.SomaDeQtMov = SomaDeQtMov;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_EC_ULT_MOV_EA toCompare = obj as WK_EC_ULT_MOV_EA;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.NRDOCI, toCompare.NRDOCI))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + NRDOCI.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}