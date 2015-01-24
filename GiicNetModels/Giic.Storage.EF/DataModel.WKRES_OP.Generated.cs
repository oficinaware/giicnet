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
    /// There are no comments for DataGiic_LiagoModel.WKRES_OP in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OPERACAO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WKRES_OP")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WKRES_OP : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WKRES_OP object.
        /// </summary>
        /// <param name="oPERACAO">Initial value of OPERACAO.</param>
        public static WKRES_OP CreateWKRES_OP(string oPERACAO)
        {
            WKRES_OP wKRES_OP = new WKRES_OP();
            wKRES_OP.OPERACAO = oPERACAO;
            return wKRES_OP;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for OPERACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string OPERACAO
        {
            get
            {
                string value = _OPERACAO;
                OnGetOPERACAO(ref value);
                return value;
            }
            set
            {
                if (_OPERACAO != value)
                {
                  OnOPERACAOChanging(ref value);
                  ReportPropertyChanging("OPERACAO");
                  _OPERACAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("OPERACAO");
                  OnOPERACAOChanged();
              }
            }
        }
        private string _OPERACAO;
        partial void OnGetOPERACAO(ref string value);
        partial void OnOPERACAOChanging(ref string value);
        partial void OnOPERACAOChanged();
    
        /// <summary>
        /// There are no comments for TOTLAN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TOTLAN
        {
            get
            {
                global::System.Nullable<int> value = _TOTLAN;
                OnGetTOTLAN(ref value);
                return value;
            }
            set
            {
                if (_TOTLAN != value)
                {
                  OnTOTLANChanging(ref value);
                  ReportPropertyChanging("TOTLAN");
                  _TOTLAN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTLAN");
                  OnTOTLANChanged();
              }
            }
        }
        private global::System.Nullable<int> _TOTLAN;
        partial void OnGetTOTLAN(ref global::System.Nullable<int> value);
        partial void OnTOTLANChanging(ref global::System.Nullable<int> value);
        partial void OnTOTLANChanged();
    
        /// <summary>
        /// There are no comments for QTFILA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QTFILA
        {
            get
            {
                global::System.Nullable<int> value = _QTFILA;
                OnGetQTFILA(ref value);
                return value;
            }
            set
            {
                if (_QTFILA != value)
                {
                  OnQTFILAChanging(ref value);
                  ReportPropertyChanging("QTFILA");
                  _QTFILA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTFILA");
                  OnQTFILAChanged();
              }
            }
        }
        private global::System.Nullable<int> _QTFILA;
        partial void OnGetQTFILA(ref global::System.Nullable<int> value);
        partial void OnQTFILAChanging(ref global::System.Nullable<int> value);
        partial void OnQTFILAChanged();
    
        /// <summary>
        /// There are no comments for TOTENT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TOTENT
        {
            get
            {
                global::System.Nullable<int> value = _TOTENT;
                OnGetTOTENT(ref value);
                return value;
            }
            set
            {
                if (_TOTENT != value)
                {
                  OnTOTENTChanging(ref value);
                  ReportPropertyChanging("TOTENT");
                  _TOTENT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTENT");
                  OnTOTENTChanged();
              }
            }
        }
        private global::System.Nullable<int> _TOTENT;
        partial void OnGetTOTENT(ref global::System.Nullable<int> value);
        partial void OnTOTENTChanging(ref global::System.Nullable<int> value);
        partial void OnTOTENTChanged();
    
        /// <summary>
        /// There are no comments for TOTSAI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TOTSAI
        {
            get
            {
                global::System.Nullable<int> value = _TOTSAI;
                OnGetTOTSAI(ref value);
                return value;
            }
            set
            {
                if (_TOTSAI != value)
                {
                  OnTOTSAIChanging(ref value);
                  ReportPropertyChanging("TOTSAI");
                  _TOTSAI = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTSAI");
                  OnTOTSAIChanged();
              }
            }
        }
        private global::System.Nullable<int> _TOTSAI;
        partial void OnGetTOTSAI(ref global::System.Nullable<int> value);
        partial void OnTOTSAIChanging(ref global::System.Nullable<int> value);
        partial void OnTOTSAIChanged();
    
        /// <summary>
        /// There are no comments for EMCURSO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> EMCURSO
        {
            get
            {
                global::System.Nullable<int> value = _EMCURSO;
                OnGetEMCURSO(ref value);
                return value;
            }
            set
            {
                if (_EMCURSO != value)
                {
                  OnEMCURSOChanging(ref value);
                  ReportPropertyChanging("EMCURSO");
                  _EMCURSO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("EMCURSO");
                  OnEMCURSOChanged();
              }
            }
        }
        private global::System.Nullable<int> _EMCURSO;
        partial void OnGetEMCURSO(ref global::System.Nullable<int> value);
        partial void OnEMCURSOChanging(ref global::System.Nullable<int> value);
        partial void OnEMCURSOChanged();
    
        /// <summary>
        /// There are no comments for TOTFALTA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TOTFALTA
        {
            get
            {
                global::System.Nullable<int> value = _TOTFALTA;
                OnGetTOTFALTA(ref value);
                return value;
            }
            set
            {
                if (_TOTFALTA != value)
                {
                  OnTOTFALTAChanging(ref value);
                  ReportPropertyChanging("TOTFALTA");
                  _TOTFALTA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTFALTA");
                  OnTOTFALTAChanged();
              }
            }
        }
        private global::System.Nullable<int> _TOTFALTA;
        partial void OnGetTOTFALTA(ref global::System.Nullable<int> value);
        partial void OnTOTFALTAChanging(ref global::System.Nullable<int> value);
        partial void OnTOTFALTAChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WKRES_OP obj = new WKRES_OP();
            obj.OPERACAO = OPERACAO;
            obj.TOTLAN = TOTLAN;
            obj.QTFILA = QTFILA;
            obj.TOTENT = TOTENT;
            obj.TOTSAI = TOTSAI;
            obj.EMCURSO = EMCURSO;
            obj.TOTFALTA = TOTFALTA;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WKRES_OP toCompare = obj as WKRES_OP;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.OPERACAO, toCompare.OPERACAO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + OPERACAO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}