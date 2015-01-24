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
    /// There are no comments for DataGiic_LiagoModel.TS_WK_ARTIGOS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// IdArtigo
    /// CodCor
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TS_WK_ARTIGOS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TS_WK_ARTIGOS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TS_WK_ARTIGOS object.
        /// </summary>
        /// <param name="idArtigo">Initial value of IdArtigo.</param>
        /// <param name="codCor">Initial value of CodCor.</param>
        public static TS_WK_ARTIGOS CreateTS_WK_ARTIGOS(string idArtigo, string codCor)
        {
            TS_WK_ARTIGOS tS_WK_ARTIGOS = new TS_WK_ARTIGOS();
            tS_WK_ARTIGOS.IdArtigo = idArtigo;
            tS_WK_ARTIGOS.CodCor = codCor;
            return tS_WK_ARTIGOS;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for IdArtigo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string IdArtigo
        {
            get
            {
                string value = _IdArtigo;
                OnGetIdArtigo(ref value);
                return value;
            }
            set
            {
                if (_IdArtigo != value)
                {
                  OnIdArtigoChanging(ref value);
                  ReportPropertyChanging("IdArtigo");
                  _IdArtigo = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("IdArtigo");
                  OnIdArtigoChanged();
              }
            }
        }
        private string _IdArtigo;
        partial void OnGetIdArtigo(ref string value);
        partial void OnIdArtigoChanging(ref string value);
        partial void OnIdArtigoChanged();
    
        /// <summary>
        /// There are no comments for CodCor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CodCor
        {
            get
            {
                string value = _CodCor;
                OnGetCodCor(ref value);
                return value;
            }
            set
            {
                if (_CodCor != value)
                {
                  OnCodCorChanging(ref value);
                  ReportPropertyChanging("CodCor");
                  _CodCor = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CodCor");
                  OnCodCorChanged();
              }
            }
        }
        private string _CodCor = @"space((3))";
        partial void OnGetCodCor(ref string value);
        partial void OnCodCorChanging(ref string value);
        partial void OnCodCorChanged();
    
        /// <summary>
        /// There are no comments for Descricao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string Descricao
        {
            get
            {
                string value = _Descricao;
                OnGetDescricao(ref value);
                return value;
            }
            set
            {
                if (_Descricao != value)
                {
                  OnDescricaoChanging(ref value);
                  ReportPropertyChanging("Descricao");
                  _Descricao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Descricao");
                  OnDescricaoChanged();
              }
            }
        }
        private string _Descricao;
        partial void OnGetDescricao(ref string value);
        partial void OnDescricaoChanging(ref string value);
        partial void OnDescricaoChanged();
    
        /// <summary>
        /// There are no comments for DescCor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string DescCor
        {
            get
            {
                string value = _DescCor;
                OnGetDescCor(ref value);
                return value;
            }
            set
            {
                if (_DescCor != value)
                {
                  OnDescCorChanging(ref value);
                  ReportPropertyChanging("DescCor");
                  _DescCor = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DescCor");
                  OnDescCorChanged();
              }
            }
        }
        private string _DescCor;
        partial void OnGetDescCor(ref string value);
        partial void OnDescCorChanging(ref string value);
        partial void OnDescCorChanged();
    
        /// <summary>
        /// There are no comments for Familia in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string Familia
        {
            get
            {
                string value = _Familia;
                OnGetFamilia(ref value);
                return value;
            }
            set
            {
                if (_Familia != value)
                {
                  OnFamiliaChanging(ref value);
                  ReportPropertyChanging("Familia");
                  _Familia = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Familia");
                  OnFamiliaChanged();
              }
            }
        }
        private string _Familia;
        partial void OnGetFamilia(ref string value);
        partial void OnFamiliaChanging(ref string value);
        partial void OnFamiliaChanged();
    
        /// <summary>
        /// There are no comments for DescFamilia in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public string DescFamilia
        {
            get
            {
                string value = _DescFamilia;
                OnGetDescFamilia(ref value);
                return value;
            }
            set
            {
                if (_DescFamilia != value)
                {
                  OnDescFamiliaChanging(ref value);
                  ReportPropertyChanging("DescFamilia");
                  _DescFamilia = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DescFamilia");
                  OnDescFamiliaChanged();
              }
            }
        }
        private string _DescFamilia;
        partial void OnGetDescFamilia(ref string value);
        partial void OnDescFamiliaChanging(ref string value);
        partial void OnDescFamiliaChanged();
    
        /// <summary>
        /// There are no comments for UnMed in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string UnMed
        {
            get
            {
                string value = _UnMed;
                OnGetUnMed(ref value);
                return value;
            }
            set
            {
                if (_UnMed != value)
                {
                  OnUnMedChanging(ref value);
                  ReportPropertyChanging("UnMed");
                  _UnMed = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("UnMed");
                  OnUnMedChanged();
              }
            }
        }
        private string _UnMed;
        partial void OnGetUnMed(ref string value);
        partial void OnUnMedChanging(ref string value);
        partial void OnUnMedChanged();
    
        /// <summary>
        /// There are no comments for Tamanhos in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(180)]
        public string Tamanhos
        {
            get
            {
                string value = _Tamanhos;
                OnGetTamanhos(ref value);
                return value;
            }
            set
            {
                if (_Tamanhos != value)
                {
                  OnTamanhosChanging(ref value);
                  ReportPropertyChanging("Tamanhos");
                  _Tamanhos = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Tamanhos");
                  OnTamanhosChanged();
              }
            }
        }
        private string _Tamanhos;
        partial void OnGetTamanhos(ref string value);
        partial void OnTamanhosChanging(ref string value);
        partial void OnTamanhosChanged();
    
        /// <summary>
        /// There are no comments for ListaPrecos in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(460)]
        public string ListaPrecos
        {
            get
            {
                string value = _ListaPrecos;
                OnGetListaPrecos(ref value);
                return value;
            }
            set
            {
                if (_ListaPrecos != value)
                {
                  OnListaPrecosChanging(ref value);
                  ReportPropertyChanging("ListaPrecos");
                  _ListaPrecos = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ListaPrecos");
                  OnListaPrecosChanged();
              }
            }
        }
        private string _ListaPrecos;
        partial void OnGetListaPrecos(ref string value);
        partial void OnListaPrecosChanging(ref string value);
        partial void OnListaPrecosChanged();
    
        /// <summary>
        /// There are no comments for Syst_Op in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        public string Syst_Op
        {
            get
            {
                string value = _Syst_Op;
                OnGetSyst_Op(ref value);
                return value;
            }
            set
            {
                if (_Syst_Op != value)
                {
                  OnSyst_OpChanging(ref value);
                  ReportPropertyChanging("Syst_Op");
                  _Syst_Op = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Syst_Op");
                  OnSyst_OpChanged();
              }
            }
        }
        private string _Syst_Op;
        partial void OnGetSyst_Op(ref string value);
        partial void OnSyst_OpChanging(ref string value);
        partial void OnSyst_OpChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TS_WK_ARTIGOS obj = new TS_WK_ARTIGOS();
            obj.IdArtigo = IdArtigo;
            obj.CodCor = CodCor;
            obj.Descricao = Descricao;
            obj.DescCor = DescCor;
            obj.Familia = Familia;
            obj.DescFamilia = DescFamilia;
            obj.UnMed = UnMed;
            obj.Tamanhos = Tamanhos;
            obj.ListaPrecos = ListaPrecos;
            obj.Syst_Op = Syst_Op;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TS_WK_ARTIGOS toCompare = obj as TS_WK_ARTIGOS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.IdArtigo, toCompare.IdArtigo))
            return false;
          if (!Object.Equals(this.CodCor, toCompare.CodCor))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + IdArtigo.GetHashCode();
          hashCode = (hashCode * 7) + CodCor.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}