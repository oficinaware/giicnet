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
    /// There are no comments for DataGiic_LiagoModel.wk_mrp_disp_det in the schema.
    /// </summary>
    /// <KeyProperties>
    /// arm
    /// artigo
    /// cartaz
    /// codcor
    /// tam
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wk_mrp_disp_det")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wk_mrp_disp_det : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wk_mrp_disp_det object.
        /// </summary>
        /// <param name="arm">Initial value of arm.</param>
        /// <param name="artigo">Initial value of artigo.</param>
        /// <param name="cartaz">Initial value of cartaz.</param>
        /// <param name="codcor">Initial value of codcor.</param>
        /// <param name="tam">Initial value of tam.</param>
        public static wk_mrp_disp_det Createwk_mrp_disp_det(string arm, string artigo, string cartaz, string codcor, string tam)
        {
            wk_mrp_disp_det wk_mrp_disp_det = new wk_mrp_disp_det();
            wk_mrp_disp_det.arm = arm;
            wk_mrp_disp_det.artigo = artigo;
            wk_mrp_disp_det.cartaz = cartaz;
            wk_mrp_disp_det.codcor = codcor;
            wk_mrp_disp_det.tam = tam;
            return wk_mrp_disp_det;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for arm in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string arm
        {
            get
            {
                string value = _arm;
                OnGetarm(ref value);
                return value;
            }
            set
            {
                if (_arm != value)
                {
                  OnarmChanging(ref value);
                  ReportPropertyChanging("arm");
                  _arm = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("arm");
                  OnarmChanged();
              }
            }
        }
        private string _arm = @"space(3)";
        partial void OnGetarm(ref string value);
        partial void OnarmChanging(ref string value);
        partial void OnarmChanged();
    
        /// <summary>
        /// There are no comments for artigo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string artigo
        {
            get
            {
                string value = _artigo;
                OnGetartigo(ref value);
                return value;
            }
            set
            {
                if (_artigo != value)
                {
                  OnartigoChanging(ref value);
                  ReportPropertyChanging("artigo");
                  _artigo = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("artigo");
                  OnartigoChanged();
              }
            }
        }
        private string _artigo;
        partial void OnGetartigo(ref string value);
        partial void OnartigoChanging(ref string value);
        partial void OnartigoChanged();
    
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
        private string _cartaz = @"space(5)";
        partial void OnGetcartaz(ref string value);
        partial void OncartazChanging(ref string value);
        partial void OncartazChanged();
    
        /// <summary>
        /// There are no comments for codcor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
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
        /// There are no comments for tam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string tam
        {
            get
            {
                string value = _tam;
                OnGettam(ref value);
                return value;
            }
            set
            {
                if (_tam != value)
                {
                  OntamChanging(ref value);
                  ReportPropertyChanging("tam");
                  _tam = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("tam");
                  OntamChanged();
              }
            }
        }
        private string _tam = @"space(4)";
        partial void OnGettam(ref string value);
        partial void OntamChanging(ref string value);
        partial void OntamChanged();
    
        /// <summary>
        /// There are no comments for Saldo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> Saldo
        {
            get
            {
                global::System.Nullable<decimal> value = _Saldo;
                OnGetSaldo(ref value);
                return value;
            }
            set
            {
                if (_Saldo != value)
                {
                  OnSaldoChanging(ref value);
                  ReportPropertyChanging("Saldo");
                  _Saldo = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Saldo");
                  OnSaldoChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _Saldo;
        partial void OnGetSaldo(ref global::System.Nullable<decimal> value);
        partial void OnSaldoChanging(ref global::System.Nullable<decimal> value);
        partial void OnSaldoChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wk_mrp_disp_det obj = new wk_mrp_disp_det();
            obj.arm = arm;
            obj.artigo = artigo;
            obj.cartaz = cartaz;
            obj.codcor = codcor;
            obj.tam = tam;
            obj.Saldo = Saldo;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wk_mrp_disp_det toCompare = obj as wk_mrp_disp_det;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.arm, toCompare.arm))
            return false;
          if (!Object.Equals(this.artigo, toCompare.artigo))
            return false;
          if (!Object.Equals(this.cartaz, toCompare.cartaz))
            return false;
          if (!Object.Equals(this.codcor, toCompare.codcor))
            return false;
          if (!Object.Equals(this.tam, toCompare.tam))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + arm.GetHashCode();
          hashCode = (hashCode * 7) + artigo.GetHashCode();
          hashCode = (hashCode * 7) + cartaz.GetHashCode();
          hashCode = (hashCode * 7) + codcor.GetHashCode();
          hashCode = (hashCode * 7) + tam.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
