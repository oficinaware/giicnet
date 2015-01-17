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
    /// There are no comments for DataGiic_LiagoModel.WKMRPL in the schema.
    /// </summary>
    /// <KeyProperties>
    /// spid
    /// ARM
    /// ARTIGO
    /// CARTAZ
    /// CODCOR
    /// TAM
    /// SEQ
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WKMRPL")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WKMRPL : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WKMRPL object.
        /// </summary>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="aRM">Initial value of ARM.</param>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        /// <param name="cARTAZ">Initial value of CARTAZ.</param>
        /// <param name="cODCOR">Initial value of CODCOR.</param>
        /// <param name="tAM">Initial value of TAM.</param>
        /// <param name="sEQ">Initial value of SEQ.</param>
        public static WKMRPL CreateWKMRPL(int spid, string aRM, string aRTIGO, string cARTAZ, string cODCOR, string tAM, int sEQ)
        {
            WKMRPL wKMRPL = new WKMRPL();
            wKMRPL.spid = spid;
            wKMRPL.ARM = aRM;
            wKMRPL.ARTIGO = aRTIGO;
            wKMRPL.CARTAZ = cARTAZ;
            wKMRPL.CODCOR = cODCOR;
            wKMRPL.TAM = tAM;
            wKMRPL.SEQ = sEQ;
            return wKMRPL;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for spid in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int spid
        {
            get
            {
                int value = _spid;
                OnGetspid(ref value);
                return value;
            }
            set
            {
                if (_spid != value)
                {
                  OnspidChanging(ref value);
                  ReportPropertyChanging("spid");
                  _spid = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("spid");
                  OnspidChanged();
              }
            }
        }
        private int _spid;
        partial void OnGetspid(ref int value);
        partial void OnspidChanging(ref int value);
        partial void OnspidChanged();
    
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
        /// There are no comments for ARTIGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
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
        /// There are no comments for SEQ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int SEQ
        {
            get
            {
                int value = _SEQ;
                OnGetSEQ(ref value);
                return value;
            }
            set
            {
                if (_SEQ != value)
                {
                  OnSEQChanging(ref value);
                  ReportPropertyChanging("SEQ");
                  _SEQ = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SEQ");
                  OnSEQChanged();
              }
            }
        }
        private int _SEQ;
        partial void OnGetSEQ(ref int value);
        partial void OnSEQChanging(ref int value);
        partial void OnSEQChanged();
    
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
        /// There are no comments for preco in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> preco
        {
            get
            {
                global::System.Nullable<decimal> value = _preco;
                OnGetpreco(ref value);
                return value;
            }
            set
            {
                if (_preco != value)
                {
                  OnprecoChanging(ref value);
                  ReportPropertyChanging("preco");
                  _preco = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("preco");
                  OnprecoChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _preco;
        partial void OnGetpreco(ref global::System.Nullable<decimal> value);
        partial void OnprecoChanging(ref global::System.Nullable<decimal> value);
        partial void OnprecoChanged();
    
        /// <summary>
        /// There are no comments for vl in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> vl
        {
            get
            {
                global::System.Nullable<decimal> value = _vl;
                OnGetvl(ref value);
                return value;
            }
            set
            {
                if (_vl != value)
                {
                  OnvlChanging(ref value);
                  ReportPropertyChanging("vl");
                  _vl = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("vl");
                  OnvlChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _vl;
        partial void OnGetvl(ref global::System.Nullable<decimal> value);
        partial void OnvlChanging(ref global::System.Nullable<decimal> value);
        partial void OnvlChanged();
    
        /// <summary>
        /// There are no comments for ST in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> ST
        {
            get
            {
                global::System.Nullable<decimal> value = _ST;
                OnGetST(ref value);
                return value;
            }
            set
            {
                if (_ST != value)
                {
                  OnSTChanging(ref value);
                  ReportPropertyChanging("ST");
                  _ST = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ST");
                  OnSTChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _ST = 0m;
        partial void OnGetST(ref global::System.Nullable<decimal> value);
        partial void OnSTChanging(ref global::System.Nullable<decimal> value);
        partial void OnSTChanged();
    
        /// <summary>
        /// There are no comments for ST_OUTROS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> ST_OUTROS
        {
            get
            {
                global::System.Nullable<decimal> value = _ST_OUTROS;
                OnGetST_OUTROS(ref value);
                return value;
            }
            set
            {
                if (_ST_OUTROS != value)
                {
                  OnST_OUTROSChanging(ref value);
                  ReportPropertyChanging("ST_OUTROS");
                  _ST_OUTROS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ST_OUTROS");
                  OnST_OUTROSChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _ST_OUTROS = 0m;
        partial void OnGetST_OUTROS(ref global::System.Nullable<decimal> value);
        partial void OnST_OUTROSChanging(ref global::System.Nullable<decimal> value);
        partial void OnST_OUTROSChanged();
    
        /// <summary>
        /// There are no comments for OC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> OC
        {
            get
            {
                global::System.Nullable<decimal> value = _OC;
                OnGetOC(ref value);
                return value;
            }
            set
            {
                if (_OC != value)
                {
                  OnOCChanging(ref value);
                  ReportPropertyChanging("OC");
                  _OC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("OC");
                  OnOCChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _OC = 0m;
        partial void OnGetOC(ref global::System.Nullable<decimal> value);
        partial void OnOCChanging(ref global::System.Nullable<decimal> value);
        partial void OnOCChanged();
    
        /// <summary>
        /// There are no comments for OEC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> OEC
        {
            get
            {
                global::System.Nullable<decimal> value = _OEC;
                OnGetOEC(ref value);
                return value;
            }
            set
            {
                if (_OEC != value)
                {
                  OnOECChanging(ref value);
                  ReportPropertyChanging("OEC");
                  _OEC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("OEC");
                  OnOECChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _OEC = 0m;
        partial void OnGetOEC(ref global::System.Nullable<decimal> value);
        partial void OnOECChanging(ref global::System.Nullable<decimal> value);
        partial void OnOECChanged();
    
        /// <summary>
        /// There are no comments for FALTA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> FALTA
        {
            get
            {
                global::System.Nullable<decimal> value = _FALTA;
                OnGetFALTA(ref value);
                return value;
            }
            set
            {
                if (_FALTA != value)
                {
                  OnFALTAChanging(ref value);
                  ReportPropertyChanging("FALTA");
                  _FALTA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("FALTA");
                  OnFALTAChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _FALTA = 0m;
        partial void OnGetFALTA(ref global::System.Nullable<decimal> value);
        partial void OnFALTAChanging(ref global::System.Nullable<decimal> value);
        partial void OnFALTAChanged();
    
        /// <summary>
        /// There are no comments for SOBRA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> SOBRA
        {
            get
            {
                global::System.Nullable<decimal> value = _SOBRA;
                OnGetSOBRA(ref value);
                return value;
            }
            set
            {
                if (_SOBRA != value)
                {
                  OnSOBRAChanging(ref value);
                  ReportPropertyChanging("SOBRA");
                  _SOBRA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SOBRA");
                  OnSOBRAChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _SOBRA = 0m;
        partial void OnGetSOBRA(ref global::System.Nullable<decimal> value);
        partial void OnSOBRAChanging(ref global::System.Nullable<decimal> value);
        partial void OnSOBRAChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WKMRPL obj = new WKMRPL();
            obj.spid = spid;
            obj.ARM = ARM;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.TAM = TAM;
            obj.SEQ = SEQ;
            obj.OPERACAO = OPERACAO;
            obj.CONSUMO = CONSUMO;
            obj.preco = preco;
            obj.vl = vl;
            obj.ST = ST;
            obj.ST_OUTROS = ST_OUTROS;
            obj.OC = OC;
            obj.OEC = OEC;
            obj.FALTA = FALTA;
            obj.SOBRA = SOBRA;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WKMRPL toCompare = obj as WKMRPL;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.spid, toCompare.spid))
            return false;
          if (!Object.Equals(this.ARM, toCompare.ARM))
            return false;
          if (!Object.Equals(this.ARTIGO, toCompare.ARTIGO))
            return false;
          if (!Object.Equals(this.CARTAZ, toCompare.CARTAZ))
            return false;
          if (!Object.Equals(this.CODCOR, toCompare.CODCOR))
            return false;
          if (!Object.Equals(this.TAM, toCompare.TAM))
            return false;
          if (!Object.Equals(this.SEQ, toCompare.SEQ))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + spid.GetHashCode();
          hashCode = (hashCode * 7) + ARM.GetHashCode();
          hashCode = (hashCode * 7) + ARTIGO.GetHashCode();
          hashCode = (hashCode * 7) + CARTAZ.GetHashCode();
          hashCode = (hashCode * 7) + CODCOR.GetHashCode();
          hashCode = (hashCode * 7) + TAM.GetHashCode();
          hashCode = (hashCode * 7) + SEQ.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
