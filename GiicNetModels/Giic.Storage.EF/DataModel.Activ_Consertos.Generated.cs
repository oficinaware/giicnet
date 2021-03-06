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
    /// There are no comments for DataGiic_LiagoModel.Activ_Consertos in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID_Actividade
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="Activ_Consertos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Activ_Consertos : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new Activ_Consertos object.
        /// </summary>
        /// <param name="iD_Actividade">Initial value of ID_Actividade.</param>
        public static Activ_Consertos CreateActiv_Consertos(int iD_Actividade)
        {
            Activ_Consertos activ_Consertos = new Activ_Consertos();
            activ_Consertos.ID_Actividade = iD_Actividade;
            return activ_Consertos;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID_Actividade in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int ID_Actividade
        {
            get
            {
                int value = _ID_Actividade;
                OnGetID_Actividade(ref value);
                return value;
            }
            set
            {
                if (_ID_Actividade != value)
                {
                  OnID_ActividadeChanging(ref value);
                  ReportPropertyChanging("ID_Actividade");
                  _ID_Actividade = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID_Actividade");
                  OnID_ActividadeChanged();
              }
            }
        }
        private int _ID_Actividade;
        partial void OnGetID_Actividade(ref int value);
        partial void OnID_ActividadeChanging(ref int value);
        partial void OnID_ActividadeChanged();
    
        /// <summary>
        /// There are no comments for Activ_Descricao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string Activ_Descricao
        {
            get
            {
                string value = _Activ_Descricao;
                OnGetActiv_Descricao(ref value);
                return value;
            }
            set
            {
                if (_Activ_Descricao != value)
                {
                  OnActiv_DescricaoChanging(ref value);
                  ReportPropertyChanging("Activ_Descricao");
                  _Activ_Descricao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Activ_Descricao");
                  OnActiv_DescricaoChanged();
              }
            }
        }
        private string _Activ_Descricao;
        partial void OnGetActiv_Descricao(ref string value);
        partial void OnActiv_DescricaoChanging(ref string value);
        partial void OnActiv_DescricaoChanged();
    
        /// <summary>
        /// There are no comments for Sinal in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string Sinal
        {
            get
            {
                string value = _Sinal;
                OnGetSinal(ref value);
                return value;
            }
            set
            {
                if (_Sinal != value)
                {
                  OnSinalChanging(ref value);
                  ReportPropertyChanging("Sinal");
                  _Sinal = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Sinal");
                  OnSinalChanged();
              }
            }
        }
        private string _Sinal;
        partial void OnGetSinal(ref string value);
        partial void OnSinalChanging(ref string value);
        partial void OnSinalChanged();
    
        /// <summary>
        /// There are no comments for Loja in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> Loja
        {
            get
            {
                global::System.Nullable<bool> value = _Loja;
                OnGetLoja(ref value);
                return value;
            }
            set
            {
                if (_Loja != value)
                {
                  OnLojaChanging(ref value);
                  ReportPropertyChanging("Loja");
                  _Loja = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Loja");
                  OnLojaChanged();
              }
            }
        }
        private global::System.Nullable<bool> _Loja;
        partial void OnGetLoja(ref global::System.Nullable<bool> value);
        partial void OnLojaChanging(ref global::System.Nullable<bool> value);
        partial void OnLojaChanged();
    
        /// <summary>
        /// There are no comments for Central in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> Central
        {
            get
            {
                global::System.Nullable<bool> value = _Central;
                OnGetCentral(ref value);
                return value;
            }
            set
            {
                if (_Central != value)
                {
                  OnCentralChanging(ref value);
                  ReportPropertyChanging("Central");
                  _Central = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Central");
                  OnCentralChanged();
              }
            }
        }
        private global::System.Nullable<bool> _Central;
        partial void OnGetCentral(ref global::System.Nullable<bool> value);
        partial void OnCentralChanging(ref global::System.Nullable<bool> value);
        partial void OnCentralChanged();
    
        /// <summary>
        /// There are no comments for Forn in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> Forn
        {
            get
            {
                global::System.Nullable<bool> value = _Forn;
                OnGetForn(ref value);
                return value;
            }
            set
            {
                if (_Forn != value)
                {
                  OnFornChanging(ref value);
                  ReportPropertyChanging("Forn");
                  _Forn = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Forn");
                  OnFornChanged();
              }
            }
        }
        private global::System.Nullable<bool> _Forn;
        partial void OnGetForn(ref global::System.Nullable<bool> value);
        partial void OnFornChanging(ref global::System.Nullable<bool> value);
        partial void OnFornChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            Activ_Consertos obj = new Activ_Consertos();
            obj.ID_Actividade = ID_Actividade;
            obj.Activ_Descricao = Activ_Descricao;
            obj.Sinal = Sinal;
            obj.Loja = Loja;
            obj.Central = Central;
            obj.Forn = Forn;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          Activ_Consertos toCompare = obj as Activ_Consertos;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ID_Actividade, toCompare.ID_Actividade))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ID_Actividade.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
