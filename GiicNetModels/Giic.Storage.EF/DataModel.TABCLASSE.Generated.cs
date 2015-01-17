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
    /// There are no comments for DataGiic_LiagoModel.TABCLASSE in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CLASSE
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABCLASSE")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABCLASSE : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABCLASSE object.
        /// </summary>
        /// <param name="cLASSE">Initial value of CLASSE.</param>
        public static TABCLASSE CreateTABCLASSE(string cLASSE)
        {
            TABCLASSE tABCLASSE = new TABCLASSE();
            tABCLASSE.CLASSE = cLASSE;
            return tABCLASSE;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CLASSE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CLASSE
        {
            get
            {
                string value = _CLASSE;
                OnGetCLASSE(ref value);
                return value;
            }
            set
            {
                if (_CLASSE != value)
                {
                  OnCLASSEChanging(ref value);
                  ReportPropertyChanging("CLASSE");
                  _CLASSE = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CLASSE");
                  OnCLASSEChanged();
              }
            }
        }
        private string _CLASSE;
        partial void OnGetCLASSE(ref string value);
        partial void OnCLASSEChanging(ref string value);
        partial void OnCLASSEChanged();
    
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

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TABCLASSE obj = new TABCLASSE();
            obj.CLASSE = CLASSE;
            obj.DESCRICAO = DESCRICAO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABCLASSE toCompare = obj as TABCLASSE;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CLASSE, toCompare.CLASSE))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CLASSE.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
