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
    /// There are no comments for DataGiic_LiagoModel.WK_ORCR_EST in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ESTACAO
    /// MODELO
    /// VARIANTE
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WK_ORCR_EST")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WK_ORCR_EST : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WK_ORCR_EST object.
        /// </summary>
        /// <param name="eSTACAO">Initial value of ESTACAO.</param>
        /// <param name="mODELO">Initial value of MODELO.</param>
        /// <param name="vARIANTE">Initial value of VARIANTE.</param>
        public static WK_ORCR_EST CreateWK_ORCR_EST(string eSTACAO, string mODELO, string vARIANTE)
        {
            WK_ORCR_EST wK_ORCR_EST = new WK_ORCR_EST();
            wK_ORCR_EST.ESTACAO = eSTACAO;
            wK_ORCR_EST.MODELO = mODELO;
            wK_ORCR_EST.VARIANTE = vARIANTE;
            return wK_ORCR_EST;
        }

        #endregion

        #region Properties
    
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
        private string _ESTACAO;
        partial void OnGetESTACAO(ref string value);
        partial void OnESTACAOChanging(ref string value);
        partial void OnESTACAOChanged();
    
        /// <summary>
        /// There are no comments for MODELO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string MODELO
        {
            get
            {
                string value = _MODELO;
                OnGetMODELO(ref value);
                return value;
            }
            set
            {
                if (_MODELO != value)
                {
                  OnMODELOChanging(ref value);
                  ReportPropertyChanging("MODELO");
                  _MODELO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("MODELO");
                  OnMODELOChanged();
              }
            }
        }
        private string _MODELO;
        partial void OnGetMODELO(ref string value);
        partial void OnMODELOChanging(ref string value);
        partial void OnMODELOChanged();
    
        /// <summary>
        /// There are no comments for VARIANTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string VARIANTE
        {
            get
            {
                string value = _VARIANTE;
                OnGetVARIANTE(ref value);
                return value;
            }
            set
            {
                if (_VARIANTE != value)
                {
                  OnVARIANTEChanging(ref value);
                  ReportPropertyChanging("VARIANTE");
                  _VARIANTE = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("VARIANTE");
                  OnVARIANTEChanged();
              }
            }
        }
        private string _VARIANTE;
        partial void OnGetVARIANTE(ref string value);
        partial void OnVARIANTEChanging(ref string value);
        partial void OnVARIANTEChanged();
    
        /// <summary>
        /// There are no comments for COR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string COR
        {
            get
            {
                string value = _COR;
                OnGetCOR(ref value);
                return value;
            }
            set
            {
                if (_COR != value)
                {
                  OnCORChanging(ref value);
                  ReportPropertyChanging("COR");
                  _COR = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COR");
                  OnCORChanged();
              }
            }
        }
        private string _COR;
        partial void OnGetCOR(ref string value);
        partial void OnCORChanging(ref string value);
        partial void OnCORChanged();
    
        /// <summary>
        /// There are no comments for FAMILIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
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
                  _FAMILIA = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for MARCA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
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
                  _MARCA = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for LINHA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string LINHA
        {
            get
            {
                string value = _LINHA;
                OnGetLINHA(ref value);
                return value;
            }
            set
            {
                if (_LINHA != value)
                {
                  OnLINHAChanging(ref value);
                  ReportPropertyChanging("LINHA");
                  _LINHA = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("LINHA");
                  OnLINHAChanged();
              }
            }
        }
        private string _LINHA;
        partial void OnGetLINHA(ref string value);
        partial void OnLINHAChanging(ref string value);
        partial void OnLINHAChanged();
    
        /// <summary>
        /// There are no comments for IMAGEM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        public string IMAGEM
        {
            get
            {
                string value = _IMAGEM;
                OnGetIMAGEM(ref value);
                return value;
            }
            set
            {
                if (_IMAGEM != value)
                {
                  OnIMAGEMChanging(ref value);
                  ReportPropertyChanging("IMAGEM");
                  _IMAGEM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("IMAGEM");
                  OnIMAGEMChanged();
              }
            }
        }
        private string _IMAGEM;
        partial void OnGetIMAGEM(ref string value);
        partial void OnIMAGEMChanging(ref string value);
        partial void OnIMAGEMChanged();
    
        /// <summary>
        /// There are no comments for TQT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TQT
        {
            get
            {
                global::System.Nullable<int> value = _TQT;
                OnGetTQT(ref value);
                return value;
            }
            set
            {
                if (_TQT != value)
                {
                  OnTQTChanging(ref value);
                  ReportPropertyChanging("TQT");
                  _TQT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TQT");
                  OnTQTChanged();
              }
            }
        }
        private global::System.Nullable<int> _TQT;
        partial void OnGetTQT(ref global::System.Nullable<int> value);
        partial void OnTQTChanging(ref global::System.Nullable<int> value);
        partial void OnTQTChanged();
    
        /// <summary>
        /// There are no comments for VL_ENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> VL_ENCO
        {
            get
            {
                global::System.Nullable<double> value = _VL_ENCO;
                OnGetVL_ENCO(ref value);
                return value;
            }
            set
            {
                if (_VL_ENCO != value)
                {
                  OnVL_ENCOChanging(ref value);
                  ReportPropertyChanging("VL_ENCO");
                  _VL_ENCO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_ENCO");
                  OnVL_ENCOChanged();
              }
            }
        }
        private global::System.Nullable<double> _VL_ENCO;
        partial void OnGetVL_ENCO(ref global::System.Nullable<double> value);
        partial void OnVL_ENCOChanging(ref global::System.Nullable<double> value);
        partial void OnVL_ENCOChanged();
    
        /// <summary>
        /// There are no comments for TOTEA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> TOTEA
        {
            get
            {
                global::System.Nullable<double> value = _TOTEA;
                OnGetTOTEA(ref value);
                return value;
            }
            set
            {
                if (_TOTEA != value)
                {
                  OnTOTEAChanging(ref value);
                  ReportPropertyChanging("TOTEA");
                  _TOTEA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTEA");
                  OnTOTEAChanged();
              }
            }
        }
        private global::System.Nullable<double> _TOTEA;
        partial void OnGetTOTEA(ref global::System.Nullable<double> value);
        partial void OnTOTEAChanging(ref global::System.Nullable<double> value);
        partial void OnTOTEAChanged();
    
        /// <summary>
        /// There are no comments for QT_FACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> QT_FACT
        {
            get
            {
                global::System.Nullable<double> value = _QT_FACT;
                OnGetQT_FACT(ref value);
                return value;
            }
            set
            {
                if (_QT_FACT != value)
                {
                  OnQT_FACTChanging(ref value);
                  ReportPropertyChanging("QT_FACT");
                  _QT_FACT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QT_FACT");
                  OnQT_FACTChanged();
              }
            }
        }
        private global::System.Nullable<double> _QT_FACT;
        partial void OnGetQT_FACT(ref global::System.Nullable<double> value);
        partial void OnQT_FACTChanging(ref global::System.Nullable<double> value);
        partial void OnQT_FACTChanged();
    
        /// <summary>
        /// There are no comments for VL_FACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> VL_FACT
        {
            get
            {
                global::System.Nullable<double> value = _VL_FACT;
                OnGetVL_FACT(ref value);
                return value;
            }
            set
            {
                if (_VL_FACT != value)
                {
                  OnVL_FACTChanging(ref value);
                  ReportPropertyChanging("VL_FACT");
                  _VL_FACT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_FACT");
                  OnVL_FACTChanged();
              }
            }
        }
        private global::System.Nullable<double> _VL_FACT;
        partial void OnGetVL_FACT(ref global::System.Nullable<double> value);
        partial void OnVL_FACTChanging(ref global::System.Nullable<double> value);
        partial void OnVL_FACTChanged();
    
        /// <summary>
        /// There are no comments for DATAFIM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATAFIM
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATAFIM;
                OnGetDATAFIM(ref value);
                return value;
            }
            set
            {
                if (_DATAFIM != value)
                {
                  OnDATAFIMChanging(ref value);
                  ReportPropertyChanging("DATAFIM");
                  _DATAFIM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATAFIM");
                  OnDATAFIMChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATAFIM;
        partial void OnGetDATAFIM(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAFIMChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAFIMChanged();
    
        /// <summary>
        /// There are no comments for VL_CIND in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> VL_CIND
        {
            get
            {
                global::System.Nullable<double> value = _VL_CIND;
                OnGetVL_CIND(ref value);
                return value;
            }
            set
            {
                if (_VL_CIND != value)
                {
                  OnVL_CINDChanging(ref value);
                  ReportPropertyChanging("VL_CIND");
                  _VL_CIND = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_CIND");
                  OnVL_CINDChanged();
              }
            }
        }
        private global::System.Nullable<double> _VL_CIND;
        partial void OnGetVL_CIND(ref global::System.Nullable<double> value);
        partial void OnVL_CINDChanging(ref global::System.Nullable<double> value);
        partial void OnVL_CINDChanged();
    
        /// <summary>
        /// There are no comments for VL_CIND_R in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> VL_CIND_R
        {
            get
            {
                global::System.Nullable<float> value = _VL_CIND_R;
                OnGetVL_CIND_R(ref value);
                return value;
            }
            set
            {
                if (_VL_CIND_R != value)
                {
                  OnVL_CIND_RChanging(ref value);
                  ReportPropertyChanging("VL_CIND_R");
                  _VL_CIND_R = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_CIND_R");
                  OnVL_CIND_RChanged();
              }
            }
        }
        private global::System.Nullable<float> _VL_CIND_R;
        partial void OnGetVL_CIND_R(ref global::System.Nullable<float> value);
        partial void OnVL_CIND_RChanging(ref global::System.Nullable<float> value);
        partial void OnVL_CIND_RChanged();
    
        /// <summary>
        /// There are no comments for VL_TMP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> VL_TMP
        {
            get
            {
                global::System.Nullable<float> value = _VL_TMP;
                OnGetVL_TMP(ref value);
                return value;
            }
            set
            {
                if (_VL_TMP != value)
                {
                  OnVL_TMPChanging(ref value);
                  ReportPropertyChanging("VL_TMP");
                  _VL_TMP = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_TMP");
                  OnVL_TMPChanged();
              }
            }
        }
        private global::System.Nullable<float> _VL_TMP;
        partial void OnGetVL_TMP(ref global::System.Nullable<float> value);
        partial void OnVL_TMPChanging(ref global::System.Nullable<float> value);
        partial void OnVL_TMPChanged();
    
        /// <summary>
        /// There are no comments for VL_MP_R in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> VL_MP_R
        {
            get
            {
                global::System.Nullable<float> value = _VL_MP_R;
                OnGetVL_MP_R(ref value);
                return value;
            }
            set
            {
                if (_VL_MP_R != value)
                {
                  OnVL_MP_RChanging(ref value);
                  ReportPropertyChanging("VL_MP_R");
                  _VL_MP_R = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_MP_R");
                  OnVL_MP_RChanged();
              }
            }
        }
        private global::System.Nullable<float> _VL_MP_R;
        partial void OnGetVL_MP_R(ref global::System.Nullable<float> value);
        partial void OnVL_MP_RChanging(ref global::System.Nullable<float> value);
        partial void OnVL_MP_RChanged();
    
        /// <summary>
        /// There are no comments for VL_TMO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> VL_TMO
        {
            get
            {
                global::System.Nullable<float> value = _VL_TMO;
                OnGetVL_TMO(ref value);
                return value;
            }
            set
            {
                if (_VL_TMO != value)
                {
                  OnVL_TMOChanging(ref value);
                  ReportPropertyChanging("VL_TMO");
                  _VL_TMO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_TMO");
                  OnVL_TMOChanged();
              }
            }
        }
        private global::System.Nullable<float> _VL_TMO;
        partial void OnGetVL_TMO(ref global::System.Nullable<float> value);
        partial void OnVL_TMOChanging(ref global::System.Nullable<float> value);
        partial void OnVL_TMOChanged();
    
        /// <summary>
        /// There are no comments for VL_TMO_R in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> VL_TMO_R
        {
            get
            {
                global::System.Nullable<float> value = _VL_TMO_R;
                OnGetVL_TMO_R(ref value);
                return value;
            }
            set
            {
                if (_VL_TMO_R != value)
                {
                  OnVL_TMO_RChanging(ref value);
                  ReportPropertyChanging("VL_TMO_R");
                  _VL_TMO_R = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_TMO_R");
                  OnVL_TMO_RChanged();
              }
            }
        }
        private global::System.Nullable<float> _VL_TMO_R;
        partial void OnGetVL_TMO_R(ref global::System.Nullable<float> value);
        partial void OnVL_TMO_RChanging(ref global::System.Nullable<float> value);
        partial void OnVL_TMO_RChanged();
    
        /// <summary>
        /// There are no comments for VL_TMO_R_I in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> VL_TMO_R_I
        {
            get
            {
                global::System.Nullable<float> value = _VL_TMO_R_I;
                OnGetVL_TMO_R_I(ref value);
                return value;
            }
            set
            {
                if (_VL_TMO_R_I != value)
                {
                  OnVL_TMO_R_IChanging(ref value);
                  ReportPropertyChanging("VL_TMO_R_I");
                  _VL_TMO_R_I = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_TMO_R_I");
                  OnVL_TMO_R_IChanged();
              }
            }
        }
        private global::System.Nullable<float> _VL_TMO_R_I;
        partial void OnGetVL_TMO_R_I(ref global::System.Nullable<float> value);
        partial void OnVL_TMO_R_IChanging(ref global::System.Nullable<float> value);
        partial void OnVL_TMO_R_IChanged();
    
        /// <summary>
        /// There are no comments for VL_TMO_R_E in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> VL_TMO_R_E
        {
            get
            {
                global::System.Nullable<float> value = _VL_TMO_R_E;
                OnGetVL_TMO_R_E(ref value);
                return value;
            }
            set
            {
                if (_VL_TMO_R_E != value)
                {
                  OnVL_TMO_R_EChanging(ref value);
                  ReportPropertyChanging("VL_TMO_R_E");
                  _VL_TMO_R_E = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_TMO_R_E");
                  OnVL_TMO_R_EChanged();
              }
            }
        }
        private global::System.Nullable<float> _VL_TMO_R_E;
        partial void OnGetVL_TMO_R_E(ref global::System.Nullable<float> value);
        partial void OnVL_TMO_R_EChanging(ref global::System.Nullable<float> value);
        partial void OnVL_TMO_R_EChanged();
    
        /// <summary>
        /// There are no comments for VL_GGF in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> VL_GGF
        {
            get
            {
                global::System.Nullable<double> value = _VL_GGF;
                OnGetVL_GGF(ref value);
                return value;
            }
            set
            {
                if (_VL_GGF != value)
                {
                  OnVL_GGFChanging(ref value);
                  ReportPropertyChanging("VL_GGF");
                  _VL_GGF = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_GGF");
                  OnVL_GGFChanged();
              }
            }
        }
        private global::System.Nullable<double> _VL_GGF;
        partial void OnGetVL_GGF(ref global::System.Nullable<double> value);
        partial void OnVL_GGFChanging(ref global::System.Nullable<double> value);
        partial void OnVL_GGFChanged();
    
        /// <summary>
        /// There are no comments for VL_GGF_R in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> VL_GGF_R
        {
            get
            {
                global::System.Nullable<float> value = _VL_GGF_R;
                OnGetVL_GGF_R(ref value);
                return value;
            }
            set
            {
                if (_VL_GGF_R != value)
                {
                  OnVL_GGF_RChanging(ref value);
                  ReportPropertyChanging("VL_GGF_R");
                  _VL_GGF_R = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_GGF_R");
                  OnVL_GGF_RChanged();
              }
            }
        }
        private global::System.Nullable<float> _VL_GGF_R;
        partial void OnGetVL_GGF_R(ref global::System.Nullable<float> value);
        partial void OnVL_GGF_RChanging(ref global::System.Nullable<float> value);
        partial void OnVL_GGF_RChanged();
    
        /// <summary>
        /// There are no comments for VALOR_REAL_MS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> VALOR_REAL_MS
        {
            get
            {
                global::System.Nullable<double> value = _VALOR_REAL_MS;
                OnGetVALOR_REAL_MS(ref value);
                return value;
            }
            set
            {
                if (_VALOR_REAL_MS != value)
                {
                  OnVALOR_REAL_MSChanging(ref value);
                  ReportPropertyChanging("VALOR_REAL_MS");
                  _VALOR_REAL_MS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VALOR_REAL_MS");
                  OnVALOR_REAL_MSChanged();
              }
            }
        }
        private global::System.Nullable<double> _VALOR_REAL_MS;
        partial void OnGetVALOR_REAL_MS(ref global::System.Nullable<double> value);
        partial void OnVALOR_REAL_MSChanging(ref global::System.Nullable<double> value);
        partial void OnVALOR_REAL_MSChanged();
    
        /// <summary>
        /// There are no comments for GGF_REAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> GGF_REAL
        {
            get
            {
                global::System.Nullable<double> value = _GGF_REAL;
                OnGetGGF_REAL(ref value);
                return value;
            }
            set
            {
                if (_GGF_REAL != value)
                {
                  OnGGF_REALChanging(ref value);
                  ReportPropertyChanging("GGF_REAL");
                  _GGF_REAL = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("GGF_REAL");
                  OnGGF_REALChanged();
              }
            }
        }
        private global::System.Nullable<double> _GGF_REAL;
        partial void OnGetGGF_REAL(ref global::System.Nullable<double> value);
        partial void OnGGF_REALChanging(ref global::System.Nullable<double> value);
        partial void OnGGF_REALChanged();
    
        /// <summary>
        /// There are no comments for AMO_REAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> AMO_REAL
        {
            get
            {
                global::System.Nullable<double> value = _AMO_REAL;
                OnGetAMO_REAL(ref value);
                return value;
            }
            set
            {
                if (_AMO_REAL != value)
                {
                  OnAMO_REALChanging(ref value);
                  ReportPropertyChanging("AMO_REAL");
                  _AMO_REAL = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("AMO_REAL");
                  OnAMO_REALChanged();
              }
            }
        }
        private global::System.Nullable<double> _AMO_REAL;
        partial void OnGetAMO_REAL(ref global::System.Nullable<double> value);
        partial void OnAMO_REALChanging(ref global::System.Nullable<double> value);
        partial void OnAMO_REALChanged();
    
        /// <summary>
        /// There are no comments for VL_AMORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> VL_AMORT
        {
            get
            {
                global::System.Nullable<double> value = _VL_AMORT;
                OnGetVL_AMORT(ref value);
                return value;
            }
            set
            {
                if (_VL_AMORT != value)
                {
                  OnVL_AMORTChanging(ref value);
                  ReportPropertyChanging("VL_AMORT");
                  _VL_AMORT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_AMORT");
                  OnVL_AMORTChanged();
              }
            }
        }
        private global::System.Nullable<double> _VL_AMORT;
        partial void OnGetVL_AMORT(ref global::System.Nullable<double> value);
        partial void OnVL_AMORTChanging(ref global::System.Nullable<double> value);
        partial void OnVL_AMORTChanged();
    
        /// <summary>
        /// There are no comments for VL_AMORT_R in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<double> VL_AMORT_R
        {
            get
            {
                global::System.Nullable<double> value = _VL_AMORT_R;
                OnGetVL_AMORT_R(ref value);
                return value;
            }
            set
            {
                if (_VL_AMORT_R != value)
                {
                  OnVL_AMORT_RChanging(ref value);
                  ReportPropertyChanging("VL_AMORT_R");
                  _VL_AMORT_R = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VL_AMORT_R");
                  OnVL_AMORT_RChanged();
              }
            }
        }
        private global::System.Nullable<double> _VL_AMORT_R;
        partial void OnGetVL_AMORT_R(ref global::System.Nullable<double> value);
        partial void OnVL_AMORT_RChanging(ref global::System.Nullable<double> value);
        partial void OnVL_AMORT_RChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WK_ORCR_EST obj = new WK_ORCR_EST();
            obj.ESTACAO = ESTACAO;
            obj.MODELO = MODELO;
            obj.VARIANTE = VARIANTE;
            obj.COR = COR;
            obj.FAMILIA = FAMILIA;
            obj.MARCA = MARCA;
            obj.LINHA = LINHA;
            obj.IMAGEM = IMAGEM;
            obj.TQT = TQT;
            obj.VL_ENCO = VL_ENCO;
            obj.TOTEA = TOTEA;
            obj.QT_FACT = QT_FACT;
            obj.VL_FACT = VL_FACT;
            obj.DATAFIM = DATAFIM;
            obj.VL_CIND = VL_CIND;
            obj.VL_CIND_R = VL_CIND_R;
            obj.VL_TMP = VL_TMP;
            obj.VL_MP_R = VL_MP_R;
            obj.VL_TMO = VL_TMO;
            obj.VL_TMO_R = VL_TMO_R;
            obj.VL_TMO_R_I = VL_TMO_R_I;
            obj.VL_TMO_R_E = VL_TMO_R_E;
            obj.VL_GGF = VL_GGF;
            obj.VL_GGF_R = VL_GGF_R;
            obj.VALOR_REAL_MS = VALOR_REAL_MS;
            obj.GGF_REAL = GGF_REAL;
            obj.AMO_REAL = AMO_REAL;
            obj.VL_AMORT = VL_AMORT;
            obj.VL_AMORT_R = VL_AMORT_R;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WK_ORCR_EST toCompare = obj as WK_ORCR_EST;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ESTACAO, toCompare.ESTACAO))
            return false;
          if (!Object.Equals(this.MODELO, toCompare.MODELO))
            return false;
          if (!Object.Equals(this.VARIANTE, toCompare.VARIANTE))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ESTACAO.GetHashCode();
          hashCode = (hashCode * 7) + MODELO.GetHashCode();
          hashCode = (hashCode * 7) + VARIANTE.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}