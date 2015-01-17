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
    /// There are no comments for DataGiic_LiagoModel.EMBTROCAS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NRREG
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="EMBTROCAS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EMBTROCAS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new EMBTROCAS object.
        /// </summary>
        /// <param name="nRREG">Initial value of NRREG.</param>
        public static EMBTROCAS CreateEMBTROCAS(int nRREG)
        {
            EMBTROCAS eMBTROCAS = new EMBTROCAS();
            eMBTROCAS.NRREG = nRREG;
            return eMBTROCAS;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for NRREG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int NRREG
        {
            get
            {
                int value = _NRREG;
                OnGetNRREG(ref value);
                return value;
            }
            set
            {
                if (_NRREG != value)
                {
                  OnNRREGChanging(ref value);
                  ReportPropertyChanging("NRREG");
                  _NRREG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRREG");
                  OnNRREGChanged();
              }
            }
        }
        private int _NRREG;
        partial void OnGetNRREG(ref int value);
        partial void OnNRREGChanging(ref int value);
        partial void OnNRREGChanged();
    
        /// <summary>
        /// There are no comments for IDPACK_ORIG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(14)]
        public string IDPACK_ORIG
        {
            get
            {
                string value = _IDPACK_ORIG;
                OnGetIDPACK_ORIG(ref value);
                return value;
            }
            set
            {
                if (_IDPACK_ORIG != value)
                {
                  OnIDPACK_ORIGChanging(ref value);
                  ReportPropertyChanging("IDPACK_ORIG");
                  _IDPACK_ORIG = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("IDPACK_ORIG");
                  OnIDPACK_ORIGChanged();
              }
            }
        }
        private string _IDPACK_ORIG;
        partial void OnGetIDPACK_ORIG(ref string value);
        partial void OnIDPACK_ORIGChanging(ref string value);
        partial void OnIDPACK_ORIGChanged();
    
        /// <summary>
        /// There are no comments for NRENCO_ORIG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string NRENCO_ORIG
        {
            get
            {
                string value = _NRENCO_ORIG;
                OnGetNRENCO_ORIG(ref value);
                return value;
            }
            set
            {
                if (_NRENCO_ORIG != value)
                {
                  OnNRENCO_ORIGChanging(ref value);
                  ReportPropertyChanging("NRENCO_ORIG");
                  _NRENCO_ORIG = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NRENCO_ORIG");
                  OnNRENCO_ORIGChanged();
              }
            }
        }
        private string _NRENCO_ORIG;
        partial void OnGetNRENCO_ORIG(ref string value);
        partial void OnNRENCO_ORIGChanging(ref string value);
        partial void OnNRENCO_ORIGChanged();
    
        /// <summary>
        /// There are no comments for LNENCO_ORIG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNENCO_ORIG
        {
            get
            {
                global::System.Nullable<int> value = _LNENCO_ORIG;
                OnGetLNENCO_ORIG(ref value);
                return value;
            }
            set
            {
                if (_LNENCO_ORIG != value)
                {
                  OnLNENCO_ORIGChanging(ref value);
                  ReportPropertyChanging("LNENCO_ORIG");
                  _LNENCO_ORIG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNENCO_ORIG");
                  OnLNENCO_ORIGChanged();
              }
            }
        }
        private global::System.Nullable<int> _LNENCO_ORIG;
        partial void OnGetLNENCO_ORIG(ref global::System.Nullable<int> value);
        partial void OnLNENCO_ORIGChanging(ref global::System.Nullable<int> value);
        partial void OnLNENCO_ORIGChanged();
    
        /// <summary>
        /// There are no comments for IDPACK_DEST in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(14)]
        public string IDPACK_DEST
        {
            get
            {
                string value = _IDPACK_DEST;
                OnGetIDPACK_DEST(ref value);
                return value;
            }
            set
            {
                if (_IDPACK_DEST != value)
                {
                  OnIDPACK_DESTChanging(ref value);
                  ReportPropertyChanging("IDPACK_DEST");
                  _IDPACK_DEST = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("IDPACK_DEST");
                  OnIDPACK_DESTChanged();
              }
            }
        }
        private string _IDPACK_DEST;
        partial void OnGetIDPACK_DEST(ref string value);
        partial void OnIDPACK_DESTChanging(ref string value);
        partial void OnIDPACK_DESTChanged();
    
        /// <summary>
        /// There are no comments for NRENCO_DEST in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string NRENCO_DEST
        {
            get
            {
                string value = _NRENCO_DEST;
                OnGetNRENCO_DEST(ref value);
                return value;
            }
            set
            {
                if (_NRENCO_DEST != value)
                {
                  OnNRENCO_DESTChanging(ref value);
                  ReportPropertyChanging("NRENCO_DEST");
                  _NRENCO_DEST = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NRENCO_DEST");
                  OnNRENCO_DESTChanged();
              }
            }
        }
        private string _NRENCO_DEST;
        partial void OnGetNRENCO_DEST(ref string value);
        partial void OnNRENCO_DESTChanging(ref string value);
        partial void OnNRENCO_DESTChanged();
    
        /// <summary>
        /// There are no comments for LNENCO_DEST in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNENCO_DEST
        {
            get
            {
                global::System.Nullable<int> value = _LNENCO_DEST;
                OnGetLNENCO_DEST(ref value);
                return value;
            }
            set
            {
                if (_LNENCO_DEST != value)
                {
                  OnLNENCO_DESTChanging(ref value);
                  ReportPropertyChanging("LNENCO_DEST");
                  _LNENCO_DEST = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNENCO_DEST");
                  OnLNENCO_DESTChanged();
              }
            }
        }
        private global::System.Nullable<int> _LNENCO_DEST;
        partial void OnGetLNENCO_DEST(ref global::System.Nullable<int> value);
        partial void OnLNENCO_DESTChanging(ref global::System.Nullable<int> value);
        partial void OnLNENCO_DESTChanged();
    
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

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            EMBTROCAS obj = new EMBTROCAS();
            obj.NRREG = NRREG;
            obj.IDPACK_ORIG = IDPACK_ORIG;
            obj.NRENCO_ORIG = NRENCO_ORIG;
            obj.LNENCO_ORIG = LNENCO_ORIG;
            obj.IDPACK_DEST = IDPACK_DEST;
            obj.NRENCO_DEST = NRENCO_DEST;
            obj.LNENCO_DEST = LNENCO_DEST;
            obj.DATAREG = DATAREG;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          EMBTROCAS toCompare = obj as EMBTROCAS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.NRREG, toCompare.NRREG))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + NRREG.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
