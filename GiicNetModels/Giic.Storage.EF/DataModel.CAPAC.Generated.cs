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
    /// There are no comments for DataGiic_LiagoModel.CAPAC in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SECCAO
    /// OPERACAO
    /// DTDIA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CAPAC")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CAPAC : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CAPAC object.
        /// </summary>
        /// <param name="sECCAO">Initial value of SECCAO.</param>
        /// <param name="oPERACAO">Initial value of OPERACAO.</param>
        /// <param name="dTDIA">Initial value of DTDIA.</param>
        public static CAPAC CreateCAPAC(string sECCAO, string oPERACAO, global::System.DateTime dTDIA)
        {
            CAPAC cAPAC = new CAPAC();
            cAPAC.SECCAO = sECCAO;
            cAPAC.OPERACAO = oPERACAO;
            cAPAC.DTDIA = dTDIA;
            return cAPAC;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for SECCAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string SECCAO
        {
            get
            {
                string value = _SECCAO;
                OnGetSECCAO(ref value);
                return value;
            }
            set
            {
                if (_SECCAO != value)
                {
                  OnSECCAOChanging(ref value);
                  ReportPropertyChanging("SECCAO");
                  _SECCAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("SECCAO");
                  OnSECCAOChanged();
              }
            }
        }
        private string _SECCAO;
        partial void OnGetSECCAO(ref string value);
        partial void OnSECCAOChanging(ref string value);
        partial void OnSECCAOChanged();
    
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
        /// There are no comments for DTDIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.DateTime DTDIA
        {
            get
            {
                global::System.DateTime value = _DTDIA;
                OnGetDTDIA(ref value);
                return value;
            }
            set
            {
                if (_DTDIA != value)
                {
                  OnDTDIAChanging(ref value);
                  ReportPropertyChanging("DTDIA");
                  _DTDIA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DTDIA");
                  OnDTDIAChanged();
              }
            }
        }
        private global::System.DateTime _DTDIA;
        partial void OnGetDTDIA(ref global::System.DateTime value);
        partial void OnDTDIAChanging(ref global::System.DateTime value);
        partial void OnDTDIAChanged();
    
        /// <summary>
        /// There are no comments for SEMANA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string SEMANA
        {
            get
            {
                string value = _SEMANA;
                OnGetSEMANA(ref value);
                return value;
            }
            set
            {
                if (_SEMANA != value)
                {
                  OnSEMANAChanging(ref value);
                  ReportPropertyChanging("SEMANA");
                  _SEMANA = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("SEMANA");
                  OnSEMANAChanged();
              }
            }
        }
        private string _SEMANA;
        partial void OnGetSEMANA(ref string value);
        partial void OnSEMANAChanging(ref string value);
        partial void OnSEMANAChanged();
    
        /// <summary>
        /// There are no comments for CAPNOM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CAPNOM
        {
            get
            {
                global::System.Nullable<decimal> value = _CAPNOM;
                OnGetCAPNOM(ref value);
                return value;
            }
            set
            {
                if (_CAPNOM != value)
                {
                  OnCAPNOMChanging(ref value);
                  ReportPropertyChanging("CAPNOM");
                  _CAPNOM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CAPNOM");
                  OnCAPNOMChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CAPNOM;
        partial void OnGetCAPNOM(ref global::System.Nullable<decimal> value);
        partial void OnCAPNOMChanging(ref global::System.Nullable<decimal> value);
        partial void OnCAPNOMChanged();
    
        /// <summary>
        /// There are no comments for CAPREAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CAPREAL
        {
            get
            {
                global::System.Nullable<decimal> value = _CAPREAL;
                OnGetCAPREAL(ref value);
                return value;
            }
            set
            {
                if (_CAPREAL != value)
                {
                  OnCAPREALChanging(ref value);
                  ReportPropertyChanging("CAPREAL");
                  _CAPREAL = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CAPREAL");
                  OnCAPREALChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CAPREAL;
        partial void OnGetCAPREAL(ref global::System.Nullable<decimal> value);
        partial void OnCAPREALChanging(ref global::System.Nullable<decimal> value);
        partial void OnCAPREALChanged();
    
        /// <summary>
        /// There are no comments for CARGA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CARGA
        {
            get
            {
                global::System.Nullable<decimal> value = _CARGA;
                OnGetCARGA(ref value);
                return value;
            }
            set
            {
                if (_CARGA != value)
                {
                  OnCARGAChanging(ref value);
                  ReportPropertyChanging("CARGA");
                  _CARGA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CARGA");
                  OnCARGAChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CARGA;
        partial void OnGetCARGA(ref global::System.Nullable<decimal> value);
        partial void OnCARGAChanging(ref global::System.Nullable<decimal> value);
        partial void OnCARGAChanged();
    
        /// <summary>
        /// There are no comments for PRODUCAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> PRODUCAO
        {
            get
            {
                global::System.Nullable<decimal> value = _PRODUCAO;
                OnGetPRODUCAO(ref value);
                return value;
            }
            set
            {
                if (_PRODUCAO != value)
                {
                  OnPRODUCAOChanging(ref value);
                  ReportPropertyChanging("PRODUCAO");
                  _PRODUCAO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRODUCAO");
                  OnPRODUCAOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _PRODUCAO;
        partial void OnGetPRODUCAO(ref global::System.Nullable<decimal> value);
        partial void OnPRODUCAOChanging(ref global::System.Nullable<decimal> value);
        partial void OnPRODUCAOChanged();
    
        /// <summary>
        /// There are no comments for QTPROD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QTPROD
        {
            get
            {
                global::System.Nullable<int> value = _QTPROD;
                OnGetQTPROD(ref value);
                return value;
            }
            set
            {
                if (_QTPROD != value)
                {
                  OnQTPRODChanging(ref value);
                  ReportPropertyChanging("QTPROD");
                  _QTPROD = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTPROD");
                  OnQTPRODChanged();
              }
            }
        }
        private global::System.Nullable<int> _QTPROD;
        partial void OnGetQTPROD(ref global::System.Nullable<int> value);
        partial void OnQTPRODChanging(ref global::System.Nullable<int> value);
        partial void OnQTPRODChanged();
    
        /// <summary>
        /// There are no comments for QTENT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QTENT
        {
            get
            {
                global::System.Nullable<int> value = _QTENT;
                OnGetQTENT(ref value);
                return value;
            }
            set
            {
                if (_QTENT != value)
                {
                  OnQTENTChanging(ref value);
                  ReportPropertyChanging("QTENT");
                  _QTENT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTENT");
                  OnQTENTChanged();
              }
            }
        }
        private global::System.Nullable<int> _QTENT;
        partial void OnGetQTENT(ref global::System.Nullable<int> value);
        partial void OnQTENTChanging(ref global::System.Nullable<int> value);
        partial void OnQTENTChanged();
    
        /// <summary>
        /// There are no comments for HORAENT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> HORAENT
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _HORAENT;
                OnGetHORAENT(ref value);
                return value;
            }
            set
            {
                if (_HORAENT != value)
                {
                  OnHORAENTChanging(ref value);
                  ReportPropertyChanging("HORAENT");
                  _HORAENT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("HORAENT");
                  OnHORAENTChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _HORAENT;
        partial void OnGetHORAENT(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORAENTChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORAENTChanged();
    
        /// <summary>
        /// There are no comments for MINDIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> MINDIA
        {
            get
            {
                global::System.Nullable<int> value = _MINDIA;
                OnGetMINDIA(ref value);
                return value;
            }
            set
            {
                if (_MINDIA != value)
                {
                  OnMINDIAChanging(ref value);
                  ReportPropertyChanging("MINDIA");
                  _MINDIA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("MINDIA");
                  OnMINDIAChanged();
              }
            }
        }
        private global::System.Nullable<int> _MINDIA;
        partial void OnGetMINDIA(ref global::System.Nullable<int> value);
        partial void OnMINDIAChanging(ref global::System.Nullable<int> value);
        partial void OnMINDIAChanged();
    
        /// <summary>
        /// There are no comments for NRFUNCDIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NRFUNCDIA
        {
            get
            {
                global::System.Nullable<int> value = _NRFUNCDIA;
                OnGetNRFUNCDIA(ref value);
                return value;
            }
            set
            {
                if (_NRFUNCDIA != value)
                {
                  OnNRFUNCDIAChanging(ref value);
                  ReportPropertyChanging("NRFUNCDIA");
                  _NRFUNCDIA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRFUNCDIA");
                  OnNRFUNCDIAChanged();
              }
            }
        }
        private global::System.Nullable<int> _NRFUNCDIA;
        partial void OnGetNRFUNCDIA(ref global::System.Nullable<int> value);
        partial void OnNRFUNCDIAChanging(ref global::System.Nullable<int> value);
        partial void OnNRFUNCDIAChanged();
    
        /// <summary>
        /// There are no comments for COD_HORARIO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string COD_HORARIO
        {
            get
            {
                string value = _COD_HORARIO;
                OnGetCOD_HORARIO(ref value);
                return value;
            }
            set
            {
                if (_COD_HORARIO != value)
                {
                  OnCOD_HORARIOChanging(ref value);
                  ReportPropertyChanging("COD_HORARIO");
                  _COD_HORARIO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COD_HORARIO");
                  OnCOD_HORARIOChanged();
              }
            }
        }
        private string _COD_HORARIO;
        partial void OnGetCOD_HORARIO(ref string value);
        partial void OnCOD_HORARIOChanging(ref string value);
        partial void OnCOD_HORARIOChanged();
    
        /// <summary>
        /// There are no comments for COD_HORARIO_SEM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string COD_HORARIO_SEM
        {
            get
            {
                string value = _COD_HORARIO_SEM;
                OnGetCOD_HORARIO_SEM(ref value);
                return value;
            }
            set
            {
                if (_COD_HORARIO_SEM != value)
                {
                  OnCOD_HORARIO_SEMChanging(ref value);
                  ReportPropertyChanging("COD_HORARIO_SEM");
                  _COD_HORARIO_SEM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COD_HORARIO_SEM");
                  OnCOD_HORARIO_SEMChanged();
              }
            }
        }
        private string _COD_HORARIO_SEM;
        partial void OnGetCOD_HORARIO_SEM(ref string value);
        partial void OnCOD_HORARIO_SEMChanging(ref string value);
        partial void OnCOD_HORARIO_SEMChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CAPAC obj = new CAPAC();
            obj.SECCAO = SECCAO;
            obj.OPERACAO = OPERACAO;
            obj.DTDIA = DTDIA;
            obj.SEMANA = SEMANA;
            obj.CAPNOM = CAPNOM;
            obj.CAPREAL = CAPREAL;
            obj.CARGA = CARGA;
            obj.PRODUCAO = PRODUCAO;
            obj.QTPROD = QTPROD;
            obj.QTENT = QTENT;
            obj.HORAENT = HORAENT;
            obj.MINDIA = MINDIA;
            obj.NRFUNCDIA = NRFUNCDIA;
            obj.COD_HORARIO = COD_HORARIO;
            obj.COD_HORARIO_SEM = COD_HORARIO_SEM;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CAPAC toCompare = obj as CAPAC;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SECCAO, toCompare.SECCAO))
            return false;
          if (!Object.Equals(this.OPERACAO, toCompare.OPERACAO))
            return false;
          if (!Object.Equals(this.DTDIA, toCompare.DTDIA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SECCAO.GetHashCode();
          hashCode = (hashCode * 7) + OPERACAO.GetHashCode();
          hashCode = (hashCode * 7) + DTDIA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
