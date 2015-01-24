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
    /// There are no comments for DataGiic_LiagoModel.TABCX in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CLASSE_CX
    /// MARCA
    /// ESTACAO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABCX")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABCX : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABCX object.
        /// </summary>
        /// <param name="cLASSE_CX">Initial value of CLASSE_CX.</param>
        /// <param name="mARCA">Initial value of MARCA.</param>
        /// <param name="eSTACAO">Initial value of ESTACAO.</param>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        /// <param name="cARTAZ">Initial value of CARTAZ.</param>
        /// <param name="cODCOR">Initial value of CODCOR.</param>
        /// <param name="tAM">Initial value of TAM.</param>
        public static TABCX CreateTABCX(string cLASSE_CX, string mARCA, string eSTACAO, string aRTIGO, string cARTAZ, string cODCOR, string tAM)
        {
            TABCX tABCX = new TABCX();
            tABCX.CLASSE_CX = cLASSE_CX;
            tABCX.MARCA = mARCA;
            tABCX.ESTACAO = eSTACAO;
            tABCX.ARTIGO = aRTIGO;
            tABCX.CARTAZ = cARTAZ;
            tABCX.CODCOR = cODCOR;
            tABCX.TAM = tAM;
            return tABCX;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CLASSE_CX in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CLASSE_CX
        {
            get
            {
                string value = _CLASSE_CX;
                OnGetCLASSE_CX(ref value);
                return value;
            }
            set
            {
                if (_CLASSE_CX != value)
                {
                  OnCLASSE_CXChanging(ref value);
                  ReportPropertyChanging("CLASSE_CX");
                  _CLASSE_CX = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CLASSE_CX");
                  OnCLASSE_CXChanged();
              }
            }
        }
        private string _CLASSE_CX;
        partial void OnGetCLASSE_CX(ref string value);
        partial void OnCLASSE_CXChanging(ref string value);
        partial void OnCLASSE_CXChanged();
    
        /// <summary>
        /// There are no comments for MARCA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string MARCA
        {
            get
            {
                string value = _MARCA;
                OnGetMARCA(ref value);
                return value;
            }
            set
            {
                if (_MARCA != value)
                {
                  OnMARCAChanging(ref value);
                  ReportPropertyChanging("MARCA");
                  _MARCA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("MARCA");
                  OnMARCAChanged();
              }
            }
        }
        private string _MARCA;
        partial void OnGetMARCA(ref string value);
        partial void OnMARCAChanging(ref string value);
        partial void OnMARCAChanged();
    
        /// <summary>
        /// There are no comments for ESTACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ESTACAO
        {
            get
            {
                string value = _ESTACAO;
                OnGetESTACAO(ref value);
                return value;
            }
            set
            {
                if (_ESTACAO != value)
                {
                  OnESTACAOChanging(ref value);
                  ReportPropertyChanging("ESTACAO");
                  _ESTACAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ESTACAO");
                  OnESTACAOChanged();
              }
            }
        }
        private string _ESTACAO = @"space((3))";
        partial void OnGetESTACAO(ref string value);
        partial void OnESTACAOChanging(ref string value);
        partial void OnESTACAOChanged();
    
        /// <summary>
        /// There are no comments for ARTIGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ARTIGO
        {
            get
            {
                string value = _ARTIGO;
                OnGetARTIGO(ref value);
                return value;
            }
            set
            {
                if (_ARTIGO != value)
                {
                  OnARTIGOChanging(ref value);
                  ReportPropertyChanging("ARTIGO");
                  _ARTIGO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ARTIGO");
                  OnARTIGOChanged();
              }
            }
        }
        private string _ARTIGO;
        partial void OnGetARTIGO(ref string value);
        partial void OnARTIGOChanging(ref string value);
        partial void OnARTIGOChanged();
    
        /// <summary>
        /// There are no comments for CARTAZ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CARTAZ
        {
            get
            {
                string value = _CARTAZ;
                OnGetCARTAZ(ref value);
                return value;
            }
            set
            {
                if (_CARTAZ != value)
                {
                  OnCARTAZChanging(ref value);
                  ReportPropertyChanging("CARTAZ");
                  _CARTAZ = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CARTAZ");
                  OnCARTAZChanged();
              }
            }
        }
        private string _CARTAZ = @"space((5))";
        partial void OnGetCARTAZ(ref string value);
        partial void OnCARTAZChanging(ref string value);
        partial void OnCARTAZChanged();
    
        /// <summary>
        /// There are no comments for CODCOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODCOR
        {
            get
            {
                string value = _CODCOR;
                OnGetCODCOR(ref value);
                return value;
            }
            set
            {
                if (_CODCOR != value)
                {
                  OnCODCORChanging(ref value);
                  ReportPropertyChanging("CODCOR");
                  _CODCOR = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODCOR");
                  OnCODCORChanged();
              }
            }
        }
        private string _CODCOR = @"space((3))";
        partial void OnGetCODCOR(ref string value);
        partial void OnCODCORChanging(ref string value);
        partial void OnCODCORChanged();
    
        /// <summary>
        /// There are no comments for TAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TAM
        {
            get
            {
                string value = _TAM;
                OnGetTAM(ref value);
                return value;
            }
            set
            {
                if (_TAM != value)
                {
                  OnTAMChanging(ref value);
                  ReportPropertyChanging("TAM");
                  _TAM = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TAM");
                  OnTAMChanged();
              }
            }
        }
        private string _TAM = @"space((4))";
        partial void OnGetTAM(ref string value);
        partial void OnTAMChanging(ref string value);
        partial void OnTAMChanged();
    
        /// <summary>
        /// There are no comments for COMP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> COMP
        {
            get
            {
                global::System.Nullable<decimal> value = _COMP;
                OnGetCOMP(ref value);
                return value;
            }
            set
            {
                if (_COMP != value)
                {
                  OnCOMPChanging(ref value);
                  ReportPropertyChanging("COMP");
                  _COMP = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("COMP");
                  OnCOMPChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _COMP;
        partial void OnGetCOMP(ref global::System.Nullable<decimal> value);
        partial void OnCOMPChanging(ref global::System.Nullable<decimal> value);
        partial void OnCOMPChanged();
    
        /// <summary>
        /// There are no comments for LARG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> LARG
        {
            get
            {
                global::System.Nullable<decimal> value = _LARG;
                OnGetLARG(ref value);
                return value;
            }
            set
            {
                if (_LARG != value)
                {
                  OnLARGChanging(ref value);
                  ReportPropertyChanging("LARG");
                  _LARG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LARG");
                  OnLARGChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _LARG;
        partial void OnGetLARG(ref global::System.Nullable<decimal> value);
        partial void OnLARGChanging(ref global::System.Nullable<decimal> value);
        partial void OnLARGChanged();
    
        /// <summary>
        /// There are no comments for ALT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> ALT
        {
            get
            {
                global::System.Nullable<decimal> value = _ALT;
                OnGetALT(ref value);
                return value;
            }
            set
            {
                if (_ALT != value)
                {
                  OnALTChanging(ref value);
                  ReportPropertyChanging("ALT");
                  _ALT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ALT");
                  OnALTChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _ALT;
        partial void OnGetALT(ref global::System.Nullable<decimal> value);
        partial void OnALTChanging(ref global::System.Nullable<decimal> value);
        partial void OnALTChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TABCX obj = new TABCX();
            obj.CLASSE_CX = CLASSE_CX;
            obj.MARCA = MARCA;
            obj.ESTACAO = ESTACAO;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.TAM = TAM;
            obj.COMP = COMP;
            obj.LARG = LARG;
            obj.ALT = ALT;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABCX toCompare = obj as TABCX;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CLASSE_CX, toCompare.CLASSE_CX))
            return false;
          if (!Object.Equals(this.MARCA, toCompare.MARCA))
            return false;
          if (!Object.Equals(this.ESTACAO, toCompare.ESTACAO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CLASSE_CX.GetHashCode();
          hashCode = (hashCode * 7) + MARCA.GetHashCode();
          hashCode = (hashCode * 7) + ESTACAO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}