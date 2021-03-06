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
    /// There are no comments for DataGiic_LiagoModel.AlertasErros in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IDErro
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="AlertasErros")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AlertasErros : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new AlertasErros object.
        /// </summary>
        /// <param name="iDErro">Initial value of IDErro.</param>
        public static AlertasErros CreateAlertasErros(int iDErro)
        {
            AlertasErros alertasErros = new AlertasErros();
            alertasErros.IDErro = iDErro;
            return alertasErros;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for IDErro in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int IDErro
        {
            get
            {
                int value = _IDErro;
                OnGetIDErro(ref value);
                return value;
            }
            set
            {
                if (_IDErro != value)
                {
                  OnIDErroChanging(ref value);
                  ReportPropertyChanging("IDErro");
                  _IDErro = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("IDErro");
                  OnIDErroChanged();
              }
            }
        }
        private int _IDErro;
        partial void OnGetIDErro(ref int value);
        partial void OnIDErroChanging(ref int value);
        partial void OnIDErroChanged();
    
        /// <summary>
        /// There are no comments for CategoriaAlerta in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
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
                  _CategoriaAlerta = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for DataHora in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DataHora
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DataHora;
                OnGetDataHora(ref value);
                return value;
            }
            set
            {
                if (_DataHora != value)
                {
                  OnDataHoraChanging(ref value);
                  ReportPropertyChanging("DataHora");
                  _DataHora = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DataHora");
                  OnDataHoraChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DataHora = DateTime.Now;
        partial void OnGetDataHora(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataHoraChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataHoraChanged();
    
        /// <summary>
        /// There are no comments for NumErro in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> NumErro
        {
            get
            {
                global::System.Nullable<int> value = _NumErro;
                OnGetNumErro(ref value);
                return value;
            }
            set
            {
                if (_NumErro != value)
                {
                  OnNumErroChanging(ref value);
                  ReportPropertyChanging("NumErro");
                  _NumErro = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NumErro");
                  OnNumErroChanged();
              }
            }
        }
        private global::System.Nullable<int> _NumErro = 0;
        partial void OnGetNumErro(ref global::System.Nullable<int> value);
        partial void OnNumErroChanging(ref global::System.Nullable<int> value);
        partial void OnNumErroChanged();
    
        /// <summary>
        /// There are no comments for DescErro in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(400)]
        public string DescErro
        {
            get
            {
                string value = _DescErro;
                OnGetDescErro(ref value);
                return value;
            }
            set
            {
                if (_DescErro != value)
                {
                  OnDescErroChanging(ref value);
                  ReportPropertyChanging("DescErro");
                  _DescErro = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DescErro");
                  OnDescErroChanged();
              }
            }
        }
        private string _DescErro;
        partial void OnGetDescErro(ref string value);
        partial void OnDescErroChanging(ref string value);
        partial void OnDescErroChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            AlertasErros obj = new AlertasErros();
            obj.IDErro = IDErro;
            obj.CategoriaAlerta = CategoriaAlerta;
            obj.DataHora = DataHora;
            obj.NumErro = NumErro;
            obj.DescErro = DescErro;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          AlertasErros toCompare = obj as AlertasErros;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.IDErro, toCompare.IDErro))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + IDErro.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
