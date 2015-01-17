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
    /// There are no comments for DataGiic_LiagoModel.TAB_CAPAC in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SECCAO
    /// SISTEMA
    /// SEMANA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TAB_CAPAC")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TAB_CAPAC : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TAB_CAPAC object.
        /// </summary>
        /// <param name="sECCAO">Initial value of SECCAO.</param>
        /// <param name="sISTEMA">Initial value of SISTEMA.</param>
        /// <param name="sEMANA">Initial value of SEMANA.</param>
        public static TAB_CAPAC CreateTAB_CAPAC(string sECCAO, string sISTEMA, string sEMANA)
        {
            TAB_CAPAC tAB_CAPAC = new TAB_CAPAC();
            tAB_CAPAC.SECCAO = sECCAO;
            tAB_CAPAC.SISTEMA = sISTEMA;
            tAB_CAPAC.SEMANA = sEMANA;
            return tAB_CAPAC;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for SECCAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string SECCAO
        {
            get
            {
                string value = _SECCAO;
                OnGetSECCAO(ref value);
                return value;
            }
            set
            {
                if (_SECCAO != value)
                {
                  OnSECCAOChanging(ref value);
                  ReportPropertyChanging("SECCAO");
                  _SECCAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("SECCAO");
                  OnSECCAOChanged();
              }
            }
        }
        private string _SECCAO;
        partial void OnGetSECCAO(ref string value);
        partial void OnSECCAOChanging(ref string value);
        partial void OnSECCAOChanged();
    
        /// <summary>
        /// There are no comments for SISTEMA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string SISTEMA
        {
            get
            {
                string value = _SISTEMA;
                OnGetSISTEMA(ref value);
                return value;
            }
            set
            {
                if (_SISTEMA != value)
                {
                  OnSISTEMAChanging(ref value);
                  ReportPropertyChanging("SISTEMA");
                  _SISTEMA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("SISTEMA");
                  OnSISTEMAChanged();
              }
            }
        }
        private string _SISTEMA;
        partial void OnGetSISTEMA(ref string value);
        partial void OnSISTEMAChanging(ref string value);
        partial void OnSISTEMAChanged();
    
        /// <summary>
        /// There are no comments for SEMANA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string SEMANA
        {
            get
            {
                string value = _SEMANA;
                OnGetSEMANA(ref value);
                return value;
            }
            set
            {
                if (_SEMANA != value)
                {
                  OnSEMANAChanging(ref value);
                  ReportPropertyChanging("SEMANA");
                  _SEMANA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("SEMANA");
                  OnSEMANAChanged();
              }
            }
        }
        private string _SEMANA;
        partial void OnGetSEMANA(ref string value);
        partial void OnSEMANAChanging(ref string value);
        partial void OnSEMANAChanged();
    
        /// <summary>
        /// There are no comments for CAPAC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> CAPAC
        {
            get
            {
                global::System.Nullable<int> value = _CAPAC;
                OnGetCAPAC(ref value);
                return value;
            }
            set
            {
                if (_CAPAC != value)
                {
                  OnCAPACChanging(ref value);
                  ReportPropertyChanging("CAPAC");
                  _CAPAC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CAPAC");
                  OnCAPACChanged();
              }
            }
        }
        private global::System.Nullable<int> _CAPAC = 0;
        partial void OnGetCAPAC(ref global::System.Nullable<int> value);
        partial void OnCAPACChanging(ref global::System.Nullable<int> value);
        partial void OnCAPACChanged();
    
        /// <summary>
        /// There are no comments for CARGA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> CARGA
        {
            get
            {
                global::System.Nullable<int> value = _CARGA;
                OnGetCARGA(ref value);
                return value;
            }
            set
            {
                if (_CARGA != value)
                {
                  OnCARGAChanging(ref value);
                  ReportPropertyChanging("CARGA");
                  _CARGA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CARGA");
                  OnCARGAChanged();
              }
            }
        }
        private global::System.Nullable<int> _CARGA = 0;
        partial void OnGetCARGA(ref global::System.Nullable<int> value);
        partial void OnCARGAChanging(ref global::System.Nullable<int> value);
        partial void OnCARGAChanged();
    
        /// <summary>
        /// There are no comments for CARGA_TMP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> CARGA_TMP
        {
            get
            {
                global::System.Nullable<int> value = _CARGA_TMP;
                OnGetCARGA_TMP(ref value);
                return value;
            }
            set
            {
                if (_CARGA_TMP != value)
                {
                  OnCARGA_TMPChanging(ref value);
                  ReportPropertyChanging("CARGA_TMP");
                  _CARGA_TMP = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CARGA_TMP");
                  OnCARGA_TMPChanged();
              }
            }
        }
        private global::System.Nullable<int> _CARGA_TMP = 0;
        partial void OnGetCARGA_TMP(ref global::System.Nullable<int> value);
        partial void OnCARGA_TMPChanging(ref global::System.Nullable<int> value);
        partial void OnCARGA_TMPChanged();
    
        /// <summary>
        /// There are no comments for CARGA_FIXA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> CARGA_FIXA
        {
            get
            {
                global::System.Nullable<int> value = _CARGA_FIXA;
                OnGetCARGA_FIXA(ref value);
                return value;
            }
            set
            {
                if (_CARGA_FIXA != value)
                {
                  OnCARGA_FIXAChanging(ref value);
                  ReportPropertyChanging("CARGA_FIXA");
                  _CARGA_FIXA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CARGA_FIXA");
                  OnCARGA_FIXAChanged();
              }
            }
        }
        private global::System.Nullable<int> _CARGA_FIXA = 0;
        partial void OnGetCARGA_FIXA(ref global::System.Nullable<int> value);
        partial void OnCARGA_FIXAChanging(ref global::System.Nullable<int> value);
        partial void OnCARGA_FIXAChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for SECCOES in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_TAB_CAPAC_SECCOES", "SECCOES")]
        public SECCOES SECCOES
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<SECCOES>("DataGiic_LiagoModel.FK_TAB_CAPAC_SECCOES", "SECCOES").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<SECCOES>("DataGiic_LiagoModel.FK_TAB_CAPAC_SECCOES", "SECCOES").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for SECCOES in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<SECCOES> SECCOESReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<SECCOES>("DataGiic_LiagoModel.FK_TAB_CAPAC_SECCOES", "SECCOES");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<SECCOES>("DataGiic_LiagoModel.FK_TAB_CAPAC_SECCOES", "SECCOES", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<SECCOES>("DataGiic_LiagoModel.FK_TAB_CAPAC_SECCOES", "SECCOES").Value = null;
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TAB_CAPAC obj = new TAB_CAPAC();
            obj.SECCAO = SECCAO;
            obj.SISTEMA = SISTEMA;
            obj.SEMANA = SEMANA;
            obj.CAPAC = CAPAC;
            obj.CARGA = CARGA;
            obj.CARGA_TMP = CARGA_TMP;
            obj.CARGA_FIXA = CARGA_FIXA;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TAB_CAPAC toCompare = obj as TAB_CAPAC;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SECCAO, toCompare.SECCAO))
            return false;
          if (!Object.Equals(this.SISTEMA, toCompare.SISTEMA))
            return false;
          if (!Object.Equals(this.SEMANA, toCompare.SEMANA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SECCAO.GetHashCode();
          hashCode = (hashCode * 7) + SISTEMA.GetHashCode();
          hashCode = (hashCode * 7) + SEMANA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
