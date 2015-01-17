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
    /// There are no comments for DataGiic_LiagoModel.CCATALOG in the schema.
    /// </summary>
    /// <KeyProperties>
    /// catalogo
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CCATALOG")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CCATALOG : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CCATALOG object.
        /// </summary>
        /// <param name="catalogo">Initial value of catalogo.</param>
        public static CCATALOG CreateCCATALOG(string catalogo)
        {
            CCATALOG cCATALOG = new CCATALOG();
            cCATALOG.catalogo = catalogo;
            return cCATALOG;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for catalogo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string catalogo
        {
            get
            {
                string value = _catalogo;
                OnGetcatalogo(ref value);
                return value;
            }
            set
            {
                if (_catalogo != value)
                {
                  OncatalogoChanging(ref value);
                  ReportPropertyChanging("catalogo");
                  _catalogo = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("catalogo");
                  OncatalogoChanged();
              }
            }
        }
        private string _catalogo;
        partial void OnGetcatalogo(ref string value);
        partial void OncatalogoChanging(ref string value);
        partial void OncatalogoChanged();
    
        /// <summary>
        /// There are no comments for Descricao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string Descricao
        {
            get
            {
                string value = _Descricao;
                OnGetDescricao(ref value);
                return value;
            }
            set
            {
                if (_Descricao != value)
                {
                  OnDescricaoChanging(ref value);
                  ReportPropertyChanging("Descricao");
                  _Descricao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Descricao");
                  OnDescricaoChanged();
              }
            }
        }
        private string _Descricao;
        partial void OnGetDescricao(ref string value);
        partial void OnDescricaoChanging(ref string value);
        partial void OnDescricaoChanged();
    
        /// <summary>
        /// There are no comments for estacao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
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
        /// There are no comments for data in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> data
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _data;
                OnGetdata(ref value);
                return value;
            }
            set
            {
                if (_data != value)
                {
                  OndataChanging(ref value);
                  ReportPropertyChanging("data");
                  _data = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("data");
                  OndataChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _data;
        partial void OnGetdata(ref global::System.Nullable<System.DateTime> value);
        partial void OndataChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OndataChanged();
    
        /// <summary>
        /// There are no comments for cliente in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
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
                  _cliente = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for coment in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string coment
        {
            get
            {
                string value = _coment;
                OnGetcoment(ref value);
                return value;
            }
            set
            {
                if (_coment != value)
                {
                  OncomentChanging(ref value);
                  ReportPropertyChanging("coment");
                  _coment = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("coment");
                  OncomentChanged();
              }
            }
        }
        private string _coment;
        partial void OnGetcoment(ref string value);
        partial void OncomentChanging(ref string value);
        partial void OncomentChanged();
    
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
        /// There are no comments for link_cabecalho in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string link_cabecalho
        {
            get
            {
                string value = _link_cabecalho;
                OnGetlink_cabecalho(ref value);
                return value;
            }
            set
            {
                if (_link_cabecalho != value)
                {
                  Onlink_cabecalhoChanging(ref value);
                  ReportPropertyChanging("link_cabecalho");
                  _link_cabecalho = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("link_cabecalho");
                  Onlink_cabecalhoChanged();
              }
            }
        }
        private string _link_cabecalho;
        partial void OnGetlink_cabecalho(ref string value);
        partial void Onlink_cabecalhoChanging(ref string value);
        partial void Onlink_cabecalhoChanged();
    
        /// <summary>
        /// There are no comments for CondPag in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(300)]
        public string CondPag
        {
            get
            {
                string value = _CondPag;
                OnGetCondPag(ref value);
                return value;
            }
            set
            {
                if (_CondPag != value)
                {
                  OnCondPagChanging(ref value);
                  ReportPropertyChanging("CondPag");
                  _CondPag = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CondPag");
                  OnCondPagChanged();
              }
            }
        }
        private string _CondPag = @"";
        partial void OnGetCondPag(ref string value);
        partial void OnCondPagChanging(ref string value);
        partial void OnCondPagChanged();
    
        /// <summary>
        /// There are no comments for CondEnt in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(300)]
        public string CondEnt
        {
            get
            {
                string value = _CondEnt;
                OnGetCondEnt(ref value);
                return value;
            }
            set
            {
                if (_CondEnt != value)
                {
                  OnCondEntChanging(ref value);
                  ReportPropertyChanging("CondEnt");
                  _CondEnt = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CondEnt");
                  OnCondEntChanged();
              }
            }
        }
        private string _CondEnt;
        partial void OnGetCondEnt(ref string value);
        partial void OnCondEntChanging(ref string value);
        partial void OnCondEntChanged();
    
        /// <summary>
        /// There are no comments for DadosBancarios in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(300)]
        public string DadosBancarios
        {
            get
            {
                string value = _DadosBancarios;
                OnGetDadosBancarios(ref value);
                return value;
            }
            set
            {
                if (_DadosBancarios != value)
                {
                  OnDadosBancariosChanging(ref value);
                  ReportPropertyChanging("DadosBancarios");
                  _DadosBancarios = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DadosBancarios");
                  OnDadosBancariosChanged();
              }
            }
        }
        private string _DadosBancarios = @"";
        partial void OnGetDadosBancarios(ref string value);
        partial void OnDadosBancariosChanging(ref string value);
        partial void OnDadosBancariosChanged();
    
        /// <summary>
        /// There are no comments for ObsQuant in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(300)]
        public string ObsQuant
        {
            get
            {
                string value = _ObsQuant;
                OnGetObsQuant(ref value);
                return value;
            }
            set
            {
                if (_ObsQuant != value)
                {
                  OnObsQuantChanging(ref value);
                  ReportPropertyChanging("ObsQuant");
                  _ObsQuant = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ObsQuant");
                  OnObsQuantChanged();
              }
            }
        }
        private string _ObsQuant = @"";
        partial void OnGetObsQuant(ref string value);
        partial void OnObsQuantChanging(ref string value);
        partial void OnObsQuantChanged();
    
        /// <summary>
        /// There are no comments for Obs in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(300)]
        public string Obs
        {
            get
            {
                string value = _Obs;
                OnGetObs(ref value);
                return value;
            }
            set
            {
                if (_Obs != value)
                {
                  OnObsChanging(ref value);
                  ReportPropertyChanging("Obs");
                  _Obs = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Obs");
                  OnObsChanged();
              }
            }
        }
        private string _Obs;
        partial void OnGetObs(ref string value);
        partial void OnObsChanging(ref string value);
        partial void OnObsChanged();
    
        /// <summary>
        /// There are no comments for online in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> online
        {
            get
            {
                global::System.Nullable<bool> value = _online;
                OnGetonline(ref value);
                return value;
            }
            set
            {
                if (_online != value)
                {
                  OnonlineChanging(ref value);
                  ReportPropertyChanging("online");
                  _online = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("online");
                  OnonlineChanged();
              }
            }
        }
        private global::System.Nullable<bool> _online;
        partial void OnGetonline(ref global::System.Nullable<bool> value);
        partial void OnonlineChanging(ref global::System.Nullable<bool> value);
        partial void OnonlineChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for CATALOGO in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_CATALOGO_CCATALOG", "CATALOGO")]
        public EntityCollection<CATALOGO> CATALOGO
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<CATALOGO>("DataGiic_LiagoModel.FK_CATALOGO_CCATALOG", "CATALOGO");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<CATALOGO>("DataGiic_LiagoModel.FK_CATALOGO_CCATALOG", "CATALOGO", value);
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CCATALOG obj = new CCATALOG();
            obj.catalogo = catalogo;
            obj.Descricao = Descricao;
            obj.estacao = estacao;
            obj.data = data;
            obj.cliente = cliente;
            obj.coment = coment;
            obj.moeda = moeda;
            obj.link_cabecalho = link_cabecalho;
            obj.CondPag = CondPag;
            obj.CondEnt = CondEnt;
            obj.DadosBancarios = DadosBancarios;
            obj.ObsQuant = ObsQuant;
            obj.Obs = Obs;
            obj.online = online;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CCATALOG toCompare = obj as CCATALOG;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.catalogo, toCompare.catalogo))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + catalogo.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
