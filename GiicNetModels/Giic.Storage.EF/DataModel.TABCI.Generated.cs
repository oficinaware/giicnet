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
    /// There are no comments for DataGiic_LiagoModel.TABCI in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CODIGO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABCI")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABCI : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABCI object.
        /// </summary>
        /// <param name="cODIGO">Initial value of CODIGO.</param>
        public static TABCI CreateTABCI(string cODIGO)
        {
            TABCI tABCI = new TABCI();
            tABCI.CODIGO = cODIGO;
            return tABCI;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CODIGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODIGO
        {
            get
            {
                string value = _CODIGO;
                OnGetCODIGO(ref value);
                return value;
            }
            set
            {
                if (_CODIGO != value)
                {
                  OnCODIGOChanging(ref value);
                  ReportPropertyChanging("CODIGO");
                  _CODIGO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODIGO");
                  OnCODIGOChanged();
              }
            }
        }
        private string _CODIGO;
        partial void OnGetCODIGO(ref string value);
        partial void OnCODIGOChanging(ref string value);
        partial void OnCODIGOChanged();
    
        /// <summary>
        /// There are no comments for CD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CD
        {
            get
            {
                global::System.Nullable<decimal> value = _CD;
                OnGetCD(ref value);
                return value;
            }
            set
            {
                if (_CD != value)
                {
                  OnCDChanging(ref value);
                  ReportPropertyChanging("CD");
                  _CD = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CD");
                  OnCDChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CD = 0m;
        partial void OnGetCD(ref global::System.Nullable<decimal> value);
        partial void OnCDChanging(ref global::System.Nullable<decimal> value);
        partial void OnCDChanged();
    
        /// <summary>
        /// There are no comments for CI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CI
        {
            get
            {
                global::System.Nullable<decimal> value = _CI;
                OnGetCI(ref value);
                return value;
            }
            set
            {
                if (_CI != value)
                {
                  OnCIChanging(ref value);
                  ReportPropertyChanging("CI");
                  _CI = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CI");
                  OnCIChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CI = 0m;
        partial void OnGetCI(ref global::System.Nullable<decimal> value);
        partial void OnCIChanging(ref global::System.Nullable<decimal> value);
        partial void OnCIChanged();
    
        /// <summary>
        /// There are no comments for AMORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> AMORT
        {
            get
            {
                global::System.Nullable<decimal> value = _AMORT;
                OnGetAMORT(ref value);
                return value;
            }
            set
            {
                if (_AMORT != value)
                {
                  OnAMORTChanging(ref value);
                  ReportPropertyChanging("AMORT");
                  _AMORT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("AMORT");
                  OnAMORTChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _AMORT = 0m;
        partial void OnGetAMORT(ref global::System.Nullable<decimal> value);
        partial void OnAMORTChanging(ref global::System.Nullable<decimal> value);
        partial void OnAMORTChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TABCI obj = new TABCI();
            obj.CODIGO = CODIGO;
            obj.CD = CD;
            obj.CI = CI;
            obj.AMORT = AMORT;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABCI toCompare = obj as TABCI;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CODIGO, toCompare.CODIGO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CODIGO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
