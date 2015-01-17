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
    /// There are no comments for DataGiic_LiagoModel.PRINT_SERVER in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="PRINT_SERVER")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PRINT_SERVER : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new PRINT_SERVER object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        public static PRINT_SERVER CreatePRINT_SERVER(global::System.Guid iD)
        {
            PRINT_SERVER pRINT_SERVER = new PRINT_SERVER();
            pRINT_SERVER.ID = iD;
            return pRINT_SERVER;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.Guid ID
        {
            get
            {
                global::System.Guid value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private global::System.Guid _ID;
        partial void OnGetID(ref global::System.Guid value);
        partial void OnIDChanging(ref global::System.Guid value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for UTENTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string UTENTE
        {
            get
            {
                string value = _UTENTE;
                OnGetUTENTE(ref value);
                return value;
            }
            set
            {
                if (_UTENTE != value)
                {
                  OnUTENTEChanging(ref value);
                  ReportPropertyChanging("UTENTE");
                  _UTENTE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("UTENTE");
                  OnUTENTEChanged();
              }
            }
        }
        private string _UTENTE;
        partial void OnGetUTENTE(ref string value);
        partial void OnUTENTEChanging(ref string value);
        partial void OnUTENTEChanged();
    
        /// <summary>
        /// There are no comments for DATAREG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATAREG
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATAREG;
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
        private global::System.Nullable<System.DateTime> _DATAREG;
        partial void OnGetDATAREG(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAREGChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAREGChanged();
    
        /// <summary>
        /// There are no comments for HORA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> HORA
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _HORA;
                OnGetHORA(ref value);
                return value;
            }
            set
            {
                if (_HORA != value)
                {
                  OnHORAChanging(ref value);
                  ReportPropertyChanging("HORA");
                  _HORA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("HORA");
                  OnHORAChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _HORA;
        partial void OnGetHORA(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORAChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORAChanged();
    
        /// <summary>
        /// There are no comments for PRINTER in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string PRINTER
        {
            get
            {
                string value = _PRINTER;
                OnGetPRINTER(ref value);
                return value;
            }
            set
            {
                if (_PRINTER != value)
                {
                  OnPRINTERChanging(ref value);
                  ReportPropertyChanging("PRINTER");
                  _PRINTER = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("PRINTER");
                  OnPRINTERChanged();
              }
            }
        }
        private string _PRINTER;
        partial void OnGetPRINTER(ref string value);
        partial void OnPRINTERChanging(ref string value);
        partial void OnPRINTERChanged();
    
        /// <summary>
        /// There are no comments for REPORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string REPORT
        {
            get
            {
                string value = _REPORT;
                OnGetREPORT(ref value);
                return value;
            }
            set
            {
                if (_REPORT != value)
                {
                  OnREPORTChanging(ref value);
                  ReportPropertyChanging("REPORT");
                  _REPORT = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("REPORT");
                  OnREPORTChanged();
              }
            }
        }
        private string _REPORT;
        partial void OnGetREPORT(ref string value);
        partial void OnREPORTChanging(ref string value);
        partial void OnREPORTChanged();
    
        /// <summary>
        /// There are no comments for PARAMETROS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(256)]
        public string PARAMETROS
        {
            get
            {
                string value = _PARAMETROS;
                OnGetPARAMETROS(ref value);
                return value;
            }
            set
            {
                if (_PARAMETROS != value)
                {
                  OnPARAMETROSChanging(ref value);
                  ReportPropertyChanging("PARAMETROS");
                  _PARAMETROS = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("PARAMETROS");
                  OnPARAMETROSChanged();
              }
            }
        }
        private string _PARAMETROS;
        partial void OnGetPARAMETROS(ref string value);
        partial void OnPARAMETROSChanging(ref string value);
        partial void OnPARAMETROSChanged();
    
        /// <summary>
        /// There are no comments for STAT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string STAT
        {
            get
            {
                string value = _STAT;
                OnGetSTAT(ref value);
                return value;
            }
            set
            {
                if (_STAT != value)
                {
                  OnSTATChanging(ref value);
                  ReportPropertyChanging("STAT");
                  _STAT = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("STAT");
                  OnSTATChanged();
              }
            }
        }
        private string _STAT;
        partial void OnGetSTAT(ref string value);
        partial void OnSTATChanging(ref string value);
        partial void OnSTATChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            PRINT_SERVER obj = new PRINT_SERVER();
            obj.ID = ID;
            obj.UTENTE = UTENTE;
            obj.DATAREG = DATAREG;
            obj.HORA = HORA;
            obj.PRINTER = PRINTER;
            obj.REPORT = REPORT;
            obj.PARAMETROS = PARAMETROS;
            obj.STAT = STAT;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          PRINT_SERVER toCompare = obj as PRINT_SERVER;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ID, toCompare.ID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ID.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
