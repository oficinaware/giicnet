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
    /// There are no comments for DataGiic_LiagoModel.WKERROS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// SPID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="WKERROS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WKERROS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new WKERROS object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="sPID">Initial value of SPID.</param>
        public static WKERROS CreateWKERROS(global::System.Guid iD, int sPID)
        {
            WKERROS wKERROS = new WKERROS();
            wKERROS.ID = iD;
            wKERROS.SPID = sPID;
            return wKERROS;
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
        /// There are no comments for SPID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int SPID
        {
            get
            {
                int value = _SPID;
                OnGetSPID(ref value);
                return value;
            }
            set
            {
                if (_SPID != value)
                {
                  OnSPIDChanging(ref value);
                  ReportPropertyChanging("SPID");
                  _SPID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SPID");
                  OnSPIDChanged();
              }
            }
        }
        private int _SPID;
        partial void OnGetSPID(ref int value);
        partial void OnSPIDChanging(ref int value);
        partial void OnSPIDChanged();
    
        /// <summary>
        /// There are no comments for TEXTO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(400)]
        public string TEXTO
        {
            get
            {
                string value = _TEXTO;
                OnGetTEXTO(ref value);
                return value;
            }
            set
            {
                if (_TEXTO != value)
                {
                  OnTEXTOChanging(ref value);
                  ReportPropertyChanging("TEXTO");
                  _TEXTO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TEXTO");
                  OnTEXTOChanged();
              }
            }
        }
        private string _TEXTO;
        partial void OnGetTEXTO(ref string value);
        partial void OnTEXTOChanging(ref string value);
        partial void OnTEXTOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            WKERROS obj = new WKERROS();
            obj.ID = ID;
            obj.SPID = SPID;
            obj.TEXTO = TEXTO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          WKERROS toCompare = obj as WKERROS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ID, toCompare.ID))
            return false;
          if (!Object.Equals(this.SPID, toCompare.SPID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ID.GetHashCode();
          hashCode = (hashCode * 7) + SPID.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}