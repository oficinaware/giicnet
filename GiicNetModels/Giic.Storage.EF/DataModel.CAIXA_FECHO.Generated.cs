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
    /// There are no comments for DataGiic_LiagoModel.CAIXA_FECHO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ARM
    /// POS
    /// NRDOCCX
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CAIXA_FECHO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CAIXA_FECHO : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CAIXA_FECHO object.
        /// </summary>
        /// <param name="aRM">Initial value of ARM.</param>
        /// <param name="pOS">Initial value of POS.</param>
        /// <param name="nRDOCCX">Initial value of NRDOCCX.</param>
        public static CAIXA_FECHO CreateCAIXA_FECHO(string aRM, string pOS, int nRDOCCX)
        {
            CAIXA_FECHO cAIXA_FECHO = new CAIXA_FECHO();
            cAIXA_FECHO.ARM = aRM;
            cAIXA_FECHO.POS = pOS;
            cAIXA_FECHO.NRDOCCX = nRDOCCX;
            return cAIXA_FECHO;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ARM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ARM
        {
            get
            {
                string value = _ARM;
                OnGetARM(ref value);
                return value;
            }
            set
            {
                if (_ARM != value)
                {
                  OnARMChanging(ref value);
                  ReportPropertyChanging("ARM");
                  _ARM = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ARM");
                  OnARMChanged();
              }
            }
        }
        private string _ARM;
        partial void OnGetARM(ref string value);
        partial void OnARMChanging(ref string value);
        partial void OnARMChanged();
    
        /// <summary>
        /// There are no comments for POS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string POS
        {
            get
            {
                string value = _POS;
                OnGetPOS(ref value);
                return value;
            }
            set
            {
                if (_POS != value)
                {
                  OnPOSChanging(ref value);
                  ReportPropertyChanging("POS");
                  _POS = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("POS");
                  OnPOSChanged();
              }
            }
        }
        private string _POS;
        partial void OnGetPOS(ref string value);
        partial void OnPOSChanging(ref string value);
        partial void OnPOSChanged();
    
        /// <summary>
        /// There are no comments for NRDOCCX in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int NRDOCCX
        {
            get
            {
                int value = _NRDOCCX;
                OnGetNRDOCCX(ref value);
                return value;
            }
            set
            {
                if (_NRDOCCX != value)
                {
                  OnNRDOCCXChanging(ref value);
                  ReportPropertyChanging("NRDOCCX");
                  _NRDOCCX = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRDOCCX");
                  OnNRDOCCXChanged();
              }
            }
        }
        private int _NRDOCCX;
        partial void OnGetNRDOCCX(ref int value);
        partial void OnNRDOCCXChanging(ref int value);
        partial void OnNRDOCCXChanged();
    
        /// <summary>
        /// There are no comments for FUNC_ABERT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string FUNC_ABERT
        {
            get
            {
                string value = _FUNC_ABERT;
                OnGetFUNC_ABERT(ref value);
                return value;
            }
            set
            {
                if (_FUNC_ABERT != value)
                {
                  OnFUNC_ABERTChanging(ref value);
                  ReportPropertyChanging("FUNC_ABERT");
                  _FUNC_ABERT = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("FUNC_ABERT");
                  OnFUNC_ABERTChanged();
              }
            }
        }
        private string _FUNC_ABERT;
        partial void OnGetFUNC_ABERT(ref string value);
        partial void OnFUNC_ABERTChanging(ref string value);
        partial void OnFUNC_ABERTChanged();
    
        /// <summary>
        /// There are no comments for DATA_ABERT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_ABERT
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_ABERT;
                OnGetDATA_ABERT(ref value);
                return value;
            }
            set
            {
                if (_DATA_ABERT != value)
                {
                  OnDATA_ABERTChanging(ref value);
                  ReportPropertyChanging("DATA_ABERT");
                  _DATA_ABERT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_ABERT");
                  OnDATA_ABERTChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_ABERT;
        partial void OnGetDATA_ABERT(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ABERTChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ABERTChanged();
    
        /// <summary>
        /// There are no comments for HORA_ABERT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> HORA_ABERT
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _HORA_ABERT;
                OnGetHORA_ABERT(ref value);
                return value;
            }
            set
            {
                if (_HORA_ABERT != value)
                {
                  OnHORA_ABERTChanging(ref value);
                  ReportPropertyChanging("HORA_ABERT");
                  _HORA_ABERT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("HORA_ABERT");
                  OnHORA_ABERTChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _HORA_ABERT;
        partial void OnGetHORA_ABERT(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORA_ABERTChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORA_ABERTChanged();
    
        /// <summary>
        /// There are no comments for VALOR_ABERT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VALOR_ABERT
        {
            get
            {
                global::System.Nullable<decimal> value = _VALOR_ABERT;
                OnGetVALOR_ABERT(ref value);
                return value;
            }
            set
            {
                if (_VALOR_ABERT != value)
                {
                  OnVALOR_ABERTChanging(ref value);
                  ReportPropertyChanging("VALOR_ABERT");
                  _VALOR_ABERT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VALOR_ABERT");
                  OnVALOR_ABERTChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VALOR_ABERT;
        partial void OnGetVALOR_ABERT(ref global::System.Nullable<decimal> value);
        partial void OnVALOR_ABERTChanging(ref global::System.Nullable<decimal> value);
        partial void OnVALOR_ABERTChanged();
    
        /// <summary>
        /// There are no comments for FUNC_FECHO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string FUNC_FECHO
        {
            get
            {
                string value = _FUNC_FECHO;
                OnGetFUNC_FECHO(ref value);
                return value;
            }
            set
            {
                if (_FUNC_FECHO != value)
                {
                  OnFUNC_FECHOChanging(ref value);
                  ReportPropertyChanging("FUNC_FECHO");
                  _FUNC_FECHO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("FUNC_FECHO");
                  OnFUNC_FECHOChanged();
              }
            }
        }
        private string _FUNC_FECHO;
        partial void OnGetFUNC_FECHO(ref string value);
        partial void OnFUNC_FECHOChanging(ref string value);
        partial void OnFUNC_FECHOChanged();
    
        /// <summary>
        /// There are no comments for DATA_FECHO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_FECHO
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_FECHO;
                OnGetDATA_FECHO(ref value);
                return value;
            }
            set
            {
                if (_DATA_FECHO != value)
                {
                  OnDATA_FECHOChanging(ref value);
                  ReportPropertyChanging("DATA_FECHO");
                  _DATA_FECHO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_FECHO");
                  OnDATA_FECHOChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_FECHO;
        partial void OnGetDATA_FECHO(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_FECHOChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_FECHOChanged();
    
        /// <summary>
        /// There are no comments for HORA_FECHO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> HORA_FECHO
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _HORA_FECHO;
                OnGetHORA_FECHO(ref value);
                return value;
            }
            set
            {
                if (_HORA_FECHO != value)
                {
                  OnHORA_FECHOChanging(ref value);
                  ReportPropertyChanging("HORA_FECHO");
                  _HORA_FECHO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("HORA_FECHO");
                  OnHORA_FECHOChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _HORA_FECHO;
        partial void OnGetHORA_FECHO(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORA_FECHOChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORA_FECHOChanged();
    
        /// <summary>
        /// There are no comments for VALOR_FECHO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VALOR_FECHO
        {
            get
            {
                global::System.Nullable<decimal> value = _VALOR_FECHO;
                OnGetVALOR_FECHO(ref value);
                return value;
            }
            set
            {
                if (_VALOR_FECHO != value)
                {
                  OnVALOR_FECHOChanging(ref value);
                  ReportPropertyChanging("VALOR_FECHO");
                  _VALOR_FECHO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VALOR_FECHO");
                  OnVALOR_FECHOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VALOR_FECHO;
        partial void OnGetVALOR_FECHO(ref global::System.Nullable<decimal> value);
        partial void OnVALOR_FECHOChanging(ref global::System.Nullable<decimal> value);
        partial void OnVALOR_FECHOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CAIXA_FECHO obj = new CAIXA_FECHO();
            obj.ARM = ARM;
            obj.POS = POS;
            obj.NRDOCCX = NRDOCCX;
            obj.FUNC_ABERT = FUNC_ABERT;
            obj.DATA_ABERT = DATA_ABERT;
            obj.HORA_ABERT = HORA_ABERT;
            obj.VALOR_ABERT = VALOR_ABERT;
            obj.FUNC_FECHO = FUNC_FECHO;
            obj.DATA_FECHO = DATA_FECHO;
            obj.HORA_FECHO = HORA_FECHO;
            obj.VALOR_FECHO = VALOR_FECHO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CAIXA_FECHO toCompare = obj as CAIXA_FECHO;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ARM, toCompare.ARM))
            return false;
          if (!Object.Equals(this.POS, toCompare.POS))
            return false;
          if (!Object.Equals(this.NRDOCCX, toCompare.NRDOCCX))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ARM.GetHashCode();
          hashCode = (hashCode * 7) + POS.GetHashCode();
          hashCode = (hashCode * 7) + NRDOCCX.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
