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
    /// There are no comments for DataGiic_LiagoModel.TEMPLATES_CAB in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TEMPLATE
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TEMPLATES_CAB")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TEMPLATES_CAB : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TEMPLATES_CAB object.
        /// </summary>
        /// <param name="tEMPLATE">Initial value of TEMPLATE.</param>
        public static TEMPLATES_CAB CreateTEMPLATES_CAB(string tEMPLATE)
        {
            TEMPLATES_CAB tEMPLATES_CAB = new TEMPLATES_CAB();
            tEMPLATES_CAB.TEMPLATE = tEMPLATE;
            return tEMPLATES_CAB;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for TEMPLATE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TEMPLATE
        {
            get
            {
                string value = _TEMPLATE;
                OnGetTEMPLATE(ref value);
                return value;
            }
            set
            {
                if (_TEMPLATE != value)
                {
                  OnTEMPLATEChanging(ref value);
                  ReportPropertyChanging("TEMPLATE");
                  _TEMPLATE = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TEMPLATE");
                  OnTEMPLATEChanged();
              }
            }
        }
        private string _TEMPLATE;
        partial void OnGetTEMPLATE(ref string value);
        partial void OnTEMPLATEChanging(ref string value);
        partial void OnTEMPLATEChanged();
    
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

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for MODELOS in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_MODELOS_TEMPLATES_CAB", "MODELOS")]
        public EntityCollection<MODELOS> MODELOS
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<MODELOS>("DataGiic_LiagoModel.FK_MODELOS_TEMPLATES_CAB", "MODELOS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<MODELOS>("DataGiic_LiagoModel.FK_MODELOS_TEMPLATES_CAB", "MODELOS", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for TEMPLATES in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_TEMPLATES_TEMPLATES_CAB", "TEMPLATES")]
        public EntityCollection<TEMPLATES> TEMPLATES
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<TEMPLATES>("DataGiic_LiagoModel.FK_TEMPLATES_TEMPLATES_CAB", "TEMPLATES");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<TEMPLATES>("DataGiic_LiagoModel.FK_TEMPLATES_TEMPLATES_CAB", "TEMPLATES", value);
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TEMPLATES_CAB obj = new TEMPLATES_CAB();
            obj.TEMPLATE = TEMPLATE;
            obj.DESCRICAO = DESCRICAO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TEMPLATES_CAB toCompare = obj as TEMPLATES_CAB;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.TEMPLATE, toCompare.TEMPLATE))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + TEMPLATE.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
