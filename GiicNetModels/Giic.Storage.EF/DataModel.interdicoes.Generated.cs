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
    /// There are no comments for DataGiic_LiagoModel.interdicoes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// grupo
    /// formulario
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="interdicoes")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class interdicoes : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new interdicoes object.
        /// </summary>
        /// <param name="grupo">Initial value of grupo.</param>
        /// <param name="formulario">Initial value of formulario.</param>
        /// <param name="abrir">Initial value of abrir.</param>
        /// <param name="novo">Initial value of Novo.</param>
        /// <param name="editar">Initial value of Editar.</param>
        /// <param name="apagar">Initial value of Apagar.</param>
        public static interdicoes Createinterdicoes(string grupo, string formulario, bool abrir, bool novo, bool editar, bool apagar)
        {
            interdicoes interdicoes = new interdicoes();
            interdicoes.grupo = grupo;
            interdicoes.formulario = formulario;
            interdicoes.abrir = abrir;
            interdicoes.Novo = novo;
            interdicoes.Editar = editar;
            interdicoes.Apagar = apagar;
            return interdicoes;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for grupo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string grupo
        {
            get
            {
                string value = _grupo;
                OnGetgrupo(ref value);
                return value;
            }
            set
            {
                if (_grupo != value)
                {
                  OngrupoChanging(ref value);
                  ReportPropertyChanging("grupo");
                  _grupo = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("grupo");
                  OngrupoChanged();
              }
            }
        }
        private string _grupo;
        partial void OnGetgrupo(ref string value);
        partial void OngrupoChanging(ref string value);
        partial void OngrupoChanged();
    
        /// <summary>
        /// There are no comments for formulario in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string formulario
        {
            get
            {
                string value = _formulario;
                OnGetformulario(ref value);
                return value;
            }
            set
            {
                if (_formulario != value)
                {
                  OnformularioChanging(ref value);
                  ReportPropertyChanging("formulario");
                  _formulario = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("formulario");
                  OnformularioChanged();
              }
            }
        }
        private string _formulario;
        partial void OnGetformulario(ref string value);
        partial void OnformularioChanging(ref string value);
        partial void OnformularioChanged();
    
        /// <summary>
        /// There are no comments for abrir in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public bool abrir
        {
            get
            {
                bool value = _abrir;
                OnGetabrir(ref value);
                return value;
            }
            set
            {
                if (_abrir != value)
                {
                  OnabrirChanging(ref value);
                  ReportPropertyChanging("abrir");
                  _abrir = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("abrir");
                  OnabrirChanged();
              }
            }
        }
        private bool _abrir;
        partial void OnGetabrir(ref bool value);
        partial void OnabrirChanging(ref bool value);
        partial void OnabrirChanged();
    
        /// <summary>
        /// There are no comments for Novo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public bool Novo
        {
            get
            {
                bool value = _Novo;
                OnGetNovo(ref value);
                return value;
            }
            set
            {
                if (_Novo != value)
                {
                  OnNovoChanging(ref value);
                  ReportPropertyChanging("Novo");
                  _Novo = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Novo");
                  OnNovoChanged();
              }
            }
        }
        private bool _Novo;
        partial void OnGetNovo(ref bool value);
        partial void OnNovoChanging(ref bool value);
        partial void OnNovoChanged();
    
        /// <summary>
        /// There are no comments for Editar in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public bool Editar
        {
            get
            {
                bool value = _Editar;
                OnGetEditar(ref value);
                return value;
            }
            set
            {
                if (_Editar != value)
                {
                  OnEditarChanging(ref value);
                  ReportPropertyChanging("Editar");
                  _Editar = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Editar");
                  OnEditarChanged();
              }
            }
        }
        private bool _Editar;
        partial void OnGetEditar(ref bool value);
        partial void OnEditarChanging(ref bool value);
        partial void OnEditarChanged();
    
        /// <summary>
        /// There are no comments for Apagar in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public bool Apagar
        {
            get
            {
                bool value = _Apagar;
                OnGetApagar(ref value);
                return value;
            }
            set
            {
                if (_Apagar != value)
                {
                  OnApagarChanging(ref value);
                  ReportPropertyChanging("Apagar");
                  _Apagar = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Apagar");
                  OnApagarChanged();
              }
            }
        }
        private bool _Apagar;
        partial void OnGetApagar(ref bool value);
        partial void OnApagarChanging(ref bool value);
        partial void OnApagarChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            interdicoes obj = new interdicoes();
            obj.grupo = grupo;
            obj.formulario = formulario;
            obj.abrir = abrir;
            obj.Novo = Novo;
            obj.Editar = Editar;
            obj.Apagar = Apagar;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          interdicoes toCompare = obj as interdicoes;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.grupo, toCompare.grupo))
            return false;
          if (!Object.Equals(this.formulario, toCompare.formulario))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + grupo.GetHashCode();
          hashCode = (hashCode * 7) + formulario.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}