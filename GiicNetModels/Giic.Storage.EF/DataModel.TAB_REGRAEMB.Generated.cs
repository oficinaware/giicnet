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
    /// There are no comments for DataGiic_LiagoModel.TAB_REGRAEMB in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CODREGRA
    /// CODEMB
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TAB_REGRAEMB")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TAB_REGRAEMB : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TAB_REGRAEMB object.
        /// </summary>
        /// <param name="cODREGRA">Initial value of CODREGRA.</param>
        /// <param name="cODEMB">Initial value of CODEMB.</param>
        /// <param name="qT">Initial value of QT.</param>
        public static TAB_REGRAEMB CreateTAB_REGRAEMB(string cODREGRA, string cODEMB, int qT)
        {
            TAB_REGRAEMB tAB_REGRAEMB = new TAB_REGRAEMB();
            tAB_REGRAEMB.CODREGRA = cODREGRA;
            tAB_REGRAEMB.CODEMB = cODEMB;
            tAB_REGRAEMB.QT = qT;
            return tAB_REGRAEMB;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CODREGRA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODREGRA
        {
            get
            {
                string value = _CODREGRA;
                OnGetCODREGRA(ref value);
                return value;
            }
            set
            {
                if (_CODREGRA != value)
                {
                  OnCODREGRAChanging(ref value);
                  ReportPropertyChanging("CODREGRA");
                  _CODREGRA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODREGRA");
                  OnCODREGRAChanged();
              }
            }
        }
        private string _CODREGRA;
        partial void OnGetCODREGRA(ref string value);
        partial void OnCODREGRAChanging(ref string value);
        partial void OnCODREGRAChanged();
    
        /// <summary>
        /// There are no comments for CODEMB in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODEMB
        {
            get
            {
                string value = _CODEMB;
                OnGetCODEMB(ref value);
                return value;
            }
            set
            {
                if (_CODEMB != value)
                {
                  OnCODEMBChanging(ref value);
                  ReportPropertyChanging("CODEMB");
                  _CODEMB = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODEMB");
                  OnCODEMBChanged();
              }
            }
        }
        private string _CODEMB;
        partial void OnGetCODEMB(ref string value);
        partial void OnCODEMBChanging(ref string value);
        partial void OnCODEMBChanged();
    
        /// <summary>
        /// There are no comments for QT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public int QT
        {
            get
            {
                int value = _QT;
                OnGetQT(ref value);
                return value;
            }
            set
            {
                if (_QT != value)
                {
                  OnQTChanging(ref value);
                  ReportPropertyChanging("QT");
                  _QT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QT");
                  OnQTChanged();
              }
            }
        }
        private int _QT;
        partial void OnGetQT(ref int value);
        partial void OnQTChanging(ref int value);
        partial void OnQTChanged();
    
        /// <summary>
        /// There are no comments for DIMCAIXA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
        public string DIMCAIXA
        {
            get
            {
                string value = _DIMCAIXA;
                OnGetDIMCAIXA(ref value);
                return value;
            }
            set
            {
                if (_DIMCAIXA != value)
                {
                  OnDIMCAIXAChanging(ref value);
                  ReportPropertyChanging("DIMCAIXA");
                  _DIMCAIXA = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DIMCAIXA");
                  OnDIMCAIXAChanged();
              }
            }
        }
        private string _DIMCAIXA;
        partial void OnGetDIMCAIXA(ref string value);
        partial void OnDIMCAIXAChanging(ref string value);
        partial void OnDIMCAIXAChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for TABEMB in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_TAB_REGRAEMB_TABEMB", "TABEMB")]
        public TABEMB TABEMB
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TABEMB>("DataGiic_LiagoModel.FK_TAB_REGRAEMB_TABEMB", "TABEMB").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TABEMB>("DataGiic_LiagoModel.FK_TAB_REGRAEMB_TABEMB", "TABEMB").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for TABEMB in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TABEMB> TABEMBReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TABEMB>("DataGiic_LiagoModel.FK_TAB_REGRAEMB_TABEMB", "TABEMB");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<TABEMB>("DataGiic_LiagoModel.FK_TAB_REGRAEMB_TABEMB", "TABEMB", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TABEMB>("DataGiic_LiagoModel.FK_TAB_REGRAEMB_TABEMB", "TABEMB").Value = null;
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TAB_REGRAEMB obj = new TAB_REGRAEMB();
            obj.CODREGRA = CODREGRA;
            obj.CODEMB = CODEMB;
            obj.QT = QT;
            obj.DIMCAIXA = DIMCAIXA;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TAB_REGRAEMB toCompare = obj as TAB_REGRAEMB;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CODREGRA, toCompare.CODREGRA))
            return false;
          if (!Object.Equals(this.CODEMB, toCompare.CODEMB))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CODREGRA.GetHashCode();
          hashCode = (hashCode * 7) + CODEMB.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}