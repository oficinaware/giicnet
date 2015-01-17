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
    /// There are no comments for DataGiic_LiagoModel.WKFATL in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// TPDOC
    /// NRFACT
    /// LNFACT
    /// ITAM
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WKFATL")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WKFATL : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WKFATL object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="tPDOC">Initial value of TPDOC.</param>
        /// <param name="nRFACT">Initial value of NRFACT.</param>
        /// <param name="lNFACT">Initial value of LNFACT.</param>
        /// <param name="iTAM">Initial value of ITAM.</param>
        public static WKFATL CreateWKFATL(int sPID, string tPDOC, int nRFACT, int lNFACT, short iTAM)
        {
            WKFATL wKFATL = new WKFATL();
            wKFATL.SPID = sPID;
            wKFATL.TPDOC = tPDOC;
            wKFATL.NRFACT = nRFACT;
            wKFATL.LNFACT = lNFACT;
            wKFATL.ITAM = iTAM;
            return wKFATL;
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
        /// There are no comments for TPDOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TPDOC
        {
            get
            {
                string value = _TPDOC;
                OnGetTPDOC(ref value);
                return value;
            }
            set
            {
                if (_TPDOC != value)
                {
                  OnTPDOCChanging(ref value);
                  ReportPropertyChanging("TPDOC");
                  _TPDOC = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TPDOC");
                  OnTPDOCChanged();
              }
            }
        }
        private string _TPDOC;
        partial void OnGetTPDOC(ref string value);
        partial void OnTPDOCChanging(ref string value);
        partial void OnTPDOCChanged();
    
        /// <summary>
        /// There are no comments for NRFACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int NRFACT
        {
            get
            {
                int value = _NRFACT;
                OnGetNRFACT(ref value);
                return value;
            }
            set
            {
                if (_NRFACT != value)
                {
                  OnNRFACTChanging(ref value);
                  ReportPropertyChanging("NRFACT");
                  _NRFACT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRFACT");
                  OnNRFACTChanged();
              }
            }
        }
        private int _NRFACT;
        partial void OnGetNRFACT(ref int value);
        partial void OnNRFACTChanging(ref int value);
        partial void OnNRFACTChanged();
    
        /// <summary>
        /// There are no comments for LNFACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LNFACT
        {
            get
            {
                int value = _LNFACT;
                OnGetLNFACT(ref value);
                return value;
            }
            set
            {
                if (_LNFACT != value)
                {
                  OnLNFACTChanging(ref value);
                  ReportPropertyChanging("LNFACT");
                  _LNFACT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNFACT");
                  OnLNFACTChanged();
              }
            }
        }
        private int _LNFACT;
        partial void OnGetLNFACT(ref int value);
        partial void OnLNFACTChanging(ref int value);
        partial void OnLNFACTChanged();
    
        /// <summary>
        /// There are no comments for ITAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public short ITAM
        {
            get
            {
                short value = _ITAM;
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
        private short _ITAM;
        partial void OnGetITAM(ref short value);
        partial void OnITAMChanging(ref short value);
        partial void OnITAMChanged();
    
        /// <summary>
        /// There are no comments for SERIE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string SERIE
        {
            get
            {
                string value = _SERIE;
                OnGetSERIE(ref value);
                return value;
            }
            set
            {
                if (_SERIE != value)
                {
                  OnSERIEChanging(ref value);
                  ReportPropertyChanging("SERIE");
                  _SERIE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("SERIE");
                  OnSERIEChanged();
              }
            }
        }
        private string _SERIE;
        partial void OnGetSERIE(ref string value);
        partial void OnSERIEChanging(ref string value);
        partial void OnSERIEChanged();
    
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
        /// There are no comments for ARMD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string ARMD
        {
            get
            {
                string value = _ARMD;
                OnGetARMD(ref value);
                return value;
            }
            set
            {
                if (_ARMD != value)
                {
                  OnARMDChanging(ref value);
                  ReportPropertyChanging("ARMD");
                  _ARMD = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ARMD");
                  OnARMDChanged();
              }
            }
        }
        private string _ARMD;
        partial void OnGetARMD(ref string value);
        partial void OnARMDChanging(ref string value);
        partial void OnARMDChanged();
    
        /// <summary>
        /// There are no comments for TIPO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string TIPO
        {
            get
            {
                string value = _TIPO;
                OnGetTIPO(ref value);
                return value;
            }
            set
            {
                if (_TIPO != value)
                {
                  OnTIPOChanging(ref value);
                  ReportPropertyChanging("TIPO");
                  _TIPO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TIPO");
                  OnTIPOChanged();
              }
            }
        }
        private string _TIPO;
        partial void OnGetTIPO(ref string value);
        partial void OnTIPOChanging(ref string value);
        partial void OnTIPOChanged();
    
        /// <summary>
        /// There are no comments for TIPODOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string TIPODOC
        {
            get
            {
                string value = _TIPODOC;
                OnGetTIPODOC(ref value);
                return value;
            }
            set
            {
                if (_TIPODOC != value)
                {
                  OnTIPODOCChanging(ref value);
                  ReportPropertyChanging("TIPODOC");
                  _TIPODOC = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TIPODOC");
                  OnTIPODOCChanged();
              }
            }
        }
        private string _TIPODOC;
        partial void OnGetTIPODOC(ref string value);
        partial void OnTIPODOCChanging(ref string value);
        partial void OnTIPODOCChanged();
    
        /// <summary>
        /// There are no comments for SERIEDOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string SERIEDOC
        {
            get
            {
                string value = _SERIEDOC;
                OnGetSERIEDOC(ref value);
                return value;
            }
            set
            {
                if (_SERIEDOC != value)
                {
                  OnSERIEDOCChanging(ref value);
                  ReportPropertyChanging("SERIEDOC");
                  _SERIEDOC = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("SERIEDOC");
                  OnSERIEDOCChanged();
              }
            }
        }
        private string _SERIEDOC;
        partial void OnGetSERIEDOC(ref string value);
        partial void OnSERIEDOCChanging(ref string value);
        partial void OnSERIEDOCChanged();
    
        /// <summary>
        /// There are no comments for NRDOC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NRDOC
        {
            get
            {
                global::System.Nullable<int> value = _NRDOC;
                OnGetNRDOC(ref value);
                return value;
            }
            set
            {
                if (_NRDOC != value)
                {
                  OnNRDOCChanging(ref value);
                  ReportPropertyChanging("NRDOC");
                  _NRDOC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRDOC");
                  OnNRDOCChanged();
              }
            }
        }
        private global::System.Nullable<int> _NRDOC;
        partial void OnGetNRDOC(ref global::System.Nullable<int> value);
        partial void OnNRDOCChanging(ref global::System.Nullable<int> value);
        partial void OnNRDOCChanged();
    
        /// <summary>
        /// There are no comments for MODELO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
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
                  _MODELO = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
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
                  _VARIANTE = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for ENCOCLI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string ENCOCLI
        {
            get
            {
                string value = _ENCOCLI;
                OnGetENCOCLI(ref value);
                return value;
            }
            set
            {
                if (_ENCOCLI != value)
                {
                  OnENCOCLIChanging(ref value);
                  ReportPropertyChanging("ENCOCLI");
                  _ENCOCLI = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ENCOCLI");
                  OnENCOCLIChanged();
              }
            }
        }
        private string _ENCOCLI;
        partial void OnGetENCOCLI(ref string value);
        partial void OnENCOCLIChanging(ref string value);
        partial void OnENCOCLIChanged();
    
        /// <summary>
        /// There are no comments for REFCLI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string REFCLI
        {
            get
            {
                string value = _REFCLI;
                OnGetREFCLI(ref value);
                return value;
            }
            set
            {
                if (_REFCLI != value)
                {
                  OnREFCLIChanging(ref value);
                  ReportPropertyChanging("REFCLI");
                  _REFCLI = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("REFCLI");
                  OnREFCLIChanged();
              }
            }
        }
        private string _REFCLI;
        partial void OnGetREFCLI(ref string value);
        partial void OnREFCLIChanging(ref string value);
        partial void OnREFCLIChanged();
    
        /// <summary>
        /// There are no comments for CLIDESP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string CLIDESP
        {
            get
            {
                string value = _CLIDESP;
                OnGetCLIDESP(ref value);
                return value;
            }
            set
            {
                if (_CLIDESP != value)
                {
                  OnCLIDESPChanging(ref value);
                  ReportPropertyChanging("CLIDESP");
                  _CLIDESP = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CLIDESP");
                  OnCLIDESPChanged();
              }
            }
        }
        private string _CLIDESP;
        partial void OnGetCLIDESP(ref string value);
        partial void OnCLIDESPChanging(ref string value);
        partial void OnCLIDESPChanged();
    
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
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string DESCRICAO
        {
            get
            {
                string value = _DESCRICAO;
                OnGetDESCRICAO(ref value);
                return value;
            }
            set
            {
                if (_DESCRICAO != value)
                {
                  OnDESCRICAOChanging(ref value);
                  ReportPropertyChanging("DESCRICAO");
                  _DESCRICAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DESCRICAO");
                  OnDESCRICAOChanged();
              }
            }
        }
        private string _DESCRICAO;
        partial void OnGetDESCRICAO(ref string value);
        partial void OnDESCRICAOChanging(ref string value);
        partial void OnDESCRICAOChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string DESCRICAO2
        {
            get
            {
                string value = _DESCRICAO2;
                OnGetDESCRICAO2(ref value);
                return value;
            }
            set
            {
                if (_DESCRICAO2 != value)
                {
                  OnDESCRICAO2Changing(ref value);
                  ReportPropertyChanging("DESCRICAO2");
                  _DESCRICAO2 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DESCRICAO2");
                  OnDESCRICAO2Changed();
              }
            }
        }
        private string _DESCRICAO2;
        partial void OnGetDESCRICAO2(ref string value);
        partial void OnDESCRICAO2Changing(ref string value);
        partial void OnDESCRICAO2Changed();
    
        /// <summary>
        /// There are no comments for UNMED in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string UNMED
        {
            get
            {
                string value = _UNMED;
                OnGetUNMED(ref value);
                return value;
            }
            set
            {
                if (_UNMED != value)
                {
                  OnUNMEDChanging(ref value);
                  ReportPropertyChanging("UNMED");
                  _UNMED = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("UNMED");
                  OnUNMEDChanged();
              }
            }
        }
        private string _UNMED;
        partial void OnGetUNMED(ref string value);
        partial void OnUNMEDChanging(ref string value);
        partial void OnUNMEDChanged();
    
        /// <summary>
        /// There are no comments for QT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QT
        {
            get
            {
                global::System.Nullable<int> value = _QT;
                OnGetQT(ref value);
                return value;
            }
            set
            {
                if (_QT != value)
                {
                  OnQTChanging(ref value);
                  ReportPropertyChanging("QT");
                  _QT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QT");
                  OnQTChanged();
              }
            }
        }
        private global::System.Nullable<int> _QT;
        partial void OnGetQT(ref global::System.Nullable<int> value);
        partial void OnQTChanging(ref global::System.Nullable<int> value);
        partial void OnQTChanged();
    
        /// <summary>
        /// There are no comments for QTFALTA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QTFALTA
        {
            get
            {
                global::System.Nullable<int> value = _QTFALTA;
                OnGetQTFALTA(ref value);
                return value;
            }
            set
            {
                if (_QTFALTA != value)
                {
                  OnQTFALTAChanging(ref value);
                  ReportPropertyChanging("QTFALTA");
                  _QTFALTA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTFALTA");
                  OnQTFALTAChanged();
              }
            }
        }
        private global::System.Nullable<int> _QTFALTA;
        partial void OnGetQTFALTA(ref global::System.Nullable<int> value);
        partial void OnQTFALTAChanging(ref global::System.Nullable<int> value);
        partial void OnQTFALTAChanged();
    
        /// <summary>
        /// There are no comments for TABP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string TABP
        {
            get
            {
                string value = _TABP;
                OnGetTABP(ref value);
                return value;
            }
            set
            {
                if (_TABP != value)
                {
                  OnTABPChanging(ref value);
                  ReportPropertyChanging("TABP");
                  _TABP = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TABP");
                  OnTABPChanged();
              }
            }
        }
        private string _TABP;
        partial void OnGetTABP(ref string value);
        partial void OnTABPChanging(ref string value);
        partial void OnTABPChanged();
    
        /// <summary>
        /// There are no comments for PRECO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> PRECO
        {
            get
            {
                global::System.Nullable<decimal> value = _PRECO;
                OnGetPRECO(ref value);
                return value;
            }
            set
            {
                if (_PRECO != value)
                {
                  OnPRECOChanging(ref value);
                  ReportPropertyChanging("PRECO");
                  _PRECO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRECO");
                  OnPRECOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _PRECO;
        partial void OnGetPRECO(ref global::System.Nullable<decimal> value);
        partial void OnPRECOChanging(ref global::System.Nullable<decimal> value);
        partial void OnPRECOChanged();
    
        /// <summary>
        /// There are no comments for DESCL1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> DESCL1
        {
            get
            {
                global::System.Nullable<decimal> value = _DESCL1;
                OnGetDESCL1(ref value);
                return value;
            }
            set
            {
                if (_DESCL1 != value)
                {
                  OnDESCL1Changing(ref value);
                  ReportPropertyChanging("DESCL1");
                  _DESCL1 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DESCL1");
                  OnDESCL1Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _DESCL1;
        partial void OnGetDESCL1(ref global::System.Nullable<decimal> value);
        partial void OnDESCL1Changing(ref global::System.Nullable<decimal> value);
        partial void OnDESCL1Changed();
    
        /// <summary>
        /// There are no comments for DESCL2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> DESCL2
        {
            get
            {
                global::System.Nullable<decimal> value = _DESCL2;
                OnGetDESCL2(ref value);
                return value;
            }
            set
            {
                if (_DESCL2 != value)
                {
                  OnDESCL2Changing(ref value);
                  ReportPropertyChanging("DESCL2");
                  _DESCL2 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DESCL2");
                  OnDESCL2Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _DESCL2;
        partial void OnGetDESCL2(ref global::System.Nullable<decimal> value);
        partial void OnDESCL2Changing(ref global::System.Nullable<decimal> value);
        partial void OnDESCL2Changed();
    
        /// <summary>
        /// There are no comments for CCUSTO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public string CCUSTO
        {
            get
            {
                string value = _CCUSTO;
                OnGetCCUSTO(ref value);
                return value;
            }
            set
            {
                if (_CCUSTO != value)
                {
                  OnCCUSTOChanging(ref value);
                  ReportPropertyChanging("CCUSTO");
                  _CCUSTO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CCUSTO");
                  OnCCUSTOChanged();
              }
            }
        }
        private string _CCUSTO;
        partial void OnGetCCUSTO(ref string value);
        partial void OnCCUSTOChanging(ref string value);
        partial void OnCCUSTOChanged();
    
        /// <summary>
        /// There are no comments for NRENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
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
                  _NRENCO = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNENCO
        {
            get
            {
                global::System.Nullable<int> value = _LNENCO;
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
        private global::System.Nullable<int> _LNENCO;
        partial void OnGetLNENCO(ref global::System.Nullable<int> value);
        partial void OnLNENCOChanging(ref global::System.Nullable<int> value);
        partial void OnLNENCOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WKFATL obj = new WKFATL();
            obj.SPID = SPID;
            obj.TPDOC = TPDOC;
            obj.NRFACT = NRFACT;
            obj.LNFACT = LNFACT;
            obj.ITAM = ITAM;
            obj.SERIE = SERIE;
            obj.ARM = ARM;
            obj.ARMD = ARMD;
            obj.TIPO = TIPO;
            obj.TIPODOC = TIPODOC;
            obj.SERIEDOC = SERIEDOC;
            obj.NRDOC = NRDOC;
            obj.MODELO = MODELO;
            obj.VARIANTE = VARIANTE;
            obj.ENCOCLI = ENCOCLI;
            obj.REFCLI = REFCLI;
            obj.CLIDESP = CLIDESP;
            obj.TAM = TAM;
            obj.DESCRICAO = DESCRICAO;
            obj.DESCRICAO2 = DESCRICAO2;
            obj.UNMED = UNMED;
            obj.QT = QT;
            obj.QTFALTA = QTFALTA;
            obj.TABP = TABP;
            obj.PRECO = PRECO;
            obj.DESCL1 = DESCL1;
            obj.DESCL2 = DESCL2;
            obj.CCUSTO = CCUSTO;
            obj.NRENCO = NRENCO;
            obj.LNENCO = LNENCO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WKFATL toCompare = obj as WKFATL;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          if (!Object.Equals(this.TPDOC, toCompare.TPDOC))
            return false;
          if (!Object.Equals(this.NRFACT, toCompare.NRFACT))
            return false;
          if (!Object.Equals(this.LNFACT, toCompare.LNFACT))
            return false;
          if (!Object.Equals(this.ITAM, toCompare.ITAM))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + TPDOC.GetHashCode();
          hashCode = (hashCode * 7) + NRFACT.GetHashCode();
          hashCode = (hashCode * 7) + LNFACT.GetHashCode();
          hashCode = (hashCode * 7) + ITAM.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
