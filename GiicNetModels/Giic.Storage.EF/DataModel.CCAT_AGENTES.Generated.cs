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
    /// There are no comments for DataGiic_LiagoModel.CCAT_AGENTES in the schema.
    /// </summary>
    /// <KeyProperties>
    /// nrregCat
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CCAT_AGENTES")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CCAT_AGENTES : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CCAT_AGENTES object.
        /// </summary>
        /// <param name="nrregCat">Initial value of nrregCat.</param>
        /// <param name="catalogo">Initial value of catalogo.</param>
        /// <param name="agente">Initial value of agente.</param>
        public static CCAT_AGENTES CreateCCAT_AGENTES(global::System.Guid nrregCat, string catalogo, string agente)
        {
            CCAT_AGENTES cCAT_AGENTES = new CCAT_AGENTES();
            cCAT_AGENTES.nrregCat = nrregCat;
            cCAT_AGENTES.catalogo = catalogo;
            cCAT_AGENTES.agente = agente;
            return cCAT_AGENTES;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for nrregCat in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.Guid nrregCat
        {
            get
            {
                global::System.Guid value = _nrregCat;
                OnGetnrregCat(ref value);
                return value;
            }
            set
            {
                if (_nrregCat != value)
                {
                  OnnrregCatChanging(ref value);
                  ReportPropertyChanging("nrregCat");
                  _nrregCat = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("nrregCat");
                  OnnrregCatChanged();
              }
            }
        }
        private global::System.Guid _nrregCat;
        partial void OnGetnrregCat(ref global::System.Guid value);
        partial void OnnrregCatChanging(ref global::System.Guid value);
        partial void OnnrregCatChanged();
    
        /// <summary>
        /// There are no comments for catalogo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
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
        /// There are no comments for descricao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string descricao
        {
            get
            {
                string value = _descricao;
                OnGetdescricao(ref value);
                return value;
            }
            set
            {
                if (_descricao != value)
                {
                  OndescricaoChanging(ref value);
                  ReportPropertyChanging("descricao");
                  _descricao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("descricao");
                  OndescricaoChanged();
              }
            }
        }
        private string _descricao;
        partial void OnGetdescricao(ref string value);
        partial void OndescricaoChanging(ref string value);
        partial void OndescricaoChanged();
    
        /// <summary>
        /// There are no comments for agente in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string agente
        {
            get
            {
                string value = _agente;
                OnGetagente(ref value);
                return value;
            }
            set
            {
                if (_agente != value)
                {
                  OnagenteChanging(ref value);
                  ReportPropertyChanging("agente");
                  _agente = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("agente");
                  OnagenteChanged();
              }
            }
        }
        private string _agente;
        partial void OnGetagente(ref string value);
        partial void OnagenteChanging(ref string value);
        partial void OnagenteChanged();
    
        /// <summary>
        /// There are no comments for agente1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string agente1
        {
            get
            {
                string value = _agente1;
                OnGetagente1(ref value);
                return value;
            }
            set
            {
                if (_agente1 != value)
                {
                  Onagente1Changing(ref value);
                  ReportPropertyChanging("agente1");
                  _agente1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("agente1");
                  Onagente1Changed();
              }
            }
        }
        private string _agente1;
        partial void OnGetagente1(ref string value);
        partial void Onagente1Changing(ref string value);
        partial void Onagente1Changed();
    
        /// <summary>
        /// There are no comments for agente2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string agente2
        {
            get
            {
                string value = _agente2;
                OnGetagente2(ref value);
                return value;
            }
            set
            {
                if (_agente2 != value)
                {
                  Onagente2Changing(ref value);
                  ReportPropertyChanging("agente2");
                  _agente2 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("agente2");
                  Onagente2Changed();
              }
            }
        }
        private string _agente2;
        partial void OnGetagente2(ref string value);
        partial void Onagente2Changing(ref string value);
        partial void Onagente2Changed();
    
        /// <summary>
        /// There are no comments for agente3 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string agente3
        {
            get
            {
                string value = _agente3;
                OnGetagente3(ref value);
                return value;
            }
            set
            {
                if (_agente3 != value)
                {
                  Onagente3Changing(ref value);
                  ReportPropertyChanging("agente3");
                  _agente3 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("agente3");
                  Onagente3Changed();
              }
            }
        }
        private string _agente3;
        partial void OnGetagente3(ref string value);
        partial void Onagente3Changing(ref string value);
        partial void Onagente3Changed();
    
        /// <summary>
        /// There are no comments for comissao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> comissao
        {
            get
            {
                global::System.Nullable<decimal> value = _comissao;
                OnGetcomissao(ref value);
                return value;
            }
            set
            {
                if (_comissao != value)
                {
                  OncomissaoChanging(ref value);
                  ReportPropertyChanging("comissao");
                  _comissao = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("comissao");
                  OncomissaoChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _comissao;
        partial void OnGetcomissao(ref global::System.Nullable<decimal> value);
        partial void OncomissaoChanging(ref global::System.Nullable<decimal> value);
        partial void OncomissaoChanged();
    
        /// <summary>
        /// There are no comments for comissao1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> comissao1
        {
            get
            {
                global::System.Nullable<decimal> value = _comissao1;
                OnGetcomissao1(ref value);
                return value;
            }
            set
            {
                if (_comissao1 != value)
                {
                  Oncomissao1Changing(ref value);
                  ReportPropertyChanging("comissao1");
                  _comissao1 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("comissao1");
                  Oncomissao1Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _comissao1;
        partial void OnGetcomissao1(ref global::System.Nullable<decimal> value);
        partial void Oncomissao1Changing(ref global::System.Nullable<decimal> value);
        partial void Oncomissao1Changed();
    
        /// <summary>
        /// There are no comments for comissao2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> comissao2
        {
            get
            {
                global::System.Nullable<decimal> value = _comissao2;
                OnGetcomissao2(ref value);
                return value;
            }
            set
            {
                if (_comissao2 != value)
                {
                  Oncomissao2Changing(ref value);
                  ReportPropertyChanging("comissao2");
                  _comissao2 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("comissao2");
                  Oncomissao2Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _comissao2;
        partial void OnGetcomissao2(ref global::System.Nullable<decimal> value);
        partial void Oncomissao2Changing(ref global::System.Nullable<decimal> value);
        partial void Oncomissao2Changed();
    
        /// <summary>
        /// There are no comments for comissao3 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> comissao3
        {
            get
            {
                global::System.Nullable<decimal> value = _comissao3;
                OnGetcomissao3(ref value);
                return value;
            }
            set
            {
                if (_comissao3 != value)
                {
                  Oncomissao3Changing(ref value);
                  ReportPropertyChanging("comissao3");
                  _comissao3 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("comissao3");
                  Oncomissao3Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _comissao3;
        partial void OnGetcomissao3(ref global::System.Nullable<decimal> value);
        partial void Oncomissao3Changing(ref global::System.Nullable<decimal> value);
        partial void Oncomissao3Changed();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CCAT_AGENTES obj = new CCAT_AGENTES();
            obj.nrregCat = nrregCat;
            obj.catalogo = catalogo;
            obj.descricao = descricao;
            obj.agente = agente;
            obj.agente1 = agente1;
            obj.agente2 = agente2;
            obj.agente3 = agente3;
            obj.comissao = comissao;
            obj.comissao1 = comissao1;
            obj.comissao2 = comissao2;
            obj.comissao3 = comissao3;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CCAT_AGENTES toCompare = obj as CCAT_AGENTES;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.nrregCat, toCompare.nrregCat))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + nrregCat.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
