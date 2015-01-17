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
    /// There are no comments for DataGiic_LiagoModel.STKLOC in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ARM
    /// IDLOCAL
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="STKLOC")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class STKLOC : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new STKLOC object.
        /// </summary>
        /// <param name="aRM">Initial value of ARM.</param>
        /// <param name="iDLOCAL">Initial value of IDLOCAL.</param>
        public static STKLOC CreateSTKLOC(string aRM, string iDLOCAL)
        {
            STKLOC sTKLOC = new STKLOC();
            sTKLOC.ARM = aRM;
            sTKLOC.IDLOCAL = iDLOCAL;
            return sTKLOC;
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
        /// There are no comments for IDLOCAL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string IDLOCAL
        {
            get
            {
                string value = _IDLOCAL;
                OnGetIDLOCAL(ref value);
                return value;
            }
            set
            {
                if (_IDLOCAL != value)
                {
                  OnIDLOCALChanging(ref value);
                  ReportPropertyChanging("IDLOCAL");
                  _IDLOCAL = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("IDLOCAL");
                  OnIDLOCALChanged();
              }
            }
        }
        private string _IDLOCAL;
        partial void OnGetIDLOCAL(ref string value);
        partial void OnIDLOCALChanging(ref string value);
        partial void OnIDLOCALChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            STKLOC obj = new STKLOC();
            obj.ARM = ARM;
            obj.IDLOCAL = IDLOCAL;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          STKLOC toCompare = obj as STKLOC;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ARM, toCompare.ARM))
            return false;
          if (!Object.Equals(this.IDLOCAL, toCompare.IDLOCAL))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ARM.GetHashCode();
          hashCode = (hashCode * 7) + IDLOCAL.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
