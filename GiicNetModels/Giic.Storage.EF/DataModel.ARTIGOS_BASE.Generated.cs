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
    /// There are no comments for DataGiic_LiagoModel.ARTIGOS_BASE in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ESTACAO
    /// MARCA
    /// FAMILIA
    /// ARTIGO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="ARTIGOS_BASE")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ARTIGOS_BASE : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new ARTIGOS_BASE object.
        /// </summary>
        /// <param name="eSTACAO">Initial value of ESTACAO.</param>
        /// <param name="mARCA">Initial value of MARCA.</param>
        /// <param name="fAMILIA">Initial value of FAMILIA.</param>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        public static ARTIGOS_BASE CreateARTIGOS_BASE(string eSTACAO, string mARCA, string fAMILIA, string aRTIGO)
        {
            ARTIGOS_BASE aRTIGOS_BASE = new ARTIGOS_BASE();
            aRTIGOS_BASE.ESTACAO = eSTACAO;
            aRTIGOS_BASE.MARCA = mARCA;
            aRTIGOS_BASE.FAMILIA = fAMILIA;
            aRTIGOS_BASE.ARTIGO = aRTIGO;
            return aRTIGOS_BASE;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ESTACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ESTACAO
        {
            get
            {
                string value = _ESTACAO;
                OnGetESTACAO(ref value);
                return value;
            }
            set
            {
                if (_ESTACAO != value)
                {
                  OnESTACAOChanging(ref value);
                  ReportPropertyChanging("ESTACAO");
                  _ESTACAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ESTACAO");
                  OnESTACAOChanged();
              }
            }
        }
        private string _ESTACAO;
        partial void OnGetESTACAO(ref string value);
        partial void OnESTACAOChanging(ref string value);
        partial void OnESTACAOChanged();
    
        /// <summary>
        /// There are no comments for MARCA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string MARCA
        {
            get
            {
                string value = _MARCA;
                OnGetMARCA(ref value);
                return value;
            }
            set
            {
                if (_MARCA != value)
                {
                  OnMARCAChanging(ref value);
                  ReportPropertyChanging("MARCA");
                  _MARCA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("MARCA");
                  OnMARCAChanged();
              }
            }
        }
        private string _MARCA;
        partial void OnGetMARCA(ref string value);
        partial void OnMARCAChanging(ref string value);
        partial void OnMARCAChanged();
    
        /// <summary>
        /// There are no comments for FAMILIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string FAMILIA
        {
            get
            {
                string value = _FAMILIA;
                OnGetFAMILIA(ref value);
                return value;
            }
            set
            {
                if (_FAMILIA != value)
                {
                  OnFAMILIAChanging(ref value);
                  ReportPropertyChanging("FAMILIA");
                  _FAMILIA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("FAMILIA");
                  OnFAMILIAChanged();
              }
            }
        }
        private string _FAMILIA;
        partial void OnGetFAMILIA(ref string value);
        partial void OnFAMILIAChanging(ref string value);
        partial void OnFAMILIAChanged();
    
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
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
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
        /// There are no comments for IMAGEM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        public string IMAGEM
        {
            get
            {
                string value = _IMAGEM;
                OnGetIMAGEM(ref value);
                return value;
            }
            set
            {
                if (_IMAGEM != value)
                {
                  OnIMAGEMChanging(ref value);
                  ReportPropertyChanging("IMAGEM");
                  _IMAGEM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("IMAGEM");
                  OnIMAGEMChanged();
              }
            }
        }
        private string _IMAGEM;
        partial void OnGetIMAGEM(ref string value);
        partial void OnIMAGEMChanging(ref string value);
        partial void OnIMAGEMChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            ARTIGOS_BASE obj = new ARTIGOS_BASE();
            obj.ESTACAO = ESTACAO;
            obj.MARCA = MARCA;
            obj.FAMILIA = FAMILIA;
            obj.ARTIGO = ARTIGO;
            obj.DESCRICAO = DESCRICAO;
            obj.IMAGEM = IMAGEM;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          ARTIGOS_BASE toCompare = obj as ARTIGOS_BASE;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ESTACAO, toCompare.ESTACAO))
            return false;
          if (!Object.Equals(this.MARCA, toCompare.MARCA))
            return false;
          if (!Object.Equals(this.FAMILIA, toCompare.FAMILIA))
            return false;
          if (!Object.Equals(this.ARTIGO, toCompare.ARTIGO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ESTACAO.GetHashCode();
          hashCode = (hashCode * 7) + MARCA.GetHashCode();
          hashCode = (hashCode * 7) + FAMILIA.GetHashCode();
          hashCode = (hashCode * 7) + ARTIGO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
