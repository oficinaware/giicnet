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
    /// There are no comments for DataGiic_LiagoModel.wk_capac in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dept
    /// dtdia
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wk_capac")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wk_capac : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wk_capac object.
        /// </summary>
        /// <param name="dept">Initial value of dept.</param>
        /// <param name="dtdia">Initial value of dtdia.</param>
        public static wk_capac Createwk_capac(int dept, global::System.DateTime dtdia)
        {
            wk_capac wk_capac = new wk_capac();
            wk_capac.dept = dept;
            wk_capac.dtdia = dtdia;
            return wk_capac;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for dept in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int dept
        {
            get
            {
                int value = _dept;
                OnGetdept(ref value);
                return value;
            }
            set
            {
                if (_dept != value)
                {
                  OndeptChanging(ref value);
                  ReportPropertyChanging("dept");
                  _dept = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("dept");
                  OndeptChanged();
              }
            }
        }
        private int _dept;
        partial void OnGetdept(ref int value);
        partial void OndeptChanging(ref int value);
        partial void OndeptChanged();
    
        /// <summary>
        /// There are no comments for dtdia in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.DateTime dtdia
        {
            get
            {
                global::System.DateTime value = _dtdia;
                OnGetdtdia(ref value);
                return value;
            }
            set
            {
                if (_dtdia != value)
                {
                  OndtdiaChanging(ref value);
                  ReportPropertyChanging("dtdia");
                  _dtdia = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("dtdia");
                  OndtdiaChanged();
              }
            }
        }
        private global::System.DateTime _dtdia;
        partial void OnGetdtdia(ref global::System.DateTime value);
        partial void OndtdiaChanging(ref global::System.DateTime value);
        partial void OndtdiaChanged();
    
        /// <summary>
        /// There are no comments for min_disp in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> min_disp
        {
            get
            {
                global::System.Nullable<decimal> value = _min_disp;
                OnGetmin_disp(ref value);
                return value;
            }
            set
            {
                if (_min_disp != value)
                {
                  Onmin_dispChanging(ref value);
                  ReportPropertyChanging("min_disp");
                  _min_disp = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("min_disp");
                  Onmin_dispChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _min_disp;
        partial void OnGetmin_disp(ref global::System.Nullable<decimal> value);
        partial void Onmin_dispChanging(ref global::System.Nullable<decimal> value);
        partial void Onmin_dispChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wk_capac obj = new wk_capac();
            obj.dept = dept;
            obj.dtdia = dtdia;
            obj.min_disp = min_disp;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wk_capac toCompare = obj as wk_capac;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.dept, toCompare.dept))
            return false;
          if (!Object.Equals(this.dtdia, toCompare.dtdia))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + dept.GetHashCode();
          hashCode = (hashCode * 7) + dtdia.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
