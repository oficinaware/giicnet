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
    /// There are no comments for DataGiic_LiagoModel.MODMEMO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// MODELO
    /// VARIANTE
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="MODMEMO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MODMEMO : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new MODMEMO object.
        /// </summary>
        /// <param name="mODELO">Initial value of MODELO.</param>
        /// <param name="vARIANTE">Initial value of VARIANTE.</param>
        public static MODMEMO CreateMODMEMO(string mODELO, string vARIANTE)
        {
            MODMEMO mODMEMO = new MODMEMO();
            mODMEMO.MODELO = mODELO;
            mODMEMO.VARIANTE = vARIANTE;
            return mODMEMO;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for MODELO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string MODELO
        {
            get
            {
                string value = _MODELO;
                OnGetMODELO(ref value);
                return value;
            }
            set
            {
                if (_MODELO != value)
                {
                  OnMODELOChanging(ref value);
                  ReportPropertyChanging("MODELO");
                  _MODELO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("MODELO");
                  OnMODELOChanged();
              }
            }
        }
        private string _MODELO;
        partial void OnGetMODELO(ref string value);
        partial void OnMODELOChanging(ref string value);
        partial void OnMODELOChanged();
    
        /// <summary>
        /// There are no comments for VARIANTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string VARIANTE
        {
            get
            {
                string value = _VARIANTE;
                OnGetVARIANTE(ref value);
                return value;
            }
            set
            {
                if (_VARIANTE != value)
                {
                  OnVARIANTEChanging(ref value);
                  ReportPropertyChanging("VARIANTE");
                  _VARIANTE = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("VARIANTE");
                  OnVARIANTEChanged();
              }
            }
        }
        private string _VARIANTE;
        partial void OnGetVARIANTE(ref string value);
        partial void OnVARIANTEChanging(ref string value);
        partial void OnVARIANTEChanged();
    
        /// <summary>
        /// There are no comments for OBS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string OBS
        {
            get
            {
                string value = _OBS;
                OnGetOBS(ref value);
                return value;
            }
            set
            {
                if (_OBS != value)
                {
                  OnOBSChanging(ref value);
                  ReportPropertyChanging("OBS");
                  _OBS = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("OBS");
                  OnOBSChanged();
              }
            }
        }
        private string _OBS;
        partial void OnGetOBS(ref string value);
        partial void OnOBSChanging(ref string value);
        partial void OnOBSChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            MODMEMO obj = new MODMEMO();
            obj.MODELO = MODELO;
            obj.VARIANTE = VARIANTE;
            obj.OBS = OBS;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          MODMEMO toCompare = obj as MODMEMO;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.MODELO, toCompare.MODELO))
            return false;
          if (!Object.Equals(this.VARIANTE, toCompare.VARIANTE))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + MODELO.GetHashCode();
          hashCode = (hashCode * 7) + VARIANTE.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
