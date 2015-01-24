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
    /// There are no comments for DataGiic_LiagoModel.wkcores in the schema.
    /// </summary>
    /// <KeyProperties>
    /// spid
    /// cartaz
    /// cod_var
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wkcores")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wkcores : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wkcores object.
        /// </summary>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="cartaz">Initial value of cartaz.</param>
        /// <param name="cod_var">Initial value of cod_var.</param>
        /// <param name="cor">Initial value of cor.</param>
        /// <param name="sel">Initial value of sel.</param>
        public static wkcores Createwkcores(int spid, string cartaz, string cod_var, string cor, bool sel)
        {
            wkcores wkcores = new wkcores();
            wkcores.spid = spid;
            wkcores.cartaz = cartaz;
            wkcores.cod_var = cod_var;
            wkcores.cor = cor;
            wkcores.sel = sel;
            return wkcores;
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
        /// There are no comments for cartaz in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string cartaz
        {
            get
            {
                string value = _cartaz;
                OnGetcartaz(ref value);
                return value;
            }
            set
            {
                if (_cartaz != value)
                {
                  OncartazChanging(ref value);
                  ReportPropertyChanging("cartaz");
                  _cartaz = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("cartaz");
                  OncartazChanged();
              }
            }
        }
        private string _cartaz;
        partial void OnGetcartaz(ref string value);
        partial void OncartazChanging(ref string value);
        partial void OncartazChanged();
    
        /// <summary>
        /// There are no comments for cod_var in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string cod_var
        {
            get
            {
                string value = _cod_var;
                OnGetcod_var(ref value);
                return value;
            }
            set
            {
                if (_cod_var != value)
                {
                  Oncod_varChanging(ref value);
                  ReportPropertyChanging("cod_var");
                  _cod_var = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("cod_var");
                  Oncod_varChanged();
              }
            }
        }
        private string _cod_var;
        partial void OnGetcod_var(ref string value);
        partial void Oncod_varChanging(ref string value);
        partial void Oncod_varChanged();
    
        /// <summary>
        /// There are no comments for cor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string cor
        {
            get
            {
                string value = _cor;
                OnGetcor(ref value);
                return value;
            }
            set
            {
                if (_cor != value)
                {
                  OncorChanging(ref value);
                  ReportPropertyChanging("cor");
                  _cor = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("cor");
                  OncorChanged();
              }
            }
        }
        private string _cor;
        partial void OnGetcor(ref string value);
        partial void OncorChanging(ref string value);
        partial void OncorChanged();
    
        /// <summary>
        /// There are no comments for codrota in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string codrota
        {
            get
            {
                string value = _codrota;
                OnGetcodrota(ref value);
                return value;
            }
            set
            {
                if (_codrota != value)
                {
                  OncodrotaChanging(ref value);
                  ReportPropertyChanging("codrota");
                  _codrota = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codrota");
                  OncodrotaChanged();
              }
            }
        }
        private string _codrota;
        partial void OnGetcodrota(ref string value);
        partial void OncodrotaChanging(ref string value);
        partial void OncodrotaChanged();
    
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
        /// There are no comments for sel in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public bool sel
        {
            get
            {
                bool value = _sel;
                OnGetsel(ref value);
                return value;
            }
            set
            {
                if (_sel != value)
                {
                  OnselChanging(ref value);
                  ReportPropertyChanging("sel");
                  _sel = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("sel");
                  OnselChanged();
              }
            }
        }
        private bool _sel;
        partial void OnGetsel(ref bool value);
        partial void OnselChanging(ref bool value);
        partial void OnselChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wkcores obj = new wkcores();
            obj.spid = spid;
            obj.cartaz = cartaz;
            obj.cod_var = cod_var;
            obj.cor = cor;
            obj.codrota = codrota;
            obj.descricao = descricao;
            obj.sel = sel;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wkcores toCompare = obj as wkcores;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.spid, toCompare.spid))
            return false;
          if (!Object.Equals(this.cartaz, toCompare.cartaz))
            return false;
          if (!Object.Equals(this.cod_var, toCompare.cod_var))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + spid.GetHashCode();
          hashCode = (hashCode * 7) + cartaz.GetHashCode();
          hashCode = (hashCode * 7) + cod_var.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}