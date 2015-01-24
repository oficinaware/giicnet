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
    /// There are no comments for DataGiic_LiagoModel.TABBAN_TIPOCONTA in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TIPOCONTA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TABBAN_TIPOCONTA")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TABBAN_TIPOCONTA : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TABBAN_TIPOCONTA object.
        /// </summary>
        /// <param name="tIPOCONTA">Initial value of TIPOCONTA.</param>
        public static TABBAN_TIPOCONTA CreateTABBAN_TIPOCONTA(short tIPOCONTA)
        {
            TABBAN_TIPOCONTA tABBAN_TIPOCONTA = new TABBAN_TIPOCONTA();
            tABBAN_TIPOCONTA.TIPOCONTA = tIPOCONTA;
            return tABBAN_TIPOCONTA;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for TIPOCONTA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public short TIPOCONTA
        {
            get
            {
                short value = _TIPOCONTA;
                OnGetTIPOCONTA(ref value);
                return value;
            }
            set
            {
                if (_TIPOCONTA != value)
                {
                  OnTIPOCONTAChanging(ref value);
                  ReportPropertyChanging("TIPOCONTA");
                  _TIPOCONTA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TIPOCONTA");
                  OnTIPOCONTAChanged();
              }
            }
        }
        private short _TIPOCONTA;
        partial void OnGetTIPOCONTA(ref short value);
        partial void OnTIPOCONTAChanging(ref short value);
        partial void OnTIPOCONTAChanged();
    
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
            TABBAN_TIPOCONTA obj = new TABBAN_TIPOCONTA();
            obj.TIPOCONTA = TIPOCONTA;
            obj.DESCRICAO = DESCRICAO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TABBAN_TIPOCONTA toCompare = obj as TABBAN_TIPOCONTA;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.TIPOCONTA, toCompare.TIPOCONTA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + TIPOCONTA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}