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
    /// There are no comments for DataGiic_LiagoModel.TABZON in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CODPAIS
    /// CODZON
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABZON")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABZON : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABZON object.
        /// </summary>
        /// <param name="cODPAIS">Initial value of CODPAIS.</param>
        /// <param name="cODZON">Initial value of CODZON.</param>
        /// <param name="dESCRICAO">Initial value of DESCRICAO.</param>
        public static TABZON CreateTABZON(string cODPAIS, string cODZON, string dESCRICAO)
        {
            TABZON tABZON = new TABZON();
            tABZON.CODPAIS = cODPAIS;
            tABZON.CODZON = cODZON;
            tABZON.DESCRICAO = dESCRICAO;
            return tABZON;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CODPAIS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODPAIS
        {
            get
            {
                string value = _CODPAIS;
                OnGetCODPAIS(ref value);
                return value;
            }
            set
            {
                if (_CODPAIS != value)
                {
                  OnCODPAISChanging(ref value);
                  ReportPropertyChanging("CODPAIS");
                  _CODPAIS = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODPAIS");
                  OnCODPAISChanged();
              }
            }
        }
        private string _CODPAIS;
        partial void OnGetCODPAIS(ref string value);
        partial void OnCODPAISChanging(ref string value);
        partial void OnCODPAISChanged();
    
        /// <summary>
        /// There are no comments for CODZON in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODZON
        {
            get
            {
                string value = _CODZON;
                OnGetCODZON(ref value);
                return value;
            }
            set
            {
                if (_CODZON != value)
                {
                  OnCODZONChanging(ref value);
                  ReportPropertyChanging("CODZON");
                  _CODZON = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODZON");
                  OnCODZONChanged();
              }
            }
        }
        private string _CODZON;
        partial void OnGetCODZON(ref string value);
        partial void OnCODZONChanging(ref string value);
        partial void OnCODZONChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        [System.ComponentModel.DataAnnotations.Required()]
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
                  _DESCRICAO = StructuralObject.SetValidValue(value, false);
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
        /// There are no comments for codctb in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codctb
        {
            get
            {
                string value = _codctb;
                OnGetcodctb(ref value);
                return value;
            }
            set
            {
                if (_codctb != value)
                {
                  OncodctbChanging(ref value);
                  ReportPropertyChanging("codctb");
                  _codctb = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codctb");
                  OncodctbChanged();
              }
            }
        }
        private string _codctb;
        partial void OnGetcodctb(ref string value);
        partial void OncodctbChanging(ref string value);
        partial void OncodctbChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for CLIENTES in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_CLIENTES_TABZON", "CLIENTES")]
        public EntityCollection<CLIENTES> CLIENTES
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<CLIENTES>("DataGiic_LiagoModel.FK_CLIENTES_TABZON", "CLIENTES");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<CLIENTES>("DataGiic_LiagoModel.FK_CLIENTES_TABZON", "CLIENTES", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for TABLOCAL in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_TABLOCAL_TABZON", "TABLOCAL")]
        public EntityCollection<TABLOCAL> TABLOCAL
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<TABLOCAL>("DataGiic_LiagoModel.FK_TABLOCAL_TABZON", "TABLOCAL");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<TABLOCAL>("DataGiic_LiagoModel.FK_TABLOCAL_TABZON", "TABLOCAL", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for TABPAIS in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_TABZON_TABPAIS", "TABPAIS")]
        public TABPAIS TABPAIS
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TABPAIS>("DataGiic_LiagoModel.FK_TABZON_TABPAIS", "TABPAIS").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TABPAIS>("DataGiic_LiagoModel.FK_TABZON_TABPAIS", "TABPAIS").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for TABPAIS in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TABPAIS> TABPAISReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TABPAIS>("DataGiic_LiagoModel.FK_TABZON_TABPAIS", "TABPAIS");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<TABPAIS>("DataGiic_LiagoModel.FK_TABZON_TABPAIS", "TABPAIS", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TABPAIS>("DataGiic_LiagoModel.FK_TABZON_TABPAIS", "TABPAIS").Value = null;
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TABZON obj = new TABZON();
            obj.CODPAIS = CODPAIS;
            obj.CODZON = CODZON;
            obj.DESCRICAO = DESCRICAO;
            obj.codctb = codctb;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABZON toCompare = obj as TABZON;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CODPAIS, toCompare.CODPAIS))
            return false;
          if (!Object.Equals(this.CODZON, toCompare.CODZON))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CODPAIS.GetHashCode();
          hashCode = (hashCode * 7) + CODZON.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
