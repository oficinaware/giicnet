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
    /// There are no comments for DataGiic_LiagoModel.TABCOMISSOESF in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ARM
    /// DATAREG
    /// CODFUNC
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABCOMISSOESF")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABCOMISSOESF : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABCOMISSOESF object.
        /// </summary>
        /// <param name="aRM">Initial value of ARM.</param>
        /// <param name="dATAREG">Initial value of DATAREG.</param>
        /// <param name="cODFUNC">Initial value of CODFUNC.</param>
        public static TABCOMISSOESF CreateTABCOMISSOESF(string aRM, global::System.DateTime dATAREG, string cODFUNC)
        {
            TABCOMISSOESF tABCOMISSOESF = new TABCOMISSOESF();
            tABCOMISSOESF.ARM = aRM;
            tABCOMISSOESF.DATAREG = dATAREG;
            tABCOMISSOESF.CODFUNC = cODFUNC;
            return tABCOMISSOESF;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ARM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ARM
        {
            get
            {
                string value = _ARM;
                OnGetARM(ref value);
                return value;
            }
            set
            {
                if (_ARM != value)
                {
                  OnARMChanging(ref value);
                  ReportPropertyChanging("ARM");
                  _ARM = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ARM");
                  OnARMChanged();
              }
            }
        }
        private string _ARM;
        partial void OnGetARM(ref string value);
        partial void OnARMChanging(ref string value);
        partial void OnARMChanged();
    
        /// <summary>
        /// There are no comments for DATAREG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.DateTime DATAREG
        {
            get
            {
                global::System.DateTime value = _DATAREG;
                OnGetDATAREG(ref value);
                return value;
            }
            set
            {
                if (_DATAREG != value)
                {
                  OnDATAREGChanging(ref value);
                  ReportPropertyChanging("DATAREG");
                  _DATAREG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATAREG");
                  OnDATAREGChanged();
              }
            }
        }
        private global::System.DateTime _DATAREG;
        partial void OnGetDATAREG(ref global::System.DateTime value);
        partial void OnDATAREGChanging(ref global::System.DateTime value);
        partial void OnDATAREGChanged();
    
        /// <summary>
        /// There are no comments for CODFUNC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODFUNC
        {
            get
            {
                string value = _CODFUNC;
                OnGetCODFUNC(ref value);
                return value;
            }
            set
            {
                if (_CODFUNC != value)
                {
                  OnCODFUNCChanging(ref value);
                  ReportPropertyChanging("CODFUNC");
                  _CODFUNC = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODFUNC");
                  OnCODFUNCChanged();
              }
            }
        }
        private string _CODFUNC;
        partial void OnGetCODFUNC(ref string value);
        partial void OnCODFUNCChanging(ref string value);
        partial void OnCODFUNCChanged();
    
        /// <summary>
        /// There are no comments for ANO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> ANO
        {
            get
            {
                global::System.Nullable<int> value = _ANO;
                OnGetANO(ref value);
                return value;
            }
            set
            {
                if (_ANO != value)
                {
                  OnANOChanging(ref value);
                  ReportPropertyChanging("ANO");
                  _ANO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ANO");
                  OnANOChanged();
              }
            }
        }
        private global::System.Nullable<int> _ANO;
        partial void OnGetANO(ref global::System.Nullable<int> value);
        partial void OnANOChanging(ref global::System.Nullable<int> value);
        partial void OnANOChanged();
    
        /// <summary>
        /// There are no comments for MES in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<short> MES
        {
            get
            {
                global::System.Nullable<short> value = _MES;
                OnGetMES(ref value);
                return value;
            }
            set
            {
                if (_MES != value)
                {
                  OnMESChanging(ref value);
                  ReportPropertyChanging("MES");
                  _MES = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("MES");
                  OnMESChanged();
              }
            }
        }
        private global::System.Nullable<short> _MES;
        partial void OnGetMES(ref global::System.Nullable<short> value);
        partial void OnMESChanging(ref global::System.Nullable<short> value);
        partial void OnMESChanged();
    
        /// <summary>
        /// There are no comments for VALORVND in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VALORVND
        {
            get
            {
                global::System.Nullable<decimal> value = _VALORVND;
                OnGetVALORVND(ref value);
                return value;
            }
            set
            {
                if (_VALORVND != value)
                {
                  OnVALORVNDChanging(ref value);
                  ReportPropertyChanging("VALORVND");
                  _VALORVND = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VALORVND");
                  OnVALORVNDChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VALORVND;
        partial void OnGetVALORVND(ref global::System.Nullable<decimal> value);
        partial void OnVALORVNDChanging(ref global::System.Nullable<decimal> value);
        partial void OnVALORVNDChanged();
    
        /// <summary>
        /// There are no comments for VALORCOM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> VALORCOM
        {
            get
            {
                global::System.Nullable<decimal> value = _VALORCOM;
                OnGetVALORCOM(ref value);
                return value;
            }
            set
            {
                if (_VALORCOM != value)
                {
                  OnVALORCOMChanging(ref value);
                  ReportPropertyChanging("VALORCOM");
                  _VALORCOM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("VALORCOM");
                  OnVALORCOMChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _VALORCOM;
        partial void OnGetVALORCOM(ref global::System.Nullable<decimal> value);
        partial void OnVALORCOMChanging(ref global::System.Nullable<decimal> value);
        partial void OnVALORCOMChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TABCOMISSOESF obj = new TABCOMISSOESF();
            obj.ARM = ARM;
            obj.DATAREG = DATAREG;
            obj.CODFUNC = CODFUNC;
            obj.ANO = ANO;
            obj.MES = MES;
            obj.VALORVND = VALORVND;
            obj.VALORCOM = VALORCOM;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABCOMISSOESF toCompare = obj as TABCOMISSOESF;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ARM, toCompare.ARM))
            return false;
          if (!Object.Equals(this.DATAREG, toCompare.DATAREG))
            return false;
          if (!Object.Equals(this.CODFUNC, toCompare.CODFUNC))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ARM.GetHashCode();
          hashCode = (hashCode * 7) + DATAREG.GetHashCode();
          hashCode = (hashCode * 7) + CODFUNC.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
