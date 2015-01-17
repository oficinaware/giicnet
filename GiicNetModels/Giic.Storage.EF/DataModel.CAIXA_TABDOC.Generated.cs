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
    /// There are no comments for DataGiic_LiagoModel.CAIXA_TABDOC in the schema.
    /// </summary>
    /// <KeyProperties>
    /// MOVCX
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CAIXA_TABDOC")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CAIXA_TABDOC : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CAIXA_TABDOC object.
        /// </summary>
        /// <param name="mOVCX">Initial value of MOVCX.</param>
        public static CAIXA_TABDOC CreateCAIXA_TABDOC(string mOVCX)
        {
            CAIXA_TABDOC cAIXA_TABDOC = new CAIXA_TABDOC();
            cAIXA_TABDOC.MOVCX = mOVCX;
            return cAIXA_TABDOC;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for MOVCX in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string MOVCX
        {
            get
            {
                string value = _MOVCX;
                OnGetMOVCX(ref value);
                return value;
            }
            set
            {
                if (_MOVCX != value)
                {
                  OnMOVCXChanging(ref value);
                  ReportPropertyChanging("MOVCX");
                  _MOVCX = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("MOVCX");
                  OnMOVCXChanged();
              }
            }
        }
        private string _MOVCX;
        partial void OnGetMOVCX(ref string value);
        partial void OnMOVCXChanging(ref string value);
        partial void OnMOVCXChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(25)]
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
                  _DESCRICAO = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for SINCX in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string SINCX
        {
            get
            {
                string value = _SINCX;
                OnGetSINCX(ref value);
                return value;
            }
            set
            {
                if (_SINCX != value)
                {
                  OnSINCXChanging(ref value);
                  ReportPropertyChanging("SINCX");
                  _SINCX = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("SINCX");
                  OnSINCXChanged();
              }
            }
        }
        private string _SINCX;
        partial void OnGetSINCX(ref string value);
        partial void OnSINCXChanging(ref string value);
        partial void OnSINCXChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CAIXA_TABDOC obj = new CAIXA_TABDOC();
            obj.MOVCX = MOVCX;
            obj.DESCRICAO = DESCRICAO;
            obj.SINCX = SINCX;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CAIXA_TABDOC toCompare = obj as CAIXA_TABDOC;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.MOVCX, toCompare.MOVCX))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + MOVCX.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
