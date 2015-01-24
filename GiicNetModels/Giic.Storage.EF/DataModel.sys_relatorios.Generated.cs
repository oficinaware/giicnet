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
    /// There are no comments for DataGiic_LiagoModel.sys_relatorios in the schema.
    /// </summary>
    /// <KeyProperties>
    /// id_rel
    /// nome_relat
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="sys_relatorios")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sys_relatorios : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new sys_relatorios object.
        /// </summary>
        /// <param name="id_rel">Initial value of id_rel.</param>
        /// <param name="nome_relat">Initial value of nome_relat.</param>
        public static sys_relatorios Createsys_relatorios(string id_rel, string nome_relat)
        {
            sys_relatorios sys_relatorios = new sys_relatorios();
            sys_relatorios.id_rel = id_rel;
            sys_relatorios.nome_relat = nome_relat;
            return sys_relatorios;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for id_rel in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string id_rel
        {
            get
            {
                string value = _id_rel;
                OnGetid_rel(ref value);
                return value;
            }
            set
            {
                if (_id_rel != value)
                {
                  Onid_relChanging(ref value);
                  ReportPropertyChanging("id_rel");
                  _id_rel = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("id_rel");
                  Onid_relChanged();
              }
            }
        }
        private string _id_rel;
        partial void OnGetid_rel(ref string value);
        partial void Onid_relChanging(ref string value);
        partial void Onid_relChanged();
    
        /// <summary>
        /// There are no comments for nome_relat in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string nome_relat
        {
            get
            {
                string value = _nome_relat;
                OnGetnome_relat(ref value);
                return value;
            }
            set
            {
                if (_nome_relat != value)
                {
                  Onnome_relatChanging(ref value);
                  ReportPropertyChanging("nome_relat");
                  _nome_relat = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("nome_relat");
                  Onnome_relatChanged();
              }
            }
        }
        private string _nome_relat;
        partial void OnGetnome_relat(ref string value);
        partial void Onnome_relatChanging(ref string value);
        partial void Onnome_relatChanged();
    
        /// <summary>
        /// There are no comments for SUBFAM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string SUBFAM
        {
            get
            {
                string value = _SUBFAM;
                OnGetSUBFAM(ref value);
                return value;
            }
            set
            {
                if (_SUBFAM != value)
                {
                  OnSUBFAMChanging(ref value);
                  ReportPropertyChanging("SUBFAM");
                  _SUBFAM = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("SUBFAM");
                  OnSUBFAMChanged();
              }
            }
        }
        private string _SUBFAM;
        partial void OnGetSUBFAM(ref string value);
        partial void OnSUBFAMChanging(ref string value);
        partial void OnSUBFAMChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
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

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            sys_relatorios obj = new sys_relatorios();
            obj.id_rel = id_rel;
            obj.nome_relat = nome_relat;
            obj.SUBFAM = SUBFAM;
            obj.DESCRICAO = DESCRICAO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          sys_relatorios toCompare = obj as sys_relatorios;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.id_rel, toCompare.id_rel))
            return false;
          if (!Object.Equals(this.nome_relat, toCompare.nome_relat))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + id_rel.GetHashCode();
          hashCode = (hashCode * 7) + nome_relat.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}