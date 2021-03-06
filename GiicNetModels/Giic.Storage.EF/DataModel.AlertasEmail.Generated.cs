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
    /// There are no comments for DataGiic_LiagoModel.AlertasEmail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CategoriaAlerta
    /// Email
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="AlertasEmail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AlertasEmail : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new AlertasEmail object.
        /// </summary>
        /// <param name="categoriaAlerta">Initial value of CategoriaAlerta.</param>
        /// <param name="email">Initial value of Email.</param>
        /// <param name="enviarEmail">Initial value of EnviarEmail.</param>
        public static AlertasEmail CreateAlertasEmail(string categoriaAlerta, string email, bool enviarEmail)
        {
            AlertasEmail alertasEmail = new AlertasEmail();
            alertasEmail.CategoriaAlerta = categoriaAlerta;
            alertasEmail.Email = email;
            alertasEmail.EnviarEmail = enviarEmail;
            return alertasEmail;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CategoriaAlerta in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CategoriaAlerta
        {
            get
            {
                string value = _CategoriaAlerta;
                OnGetCategoriaAlerta(ref value);
                return value;
            }
            set
            {
                if (_CategoriaAlerta != value)
                {
                  OnCategoriaAlertaChanging(ref value);
                  ReportPropertyChanging("CategoriaAlerta");
                  _CategoriaAlerta = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CategoriaAlerta");
                  OnCategoriaAlertaChanged();
              }
            }
        }
        private string _CategoriaAlerta = @"";
        partial void OnGetCategoriaAlerta(ref string value);
        partial void OnCategoriaAlertaChanging(ref string value);
        partial void OnCategoriaAlertaChanged();
    
        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string Email
        {
            get
            {
                string value = _Email;
                OnGetEmail(ref value);
                return value;
            }
            set
            {
                if (_Email != value)
                {
                  OnEmailChanging(ref value);
                  ReportPropertyChanging("Email");
                  _Email = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Email");
                  OnEmailChanged();
              }
            }
        }
        private string _Email = @"";
        partial void OnGetEmail(ref string value);
        partial void OnEmailChanging(ref string value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// There are no comments for EnviarEmail in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public bool EnviarEmail
        {
            get
            {
                bool value = _EnviarEmail;
                OnGetEnviarEmail(ref value);
                return value;
            }
            set
            {
                if (_EnviarEmail != value)
                {
                  OnEnviarEmailChanging(ref value);
                  ReportPropertyChanging("EnviarEmail");
                  _EnviarEmail = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("EnviarEmail");
                  OnEnviarEmailChanged();
              }
            }
        }
        private bool _EnviarEmail;
        partial void OnGetEnviarEmail(ref bool value);
        partial void OnEnviarEmailChanging(ref bool value);
        partial void OnEnviarEmailChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            AlertasEmail obj = new AlertasEmail();
            obj.CategoriaAlerta = CategoriaAlerta;
            obj.Email = Email;
            obj.EnviarEmail = EnviarEmail;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          AlertasEmail toCompare = obj as AlertasEmail;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CategoriaAlerta, toCompare.CategoriaAlerta))
            return false;
          if (!Object.Equals(this.Email, toCompare.Email))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CategoriaAlerta.GetHashCode();
          hashCode = (hashCode * 7) + Email.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
