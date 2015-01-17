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
    /// There are no comments for DataGiic_LiagoModel.CORTANTES in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ARTIGO
    /// PECA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CORTANTES")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CORTANTES : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CORTANTES object.
        /// </summary>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        /// <param name="pECA">Initial value of PECA.</param>
        public static CORTANTES CreateCORTANTES(string aRTIGO, string pECA)
        {
            CORTANTES cORTANTES = new CORTANTES();
            cORTANTES.ARTIGO = aRTIGO;
            cORTANTES.PECA = pECA;
            return cORTANTES;
        }

        #endregion

        #region Properties
    
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
        /// There are no comments for PECA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string PECA
        {
            get
            {
                string value = _PECA;
                OnGetPECA(ref value);
                return value;
            }
            set
            {
                if (_PECA != value)
                {
                  OnPECAChanging(ref value);
                  ReportPropertyChanging("PECA");
                  _PECA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("PECA");
                  OnPECAChanged();
              }
            }
        }
        private string _PECA;
        partial void OnGetPECA(ref string value);
        partial void OnPECAChanging(ref string value);
        partial void OnPECAChanged();
    
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
        /// There are no comments for OPERACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string OPERACAO
        {
            get
            {
                string value = _OPERACAO;
                OnGetOPERACAO(ref value);
                return value;
            }
            set
            {
                if (_OPERACAO != value)
                {
                  OnOPERACAOChanging(ref value);
                  ReportPropertyChanging("OPERACAO");
                  _OPERACAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("OPERACAO");
                  OnOPERACAOChanged();
              }
            }
        }
        private string _OPERACAO;
        partial void OnGetOPERACAO(ref string value);
        partial void OnOPERACAOChanging(ref string value);
        partial void OnOPERACAOChanged();
    
        /// <summary>
        /// There are no comments for DATA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA;
                OnGetDATA(ref value);
                return value;
            }
            set
            {
                if (_DATA != value)
                {
                  OnDATAChanging(ref value);
                  ReportPropertyChanging("DATA");
                  _DATA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA");
                  OnDATAChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA;
        partial void OnGetDATA(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAChanged();
    
        /// <summary>
        /// There are no comments for FORN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string FORN
        {
            get
            {
                string value = _FORN;
                OnGetFORN(ref value);
                return value;
            }
            set
            {
                if (_FORN != value)
                {
                  OnFORNChanging(ref value);
                  ReportPropertyChanging("FORN");
                  _FORN = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("FORN");
                  OnFORNChanged();
              }
            }
        }
        private string _FORN;
        partial void OnGetFORN(ref string value);
        partial void OnFORNChanging(ref string value);
        partial void OnFORNChanged();
    
        /// <summary>
        /// There are no comments for ESCALA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string ESCALA
        {
            get
            {
                string value = _ESCALA;
                OnGetESCALA(ref value);
                return value;
            }
            set
            {
                if (_ESCALA != value)
                {
                  OnESCALAChanging(ref value);
                  ReportPropertyChanging("ESCALA");
                  _ESCALA = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ESCALA");
                  OnESCALAChanged();
              }
            }
        }
        private string _ESCALA;
        partial void OnGetESCALA(ref string value);
        partial void OnESCALAChanging(ref string value);
        partial void OnESCALAChanged();
    
        /// <summary>
        /// There are no comments for TAMANHOS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string TAMANHOS
        {
            get
            {
                string value = _TAMANHOS;
                OnGetTAMANHOS(ref value);
                return value;
            }
            set
            {
                if (_TAMANHOS != value)
                {
                  OnTAMANHOSChanging(ref value);
                  ReportPropertyChanging("TAMANHOS");
                  _TAMANHOS = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TAMANHOS");
                  OnTAMANHOSChanged();
              }
            }
        }
        private string _TAMANHOS;
        partial void OnGetTAMANHOS(ref string value);
        partial void OnTAMANHOSChanging(ref string value);
        partial void OnTAMANHOSChanged();
    
        /// <summary>
        /// There are no comments for COMENT1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        public string COMENT1
        {
            get
            {
                string value = _COMENT1;
                OnGetCOMENT1(ref value);
                return value;
            }
            set
            {
                if (_COMENT1 != value)
                {
                  OnCOMENT1Changing(ref value);
                  ReportPropertyChanging("COMENT1");
                  _COMENT1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COMENT1");
                  OnCOMENT1Changed();
              }
            }
        }
        private string _COMENT1;
        partial void OnGetCOMENT1(ref string value);
        partial void OnCOMENT1Changing(ref string value);
        partial void OnCOMENT1Changed();
    
        /// <summary>
        /// There are no comments for COMENT2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        public string COMENT2
        {
            get
            {
                string value = _COMENT2;
                OnGetCOMENT2(ref value);
                return value;
            }
            set
            {
                if (_COMENT2 != value)
                {
                  OnCOMENT2Changing(ref value);
                  ReportPropertyChanging("COMENT2");
                  _COMENT2 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COMENT2");
                  OnCOMENT2Changed();
              }
            }
        }
        private string _COMENT2;
        partial void OnGetCOMENT2(ref string value);
        partial void OnCOMENT2Changing(ref string value);
        partial void OnCOMENT2Changed();
    
        /// <summary>
        /// There are no comments for COMENT3 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        public string COMENT3
        {
            get
            {
                string value = _COMENT3;
                OnGetCOMENT3(ref value);
                return value;
            }
            set
            {
                if (_COMENT3 != value)
                {
                  OnCOMENT3Changing(ref value);
                  ReportPropertyChanging("COMENT3");
                  _COMENT3 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COMENT3");
                  OnCOMENT3Changed();
              }
            }
        }
        private string _COMENT3;
        partial void OnGetCOMENT3(ref string value);
        partial void OnCOMENT3Changing(ref string value);
        partial void OnCOMENT3Changed();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for CARACTC in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_CARACTC_CORTANTES", "CARACTC")]
        public EntityCollection<CARACTC> CARACTC
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<CARACTC>("DataGiic_LiagoModel.FK_CARACTC_CORTANTES", "CARACTC");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<CARACTC>("DataGiic_LiagoModel.FK_CARACTC_CORTANTES", "CARACTC", value);
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CORTANTES obj = new CORTANTES();
            obj.ARTIGO = ARTIGO;
            obj.PECA = PECA;
            obj.DESCRICAO = DESCRICAO;
            obj.OPERACAO = OPERACAO;
            obj.DATA = DATA;
            obj.FORN = FORN;
            obj.ESCALA = ESCALA;
            obj.TAMANHOS = TAMANHOS;
            obj.COMENT1 = COMENT1;
            obj.COMENT2 = COMENT2;
            obj.COMENT3 = COMENT3;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CORTANTES toCompare = obj as CORTANTES;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ARTIGO, toCompare.ARTIGO))
            return false;
          if (!Object.Equals(this.PECA, toCompare.PECA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ARTIGO.GetHashCode();
          hashCode = (hashCode * 7) + PECA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
