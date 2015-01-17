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
    /// There are no comments for DataGiic_LiagoModel.wkmrp_sug in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SPID
    /// ARM
    /// ARTIGO
    /// CARTAZ
    /// CODCOR
    /// TAM
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wkmrp_sug")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wkmrp_sug : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wkmrp_sug object.
        /// </summary>
        /// <param name="sPID">Initial value of SPID.</param>
        /// <param name="aRM">Initial value of ARM.</param>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        /// <param name="cARTAZ">Initial value of CARTAZ.</param>
        /// <param name="cODCOR">Initial value of CODCOR.</param>
        /// <param name="tAM">Initial value of TAM.</param>
        public static wkmrp_sug Createwkmrp_sug(int sPID, string aRM, string aRTIGO, string cARTAZ, string cODCOR, string tAM)
        {
            wkmrp_sug wkmrp_sug = new wkmrp_sug();
            wkmrp_sug.SPID = sPID;
            wkmrp_sug.ARM = aRM;
            wkmrp_sug.ARTIGO = aRTIGO;
            wkmrp_sug.CARTAZ = cARTAZ;
            wkmrp_sug.CODCOR = cODCOR;
            wkmrp_sug.TAM = tAM;
            return wkmrp_sug;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for SEQ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> SEQ
        {
            get
            {
                global::System.Nullable<int> value = _SEQ;
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
        private global::System.Nullable<int> _SEQ;
        partial void OnGetSEQ(ref global::System.Nullable<int> value);
        partial void OnSEQChanging(ref global::System.Nullable<int> value);
        partial void OnSEQChanged();
    
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
        private string _CARTAZ = @"space(5)";
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
        private string _CODCOR = @"space(3)";
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
        private string _TAM = @"space(4)";
        partial void OnGetTAM(ref string value);
        partial void OnTAMChanging(ref string value);
        partial void OnTAMChanged();
    
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
        private global::System.Nullable<decimal> _CONSUMO = 0m;
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
        private global::System.Nullable<decimal> _preco = 0m;
        partial void OnGetpreco(ref global::System.Nullable<decimal> value);
        partial void OnprecoChanging(ref global::System.Nullable<decimal> value);
        partial void OnprecoChanged();
    
        /// <summary>
        /// There are no comments for desconto in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> desconto
        {
            get
            {
                global::System.Nullable<decimal> value = _desconto;
                OnGetdesconto(ref value);
                return value;
            }
            set
            {
                if (_desconto != value)
                {
                  OndescontoChanging(ref value);
                  ReportPropertyChanging("desconto");
                  _desconto = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("desconto");
                  OndescontoChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _desconto = 0m;
        partial void OnGetdesconto(ref global::System.Nullable<decimal> value);
        partial void OndescontoChanging(ref global::System.Nullable<decimal> value);
        partial void OndescontoChanged();
    
        /// <summary>
        /// There are no comments for tot_acmp in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> tot_acmp
        {
            get
            {
                global::System.Nullable<decimal> value = _tot_acmp;
                OnGettot_acmp(ref value);
                return value;
            }
            set
            {
                if (_tot_acmp != value)
                {
                  Ontot_acmpChanging(ref value);
                  ReportPropertyChanging("tot_acmp");
                  _tot_acmp = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("tot_acmp");
                  Ontot_acmpChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _tot_acmp = 0m;
        partial void OnGettot_acmp(ref global::System.Nullable<decimal> value);
        partial void Ontot_acmpChanging(ref global::System.Nullable<decimal> value);
        partial void Ontot_acmpChanged();
    
        /// <summary>
        /// There are no comments for stock in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> stock
        {
            get
            {
                global::System.Nullable<decimal> value = _stock;
                OnGetstock(ref value);
                return value;
            }
            set
            {
                if (_stock != value)
                {
                  OnstockChanging(ref value);
                  ReportPropertyChanging("stock");
                  _stock = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("stock");
                  OnstockChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _stock = 0m;
        partial void OnGetstock(ref global::System.Nullable<decimal> value);
        partial void OnstockChanging(ref global::System.Nullable<decimal> value);
        partial void OnstockChanged();
    
        /// <summary>
        /// There are no comments for prod in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> prod
        {
            get
            {
                global::System.Nullable<decimal> value = _prod;
                OnGetprod(ref value);
                return value;
            }
            set
            {
                if (_prod != value)
                {
                  OnprodChanging(ref value);
                  ReportPropertyChanging("prod");
                  _prod = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("prod");
                  OnprodChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _prod = 0m;
        partial void OnGetprod(ref global::System.Nullable<decimal> value);
        partial void OnprodChanging(ref global::System.Nullable<decimal> value);
        partial void OnprodChanged();
    
        /// <summary>
        /// There are no comments for Compras in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> Compras
        {
            get
            {
                global::System.Nullable<decimal> value = _Compras;
                OnGetCompras(ref value);
                return value;
            }
            set
            {
                if (_Compras != value)
                {
                  OnComprasChanging(ref value);
                  ReportPropertyChanging("Compras");
                  _Compras = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Compras");
                  OnComprasChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _Compras = 0m;
        partial void OnGetCompras(ref global::System.Nullable<decimal> value);
        partial void OnComprasChanging(ref global::System.Nullable<decimal> value);
        partial void OnComprasChanged();
    
        /// <summary>
        /// There are no comments for disp in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> disp
        {
            get
            {
                global::System.Nullable<decimal> value = _disp;
                OnGetdisp(ref value);
                return value;
            }
            set
            {
                if (_disp != value)
                {
                  OndispChanging(ref value);
                  ReportPropertyChanging("disp");
                  _disp = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("disp");
                  OndispChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _disp = 0m;
        partial void OnGetdisp(ref global::System.Nullable<decimal> value);
        partial void OndispChanging(ref global::System.Nullable<decimal> value);
        partial void OndispChanged();
    
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

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wkmrp_sug obj = new wkmrp_sug();
            obj.SEQ = SEQ;
            obj.SPID = SPID;
            obj.ARM = ARM;
            obj.ARTIGO = ARTIGO;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.TAM = TAM;
            obj.CONSUMO = CONSUMO;
            obj.preco = preco;
            obj.desconto = desconto;
            obj.tot_acmp = tot_acmp;
            obj.stock = stock;
            obj.prod = prod;
            obj.Compras = Compras;
            obj.disp = disp;
            obj.seleccao = seleccao;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wkmrp_sug toCompare = obj as wkmrp_sug;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SPID, toCompare.SPID))
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
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          hashCode = (hashCode * 7) + ARM.GetHashCode();
          hashCode = (hashCode * 7) + ARTIGO.GetHashCode();
          hashCode = (hashCode * 7) + CARTAZ.GetHashCode();
          hashCode = (hashCode * 7) + CODCOR.GetHashCode();
          hashCode = (hashCode * 7) + TAM.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
