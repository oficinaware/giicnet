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
    /// There are no comments for DataGiic_LiagoModel.TAB_PROCESSOS_MOD in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NR_PROCESSO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TAB_PROCESSOS_MOD")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TAB_PROCESSOS_MOD : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TAB_PROCESSOS_MOD object.
        /// </summary>
        /// <param name="nR_PROCESSO">Initial value of NR_PROCESSO.</param>
        /// <param name="dATA">Initial value of DATA.</param>
        /// <param name="tITULO">Initial value of TITULO.</param>
        /// <param name="rEF">Initial value of REF.</param>
        public static TAB_PROCESSOS_MOD CreateTAB_PROCESSOS_MOD(int nR_PROCESSO, global::System.DateTime dATA, string tITULO, string rEF)
        {
            TAB_PROCESSOS_MOD tAB_PROCESSOS_MOD = new TAB_PROCESSOS_MOD();
            tAB_PROCESSOS_MOD.NR_PROCESSO = nR_PROCESSO;
            tAB_PROCESSOS_MOD.DATA = dATA;
            tAB_PROCESSOS_MOD.TITULO = tITULO;
            tAB_PROCESSOS_MOD.REF = rEF;
            return tAB_PROCESSOS_MOD;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for NR_PROCESSO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int NR_PROCESSO
        {
            get
            {
                int value = _NR_PROCESSO;
                OnGetNR_PROCESSO(ref value);
                return value;
            }
            set
            {
                if (_NR_PROCESSO != value)
                {
                  OnNR_PROCESSOChanging(ref value);
                  ReportPropertyChanging("NR_PROCESSO");
                  _NR_PROCESSO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NR_PROCESSO");
                  OnNR_PROCESSOChanged();
              }
            }
        }
        private int _NR_PROCESSO;
        partial void OnGetNR_PROCESSO(ref int value);
        partial void OnNR_PROCESSOChanging(ref int value);
        partial void OnNR_PROCESSOChanged();
    
        /// <summary>
        /// There are no comments for DATA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.DateTime DATA
        {
            get
            {
                global::System.DateTime value = _DATA;
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
        private global::System.DateTime _DATA;
        partial void OnGetDATA(ref global::System.DateTime value);
        partial void OnDATAChanging(ref global::System.DateTime value);
        partial void OnDATAChanged();
    
        /// <summary>
        /// There are no comments for TITULO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(45)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TITULO
        {
            get
            {
                string value = _TITULO;
                OnGetTITULO(ref value);
                return value;
            }
            set
            {
                if (_TITULO != value)
                {
                  OnTITULOChanging(ref value);
                  ReportPropertyChanging("TITULO");
                  _TITULO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TITULO");
                  OnTITULOChanged();
              }
            }
        }
        private string _TITULO;
        partial void OnGetTITULO(ref string value);
        partial void OnTITULOChanging(ref string value);
        partial void OnTITULOChanged();
    
        /// <summary>
        /// There are no comments for REF in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string REF
        {
            get
            {
                string value = _REF;
                OnGetREF(ref value);
                return value;
            }
            set
            {
                if (_REF != value)
                {
                  OnREFChanging(ref value);
                  ReportPropertyChanging("REF");
                  _REF = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("REF");
                  OnREFChanged();
              }
            }
        }
        private string _REF;
        partial void OnGetREF(ref string value);
        partial void OnREFChanging(ref string value);
        partial void OnREFChanged();
    
        /// <summary>
        /// There are no comments for FECHO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> FECHO
        {
            get
            {
                global::System.Nullable<bool> value = _FECHO;
                OnGetFECHO(ref value);
                return value;
            }
            set
            {
                if (_FECHO != value)
                {
                  OnFECHOChanging(ref value);
                  ReportPropertyChanging("FECHO");
                  _FECHO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("FECHO");
                  OnFECHOChanged();
              }
            }
        }
        private global::System.Nullable<bool> _FECHO;
        partial void OnGetFECHO(ref global::System.Nullable<bool> value);
        partial void OnFECHOChanging(ref global::System.Nullable<bool> value);
        partial void OnFECHOChanged();
    
        /// <summary>
        /// There are no comments for DATA_FECHO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_FECHO
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_FECHO;
                OnGetDATA_FECHO(ref value);
                return value;
            }
            set
            {
                if (_DATA_FECHO != value)
                {
                  OnDATA_FECHOChanging(ref value);
                  ReportPropertyChanging("DATA_FECHO");
                  _DATA_FECHO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_FECHO");
                  OnDATA_FECHOChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_FECHO;
        partial void OnGetDATA_FECHO(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_FECHOChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_FECHOChanged();
    
        /// <summary>
        /// There are no comments for DATA_PLAN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_PLAN
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_PLAN;
                OnGetDATA_PLAN(ref value);
                return value;
            }
            set
            {
                if (_DATA_PLAN != value)
                {
                  OnDATA_PLANChanging(ref value);
                  ReportPropertyChanging("DATA_PLAN");
                  _DATA_PLAN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_PLAN");
                  OnDATA_PLANChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_PLAN;
        partial void OnGetDATA_PLAN(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_PLANChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_PLANChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TAB_PROCESSOS_MOD obj = new TAB_PROCESSOS_MOD();
            obj.NR_PROCESSO = NR_PROCESSO;
            obj.DATA = DATA;
            obj.TITULO = TITULO;
            obj.REF = REF;
            obj.FECHO = FECHO;
            obj.DATA_FECHO = DATA_FECHO;
            obj.DATA_PLAN = DATA_PLAN;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TAB_PROCESSOS_MOD toCompare = obj as TAB_PROCESSOS_MOD;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.NR_PROCESSO, toCompare.NR_PROCESSO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + NR_PROCESSO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
