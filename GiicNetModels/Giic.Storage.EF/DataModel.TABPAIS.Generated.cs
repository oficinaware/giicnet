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
    /// There are no comments for DataGiic_LiagoModel.TABPAIS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CODPAIS
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABPAIS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABPAIS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABPAIS object.
        /// </summary>
        /// <param name="cODPAIS">Initial value of CODPAIS.</param>
        /// <param name="dESCRICAO">Initial value of DESCRICAO.</param>
        public static TABPAIS CreateTABPAIS(string cODPAIS, string dESCRICAO)
        {
            TABPAIS tABPAIS = new TABPAIS();
            tABPAIS.CODPAIS = cODPAIS;
            tABPAIS.DESCRICAO = dESCRICAO;
            return tABPAIS;
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
    
        /// <summary>
        /// There are no comments for CATALOGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string CATALOGO
        {
            get
            {
                string value = _CATALOGO;
                OnGetCATALOGO(ref value);
                return value;
            }
            set
            {
                if (_CATALOGO != value)
                {
                  OnCATALOGOChanging(ref value);
                  ReportPropertyChanging("CATALOGO");
                  _CATALOGO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CATALOGO");
                  OnCATALOGOChanged();
              }
            }
        }
        private string _CATALOGO;
        partial void OnGetCATALOGO(ref string value);
        partial void OnCATALOGOChanging(ref string value);
        partial void OnCATALOGOChanged();
    
        /// <summary>
        /// There are no comments for CATALOGO_PVP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string CATALOGO_PVP
        {
            get
            {
                string value = _CATALOGO_PVP;
                OnGetCATALOGO_PVP(ref value);
                return value;
            }
            set
            {
                if (_CATALOGO_PVP != value)
                {
                  OnCATALOGO_PVPChanging(ref value);
                  ReportPropertyChanging("CATALOGO_PVP");
                  _CATALOGO_PVP = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CATALOGO_PVP");
                  OnCATALOGO_PVPChanged();
              }
            }
        }
        private string _CATALOGO_PVP;
        partial void OnGetCATALOGO_PVP(ref string value);
        partial void OnCATALOGO_PVPChanging(ref string value);
        partial void OnCATALOGO_PVPChanged();
    
        /// <summary>
        /// There are no comments for CTBCONTA_3D in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string CTBCONTA_3D
        {
            get
            {
                string value = _CTBCONTA_3D;
                OnGetCTBCONTA_3D(ref value);
                return value;
            }
            set
            {
                if (_CTBCONTA_3D != value)
                {
                  OnCTBCONTA_3DChanging(ref value);
                  ReportPropertyChanging("CTBCONTA_3D");
                  _CTBCONTA_3D = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CTBCONTA_3D");
                  OnCTBCONTA_3DChanged();
              }
            }
        }
        private string _CTBCONTA_3D;
        partial void OnGetCTBCONTA_3D(ref string value);
        partial void OnCTBCONTA_3DChanging(ref string value);
        partial void OnCTBCONTA_3DChanged();
    
        /// <summary>
        /// There are no comments for CTBCONTA_3C in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string CTBCONTA_3C
        {
            get
            {
                string value = _CTBCONTA_3C;
                OnGetCTBCONTA_3C(ref value);
                return value;
            }
            set
            {
                if (_CTBCONTA_3C != value)
                {
                  OnCTBCONTA_3CChanging(ref value);
                  ReportPropertyChanging("CTBCONTA_3C");
                  _CTBCONTA_3C = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CTBCONTA_3C");
                  OnCTBCONTA_3CChanged();
              }
            }
        }
        private string _CTBCONTA_3C;
        partial void OnGetCTBCONTA_3C(ref string value);
        partial void OnCTBCONTA_3CChanging(ref string value);
        partial void OnCTBCONTA_3CChanged();
    
        /// <summary>
        /// There are no comments for CTBCONTA_2D in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string CTBCONTA_2D
        {
            get
            {
                string value = _CTBCONTA_2D;
                OnGetCTBCONTA_2D(ref value);
                return value;
            }
            set
            {
                if (_CTBCONTA_2D != value)
                {
                  OnCTBCONTA_2DChanging(ref value);
                  ReportPropertyChanging("CTBCONTA_2D");
                  _CTBCONTA_2D = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CTBCONTA_2D");
                  OnCTBCONTA_2DChanged();
              }
            }
        }
        private string _CTBCONTA_2D;
        partial void OnGetCTBCONTA_2D(ref string value);
        partial void OnCTBCONTA_2DChanging(ref string value);
        partial void OnCTBCONTA_2DChanged();
    
        /// <summary>
        /// There are no comments for CTBCONTA_2C in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string CTBCONTA_2C
        {
            get
            {
                string value = _CTBCONTA_2C;
                OnGetCTBCONTA_2C(ref value);
                return value;
            }
            set
            {
                if (_CTBCONTA_2C != value)
                {
                  OnCTBCONTA_2CChanging(ref value);
                  ReportPropertyChanging("CTBCONTA_2C");
                  _CTBCONTA_2C = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CTBCONTA_2C");
                  OnCTBCONTA_2CChanged();
              }
            }
        }
        private string _CTBCONTA_2C;
        partial void OnGetCTBCONTA_2C(ref string value);
        partial void OnCTBCONTA_2CChanging(ref string value);
        partial void OnCTBCONTA_2CChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for CLIENTES in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_CLIENTES_TABPAIS", "CLIENTES")]
        public EntityCollection<CLIENTES> CLIENTES
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<CLIENTES>("DataGiic_LiagoModel.FK_CLIENTES_TABPAIS", "CLIENTES");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<CLIENTES>("DataGiic_LiagoModel.FK_CLIENTES_TABPAIS", "CLIENTES", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for CMPFORN in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_CMPFORN_TABPAIS", "CMPFORN")]
        public EntityCollection<CMPFORN> CMPFORN
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<CMPFORN>("DataGiic_LiagoModel.FK_CMPFORN_TABPAIS", "CMPFORN");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<CMPFORN>("DataGiic_LiagoModel.FK_CMPFORN_TABPAIS", "CMPFORN", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for TABZON in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_TABZON_TABPAIS", "TABZON")]
        public EntityCollection<TABZON> TABZON
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<TABZON>("DataGiic_LiagoModel.FK_TABZON_TABPAIS", "TABZON");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<TABZON>("DataGiic_LiagoModel.FK_TABZON_TABPAIS", "TABZON", value);
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TABPAIS obj = new TABPAIS();
            obj.CODPAIS = CODPAIS;
            obj.DESCRICAO = DESCRICAO;
            obj.codctb = codctb;
            obj.CATALOGO = CATALOGO;
            obj.CATALOGO_PVP = CATALOGO_PVP;
            obj.CTBCONTA_3D = CTBCONTA_3D;
            obj.CTBCONTA_3C = CTBCONTA_3C;
            obj.CTBCONTA_2D = CTBCONTA_2D;
            obj.CTBCONTA_2C = CTBCONTA_2C;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABPAIS toCompare = obj as TABPAIS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CODPAIS, toCompare.CODPAIS))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CODPAIS.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}