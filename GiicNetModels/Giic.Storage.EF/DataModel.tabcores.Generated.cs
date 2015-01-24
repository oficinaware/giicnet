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
    /// There are no comments for DataGiic_LiagoModel.tabcores in the schema.
    /// </summary>
    /// <KeyProperties>
    /// cartaz
    /// codcor
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="tabcores")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tabcores : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new tabcores object.
        /// </summary>
        /// <param name="cartaz">Initial value of cartaz.</param>
        /// <param name="codcor">Initial value of codcor.</param>
        public static tabcores Createtabcores(string cartaz, string codcor)
        {
            tabcores tabcores = new tabcores();
            tabcores.cartaz = cartaz;
            tabcores.codcor = codcor;
            return tabcores;
        }

        #endregion

        #region Properties
    
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
        private string _codcor;
        partial void OnGetcodcor(ref string value);
        partial void OncodcorChanging(ref string value);
        partial void OncodcorChanged();
    
        /// <summary>
        /// There are no comments for cor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
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
                  _cor = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for cor_ingles in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string cor_ingles
        {
            get
            {
                string value = _cor_ingles;
                OnGetcor_ingles(ref value);
                return value;
            }
            set
            {
                if (_cor_ingles != value)
                {
                  Oncor_inglesChanging(ref value);
                  ReportPropertyChanging("cor_ingles");
                  _cor_ingles = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cor_ingles");
                  Oncor_inglesChanged();
              }
            }
        }
        private string _cor_ingles;
        partial void OnGetcor_ingles(ref string value);
        partial void Oncor_inglesChanging(ref string value);
        partial void Oncor_inglesChanged();
    
        /// <summary>
        /// There are no comments for cor_frances in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string cor_frances
        {
            get
            {
                string value = _cor_frances;
                OnGetcor_frances(ref value);
                return value;
            }
            set
            {
                if (_cor_frances != value)
                {
                  Oncor_francesChanging(ref value);
                  ReportPropertyChanging("cor_frances");
                  _cor_frances = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cor_frances");
                  Oncor_francesChanged();
              }
            }
        }
        private string _cor_frances;
        partial void OnGetcor_frances(ref string value);
        partial void Oncor_francesChanging(ref string value);
        partial void Oncor_francesChanged();
    
        /// <summary>
        /// There are no comments for cor_cliente in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string cor_cliente
        {
            get
            {
                string value = _cor_cliente;
                OnGetcor_cliente(ref value);
                return value;
            }
            set
            {
                if (_cor_cliente != value)
                {
                  Oncor_clienteChanging(ref value);
                  ReportPropertyChanging("cor_cliente");
                  _cor_cliente = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cor_cliente");
                  Oncor_clienteChanged();
              }
            }
        }
        private string _cor_cliente;
        partial void OnGetcor_cliente(ref string value);
        partial void Oncor_clienteChanging(ref string value);
        partial void Oncor_clienteChanged();
    
        /// <summary>
        /// There are no comments for tipocor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string tipocor
        {
            get
            {
                string value = _tipocor;
                OnGettipocor(ref value);
                return value;
            }
            set
            {
                if (_tipocor != value)
                {
                  OntipocorChanging(ref value);
                  ReportPropertyChanging("tipocor");
                  _tipocor = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("tipocor");
                  OntipocorChanged();
              }
            }
        }
        private string _tipocor;
        partial void OnGettipocor(ref string value);
        partial void OntipocorChanging(ref string value);
        partial void OntipocorChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for ARTIGOCOR in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_ARTIGOCOR_tabcores", "ARTIGOCOR")]
        public EntityCollection<ARTIGOCOR> ARTIGOCOR
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<ARTIGOCOR>("DataGiic_LiagoModel.FK_ARTIGOCOR_tabcores", "ARTIGOCOR");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<ARTIGOCOR>("DataGiic_LiagoModel.FK_ARTIGOCOR_tabcores", "ARTIGOCOR", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for cabcartaz in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_tabcores_cabcartaz", "cabcartaz")]
        public cabcartaz cabcartaz
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<cabcartaz>("DataGiic_LiagoModel.FK_tabcores_cabcartaz", "cabcartaz").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<cabcartaz>("DataGiic_LiagoModel.FK_tabcores_cabcartaz", "cabcartaz").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for cabcartaz in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<cabcartaz> cabcartazReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<cabcartaz>("DataGiic_LiagoModel.FK_tabcores_cabcartaz", "cabcartaz");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<cabcartaz>("DataGiic_LiagoModel.FK_tabcores_cabcartaz", "cabcartaz", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<cabcartaz>("DataGiic_LiagoModel.FK_tabcores_cabcartaz", "cabcartaz").Value = null;
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            tabcores obj = new tabcores();
            obj.cartaz = cartaz;
            obj.codcor = codcor;
            obj.cor = cor;
            obj.cor_ingles = cor_ingles;
            obj.cor_frances = cor_frances;
            obj.cor_cliente = cor_cliente;
            obj.tipocor = tipocor;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          tabcores toCompare = obj as tabcores;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.cartaz, toCompare.cartaz))
            return false;
          if (!Object.Equals(this.codcor, toCompare.codcor))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + cartaz.GetHashCode();
          hashCode = (hashCode * 7) + codcor.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}