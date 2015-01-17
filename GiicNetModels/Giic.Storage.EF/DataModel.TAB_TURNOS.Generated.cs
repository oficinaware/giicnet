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
    /// There are no comments for DataGiic_LiagoModel.TAB_TURNOS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// COD_TURNO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TAB_TURNOS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TAB_TURNOS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TAB_TURNOS object.
        /// </summary>
        /// <param name="cOD_TURNO">Initial value of COD_TURNO.</param>
        public static TAB_TURNOS CreateTAB_TURNOS(string cOD_TURNO)
        {
            TAB_TURNOS tAB_TURNOS = new TAB_TURNOS();
            tAB_TURNOS.COD_TURNO = cOD_TURNO;
            return tAB_TURNOS;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for COD_TURNO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string COD_TURNO
        {
            get
            {
                string value = _COD_TURNO;
                OnGetCOD_TURNO(ref value);
                return value;
            }
            set
            {
                if (_COD_TURNO != value)
                {
                  OnCOD_TURNOChanging(ref value);
                  ReportPropertyChanging("COD_TURNO");
                  _COD_TURNO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("COD_TURNO");
                  OnCOD_TURNOChanged();
              }
            }
        }
        private string _COD_TURNO;
        partial void OnGetCOD_TURNO(ref string value);
        partial void OnCOD_TURNOChanging(ref string value);
        partial void OnCOD_TURNOChanged();
    
        /// <summary>
        /// There are no comments for HORA_INI in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> HORA_INI
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _HORA_INI;
                OnGetHORA_INI(ref value);
                return value;
            }
            set
            {
                if (_HORA_INI != value)
                {
                  OnHORA_INIChanging(ref value);
                  ReportPropertyChanging("HORA_INI");
                  _HORA_INI = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("HORA_INI");
                  OnHORA_INIChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _HORA_INI;
        partial void OnGetHORA_INI(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORA_INIChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORA_INIChanged();
    
        /// <summary>
        /// There are no comments for HORA_FIM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> HORA_FIM
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _HORA_FIM;
                OnGetHORA_FIM(ref value);
                return value;
            }
            set
            {
                if (_HORA_FIM != value)
                {
                  OnHORA_FIMChanging(ref value);
                  ReportPropertyChanging("HORA_FIM");
                  _HORA_FIM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("HORA_FIM");
                  OnHORA_FIMChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _HORA_FIM;
        partial void OnGetHORA_FIM(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORA_FIMChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORA_FIMChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TAB_TURNOS obj = new TAB_TURNOS();
            obj.COD_TURNO = COD_TURNO;
            obj.HORA_INI = HORA_INI;
            obj.HORA_FIM = HORA_FIM;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TAB_TURNOS toCompare = obj as TAB_TURNOS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.COD_TURNO, toCompare.COD_TURNO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + COD_TURNO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
