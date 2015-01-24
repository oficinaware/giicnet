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
    /// There are no comments for DataGiic_LiagoModel.Subscricoes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CodSubscricao
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="Subscricoes")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Subscricoes : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new Subscricoes object.
        /// </summary>
        /// <param name="codSubscricao">Initial value of CodSubscricao.</param>
        public static Subscricoes CreateSubscricoes(string codSubscricao)
        {
            Subscricoes subscricoes = new Subscricoes();
            subscricoes.CodSubscricao = codSubscricao;
            return subscricoes;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CodSubscricao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CodSubscricao
        {
            get
            {
                string value = _CodSubscricao;
                OnGetCodSubscricao(ref value);
                return value;
            }
            set
            {
                if (_CodSubscricao != value)
                {
                  OnCodSubscricaoChanging(ref value);
                  ReportPropertyChanging("CodSubscricao");
                  _CodSubscricao = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CodSubscricao");
                  OnCodSubscricaoChanged();
              }
            }
        }
        private string _CodSubscricao;
        partial void OnGetCodSubscricao(ref string value);
        partial void OnCodSubscricaoChanging(ref string value);
        partial void OnCodSubscricaoChanged();
    
        /// <summary>
        /// There are no comments for Agente in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string Agente
        {
            get
            {
                string value = _Agente;
                OnGetAgente(ref value);
                return value;
            }
            set
            {
                if (_Agente != value)
                {
                  OnAgenteChanging(ref value);
                  ReportPropertyChanging("Agente");
                  _Agente = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Agente");
                  OnAgenteChanged();
              }
            }
        }
        private string _Agente = @"";
        partial void OnGetAgente(ref string value);
        partial void OnAgenteChanging(ref string value);
        partial void OnAgenteChanged();
    
        /// <summary>
        /// There are no comments for IDSubscricao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string IDSubscricao
        {
            get
            {
                string value = _IDSubscricao;
                OnGetIDSubscricao(ref value);
                return value;
            }
            set
            {
                if (_IDSubscricao != value)
                {
                  OnIDSubscricaoChanging(ref value);
                  ReportPropertyChanging("IDSubscricao");
                  _IDSubscricao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("IDSubscricao");
                  OnIDSubscricaoChanged();
              }
            }
        }
        private string _IDSubscricao = @"";
        partial void OnGetIDSubscricao(ref string value);
        partial void OnIDSubscricaoChanging(ref string value);
        partial void OnIDSubscricaoChanged();
    
        /// <summary>
        /// There are no comments for DescPort in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string DescPort
        {
            get
            {
                string value = _DescPort;
                OnGetDescPort(ref value);
                return value;
            }
            set
            {
                if (_DescPort != value)
                {
                  OnDescPortChanging(ref value);
                  ReportPropertyChanging("DescPort");
                  _DescPort = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DescPort");
                  OnDescPortChanged();
              }
            }
        }
        private string _DescPort = @"";
        partial void OnGetDescPort(ref string value);
        partial void OnDescPortChanging(ref string value);
        partial void OnDescPortChanged();
    
        /// <summary>
        /// There are no comments for DescIng in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string DescIng
        {
            get
            {
                string value = _DescIng;
                OnGetDescIng(ref value);
                return value;
            }
            set
            {
                if (_DescIng != value)
                {
                  OnDescIngChanging(ref value);
                  ReportPropertyChanging("DescIng");
                  _DescIng = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DescIng");
                  OnDescIngChanged();
              }
            }
        }
        private string _DescIng = @"";
        partial void OnGetDescIng(ref string value);
        partial void OnDescIngChanging(ref string value);
        partial void OnDescIngChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            Subscricoes obj = new Subscricoes();
            obj.CodSubscricao = CodSubscricao;
            obj.Agente = Agente;
            obj.IDSubscricao = IDSubscricao;
            obj.DescPort = DescPort;
            obj.DescIng = DescIng;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          Subscricoes toCompare = obj as Subscricoes;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CodSubscricao, toCompare.CodSubscricao))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CodSubscricao.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}