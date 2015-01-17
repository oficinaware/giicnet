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
    /// There are no comments for DataGiic_LiagoModel.mrp_sugoc in the schema.
    /// </summary>
    /// <KeyProperties>
    /// COD
    /// NRENCO
    /// LNENCO
    /// SEQNEC
    /// NRREG
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="mrp_sugoc")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class mrp_sugoc : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new mrp_sugoc object.
        /// </summary>
        /// <param name="cOD">Initial value of COD.</param>
        /// <param name="nRENCO">Initial value of NRENCO.</param>
        /// <param name="lNENCO">Initial value of LNENCO.</param>
        /// <param name="sEQNEC">Initial value of SEQNEC.</param>
        /// <param name="nRREG">Initial value of NRREG.</param>
        public static mrp_sugoc Createmrp_sugoc(string cOD, string nRENCO, int lNENCO, int sEQNEC, global::System.Guid nRREG)
        {
            mrp_sugoc mrp_sugoc = new mrp_sugoc();
            mrp_sugoc.COD = cOD;
            mrp_sugoc.NRENCO = nRENCO;
            mrp_sugoc.LNENCO = lNENCO;
            mrp_sugoc.SEQNEC = sEQNEC;
            mrp_sugoc.NRREG = nRREG;
            return mrp_sugoc;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for COD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string COD
        {
            get
            {
                string value = _COD;
                OnGetCOD(ref value);
                return value;
            }
            set
            {
                if (_COD != value)
                {
                  OnCODChanging(ref value);
                  ReportPropertyChanging("COD");
                  _COD = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("COD");
                  OnCODChanged();
              }
            }
        }
        private string _COD;
        partial void OnGetCOD(ref string value);
        partial void OnCODChanging(ref string value);
        partial void OnCODChanged();
    
        /// <summary>
        /// There are no comments for NRENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string NRENCO
        {
            get
            {
                string value = _NRENCO;
                OnGetNRENCO(ref value);
                return value;
            }
            set
            {
                if (_NRENCO != value)
                {
                  OnNRENCOChanging(ref value);
                  ReportPropertyChanging("NRENCO");
                  _NRENCO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("NRENCO");
                  OnNRENCOChanged();
              }
            }
        }
        private string _NRENCO;
        partial void OnGetNRENCO(ref string value);
        partial void OnNRENCOChanging(ref string value);
        partial void OnNRENCOChanged();
    
        /// <summary>
        /// There are no comments for LNENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LNENCO
        {
            get
            {
                int value = _LNENCO;
                OnGetLNENCO(ref value);
                return value;
            }
            set
            {
                if (_LNENCO != value)
                {
                  OnLNENCOChanging(ref value);
                  ReportPropertyChanging("LNENCO");
                  _LNENCO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNENCO");
                  OnLNENCOChanged();
              }
            }
        }
        private int _LNENCO;
        partial void OnGetLNENCO(ref int value);
        partial void OnLNENCOChanging(ref int value);
        partial void OnLNENCOChanged();
    
        /// <summary>
        /// There are no comments for SEQNEC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int SEQNEC
        {
            get
            {
                int value = _SEQNEC;
                OnGetSEQNEC(ref value);
                return value;
            }
            set
            {
                if (_SEQNEC != value)
                {
                  OnSEQNECChanging(ref value);
                  ReportPropertyChanging("SEQNEC");
                  _SEQNEC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SEQNEC");
                  OnSEQNECChanged();
              }
            }
        }
        private int _SEQNEC;
        partial void OnGetSEQNEC(ref int value);
        partial void OnSEQNECChanging(ref int value);
        partial void OnSEQNECChanged();
    
        /// <summary>
        /// There are no comments for NRREG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.Guid NRREG
        {
            get
            {
                global::System.Guid value = _NRREG;
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
        private global::System.Guid _NRREG;
        partial void OnGetNRREG(ref global::System.Guid value);
        partial void OnNRREGChanging(ref global::System.Guid value);
        partial void OnNRREGChanged();
    
        /// <summary>
        /// There are no comments for ARM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
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
                  _ARM = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for ARTIGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
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
                  _ARTIGO = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
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
                  _CARTAZ = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CARTAZ");
                  OnCARTAZChanged();
              }
            }
        }
        private string _CARTAZ;
        partial void OnGetCARTAZ(ref string value);
        partial void OnCARTAZChanging(ref string value);
        partial void OnCARTAZChanged();
    
        /// <summary>
        /// There are no comments for CODCOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
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
                  _CODCOR = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CODCOR");
                  OnCODCORChanged();
              }
            }
        }
        private string _CODCOR;
        partial void OnGetCODCOR(ref string value);
        partial void OnCODCORChanging(ref string value);
        partial void OnCODCORChanged();
    
        /// <summary>
        /// There are no comments for ITAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<short> ITAM
        {
            get
            {
                global::System.Nullable<short> value = _ITAM;
                OnGetITAM(ref value);
                return value;
            }
            set
            {
                if (_ITAM != value)
                {
                  OnITAMChanging(ref value);
                  ReportPropertyChanging("ITAM");
                  _ITAM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ITAM");
                  OnITAMChanged();
              }
            }
        }
        private global::System.Nullable<short> _ITAM;
        partial void OnGetITAM(ref global::System.Nullable<short> value);
        partial void OnITAMChanging(ref global::System.Nullable<short> value);
        partial void OnITAMChanged();
    
        /// <summary>
        /// There are no comments for TAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
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
                  _TAM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TAM");
                  OnTAMChanged();
              }
            }
        }
        private string _TAM;
        partial void OnGetTAM(ref string value);
        partial void OnTAMChanging(ref string value);
        partial void OnTAMChanged();
    
        /// <summary>
        /// There are no comments for QTNEC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> QTNEC
        {
            get
            {
                global::System.Nullable<decimal> value = _QTNEC;
                OnGetQTNEC(ref value);
                return value;
            }
            set
            {
                if (_QTNEC != value)
                {
                  OnQTNECChanging(ref value);
                  ReportPropertyChanging("QTNEC");
                  _QTNEC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTNEC");
                  OnQTNECChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _QTNEC;
        partial void OnGetQTNEC(ref global::System.Nullable<decimal> value);
        partial void OnQTNECChanging(ref global::System.Nullable<decimal> value);
        partial void OnQTNECChanged();
    
        /// <summary>
        /// There are no comments for DTNEC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DTNEC
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DTNEC;
                OnGetDTNEC(ref value);
                return value;
            }
            set
            {
                if (_DTNEC != value)
                {
                  OnDTNECChanging(ref value);
                  ReportPropertyChanging("DTNEC");
                  _DTNEC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DTNEC");
                  OnDTNECChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DTNEC;
        partial void OnGetDTNEC(ref global::System.Nullable<System.DateTime> value);
        partial void OnDTNECChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDTNECChanged();
    
        /// <summary>
        /// There are no comments for TIPOOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string TIPOOC
        {
            get
            {
                string value = _TIPOOC;
                OnGetTIPOOC(ref value);
                return value;
            }
            set
            {
                if (_TIPOOC != value)
                {
                  OnTIPOOCChanging(ref value);
                  ReportPropertyChanging("TIPOOC");
                  _TIPOOC = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TIPOOC");
                  OnTIPOOCChanged();
              }
            }
        }
        private string _TIPOOC = @"N'--";
        partial void OnGetTIPOOC(ref string value);
        partial void OnTIPOOCChanging(ref string value);
        partial void OnTIPOOCChanged();
    
        /// <summary>
        /// There are no comments for DATA_EMISSAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_EMISSAO
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_EMISSAO;
                OnGetDATA_EMISSAO(ref value);
                return value;
            }
            set
            {
                if (_DATA_EMISSAO != value)
                {
                  OnDATA_EMISSAOChanging(ref value);
                  ReportPropertyChanging("DATA_EMISSAO");
                  _DATA_EMISSAO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_EMISSAO");
                  OnDATA_EMISSAOChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_EMISSAO;
        partial void OnGetDATA_EMISSAO(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_EMISSAOChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_EMISSAOChanged();
    
        /// <summary>
        /// There are no comments for DATA_ENTREGA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_ENTREGA
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_ENTREGA;
                OnGetDATA_ENTREGA(ref value);
                return value;
            }
            set
            {
                if (_DATA_ENTREGA != value)
                {
                  OnDATA_ENTREGAChanging(ref value);
                  ReportPropertyChanging("DATA_ENTREGA");
                  _DATA_ENTREGA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_ENTREGA");
                  OnDATA_ENTREGAChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_ENTREGA;
        partial void OnGetDATA_ENTREGA(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ENTREGAChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ENTREGAChanged();
    
        /// <summary>
        /// There are no comments for NROC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NROC
        {
            get
            {
                global::System.Nullable<int> value = _NROC;
                OnGetNROC(ref value);
                return value;
            }
            set
            {
                if (_NROC != value)
                {
                  OnNROCChanging(ref value);
                  ReportPropertyChanging("NROC");
                  _NROC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NROC");
                  OnNROCChanged();
              }
            }
        }
        private global::System.Nullable<int> _NROC;
        partial void OnGetNROC(ref global::System.Nullable<int> value);
        partial void OnNROCChanging(ref global::System.Nullable<int> value);
        partial void OnNROCChanged();
    
        /// <summary>
        /// There are no comments for LNOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNOC
        {
            get
            {
                global::System.Nullable<int> value = _LNOC;
                OnGetLNOC(ref value);
                return value;
            }
            set
            {
                if (_LNOC != value)
                {
                  OnLNOCChanging(ref value);
                  ReportPropertyChanging("LNOC");
                  _LNOC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNOC");
                  OnLNOCChanged();
              }
            }
        }
        private global::System.Nullable<int> _LNOC;
        partial void OnGetLNOC(ref global::System.Nullable<int> value);
        partial void OnLNOCChanging(ref global::System.Nullable<int> value);
        partial void OnLNOCChanged();
    
        /// <summary>
        /// There are no comments for CDFORN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string CDFORN
        {
            get
            {
                string value = _CDFORN;
                OnGetCDFORN(ref value);
                return value;
            }
            set
            {
                if (_CDFORN != value)
                {
                  OnCDFORNChanging(ref value);
                  ReportPropertyChanging("CDFORN");
                  _CDFORN = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CDFORN");
                  OnCDFORNChanged();
              }
            }
        }
        private string _CDFORN;
        partial void OnGetCDFORN(ref string value);
        partial void OnCDFORNChanging(ref string value);
        partial void OnCDFORNChanged();
    
        /// <summary>
        /// There are no comments for ACCAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string ACCAO
        {
            get
            {
                string value = _ACCAO;
                OnGetACCAO(ref value);
                return value;
            }
            set
            {
                if (_ACCAO != value)
                {
                  OnACCAOChanging(ref value);
                  ReportPropertyChanging("ACCAO");
                  _ACCAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ACCAO");
                  OnACCAOChanged();
              }
            }
        }
        private string _ACCAO;
        partial void OnGetACCAO(ref string value);
        partial void OnACCAOChanging(ref string value);
        partial void OnACCAOChanged();
    
        /// <summary>
        /// There are no comments for QTOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> QTOC
        {
            get
            {
                global::System.Nullable<decimal> value = _QTOC;
                OnGetQTOC(ref value);
                return value;
            }
            set
            {
                if (_QTOC != value)
                {
                  OnQTOCChanging(ref value);
                  ReportPropertyChanging("QTOC");
                  _QTOC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTOC");
                  OnQTOCChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _QTOC;
        partial void OnGetQTOC(ref global::System.Nullable<decimal> value);
        partial void OnQTOCChanging(ref global::System.Nullable<decimal> value);
        partial void OnQTOCChanged();
    
        /// <summary>
        /// There are no comments for QTST in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> QTST
        {
            get
            {
                global::System.Nullable<decimal> value = _QTST;
                OnGetQTST(ref value);
                return value;
            }
            set
            {
                if (_QTST != value)
                {
                  OnQTSTChanging(ref value);
                  ReportPropertyChanging("QTST");
                  _QTST = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTST");
                  OnQTSTChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _QTST;
        partial void OnGetQTST(ref global::System.Nullable<decimal> value);
        partial void OnQTSTChanging(ref global::System.Nullable<decimal> value);
        partial void OnQTSTChanged();
    
        /// <summary>
        /// There are no comments for QTSG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> QTSG
        {
            get
            {
                global::System.Nullable<decimal> value = _QTSG;
                OnGetQTSG(ref value);
                return value;
            }
            set
            {
                if (_QTSG != value)
                {
                  OnQTSGChanging(ref value);
                  ReportPropertyChanging("QTSG");
                  _QTSG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTSG");
                  OnQTSGChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _QTSG;
        partial void OnGetQTSG(ref global::System.Nullable<decimal> value);
        partial void OnQTSGChanging(ref global::System.Nullable<decimal> value);
        partial void OnQTSGChanged();
    
        /// <summary>
        /// There are no comments for DATA_EMISSAO_SG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_EMISSAO_SG
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_EMISSAO_SG;
                OnGetDATA_EMISSAO_SG(ref value);
                return value;
            }
            set
            {
                if (_DATA_EMISSAO_SG != value)
                {
                  OnDATA_EMISSAO_SGChanging(ref value);
                  ReportPropertyChanging("DATA_EMISSAO_SG");
                  _DATA_EMISSAO_SG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_EMISSAO_SG");
                  OnDATA_EMISSAO_SGChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_EMISSAO_SG;
        partial void OnGetDATA_EMISSAO_SG(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_EMISSAO_SGChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_EMISSAO_SGChanged();
    
        /// <summary>
        /// There are no comments for DATA_ENTREGA_SG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_ENTREGA_SG
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_ENTREGA_SG;
                OnGetDATA_ENTREGA_SG(ref value);
                return value;
            }
            set
            {
                if (_DATA_ENTREGA_SG != value)
                {
                  OnDATA_ENTREGA_SGChanging(ref value);
                  ReportPropertyChanging("DATA_ENTREGA_SG");
                  _DATA_ENTREGA_SG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_ENTREGA_SG");
                  OnDATA_ENTREGA_SGChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_ENTREGA_SG;
        partial void OnGetDATA_ENTREGA_SG(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ENTREGA_SGChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ENTREGA_SGChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            mrp_sugoc obj = new mrp_sugoc();
            obj.COD = COD;
            obj.NRENCO = NRENCO;
            obj.LNENCO = LNENCO;
            obj.SEQNEC = SEQNEC;
            obj.NRREG = NRREG;
            obj.ARM = ARM;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.ITAM = ITAM;
            obj.TAM = TAM;
            obj.QTNEC = QTNEC;
            obj.DTNEC = DTNEC;
            obj.TIPOOC = TIPOOC;
            obj.DATA_EMISSAO = DATA_EMISSAO;
            obj.DATA_ENTREGA = DATA_ENTREGA;
            obj.NROC = NROC;
            obj.LNOC = LNOC;
            obj.CDFORN = CDFORN;
            obj.ACCAO = ACCAO;
            obj.QTOC = QTOC;
            obj.QTST = QTST;
            obj.QTSG = QTSG;
            obj.DATA_EMISSAO_SG = DATA_EMISSAO_SG;
            obj.DATA_ENTREGA_SG = DATA_ENTREGA_SG;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          mrp_sugoc toCompare = obj as mrp_sugoc;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.COD, toCompare.COD))
            return false;
          if (!Object.Equals(this.NRENCO, toCompare.NRENCO))
            return false;
          if (!Object.Equals(this.LNENCO, toCompare.LNENCO))
            return false;
          if (!Object.Equals(this.SEQNEC, toCompare.SEQNEC))
            return false;
          if (!Object.Equals(this.NRREG, toCompare.NRREG))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + COD.GetHashCode();
          hashCode = (hashCode * 7) + NRENCO.GetHashCode();
          hashCode = (hashCode * 7) + LNENCO.GetHashCode();
          hashCode = (hashCode * 7) + SEQNEC.GetHashCode();
          hashCode = (hashCode * 7) + NRREG.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
