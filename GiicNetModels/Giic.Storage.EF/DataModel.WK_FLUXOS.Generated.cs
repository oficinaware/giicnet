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
    /// There are no comments for DataGiic_LiagoModel.WK_FLUXOS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// SECCAO
    /// OPERACAO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_FLUXOS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_FLUXOS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_FLUXOS object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="sECCAO">Initial value of SECCAO.</param>
        /// <param name="oPERACAO">Initial value of OPERACAO.</param>
        public static WK_FLUXOS CreateWK_FLUXOS(int sPID, string sECCAO, string oPERACAO)
        {
            WK_FLUXOS wK_FLUXOS = new WK_FLUXOS();
            wK_FLUXOS.SPID = sPID;
            wK_FLUXOS.SECCAO = sECCAO;
            wK_FLUXOS.OPERACAO = oPERACAO;
            return wK_FLUXOS;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for SPID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int SPID
        {
            get
            {
                int value = _SPID;
                OnGetSPID(ref value);
                return value;
            }
            set
            {
                if (_SPID != value)
                {
                  OnSPIDChanging(ref value);
                  ReportPropertyChanging("SPID");
                  _SPID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SPID");
                  OnSPIDChanged();
              }
            }
        }
        private int _SPID;
        partial void OnGetSPID(ref int value);
        partial void OnSPIDChanging(ref int value);
        partial void OnSPIDChanged();
    
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
        /// There are no comments for CARGA_MIN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CARGA_MIN
        {
            get
            {
                global::System.Nullable<decimal> value = _CARGA_MIN;
                OnGetCARGA_MIN(ref value);
                return value;
            }
            set
            {
                if (_CARGA_MIN != value)
                {
                  OnCARGA_MINChanging(ref value);
                  ReportPropertyChanging("CARGA_MIN");
                  _CARGA_MIN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CARGA_MIN");
                  OnCARGA_MINChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CARGA_MIN = 0m;
        partial void OnGetCARGA_MIN(ref global::System.Nullable<decimal> value);
        partial void OnCARGA_MINChanging(ref global::System.Nullable<decimal> value);
        partial void OnCARGA_MINChanged();
    
        /// <summary>
        /// There are no comments for CARGA_QT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> CARGA_QT
        {
            get
            {
                global::System.Nullable<int> value = _CARGA_QT;
                OnGetCARGA_QT(ref value);
                return value;
            }
            set
            {
                if (_CARGA_QT != value)
                {
                  OnCARGA_QTChanging(ref value);
                  ReportPropertyChanging("CARGA_QT");
                  _CARGA_QT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CARGA_QT");
                  OnCARGA_QTChanged();
              }
            }
        }
        private global::System.Nullable<int> _CARGA_QT = 0;
        partial void OnGetCARGA_QT(ref global::System.Nullable<int> value);
        partial void OnCARGA_QTChanging(ref global::System.Nullable<int> value);
        partial void OnCARGA_QTChanged();
    
        /// <summary>
        /// There are no comments for CARGA_MIN_ATRAS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CARGA_MIN_ATRAS
        {
            get
            {
                global::System.Nullable<decimal> value = _CARGA_MIN_ATRAS;
                OnGetCARGA_MIN_ATRAS(ref value);
                return value;
            }
            set
            {
                if (_CARGA_MIN_ATRAS != value)
                {
                  OnCARGA_MIN_ATRASChanging(ref value);
                  ReportPropertyChanging("CARGA_MIN_ATRAS");
                  _CARGA_MIN_ATRAS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CARGA_MIN_ATRAS");
                  OnCARGA_MIN_ATRASChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CARGA_MIN_ATRAS = 0m;
        partial void OnGetCARGA_MIN_ATRAS(ref global::System.Nullable<decimal> value);
        partial void OnCARGA_MIN_ATRASChanging(ref global::System.Nullable<decimal> value);
        partial void OnCARGA_MIN_ATRASChanged();
    
        /// <summary>
        /// There are no comments for CARGA_QT_ATRAS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> CARGA_QT_ATRAS
        {
            get
            {
                global::System.Nullable<int> value = _CARGA_QT_ATRAS;
                OnGetCARGA_QT_ATRAS(ref value);
                return value;
            }
            set
            {
                if (_CARGA_QT_ATRAS != value)
                {
                  OnCARGA_QT_ATRASChanging(ref value);
                  ReportPropertyChanging("CARGA_QT_ATRAS");
                  _CARGA_QT_ATRAS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CARGA_QT_ATRAS");
                  OnCARGA_QT_ATRASChanged();
              }
            }
        }
        private global::System.Nullable<int> _CARGA_QT_ATRAS = 0;
        partial void OnGetCARGA_QT_ATRAS(ref global::System.Nullable<int> value);
        partial void OnCARGA_QT_ATRASChanging(ref global::System.Nullable<int> value);
        partial void OnCARGA_QT_ATRASChanged();
    
        /// <summary>
        /// There are no comments for QT_FILA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QT_FILA
        {
            get
            {
                global::System.Nullable<int> value = _QT_FILA;
                OnGetQT_FILA(ref value);
                return value;
            }
            set
            {
                if (_QT_FILA != value)
                {
                  OnQT_FILAChanging(ref value);
                  ReportPropertyChanging("QT_FILA");
                  _QT_FILA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QT_FILA");
                  OnQT_FILAChanged();
              }
            }
        }
        private global::System.Nullable<int> _QT_FILA = 0;
        partial void OnGetQT_FILA(ref global::System.Nullable<int> value);
        partial void OnQT_FILAChanging(ref global::System.Nullable<int> value);
        partial void OnQT_FILAChanged();
    
        /// <summary>
        /// There are no comments for QT_FILA_APA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QT_FILA_APA
        {
            get
            {
                global::System.Nullable<int> value = _QT_FILA_APA;
                OnGetQT_FILA_APA(ref value);
                return value;
            }
            set
            {
                if (_QT_FILA_APA != value)
                {
                  OnQT_FILA_APAChanging(ref value);
                  ReportPropertyChanging("QT_FILA_APA");
                  _QT_FILA_APA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QT_FILA_APA");
                  OnQT_FILA_APAChanged();
              }
            }
        }
        private global::System.Nullable<int> _QT_FILA_APA = 0;
        partial void OnGetQT_FILA_APA(ref global::System.Nullable<int> value);
        partial void OnQT_FILA_APAChanging(ref global::System.Nullable<int> value);
        partial void OnQT_FILA_APAChanged();
    
        /// <summary>
        /// There are no comments for MIN_FILA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> MIN_FILA
        {
            get
            {
                global::System.Nullable<decimal> value = _MIN_FILA;
                OnGetMIN_FILA(ref value);
                return value;
            }
            set
            {
                if (_MIN_FILA != value)
                {
                  OnMIN_FILAChanging(ref value);
                  ReportPropertyChanging("MIN_FILA");
                  _MIN_FILA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("MIN_FILA");
                  OnMIN_FILAChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _MIN_FILA = 0m;
        partial void OnGetMIN_FILA(ref global::System.Nullable<decimal> value);
        partial void OnMIN_FILAChanging(ref global::System.Nullable<decimal> value);
        partial void OnMIN_FILAChanged();
    
        /// <summary>
        /// There are no comments for EC_QT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> EC_QT
        {
            get
            {
                global::System.Nullable<int> value = _EC_QT;
                OnGetEC_QT(ref value);
                return value;
            }
            set
            {
                if (_EC_QT != value)
                {
                  OnEC_QTChanging(ref value);
                  ReportPropertyChanging("EC_QT");
                  _EC_QT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("EC_QT");
                  OnEC_QTChanged();
              }
            }
        }
        private global::System.Nullable<int> _EC_QT = 0;
        partial void OnGetEC_QT(ref global::System.Nullable<int> value);
        partial void OnEC_QTChanging(ref global::System.Nullable<int> value);
        partial void OnEC_QTChanged();
    
        /// <summary>
        /// There are no comments for EC_MIN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> EC_MIN
        {
            get
            {
                global::System.Nullable<decimal> value = _EC_MIN;
                OnGetEC_MIN(ref value);
                return value;
            }
            set
            {
                if (_EC_MIN != value)
                {
                  OnEC_MINChanging(ref value);
                  ReportPropertyChanging("EC_MIN");
                  _EC_MIN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("EC_MIN");
                  OnEC_MINChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _EC_MIN = 0m;
        partial void OnGetEC_MIN(ref global::System.Nullable<decimal> value);
        partial void OnEC_MINChanging(ref global::System.Nullable<decimal> value);
        partial void OnEC_MINChanged();
    
        /// <summary>
        /// There are no comments for PRODQT01 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> PRODQT01
        {
            get
            {
                global::System.Nullable<int> value = _PRODQT01;
                OnGetPRODQT01(ref value);
                return value;
            }
            set
            {
                if (_PRODQT01 != value)
                {
                  OnPRODQT01Changing(ref value);
                  ReportPropertyChanging("PRODQT01");
                  _PRODQT01 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRODQT01");
                  OnPRODQT01Changed();
              }
            }
        }
        private global::System.Nullable<int> _PRODQT01 = 0;
        partial void OnGetPRODQT01(ref global::System.Nullable<int> value);
        partial void OnPRODQT01Changing(ref global::System.Nullable<int> value);
        partial void OnPRODQT01Changed();
    
        /// <summary>
        /// There are no comments for PRODQT02 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> PRODQT02
        {
            get
            {
                global::System.Nullable<int> value = _PRODQT02;
                OnGetPRODQT02(ref value);
                return value;
            }
            set
            {
                if (_PRODQT02 != value)
                {
                  OnPRODQT02Changing(ref value);
                  ReportPropertyChanging("PRODQT02");
                  _PRODQT02 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRODQT02");
                  OnPRODQT02Changed();
              }
            }
        }
        private global::System.Nullable<int> _PRODQT02 = 0;
        partial void OnGetPRODQT02(ref global::System.Nullable<int> value);
        partial void OnPRODQT02Changing(ref global::System.Nullable<int> value);
        partial void OnPRODQT02Changed();
    
        /// <summary>
        /// There are no comments for PRODQT03 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> PRODQT03
        {
            get
            {
                global::System.Nullable<int> value = _PRODQT03;
                OnGetPRODQT03(ref value);
                return value;
            }
            set
            {
                if (_PRODQT03 != value)
                {
                  OnPRODQT03Changing(ref value);
                  ReportPropertyChanging("PRODQT03");
                  _PRODQT03 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRODQT03");
                  OnPRODQT03Changed();
              }
            }
        }
        private global::System.Nullable<int> _PRODQT03 = 0;
        partial void OnGetPRODQT03(ref global::System.Nullable<int> value);
        partial void OnPRODQT03Changing(ref global::System.Nullable<int> value);
        partial void OnPRODQT03Changed();
    
        /// <summary>
        /// There are no comments for PRODQT04 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> PRODQT04
        {
            get
            {
                global::System.Nullable<int> value = _PRODQT04;
                OnGetPRODQT04(ref value);
                return value;
            }
            set
            {
                if (_PRODQT04 != value)
                {
                  OnPRODQT04Changing(ref value);
                  ReportPropertyChanging("PRODQT04");
                  _PRODQT04 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRODQT04");
                  OnPRODQT04Changed();
              }
            }
        }
        private global::System.Nullable<int> _PRODQT04 = 0;
        partial void OnGetPRODQT04(ref global::System.Nullable<int> value);
        partial void OnPRODQT04Changing(ref global::System.Nullable<int> value);
        partial void OnPRODQT04Changed();
    
        /// <summary>
        /// There are no comments for PRODQT05 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> PRODQT05
        {
            get
            {
                global::System.Nullable<int> value = _PRODQT05;
                OnGetPRODQT05(ref value);
                return value;
            }
            set
            {
                if (_PRODQT05 != value)
                {
                  OnPRODQT05Changing(ref value);
                  ReportPropertyChanging("PRODQT05");
                  _PRODQT05 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRODQT05");
                  OnPRODQT05Changed();
              }
            }
        }
        private global::System.Nullable<int> _PRODQT05 = 0;
        partial void OnGetPRODQT05(ref global::System.Nullable<int> value);
        partial void OnPRODQT05Changing(ref global::System.Nullable<int> value);
        partial void OnPRODQT05Changed();
    
        /// <summary>
        /// There are no comments for PRODQT06 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> PRODQT06
        {
            get
            {
                global::System.Nullable<int> value = _PRODQT06;
                OnGetPRODQT06(ref value);
                return value;
            }
            set
            {
                if (_PRODQT06 != value)
                {
                  OnPRODQT06Changing(ref value);
                  ReportPropertyChanging("PRODQT06");
                  _PRODQT06 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRODQT06");
                  OnPRODQT06Changed();
              }
            }
        }
        private global::System.Nullable<int> _PRODQT06 = 0;
        partial void OnGetPRODQT06(ref global::System.Nullable<int> value);
        partial void OnPRODQT06Changing(ref global::System.Nullable<int> value);
        partial void OnPRODQT06Changed();
    
        /// <summary>
        /// There are no comments for NDIAS7 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NDIAS7
        {
            get
            {
                global::System.Nullable<int> value = _NDIAS7;
                OnGetNDIAS7(ref value);
                return value;
            }
            set
            {
                if (_NDIAS7 != value)
                {
                  OnNDIAS7Changing(ref value);
                  ReportPropertyChanging("NDIAS7");
                  _NDIAS7 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NDIAS7");
                  OnNDIAS7Changed();
              }
            }
        }
        private global::System.Nullable<int> _NDIAS7 = 0;
        partial void OnGetNDIAS7(ref global::System.Nullable<int> value);
        partial void OnNDIAS7Changing(ref global::System.Nullable<int> value);
        partial void OnNDIAS7Changed();
    
        /// <summary>
        /// There are no comments for NDIAS15 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NDIAS15
        {
            get
            {
                global::System.Nullable<int> value = _NDIAS15;
                OnGetNDIAS15(ref value);
                return value;
            }
            set
            {
                if (_NDIAS15 != value)
                {
                  OnNDIAS15Changing(ref value);
                  ReportPropertyChanging("NDIAS15");
                  _NDIAS15 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NDIAS15");
                  OnNDIAS15Changed();
              }
            }
        }
        private global::System.Nullable<int> _NDIAS15 = 0;
        partial void OnGetNDIAS15(ref global::System.Nullable<int> value);
        partial void OnNDIAS15Changing(ref global::System.Nullable<int> value);
        partial void OnNDIAS15Changed();
    
        /// <summary>
        /// There are no comments for NDIAS30 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NDIAS30
        {
            get
            {
                global::System.Nullable<int> value = _NDIAS30;
                OnGetNDIAS30(ref value);
                return value;
            }
            set
            {
                if (_NDIAS30 != value)
                {
                  OnNDIAS30Changing(ref value);
                  ReportPropertyChanging("NDIAS30");
                  _NDIAS30 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NDIAS30");
                  OnNDIAS30Changed();
              }
            }
        }
        private global::System.Nullable<int> _NDIAS30 = 0;
        partial void OnGetNDIAS30(ref global::System.Nullable<int> value);
        partial void OnNDIAS30Changing(ref global::System.Nullable<int> value);
        partial void OnNDIAS30Changed();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_FLUXOS obj = new WK_FLUXOS();
            obj.SPID = SPID;
            obj.SECCAO = SECCAO;
            obj.OPERACAO = OPERACAO;
            obj.CARGA_MIN = CARGA_MIN;
            obj.CARGA_QT = CARGA_QT;
            obj.CARGA_MIN_ATRAS = CARGA_MIN_ATRAS;
            obj.CARGA_QT_ATRAS = CARGA_QT_ATRAS;
            obj.QT_FILA = QT_FILA;
            obj.QT_FILA_APA = QT_FILA_APA;
            obj.MIN_FILA = MIN_FILA;
            obj.EC_QT = EC_QT;
            obj.EC_MIN = EC_MIN;
            obj.PRODQT01 = PRODQT01;
            obj.PRODQT02 = PRODQT02;
            obj.PRODQT03 = PRODQT03;
            obj.PRODQT04 = PRODQT04;
            obj.PRODQT05 = PRODQT05;
            obj.PRODQT06 = PRODQT06;
            obj.NDIAS7 = NDIAS7;
            obj.NDIAS15 = NDIAS15;
            obj.NDIAS30 = NDIAS30;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_FLUXOS toCompare = obj as WK_FLUXOS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.SECCAO, toCompare.SECCAO))
            return false;
          if (!Object.Equals(this.OPERACAO, toCompare.OPERACAO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + SECCAO.GetHashCode();
          hashCode = (hashCode * 7) + OPERACAO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
