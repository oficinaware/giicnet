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
    /// There are no comments for DataGiic_LiagoModel.wktabprc_modcli in the schema.
    /// </summary>
    /// <KeyProperties>
    /// spid
    /// modelo
    /// variante
    /// cliente
    /// idotam
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wktabprc_modcli")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wktabprc_modcli : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wktabprc_modcli object.
        /// </summary>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="modelo">Initial value of modelo.</param>
        /// <param name="variante">Initial value of variante.</param>
        /// <param name="cliente">Initial value of cliente.</param>
        /// <param name="idotam">Initial value of idotam.</param>
        public static wktabprc_modcli Createwktabprc_modcli(int spid, string modelo, string variante, string cliente, short idotam)
        {
            wktabprc_modcli wktabprc_modcli = new wktabprc_modcli();
            wktabprc_modcli.spid = spid;
            wktabprc_modcli.modelo = modelo;
            wktabprc_modcli.variante = variante;
            wktabprc_modcli.cliente = cliente;
            wktabprc_modcli.idotam = idotam;
            return wktabprc_modcli;
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
        /// There are no comments for modelo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string modelo
        {
            get
            {
                string value = _modelo;
                OnGetmodelo(ref value);
                return value;
            }
            set
            {
                if (_modelo != value)
                {
                  OnmodeloChanging(ref value);
                  ReportPropertyChanging("modelo");
                  _modelo = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("modelo");
                  OnmodeloChanged();
              }
            }
        }
        private string _modelo;
        partial void OnGetmodelo(ref string value);
        partial void OnmodeloChanging(ref string value);
        partial void OnmodeloChanged();
    
        /// <summary>
        /// There are no comments for variante in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string variante
        {
            get
            {
                string value = _variante;
                OnGetvariante(ref value);
                return value;
            }
            set
            {
                if (_variante != value)
                {
                  OnvarianteChanging(ref value);
                  ReportPropertyChanging("variante");
                  _variante = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("variante");
                  OnvarianteChanged();
              }
            }
        }
        private string _variante;
        partial void OnGetvariante(ref string value);
        partial void OnvarianteChanging(ref string value);
        partial void OnvarianteChanged();
    
        /// <summary>
        /// There are no comments for cliente in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string cliente
        {
            get
            {
                string value = _cliente;
                OnGetcliente(ref value);
                return value;
            }
            set
            {
                if (_cliente != value)
                {
                  OnclienteChanging(ref value);
                  ReportPropertyChanging("cliente");
                  _cliente = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("cliente");
                  OnclienteChanged();
              }
            }
        }
        private string _cliente;
        partial void OnGetcliente(ref string value);
        partial void OnclienteChanging(ref string value);
        partial void OnclienteChanged();
    
        /// <summary>
        /// There are no comments for idotam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public short idotam
        {
            get
            {
                short value = _idotam;
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
        private short _idotam;
        partial void OnGetidotam(ref short value);
        partial void OnidotamChanging(ref short value);
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
        /// There are no comments for estacao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string estacao
        {
            get
            {
                string value = _estacao;
                OnGetestacao(ref value);
                return value;
            }
            set
            {
                if (_estacao != value)
                {
                  OnestacaoChanging(ref value);
                  ReportPropertyChanging("estacao");
                  _estacao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("estacao");
                  OnestacaoChanged();
              }
            }
        }
        private string _estacao;
        partial void OnGetestacao(ref string value);
        partial void OnestacaoChanging(ref string value);
        partial void OnestacaoChanged();
    
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
        /// There are no comments for moeda in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string moeda
        {
            get
            {
                string value = _moeda;
                OnGetmoeda(ref value);
                return value;
            }
            set
            {
                if (_moeda != value)
                {
                  OnmoedaChanging(ref value);
                  ReportPropertyChanging("moeda");
                  _moeda = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("moeda");
                  OnmoedaChanged();
              }
            }
        }
        private string _moeda;
        partial void OnGetmoeda(ref string value);
        partial void OnmoedaChanging(ref string value);
        partial void OnmoedaChanged();
    
        /// <summary>
        /// There are no comments for imagem in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        public string imagem
        {
            get
            {
                string value = _imagem;
                OnGetimagem(ref value);
                return value;
            }
            set
            {
                if (_imagem != value)
                {
                  OnimagemChanging(ref value);
                  ReportPropertyChanging("imagem");
                  _imagem = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("imagem");
                  OnimagemChanged();
              }
            }
        }
        private string _imagem;
        partial void OnGetimagem(ref string value);
        partial void OnimagemChanging(ref string value);
        partial void OnimagemChanged();
    
        /// <summary>
        /// There are no comments for preco1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> preco1
        {
            get
            {
                global::System.Nullable<decimal> value = _preco1;
                OnGetpreco1(ref value);
                return value;
            }
            set
            {
                if (_preco1 != value)
                {
                  Onpreco1Changing(ref value);
                  ReportPropertyChanging("preco1");
                  _preco1 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("preco1");
                  Onpreco1Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _preco1 = 0m;
        partial void OnGetpreco1(ref global::System.Nullable<decimal> value);
        partial void Onpreco1Changing(ref global::System.Nullable<decimal> value);
        partial void Onpreco1Changed();
    
        /// <summary>
        /// There are no comments for preco2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> preco2
        {
            get
            {
                global::System.Nullable<decimal> value = _preco2;
                OnGetpreco2(ref value);
                return value;
            }
            set
            {
                if (_preco2 != value)
                {
                  Onpreco2Changing(ref value);
                  ReportPropertyChanging("preco2");
                  _preco2 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("preco2");
                  Onpreco2Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _preco2 = 0m;
        partial void OnGetpreco2(ref global::System.Nullable<decimal> value);
        partial void Onpreco2Changing(ref global::System.Nullable<decimal> value);
        partial void Onpreco2Changed();
    
        /// <summary>
        /// There are no comments for preco3 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> preco3
        {
            get
            {
                global::System.Nullable<decimal> value = _preco3;
                OnGetpreco3(ref value);
                return value;
            }
            set
            {
                if (_preco3 != value)
                {
                  Onpreco3Changing(ref value);
                  ReportPropertyChanging("preco3");
                  _preco3 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("preco3");
                  Onpreco3Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _preco3 = 0m;
        partial void OnGetpreco3(ref global::System.Nullable<decimal> value);
        partial void Onpreco3Changing(ref global::System.Nullable<decimal> value);
        partial void Onpreco3Changed();
    
        /// <summary>
        /// There are no comments for preco4 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> preco4
        {
            get
            {
                global::System.Nullable<decimal> value = _preco4;
                OnGetpreco4(ref value);
                return value;
            }
            set
            {
                if (_preco4 != value)
                {
                  Onpreco4Changing(ref value);
                  ReportPropertyChanging("preco4");
                  _preco4 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("preco4");
                  Onpreco4Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _preco4 = 0m;
        partial void OnGetpreco4(ref global::System.Nullable<decimal> value);
        partial void Onpreco4Changing(ref global::System.Nullable<decimal> value);
        partial void Onpreco4Changed();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wktabprc_modcli obj = new wktabprc_modcli();
            obj.spid = spid;
            obj.modelo = modelo;
            obj.variante = variante;
            obj.cliente = cliente;
            obj.idotam = idotam;
            obj.iaotam = iaotam;
            obj.dotam = dotam;
            obj.aotam = aotam;
            obj.estacao = estacao;
            obj.preco = preco;
            obj.moeda = moeda;
            obj.imagem = imagem;
            obj.preco1 = preco1;
            obj.preco2 = preco2;
            obj.preco3 = preco3;
            obj.preco4 = preco4;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wktabprc_modcli toCompare = obj as wktabprc_modcli;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.spid, toCompare.spid))
            return false;
          if (!Object.Equals(this.modelo, toCompare.modelo))
            return false;
          if (!Object.Equals(this.variante, toCompare.variante))
            return false;
          if (!Object.Equals(this.cliente, toCompare.cliente))
            return false;
          if (!Object.Equals(this.idotam, toCompare.idotam))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + spid.GetHashCode();
          hashCode = (hashCode * 7) + modelo.GetHashCode();
          hashCode = (hashCode * 7) + variante.GetHashCode();
          hashCode = (hashCode * 7) + cliente.GetHashCode();
          hashCode = (hashCode * 7) + idotam.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}