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
    /// There are no comments for DataGiic_LiagoModel.WKSALDO_RESUMO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// nrreg
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WKSALDO_RESUMO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WKSALDO_RESUMO : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WKSALDO_RESUMO object.
        /// </summary>
        /// <param name="nrreg">Initial value of nrreg.</param>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="aRM">Initial value of ARM.</param>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        /// <param name="cARTAZ">Initial value of CARTAZ.</param>
        /// <param name="codcor">Initial value of codcor.</param>
        /// <param name="tAM">Initial value of TAM.</param>
        public static WKSALDO_RESUMO CreateWKSALDO_RESUMO(global::System.Guid nrreg, int spid, string aRM, string aRTIGO, string cARTAZ, string codcor, string tAM)
        {
            WKSALDO_RESUMO wKSALDO_RESUMO = new WKSALDO_RESUMO();
            wKSALDO_RESUMO.nrreg = nrreg;
            wKSALDO_RESUMO.spid = spid;
            wKSALDO_RESUMO.ARM = aRM;
            wKSALDO_RESUMO.ARTIGO = aRTIGO;
            wKSALDO_RESUMO.CARTAZ = cARTAZ;
            wKSALDO_RESUMO.codcor = codcor;
            wKSALDO_RESUMO.TAM = tAM;
            return wKSALDO_RESUMO;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for nrreg in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.Guid nrreg
        {
            get
            {
                global::System.Guid value = _nrreg;
                OnGetnrreg(ref value);
                return value;
            }
            set
            {
                if (_nrreg != value)
                {
                  OnnrregChanging(ref value);
                  ReportPropertyChanging("nrreg");
                  _nrreg = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("nrreg");
                  OnnrregChanged();
              }
            }
        }
        private global::System.Guid _nrreg;
        partial void OnGetnrreg(ref global::System.Guid value);
        partial void OnnrregChanging(ref global::System.Guid value);
        partial void OnnrregChanged();
    
        /// <summary>
        /// There are no comments for spid in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
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
        private string _CARTAZ = @"space(5)";
        partial void OnGetCARTAZ(ref string value);
        partial void OnCARTAZChanging(ref string value);
        partial void OnCARTAZChanged();
    
        /// <summary>
        /// There are no comments for codcor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string codcor
        {
            get
            {
                string value = _codcor;
                OnGetcodcor(ref value);
                return value;
            }
            set
            {
                if (_codcor != value)
                {
                  OncodcorChanging(ref value);
                  ReportPropertyChanging("codcor");
                  _codcor = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("codcor");
                  OncodcorChanged();
              }
            }
        }
        private string _codcor = @"space(3)";
        partial void OnGetcodcor(ref string value);
        partial void OncodcorChanging(ref string value);
        partial void OncodcorChanged();
    
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
        private string _TAM = @"space(4)";
        partial void OnGetTAM(ref string value);
        partial void OnTAMChanging(ref string value);
        partial void OnTAMChanged();
    
        /// <summary>
        /// There are no comments for EC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> EC
        {
            get
            {
                global::System.Nullable<decimal> value = _EC;
                OnGetEC(ref value);
                return value;
            }
            set
            {
                if (_EC != value)
                {
                  OnECChanging(ref value);
                  ReportPropertyChanging("EC");
                  _EC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("EC");
                  OnECChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _EC = 0m;
        partial void OnGetEC(ref global::System.Nullable<decimal> value);
        partial void OnECChanging(ref global::System.Nullable<decimal> value);
        partial void OnECChanged();
    
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
        /// There are no comments for SALDO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> SALDO
        {
            get
            {
                global::System.Nullable<decimal> value = _SALDO;
                OnGetSALDO(ref value);
                return value;
            }
            set
            {
                if (_SALDO != value)
                {
                  OnSALDOChanging(ref value);
                  ReportPropertyChanging("SALDO");
                  _SALDO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SALDO");
                  OnSALDOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _SALDO;
        partial void OnGetSALDO(ref global::System.Nullable<decimal> value);
        partial void OnSALDOChanging(ref global::System.Nullable<decimal> value);
        partial void OnSALDOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WKSALDO_RESUMO obj = new WKSALDO_RESUMO();
            obj.nrreg = nrreg;
            obj.spid = spid;
            obj.ARM = ARM;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.codcor = codcor;
            obj.TAM = TAM;
            obj.EC = EC;
            obj.OC = OC;
            obj.ST = ST;
            obj.SALDO = SALDO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WKSALDO_RESUMO toCompare = obj as WKSALDO_RESUMO;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.nrreg, toCompare.nrreg))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + nrreg.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
