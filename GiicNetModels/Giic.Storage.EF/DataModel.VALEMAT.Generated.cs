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
    /// There are no comments for DataGiic_LiagoModel.VALEMAT in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NRREG
    /// SPID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="VALEMAT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class VALEMAT : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new VALEMAT object.
        /// </summary>
        /// <param name="nRREG">Initial value of NRREG.</param>
        /// <param name="sPID">Initial value of SPID.</param>
        public static VALEMAT CreateVALEMAT(global::System.Guid nRREG, int sPID)
        {
            VALEMAT vALEMAT = new VALEMAT();
            vALEMAT.NRREG = nRREG;
            vALEMAT.SPID = sPID;
            return vALEMAT;
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
        /// There are no comments for ORDFAB in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string ORDFAB
        {
            get
            {
                string value = _ORDFAB;
                OnGetORDFAB(ref value);
                return value;
            }
            set
            {
                if (_ORDFAB != value)
                {
                  OnORDFABChanging(ref value);
                  ReportPropertyChanging("ORDFAB");
                  _ORDFAB = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ORDFAB");
                  OnORDFABChanged();
              }
            }
        }
        private string _ORDFAB;
        partial void OnGetORDFAB(ref string value);
        partial void OnORDFABChanging(ref string value);
        partial void OnORDFABChanged();
    
        /// <summary>
        /// There are no comments for NIVEL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<short> NIVEL
        {
            get
            {
                global::System.Nullable<short> value = _NIVEL;
                OnGetNIVEL(ref value);
                return value;
            }
            set
            {
                if (_NIVEL != value)
                {
                  OnNIVELChanging(ref value);
                  ReportPropertyChanging("NIVEL");
                  _NIVEL = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NIVEL");
                  OnNIVELChanged();
              }
            }
        }
        private global::System.Nullable<short> _NIVEL;
        partial void OnGetNIVEL(ref global::System.Nullable<short> value);
        partial void OnNIVELChanging(ref global::System.Nullable<short> value);
        partial void OnNIVELChanged();
    
        /// <summary>
        /// There are no comments for TIPOFT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string TIPOFT
        {
            get
            {
                string value = _TIPOFT;
                OnGetTIPOFT(ref value);
                return value;
            }
            set
            {
                if (_TIPOFT != value)
                {
                  OnTIPOFTChanging(ref value);
                  ReportPropertyChanging("TIPOFT");
                  _TIPOFT = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TIPOFT");
                  OnTIPOFTChanged();
              }
            }
        }
        private string _TIPOFT;
        partial void OnGetTIPOFT(ref string value);
        partial void OnTIPOFTChanging(ref string value);
        partial void OnTIPOFTChanged();
    
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
        /// There are no comments for VARIANTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
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
        /// There are no comments for OPERACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
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
                  _OPERACAO = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for COMPONENTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string COMPONENTE
        {
            get
            {
                string value = _COMPONENTE;
                OnGetCOMPONENTE(ref value);
                return value;
            }
            set
            {
                if (_COMPONENTE != value)
                {
                  OnCOMPONENTEChanging(ref value);
                  ReportPropertyChanging("COMPONENTE");
                  _COMPONENTE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COMPONENTE");
                  OnCOMPONENTEChanged();
              }
            }
        }
        private string _COMPONENTE;
        partial void OnGetCOMPONENTE(ref string value);
        partial void OnCOMPONENTEChanging(ref string value);
        partial void OnCOMPONENTEChanged();
    
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
        /// There are no comments for dotam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string dotam
        {
            get
            {
                string value = _dotam;
                OnGetdotam(ref value);
                return value;
            }
            set
            {
                if (_dotam != value)
                {
                  OndotamChanging(ref value);
                  ReportPropertyChanging("dotam");
                  _dotam = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("dotam");
                  OndotamChanged();
              }
            }
        }
        private string _dotam;
        partial void OnGetdotam(ref string value);
        partial void OndotamChanging(ref string value);
        partial void OndotamChanged();
    
        /// <summary>
        /// There are no comments for aotam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string aotam
        {
            get
            {
                string value = _aotam;
                OnGetaotam(ref value);
                return value;
            }
            set
            {
                if (_aotam != value)
                {
                  OnaotamChanging(ref value);
                  ReportPropertyChanging("aotam");
                  _aotam = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("aotam");
                  OnaotamChanged();
              }
            }
        }
        private string _aotam;
        partial void OnGetaotam(ref string value);
        partial void OnaotamChanging(ref string value);
        partial void OnaotamChanged();
    
        /// <summary>
        /// There are no comments for idotam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<short> idotam
        {
            get
            {
                global::System.Nullable<short> value = _idotam;
                OnGetidotam(ref value);
                return value;
            }
            set
            {
                if (_idotam != value)
                {
                  OnidotamChanging(ref value);
                  ReportPropertyChanging("idotam");
                  _idotam = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("idotam");
                  OnidotamChanged();
              }
            }
        }
        private global::System.Nullable<short> _idotam;
        partial void OnGetidotam(ref global::System.Nullable<short> value);
        partial void OnidotamChanging(ref global::System.Nullable<short> value);
        partial void OnidotamChanged();
    
        /// <summary>
        /// There are no comments for iaotam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<short> iaotam
        {
            get
            {
                global::System.Nullable<short> value = _iaotam;
                OnGetiaotam(ref value);
                return value;
            }
            set
            {
                if (_iaotam != value)
                {
                  OniaotamChanging(ref value);
                  ReportPropertyChanging("iaotam");
                  _iaotam = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("iaotam");
                  OniaotamChanged();
              }
            }
        }
        private global::System.Nullable<short> _iaotam;
        partial void OnGetiaotam(ref global::System.Nullable<short> value);
        partial void OniaotamChanging(ref global::System.Nullable<short> value);
        partial void OniaotamChanged();
    
        /// <summary>
        /// There are no comments for SEQOP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> SEQOP
        {
            get
            {
                global::System.Nullable<int> value = _SEQOP;
                OnGetSEQOP(ref value);
                return value;
            }
            set
            {
                if (_SEQOP != value)
                {
                  OnSEQOPChanging(ref value);
                  ReportPropertyChanging("SEQOP");
                  _SEQOP = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SEQOP");
                  OnSEQOPChanged();
              }
            }
        }
        private global::System.Nullable<int> _SEQOP;
        partial void OnGetSEQOP(ref global::System.Nullable<int> value);
        partial void OnSEQOPChanging(ref global::System.Nullable<int> value);
        partial void OnSEQOPChanged();
    
        /// <summary>
        /// There are no comments for POS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> POS
        {
            get
            {
                global::System.Nullable<int> value = _POS;
                OnGetPOS(ref value);
                return value;
            }
            set
            {
                if (_POS != value)
                {
                  OnPOSChanging(ref value);
                  ReportPropertyChanging("POS");
                  _POS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("POS");
                  OnPOSChanged();
              }
            }
        }
        private global::System.Nullable<int> _POS;
        partial void OnGetPOS(ref global::System.Nullable<int> value);
        partial void OnPOSChanging(ref global::System.Nullable<int> value);
        partial void OnPOSChanged();
    
        /// <summary>
        /// There are no comments for PECA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string PECA
        {
            get
            {
                string value = _PECA;
                OnGetPECA(ref value);
                return value;
            }
            set
            {
                if (_PECA != value)
                {
                  OnPECAChanging(ref value);
                  ReportPropertyChanging("PECA");
                  _PECA = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("PECA");
                  OnPECAChanged();
              }
            }
        }
        private string _PECA;
        partial void OnGetPECA(ref string value);
        partial void OnPECAChanging(ref string value);
        partial void OnPECAChanged();
    
        /// <summary>
        /// There are no comments for CONSUMO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CONSUMO
        {
            get
            {
                global::System.Nullable<decimal> value = _CONSUMO;
                OnGetCONSUMO(ref value);
                return value;
            }
            set
            {
                if (_CONSUMO != value)
                {
                  OnCONSUMOChanging(ref value);
                  ReportPropertyChanging("CONSUMO");
                  _CONSUMO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CONSUMO");
                  OnCONSUMOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CONSUMO;
        partial void OnGetCONSUMO(ref global::System.Nullable<decimal> value);
        partial void OnCONSUMOChanging(ref global::System.Nullable<decimal> value);
        partial void OnCONSUMOChanged();
    
        /// <summary>
        /// There are no comments for CONSUMOPAR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CONSUMOPAR
        {
            get
            {
                global::System.Nullable<decimal> value = _CONSUMOPAR;
                OnGetCONSUMOPAR(ref value);
                return value;
            }
            set
            {
                if (_CONSUMOPAR != value)
                {
                  OnCONSUMOPARChanging(ref value);
                  ReportPropertyChanging("CONSUMOPAR");
                  _CONSUMOPAR = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CONSUMOPAR");
                  OnCONSUMOPARChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CONSUMOPAR;
        partial void OnGetCONSUMOPAR(ref global::System.Nullable<decimal> value);
        partial void OnCONSUMOPARChanging(ref global::System.Nullable<decimal> value);
        partial void OnCONSUMOPARChanged();
    
        /// <summary>
        /// There are no comments for OBSV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string OBSV
        {
            get
            {
                string value = _OBSV;
                OnGetOBSV(ref value);
                return value;
            }
            set
            {
                if (_OBSV != value)
                {
                  OnOBSVChanging(ref value);
                  ReportPropertyChanging("OBSV");
                  _OBSV = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("OBSV");
                  OnOBSVChanged();
              }
            }
        }
        private string _OBSV;
        partial void OnGetOBSV(ref string value);
        partial void OnOBSVChanging(ref string value);
        partial void OnOBSVChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            VALEMAT obj = new VALEMAT();
            obj.NRREG = NRREG;
            obj.SPID = SPID;
            obj.ORDFAB = ORDFAB;
            obj.NIVEL = NIVEL;
            obj.TIPOFT = TIPOFT;
            obj.MODELO = MODELO;
            obj.VARIANTE = VARIANTE;
            obj.OPERACAO = OPERACAO;
            obj.COMPONENTE = COMPONENTE;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.TAM = TAM;
            obj.dotam = dotam;
            obj.aotam = aotam;
            obj.idotam = idotam;
            obj.iaotam = iaotam;
            obj.SEQOP = SEQOP;
            obj.POS = POS;
            obj.PECA = PECA;
            obj.CONSUMO = CONSUMO;
            obj.CONSUMOPAR = CONSUMOPAR;
            obj.OBSV = OBSV;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          VALEMAT toCompare = obj as VALEMAT;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.NRREG, toCompare.NRREG))
            return false;
          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + NRREG.GetHashCode();
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
