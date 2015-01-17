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
    /// There are no comments for DataGiic_LiagoModel.OBSCATALOGO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NRREG
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="OBSCATALOGO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OBSCATALOGO : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new OBSCATALOGO object.
        /// </summary>
        /// <param name="nRREG">Initial value of NRREG.</param>
        public static OBSCATALOGO CreateOBSCATALOGO(global::System.Guid nRREG)
        {
            OBSCATALOGO oBSCATALOGO = new OBSCATALOGO();
            oBSCATALOGO.NRREG = nRREG;
            return oBSCATALOGO;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for NRREG in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.Guid NRREG
        {
            get
            {
                global::System.Guid value = _NRREG;
                OnGetNRREG(ref value);
                return value;
            }
            set
            {
                if (_NRREG != value)
                {
                  OnNRREGChanging(ref value);
                  ReportPropertyChanging("NRREG");
                  _NRREG = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NRREG");
                  OnNRREGChanged();
              }
            }
        }
        private global::System.Guid _NRREG;
        partial void OnGetNRREG(ref global::System.Guid value);
        partial void OnNRREGChanging(ref global::System.Guid value);
        partial void OnNRREGChanged();
    
        /// <summary>
        /// There are no comments for ObsCab_P1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string ObsCab_P1
        {
            get
            {
                string value = _ObsCab_P1;
                OnGetObsCab_P1(ref value);
                return value;
            }
            set
            {
                if (_ObsCab_P1 != value)
                {
                  OnObsCab_P1Changing(ref value);
                  ReportPropertyChanging("ObsCab_P1");
                  _ObsCab_P1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ObsCab_P1");
                  OnObsCab_P1Changed();
              }
            }
        }
        private string _ObsCab_P1;
        partial void OnGetObsCab_P1(ref string value);
        partial void OnObsCab_P1Changing(ref string value);
        partial void OnObsCab_P1Changed();
    
        /// <summary>
        /// There are no comments for ObsRod_P1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string ObsRod_P1
        {
            get
            {
                string value = _ObsRod_P1;
                OnGetObsRod_P1(ref value);
                return value;
            }
            set
            {
                if (_ObsRod_P1 != value)
                {
                  OnObsRod_P1Changing(ref value);
                  ReportPropertyChanging("ObsRod_P1");
                  _ObsRod_P1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ObsRod_P1");
                  OnObsRod_P1Changed();
              }
            }
        }
        private string _ObsRod_P1;
        partial void OnGetObsRod_P1(ref string value);
        partial void OnObsRod_P1Changing(ref string value);
        partial void OnObsRod_P1Changed();
    
        /// <summary>
        /// There are no comments for ObsCab_E1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string ObsCab_E1
        {
            get
            {
                string value = _ObsCab_E1;
                OnGetObsCab_E1(ref value);
                return value;
            }
            set
            {
                if (_ObsCab_E1 != value)
                {
                  OnObsCab_E1Changing(ref value);
                  ReportPropertyChanging("ObsCab_E1");
                  _ObsCab_E1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ObsCab_E1");
                  OnObsCab_E1Changed();
              }
            }
        }
        private string _ObsCab_E1;
        partial void OnGetObsCab_E1(ref string value);
        partial void OnObsCab_E1Changing(ref string value);
        partial void OnObsCab_E1Changed();
    
        /// <summary>
        /// There are no comments for ObsRod_E1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string ObsRod_E1
        {
            get
            {
                string value = _ObsRod_E1;
                OnGetObsRod_E1(ref value);
                return value;
            }
            set
            {
                if (_ObsRod_E1 != value)
                {
                  OnObsRod_E1Changing(ref value);
                  ReportPropertyChanging("ObsRod_E1");
                  _ObsRod_E1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ObsRod_E1");
                  OnObsRod_E1Changed();
              }
            }
        }
        private string _ObsRod_E1;
        partial void OnGetObsRod_E1(ref string value);
        partial void OnObsRod_E1Changing(ref string value);
        partial void OnObsRod_E1Changed();
    
        /// <summary>
        /// There are no comments for ObsCab_I1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string ObsCab_I1
        {
            get
            {
                string value = _ObsCab_I1;
                OnGetObsCab_I1(ref value);
                return value;
            }
            set
            {
                if (_ObsCab_I1 != value)
                {
                  OnObsCab_I1Changing(ref value);
                  ReportPropertyChanging("ObsCab_I1");
                  _ObsCab_I1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ObsCab_I1");
                  OnObsCab_I1Changed();
              }
            }
        }
        private string _ObsCab_I1;
        partial void OnGetObsCab_I1(ref string value);
        partial void OnObsCab_I1Changing(ref string value);
        partial void OnObsCab_I1Changed();
    
        /// <summary>
        /// There are no comments for ObsRod_I1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string ObsRod_I1
        {
            get
            {
                string value = _ObsRod_I1;
                OnGetObsRod_I1(ref value);
                return value;
            }
            set
            {
                if (_ObsRod_I1 != value)
                {
                  OnObsRod_I1Changing(ref value);
                  ReportPropertyChanging("ObsRod_I1");
                  _ObsRod_I1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ObsRod_I1");
                  OnObsRod_I1Changed();
              }
            }
        }
        private string _ObsRod_I1;
        partial void OnGetObsRod_I1(ref string value);
        partial void OnObsRod_I1Changing(ref string value);
        partial void OnObsRod_I1Changed();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            OBSCATALOGO obj = new OBSCATALOGO();
            obj.NRREG = NRREG;
            obj.ObsCab_P1 = ObsCab_P1;
            obj.ObsRod_P1 = ObsRod_P1;
            obj.ObsCab_E1 = ObsCab_E1;
            obj.ObsRod_E1 = ObsRod_E1;
            obj.ObsCab_I1 = ObsCab_I1;
            obj.ObsRod_I1 = ObsRod_I1;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          OBSCATALOGO toCompare = obj as OBSCATALOGO;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.NRREG, toCompare.NRREG))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + NRREG.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
