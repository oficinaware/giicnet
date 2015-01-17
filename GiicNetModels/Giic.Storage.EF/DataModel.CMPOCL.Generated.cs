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
    /// There are no comments for DataGiic_LiagoModel.CMPOCL in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LRENCO
    /// LNENCO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CMPOCL")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CMPOCL : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CMPOCL object.
        /// </summary>
        /// <param name="lRENCO">Initial value of LRENCO.</param>
        /// <param name="lNENCO">Initial value of LNENCO.</param>
        /// <param name="pRAZO">Initial value of PRAZO.</param>
        public static CMPOCL CreateCMPOCL(int lRENCO, int lNENCO, global::System.DateTime pRAZO)
        {
            CMPOCL cMPOCL = new CMPOCL();
            cMPOCL.LRENCO = lRENCO;
            cMPOCL.LNENCO = lNENCO;
            cMPOCL.PRAZO = pRAZO;
            return cMPOCL;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for LRENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int LRENCO
        {
            get
            {
                int value = _LRENCO;
                OnGetLRENCO(ref value);
                return value;
            }
            set
            {
                if (_LRENCO != value)
                {
                  OnLRENCOChanging(ref value);
                  ReportPropertyChanging("LRENCO");
                  _LRENCO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LRENCO");
                  OnLRENCOChanged();
              }
            }
        }
        private int _LRENCO;
        partial void OnGetLRENCO(ref int value);
        partial void OnLRENCOChanging(ref int value);
        partial void OnLRENCOChanged();
    
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
        /// There are no comments for MODELO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
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
        private string _CARTAZ = @"space((5))";
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
        private string _CODCOR = @"space((3))";
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
        private string _TAM = @"space((4))";
        partial void OnGetTAM(ref string value);
        partial void OnTAMChanging(ref string value);
        partial void OnTAMChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
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
        [System.ComponentModel.DataAnnotations.StringLength(45)]
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
        /// There are no comments for VUNMED in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string VUNMED
        {
            get
            {
                string value = _VUNMED;
                OnGetVUNMED(ref value);
                return value;
            }
            set
            {
                if (_VUNMED != value)
                {
                  OnVUNMEDChanging(ref value);
                  ReportPropertyChanging("VUNMED");
                  _VUNMED = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VUNMED");
                  OnVUNMEDChanged();
              }
            }
        }
        private string _VUNMED;
        partial void OnGetVUNMED(ref string value);
        partial void OnVUNMEDChanging(ref string value);
        partial void OnVUNMEDChanged();
    
        /// <summary>
        /// There are no comments for FCONV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> FCONV
        {
            get
            {
                global::System.Nullable<decimal> value = _FCONV;
                OnGetFCONV(ref value);
                return value;
            }
            set
            {
                if (_FCONV != value)
                {
                  OnFCONVChanging(ref value);
                  ReportPropertyChanging("FCONV");
                  _FCONV = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("FCONV");
                  OnFCONVChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _FCONV = 1m;
        partial void OnGetFCONV(ref global::System.Nullable<decimal> value);
        partial void OnFCONVChanging(ref global::System.Nullable<decimal> value);
        partial void OnFCONVChanged();
    
        /// <summary>
        /// There are no comments for TXIVA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> TXIVA
        {
            get
            {
                global::System.Nullable<decimal> value = _TXIVA;
                OnGetTXIVA(ref value);
                return value;
            }
            set
            {
                if (_TXIVA != value)
                {
                  OnTXIVAChanging(ref value);
                  ReportPropertyChanging("TXIVA");
                  _TXIVA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TXIVA");
                  OnTXIVAChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _TXIVA;
        partial void OnGetTXIVA(ref global::System.Nullable<decimal> value);
        partial void OnTXIVAChanging(ref global::System.Nullable<decimal> value);
        partial void OnTXIVAChanged();
    
        /// <summary>
        /// There are no comments for PRAZO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.DateTime PRAZO
        {
            get
            {
                global::System.DateTime value = _PRAZO;
                OnGetPRAZO(ref value);
                return value;
            }
            set
            {
                if (_PRAZO != value)
                {
                  OnPRAZOChanging(ref value);
                  ReportPropertyChanging("PRAZO");
                  _PRAZO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRAZO");
                  OnPRAZOChanged();
              }
            }
        }
        private global::System.DateTime _PRAZO;
        partial void OnGetPRAZO(ref global::System.DateTime value);
        partial void OnPRAZOChanging(ref global::System.DateTime value);
        partial void OnPRAZOChanged();
    
        /// <summary>
        /// There are no comments for DATAUENT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATAUENT
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATAUENT;
                OnGetDATAUENT(ref value);
                return value;
            }
            set
            {
                if (_DATAUENT != value)
                {
                  OnDATAUENTChanging(ref value);
                  ReportPropertyChanging("DATAUENT");
                  _DATAUENT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATAUENT");
                  OnDATAUENTChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATAUENT;
        partial void OnGetDATAUENT(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAUENTChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAUENTChanged();
    
        /// <summary>
        /// There are no comments for TOTAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> TOTAL
        {
            get
            {
                global::System.Nullable<decimal> value = _TOTAL;
                OnGetTOTAL(ref value);
                return value;
            }
            set
            {
                if (_TOTAL != value)
                {
                  OnTOTALChanging(ref value);
                  ReportPropertyChanging("TOTAL");
                  _TOTAL = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTAL");
                  OnTOTALChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _TOTAL;
        partial void OnGetTOTAL(ref global::System.Nullable<decimal> value);
        partial void OnTOTALChanging(ref global::System.Nullable<decimal> value);
        partial void OnTOTALChanged();
    
        /// <summary>
        /// There are no comments for VTOTAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VTOTAL
        {
            get
            {
                global::System.Nullable<decimal> value = _VTOTAL;
                OnGetVTOTAL(ref value);
                return value;
            }
            set
            {
                if (_VTOTAL != value)
                {
                  OnVTOTALChanging(ref value);
                  ReportPropertyChanging("VTOTAL");
                  _VTOTAL = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VTOTAL");
                  OnVTOTALChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VTOTAL;
        partial void OnGetVTOTAL(ref global::System.Nullable<decimal> value);
        partial void OnVTOTALChanging(ref global::System.Nullable<decimal> value);
        partial void OnVTOTALChanged();
    
        /// <summary>
        /// There are no comments for TOTEXP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> TOTEXP
        {
            get
            {
                global::System.Nullable<decimal> value = _TOTEXP;
                OnGetTOTEXP(ref value);
                return value;
            }
            set
            {
                if (_TOTEXP != value)
                {
                  OnTOTEXPChanging(ref value);
                  ReportPropertyChanging("TOTEXP");
                  _TOTEXP = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTEXP");
                  OnTOTEXPChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _TOTEXP;
        partial void OnGetTOTEXP(ref global::System.Nullable<decimal> value);
        partial void OnTOTEXPChanging(ref global::System.Nullable<decimal> value);
        partial void OnTOTEXPChanged();
    
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
        /// There are no comments for VPRECO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VPRECO
        {
            get
            {
                global::System.Nullable<decimal> value = _VPRECO;
                OnGetVPRECO(ref value);
                return value;
            }
            set
            {
                if (_VPRECO != value)
                {
                  OnVPRECOChanging(ref value);
                  ReportPropertyChanging("VPRECO");
                  _VPRECO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VPRECO");
                  OnVPRECOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VPRECO;
        partial void OnGetVPRECO(ref global::System.Nullable<decimal> value);
        partial void OnVPRECOChanging(ref global::System.Nullable<decimal> value);
        partial void OnVPRECOChanged();
    
        /// <summary>
        /// There are no comments for DESCL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> DESCL
        {
            get
            {
                global::System.Nullable<decimal> value = _DESCL;
                OnGetDESCL(ref value);
                return value;
            }
            set
            {
                if (_DESCL != value)
                {
                  OnDESCLChanging(ref value);
                  ReportPropertyChanging("DESCL");
                  _DESCL = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DESCL");
                  OnDESCLChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _DESCL;
        partial void OnGetDESCL(ref global::System.Nullable<decimal> value);
        partial void OnDESCLChanging(ref global::System.Nullable<decimal> value);
        partial void OnDESCLChanged();
    
        /// <summary>
        /// There are no comments for STAT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> STAT
        {
            get
            {
                global::System.Nullable<bool> value = _STAT;
                OnGetSTAT(ref value);
                return value;
            }
            set
            {
                if (_STAT != value)
                {
                  OnSTATChanging(ref value);
                  ReportPropertyChanging("STAT");
                  _STAT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("STAT");
                  OnSTATChanged();
              }
            }
        }
        private global::System.Nullable<bool> _STAT;
        partial void OnGetSTAT(ref global::System.Nullable<bool> value);
        partial void OnSTATChanging(ref global::System.Nullable<bool> value);
        partial void OnSTATChanged();
    
        /// <summary>
        /// There are no comments for GERIR_ETIQ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> GERIR_ETIQ
        {
            get
            {
                global::System.Nullable<bool> value = _GERIR_ETIQ;
                OnGetGERIR_ETIQ(ref value);
                return value;
            }
            set
            {
                if (_GERIR_ETIQ != value)
                {
                  OnGERIR_ETIQChanging(ref value);
                  ReportPropertyChanging("GERIR_ETIQ");
                  _GERIR_ETIQ = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("GERIR_ETIQ");
                  OnGERIR_ETIQChanged();
              }
            }
        }
        private global::System.Nullable<bool> _GERIR_ETIQ;
        partial void OnGetGERIR_ETIQ(ref global::System.Nullable<bool> value);
        partial void OnGERIR_ETIQChanging(ref global::System.Nullable<bool> value);
        partial void OnGERIR_ETIQChanged();
    
        /// <summary>
        /// There are no comments for TOT_AREC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> TOT_AREC
        {
            get
            {
                global::System.Nullable<decimal> value = _TOT_AREC;
                OnGetTOT_AREC(ref value);
                return value;
            }
            set
            {
                if (_TOT_AREC != value)
                {
                  OnTOT_ARECChanging(ref value);
                  ReportPropertyChanging("TOT_AREC");
                  _TOT_AREC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOT_AREC");
                  OnTOT_ARECChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _TOT_AREC;
        partial void OnGetTOT_AREC(ref global::System.Nullable<decimal> value);
        partial void OnTOT_ARECChanging(ref global::System.Nullable<decimal> value);
        partial void OnTOT_ARECChanged();
    
        /// <summary>
        /// There are no comments for seleccao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> seleccao
        {
            get
            {
                global::System.Nullable<bool> value = _seleccao;
                OnGetseleccao(ref value);
                return value;
            }
            set
            {
                if (_seleccao != value)
                {
                  OnseleccaoChanging(ref value);
                  ReportPropertyChanging("seleccao");
                  _seleccao = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("seleccao");
                  OnseleccaoChanged();
              }
            }
        }
        private global::System.Nullable<bool> _seleccao;
        partial void OnGetseleccao(ref global::System.Nullable<bool> value);
        partial void OnseleccaoChanging(ref global::System.Nullable<bool> value);
        partial void OnseleccaoChanged();
    
        /// <summary>
        /// There are no comments for DATA_ENVIOMSG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_ENVIOMSG
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_ENVIOMSG;
                OnGetDATA_ENVIOMSG(ref value);
                return value;
            }
            set
            {
                if (_DATA_ENVIOMSG != value)
                {
                  OnDATA_ENVIOMSGChanging(ref value);
                  ReportPropertyChanging("DATA_ENVIOMSG");
                  _DATA_ENVIOMSG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_ENVIOMSG");
                  OnDATA_ENVIOMSGChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_ENVIOMSG;
        partial void OnGetDATA_ENVIOMSG(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ENVIOMSGChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ENVIOMSGChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for ARTIGOS in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_CMPOCL_ARTIGOS", "ARTIGOS")]
        public ARTIGOS ARTIGOS
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CMPOCL_ARTIGOS", "ARTIGOS").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CMPOCL_ARTIGOS", "ARTIGOS").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for ARTIGOS in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ARTIGOS> ARTIGOSReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CMPOCL_ARTIGOS", "ARTIGOS");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CMPOCL_ARTIGOS", "ARTIGOS", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CMPOCL_ARTIGOS", "ARTIGOS").Value = null;
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CMPOCL obj = new CMPOCL();
            obj.LRENCO = LRENCO;
            obj.LNENCO = LNENCO;
            obj.ARM = ARM;
            obj.MODELO = MODELO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.ITAM = ITAM;
            obj.TAM = TAM;
            obj.DESCRICAO = DESCRICAO;
            obj.DESCRICAO2 = DESCRICAO2;
            obj.UNMED = UNMED;
            obj.VUNMED = VUNMED;
            obj.FCONV = FCONV;
            obj.TXIVA = TXIVA;
            obj.PRAZO = PRAZO;
            obj.DATAUENT = DATAUENT;
            obj.TOTAL = TOTAL;
            obj.VTOTAL = VTOTAL;
            obj.TOTEXP = TOTEXP;
            obj.PRECO = PRECO;
            obj.VPRECO = VPRECO;
            obj.DESCL = DESCL;
            obj.STAT = STAT;
            obj.GERIR_ETIQ = GERIR_ETIQ;
            obj.TOT_AREC = TOT_AREC;
            obj.seleccao = seleccao;
            obj.DATA_ENVIOMSG = DATA_ENVIOMSG;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CMPOCL toCompare = obj as CMPOCL;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.LRENCO, toCompare.LRENCO))
            return false;
          if (!Object.Equals(this.LNENCO, toCompare.LNENCO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + LRENCO.GetHashCode();
          hashCode = (hashCode * 7) + LNENCO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
