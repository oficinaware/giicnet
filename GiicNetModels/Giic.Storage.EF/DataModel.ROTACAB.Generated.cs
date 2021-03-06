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
    /// There are no comments for DataGiic_LiagoModel.ROTACAB in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CODROTA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="ROTACAB")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ROTACAB : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new ROTACAB object.
        /// </summary>
        /// <param name="cODROTA">Initial value of CODROTA.</param>
        public static ROTACAB CreateROTACAB(string cODROTA)
        {
            ROTACAB rOTACAB = new ROTACAB();
            rOTACAB.CODROTA = cODROTA;
            return rOTACAB;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CODROTA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODROTA
        {
            get
            {
                string value = _CODROTA;
                OnGetCODROTA(ref value);
                return value;
            }
            set
            {
                if (_CODROTA != value)
                {
                  OnCODROTAChanging(ref value);
                  ReportPropertyChanging("CODROTA");
                  _CODROTA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODROTA");
                  OnCODROTAChanged();
              }
            }
        }
        private string _CODROTA;
        partial void OnGetCODROTA(ref string value);
        partial void OnCODROTAChanging(ref string value);
        partial void OnCODROTAChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
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
        /// There are no comments for MODCQ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string MODCQ
        {
            get
            {
                string value = _MODCQ;
                OnGetMODCQ(ref value);
                return value;
            }
            set
            {
                if (_MODCQ != value)
                {
                  OnMODCQChanging(ref value);
                  ReportPropertyChanging("MODCQ");
                  _MODCQ = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("MODCQ");
                  OnMODCQChanged();
              }
            }
        }
        private string _MODCQ;
        partial void OnGetMODCQ(ref string value);
        partial void OnMODCQChanging(ref string value);
        partial void OnMODCQChanged();
    
        /// <summary>
        /// There are no comments for EDICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> EDICAO
        {
            get
            {
                global::System.Nullable<int> value = _EDICAO;
                OnGetEDICAO(ref value);
                return value;
            }
            set
            {
                if (_EDICAO != value)
                {
                  OnEDICAOChanging(ref value);
                  ReportPropertyChanging("EDICAO");
                  _EDICAO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("EDICAO");
                  OnEDICAOChanged();
              }
            }
        }
        private global::System.Nullable<int> _EDICAO = 1;
        partial void OnGetEDICAO(ref global::System.Nullable<int> value);
        partial void OnEDICAOChanging(ref global::System.Nullable<int> value);
        partial void OnEDICAOChanged();
    
        /// <summary>
        /// There are no comments for REVISAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> REVISAO
        {
            get
            {
                global::System.Nullable<int> value = _REVISAO;
                OnGetREVISAO(ref value);
                return value;
            }
            set
            {
                if (_REVISAO != value)
                {
                  OnREVISAOChanging(ref value);
                  ReportPropertyChanging("REVISAO");
                  _REVISAO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("REVISAO");
                  OnREVISAOChanged();
              }
            }
        }
        private global::System.Nullable<int> _REVISAO = 1;
        partial void OnGetREVISAO(ref global::System.Nullable<int> value);
        partial void OnREVISAOChanging(ref global::System.Nullable<int> value);
        partial void OnREVISAOChanged();
    
        /// <summary>
        /// There are no comments for DATARV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATARV
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATARV;
                OnGetDATARV(ref value);
                return value;
            }
            set
            {
                if (_DATARV != value)
                {
                  OnDATARVChanging(ref value);
                  ReportPropertyChanging("DATARV");
                  _DATARV = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATARV");
                  OnDATARVChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATARV;
        partial void OnGetDATARV(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATARVChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATARVChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for MODELOS in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_MODELOS_ROTACAB", "MODELOS")]
        public EntityCollection<MODELOS> MODELOS
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<MODELOS>("DataGiic_LiagoModel.FK_MODELOS_ROTACAB", "MODELOS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<MODELOS>("DataGiic_LiagoModel.FK_MODELOS_ROTACAB", "MODELOS", value);
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            ROTACAB obj = new ROTACAB();
            obj.CODROTA = CODROTA;
            obj.DESCRICAO = DESCRICAO;
            obj.DATA = DATA;
            obj.MODCQ = MODCQ;
            obj.EDICAO = EDICAO;
            obj.REVISAO = REVISAO;
            obj.DATARV = DATARV;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          ROTACAB toCompare = obj as ROTACAB;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CODROTA, toCompare.CODROTA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CODROTA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
