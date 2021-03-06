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
    /// There are no comments for DataGiic_LiagoModel.PICTOGRAMAS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// COD_PICT
    /// DESCRICAO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="PICTOGRAMAS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PICTOGRAMAS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new PICTOGRAMAS object.
        /// </summary>
        /// <param name="cOD_PICT">Initial value of COD_PICT.</param>
        /// <param name="dESCRICAO">Initial value of DESCRICAO.</param>
        public static PICTOGRAMAS CreatePICTOGRAMAS(string cOD_PICT, string dESCRICAO)
        {
            PICTOGRAMAS pICTOGRAMAS = new PICTOGRAMAS();
            pICTOGRAMAS.COD_PICT = cOD_PICT;
            pICTOGRAMAS.DESCRICAO = dESCRICAO;
            return pICTOGRAMAS;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for COD_PICT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string COD_PICT
        {
            get
            {
                string value = _COD_PICT;
                OnGetCOD_PICT(ref value);
                return value;
            }
            set
            {
                if (_COD_PICT != value)
                {
                  OnCOD_PICTChanging(ref value);
                  ReportPropertyChanging("COD_PICT");
                  _COD_PICT = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("COD_PICT");
                  OnCOD_PICTChanged();
              }
            }
        }
        private string _COD_PICT;
        partial void OnGetCOD_PICT(ref string value);
        partial void OnCOD_PICTChanging(ref string value);
        partial void OnCOD_PICTChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.Required()]
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
                  _DESCRICAO = StructuralObject.SetValidValue(value, false);
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
        /// There are no comments for LOGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string LOGO
        {
            get
            {
                string value = _LOGO;
                OnGetLOGO(ref value);
                return value;
            }
            set
            {
                if (_LOGO != value)
                {
                  OnLOGOChanging(ref value);
                  ReportPropertyChanging("LOGO");
                  _LOGO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("LOGO");
                  OnLOGOChanged();
              }
            }
        }
        private string _LOGO;
        partial void OnGetLOGO(ref string value);
        partial void OnLOGOChanging(ref string value);
        partial void OnLOGOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            PICTOGRAMAS obj = new PICTOGRAMAS();
            obj.COD_PICT = COD_PICT;
            obj.DESCRICAO = DESCRICAO;
            obj.LOGO = LOGO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          PICTOGRAMAS toCompare = obj as PICTOGRAMAS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.COD_PICT, toCompare.COD_PICT))
            return false;
          if (!Object.Equals(this.DESCRICAO, toCompare.DESCRICAO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + COD_PICT.GetHashCode();
          hashCode = (hashCode * 7) + DESCRICAO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
