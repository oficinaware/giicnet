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
    /// There are no comments for DataGiic_LiagoModel.ENCO_HOL in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EncoCli
    /// Linha
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="ENCO_HOL")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ENCO_HOL : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new ENCO_HOL object.
        /// </summary>
        /// <param name="encoCli">Initial value of EncoCli.</param>
        /// <param name="linha">Initial value of Linha.</param>
        public static ENCO_HOL CreateENCO_HOL(string encoCli, int linha)
        {
            ENCO_HOL eNCO_HOL = new ENCO_HOL();
            eNCO_HOL.EncoCli = encoCli;
            eNCO_HOL.Linha = linha;
            return eNCO_HOL;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for EncoCli in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string EncoCli
        {
            get
            {
                string value = _EncoCli;
                OnGetEncoCli(ref value);
                return value;
            }
            set
            {
                if (_EncoCli != value)
                {
                  OnEncoCliChanging(ref value);
                  ReportPropertyChanging("EncoCli");
                  _EncoCli = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("EncoCli");
                  OnEncoCliChanged();
              }
            }
        }
        private string _EncoCli;
        partial void OnGetEncoCli(ref string value);
        partial void OnEncoCliChanging(ref string value);
        partial void OnEncoCliChanged();
    
        /// <summary>
        /// There are no comments for Linha in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int Linha
        {
            get
            {
                int value = _Linha;
                OnGetLinha(ref value);
                return value;
            }
            set
            {
                if (_Linha != value)
                {
                  OnLinhaChanging(ref value);
                  ReportPropertyChanging("Linha");
                  _Linha = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Linha");
                  OnLinhaChanged();
              }
            }
        }
        private int _Linha;
        partial void OnGetLinha(ref int value);
        partial void OnLinhaChanging(ref int value);
        partial void OnLinhaChanged();
    
        /// <summary>
        /// There are no comments for LinhaMatriz in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LinhaMatriz
        {
            get
            {
                global::System.Nullable<int> value = _LinhaMatriz;
                OnGetLinhaMatriz(ref value);
                return value;
            }
            set
            {
                if (_LinhaMatriz != value)
                {
                  OnLinhaMatrizChanging(ref value);
                  ReportPropertyChanging("LinhaMatriz");
                  _LinhaMatriz = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LinhaMatriz");
                  OnLinhaMatrizChanged();
              }
            }
        }
        private global::System.Nullable<int> _LinhaMatriz;
        partial void OnGetLinhaMatriz(ref global::System.Nullable<int> value);
        partial void OnLinhaMatrizChanging(ref global::System.Nullable<int> value);
        partial void OnLinhaMatrizChanged();
    
        /// <summary>
        /// There are no comments for TipoArtigo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string TipoArtigo
        {
            get
            {
                string value = _TipoArtigo;
                OnGetTipoArtigo(ref value);
                return value;
            }
            set
            {
                if (_TipoArtigo != value)
                {
                  OnTipoArtigoChanging(ref value);
                  ReportPropertyChanging("TipoArtigo");
                  _TipoArtigo = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TipoArtigo");
                  OnTipoArtigoChanged();
              }
            }
        }
        private string _TipoArtigo;
        partial void OnGetTipoArtigo(ref string value);
        partial void OnTipoArtigoChanging(ref string value);
        partial void OnTipoArtigoChanged();
    
        /// <summary>
        /// There are no comments for Modelo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Modelo
        {
            get
            {
                string value = _Modelo;
                OnGetModelo(ref value);
                return value;
            }
            set
            {
                if (_Modelo != value)
                {
                  OnModeloChanging(ref value);
                  ReportPropertyChanging("Modelo");
                  _Modelo = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Modelo");
                  OnModeloChanged();
              }
            }
        }
        private string _Modelo;
        partial void OnGetModelo(ref string value);
        partial void OnModeloChanging(ref string value);
        partial void OnModeloChanged();
    
        /// <summary>
        /// There are no comments for DescAgente in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string DescAgente
        {
            get
            {
                string value = _DescAgente;
                OnGetDescAgente(ref value);
                return value;
            }
            set
            {
                if (_DescAgente != value)
                {
                  OnDescAgenteChanging(ref value);
                  ReportPropertyChanging("DescAgente");
                  _DescAgente = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DescAgente");
                  OnDescAgenteChanged();
              }
            }
        }
        private string _DescAgente;
        partial void OnGetDescAgente(ref string value);
        partial void OnDescAgenteChanging(ref string value);
        partial void OnDescAgenteChanged();
    
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
        /// There are no comments for NTam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string NTam
        {
            get
            {
                string value = _NTam;
                OnGetNTam(ref value);
                return value;
            }
            set
            {
                if (_NTam != value)
                {
                  OnNTamChanging(ref value);
                  ReportPropertyChanging("NTam");
                  _NTam = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NTam");
                  OnNTamChanged();
              }
            }
        }
        private string _NTam;
        partial void OnGetNTam(ref string value);
        partial void OnNTamChanging(ref string value);
        partial void OnNTamChanged();
    
        /// <summary>
        /// There are no comments for VTam in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VTam
        {
            get
            {
                string value = _VTam;
                OnGetVTam(ref value);
                return value;
            }
            set
            {
                if (_VTam != value)
                {
                  OnVTamChanging(ref value);
                  ReportPropertyChanging("VTam");
                  _VTam = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VTam");
                  OnVTamChanged();
              }
            }
        }
        private string _VTam;
        partial void OnGetVTam(ref string value);
        partial void OnVTamChanging(ref string value);
        partial void OnVTamChanged();
    
        /// <summary>
        /// There are no comments for CliDesp in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string CliDesp
        {
            get
            {
                string value = _CliDesp;
                OnGetCliDesp(ref value);
                return value;
            }
            set
            {
                if (_CliDesp != value)
                {
                  OnCliDespChanging(ref value);
                  ReportPropertyChanging("CliDesp");
                  _CliDesp = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CliDesp");
                  OnCliDespChanged();
              }
            }
        }
        private string _CliDesp;
        partial void OnGetCliDesp(ref string value);
        partial void OnCliDespChanging(ref string value);
        partial void OnCliDespChanged();
    
        /// <summary>
        /// There are no comments for Unmed in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string Unmed
        {
            get
            {
                string value = _Unmed;
                OnGetUnmed(ref value);
                return value;
            }
            set
            {
                if (_Unmed != value)
                {
                  OnUnmedChanging(ref value);
                  ReportPropertyChanging("Unmed");
                  _Unmed = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Unmed");
                  OnUnmedChanged();
              }
            }
        }
        private string _Unmed;
        partial void OnGetUnmed(ref string value);
        partial void OnUnmedChanging(ref string value);
        partial void OnUnmedChanged();
    
        /// <summary>
        /// There are no comments for Quant1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> Quant1
        {
            get
            {
                global::System.Nullable<int> value = _Quant1;
                OnGetQuant1(ref value);
                return value;
            }
            set
            {
                if (_Quant1 != value)
                {
                  OnQuant1Changing(ref value);
                  ReportPropertyChanging("Quant1");
                  _Quant1 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Quant1");
                  OnQuant1Changed();
              }
            }
        }
        private global::System.Nullable<int> _Quant1 = 0;
        partial void OnGetQuant1(ref global::System.Nullable<int> value);
        partial void OnQuant1Changing(ref global::System.Nullable<int> value);
        partial void OnQuant1Changed();
    
        /// <summary>
        /// There are no comments for Quant2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> Quant2
        {
            get
            {
                global::System.Nullable<int> value = _Quant2;
                OnGetQuant2(ref value);
                return value;
            }
            set
            {
                if (_Quant2 != value)
                {
                  OnQuant2Changing(ref value);
                  ReportPropertyChanging("Quant2");
                  _Quant2 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Quant2");
                  OnQuant2Changed();
              }
            }
        }
        private global::System.Nullable<int> _Quant2 = 0;
        partial void OnGetQuant2(ref global::System.Nullable<int> value);
        partial void OnQuant2Changing(ref global::System.Nullable<int> value);
        partial void OnQuant2Changed();
    
        /// <summary>
        /// There are no comments for Preco in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> Preco
        {
            get
            {
                global::System.Nullable<decimal> value = _Preco;
                OnGetPreco(ref value);
                return value;
            }
            set
            {
                if (_Preco != value)
                {
                  OnPrecoChanging(ref value);
                  ReportPropertyChanging("Preco");
                  _Preco = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Preco");
                  OnPrecoChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _Preco = 0m;
        partial void OnGetPreco(ref global::System.Nullable<decimal> value);
        partial void OnPrecoChanging(ref global::System.Nullable<decimal> value);
        partial void OnPrecoChanged();
    
        /// <summary>
        /// There are no comments for Prazo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> Prazo
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _Prazo;
                OnGetPrazo(ref value);
                return value;
            }
            set
            {
                if (_Prazo != value)
                {
                  OnPrazoChanging(ref value);
                  ReportPropertyChanging("Prazo");
                  _Prazo = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Prazo");
                  OnPrazoChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _Prazo;
        partial void OnGetPrazo(ref global::System.Nullable<System.DateTime> value);
        partial void OnPrazoChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnPrazoChanged();
    
        /// <summary>
        /// There are no comments for PrazoEnt in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> PrazoEnt
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _PrazoEnt;
                OnGetPrazoEnt(ref value);
                return value;
            }
            set
            {
                if (_PrazoEnt != value)
                {
                  OnPrazoEntChanging(ref value);
                  ReportPropertyChanging("PrazoEnt");
                  _PrazoEnt = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PrazoEnt");
                  OnPrazoEntChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _PrazoEnt;
        partial void OnGetPrazoEnt(ref global::System.Nullable<System.DateTime> value);
        partial void OnPrazoEntChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnPrazoEntChanged();
    
        /// <summary>
        /// There are no comments for DataEncoCli in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DataEncoCli
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DataEncoCli;
                OnGetDataEncoCli(ref value);
                return value;
            }
            set
            {
                if (_DataEncoCli != value)
                {
                  OnDataEncoCliChanging(ref value);
                  ReportPropertyChanging("DataEncoCli");
                  _DataEncoCli = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DataEncoCli");
                  OnDataEncoCliChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DataEncoCli;
        partial void OnGetDataEncoCli(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataEncoCliChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataEncoCliChanged();
    
        /// <summary>
        /// There are no comments for DataEnco in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DataEnco
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DataEnco;
                OnGetDataEnco(ref value);
                return value;
            }
            set
            {
                if (_DataEnco != value)
                {
                  OnDataEncoChanging(ref value);
                  ReportPropertyChanging("DataEnco");
                  _DataEnco = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DataEnco");
                  OnDataEncoChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DataEnco;
        partial void OnGetDataEnco(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataEncoChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataEncoChanged();
    
        /// <summary>
        /// There are no comments for DataPlano in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DataPlano
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DataPlano;
                OnGetDataPlano(ref value);
                return value;
            }
            set
            {
                if (_DataPlano != value)
                {
                  OnDataPlanoChanging(ref value);
                  ReportPropertyChanging("DataPlano");
                  _DataPlano = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DataPlano");
                  OnDataPlanoChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DataPlano;
        partial void OnGetDataPlano(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataPlanoChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataPlanoChanged();
    
        /// <summary>
        /// There are no comments for Marca in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string Marca
        {
            get
            {
                string value = _Marca;
                OnGetMarca(ref value);
                return value;
            }
            set
            {
                if (_Marca != value)
                {
                  OnMarcaChanging(ref value);
                  ReportPropertyChanging("Marca");
                  _Marca = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Marca");
                  OnMarcaChanged();
              }
            }
        }
        private string _Marca;
        partial void OnGetMarca(ref string value);
        partial void OnMarcaChanging(ref string value);
        partial void OnMarcaChanged();
    
        /// <summary>
        /// There are no comments for Coleccao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Coleccao
        {
            get
            {
                string value = _Coleccao;
                OnGetColeccao(ref value);
                return value;
            }
            set
            {
                if (_Coleccao != value)
                {
                  OnColeccaoChanging(ref value);
                  ReportPropertyChanging("Coleccao");
                  _Coleccao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Coleccao");
                  OnColeccaoChanged();
              }
            }
        }
        private string _Coleccao;
        partial void OnGetColeccao(ref string value);
        partial void OnColeccaoChanging(ref string value);
        partial void OnColeccaoChanged();
    
        /// <summary>
        /// There are no comments for Estacao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Estacao
        {
            get
            {
                string value = _Estacao;
                OnGetEstacao(ref value);
                return value;
            }
            set
            {
                if (_Estacao != value)
                {
                  OnEstacaoChanging(ref value);
                  ReportPropertyChanging("Estacao");
                  _Estacao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Estacao");
                  OnEstacaoChanged();
              }
            }
        }
        private string _Estacao;
        partial void OnGetEstacao(ref string value);
        partial void OnEstacaoChanging(ref string value);
        partial void OnEstacaoChanged();
    
        /// <summary>
        /// There are no comments for Tema in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Tema
        {
            get
            {
                string value = _Tema;
                OnGetTema(ref value);
                return value;
            }
            set
            {
                if (_Tema != value)
                {
                  OnTemaChanging(ref value);
                  ReportPropertyChanging("Tema");
                  _Tema = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Tema");
                  OnTemaChanged();
              }
            }
        }
        private string _Tema;
        partial void OnGetTema(ref string value);
        partial void OnTemaChanging(ref string value);
        partial void OnTemaChanged();
    
        /// <summary>
        /// There are no comments for Desc1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Desc1
        {
            get
            {
                string value = _Desc1;
                OnGetDesc1(ref value);
                return value;
            }
            set
            {
                if (_Desc1 != value)
                {
                  OnDesc1Changing(ref value);
                  ReportPropertyChanging("Desc1");
                  _Desc1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Desc1");
                  OnDesc1Changed();
              }
            }
        }
        private string _Desc1;
        partial void OnGetDesc1(ref string value);
        partial void OnDesc1Changing(ref string value);
        partial void OnDesc1Changed();
    
        /// <summary>
        /// There are no comments for Desc2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Desc2
        {
            get
            {
                string value = _Desc2;
                OnGetDesc2(ref value);
                return value;
            }
            set
            {
                if (_Desc2 != value)
                {
                  OnDesc2Changing(ref value);
                  ReportPropertyChanging("Desc2");
                  _Desc2 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Desc2");
                  OnDesc2Changed();
              }
            }
        }
        private string _Desc2;
        partial void OnGetDesc2(ref string value);
        partial void OnDesc2Changing(ref string value);
        partial void OnDesc2Changed();
    
        /// <summary>
        /// There are no comments for Desc3 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Desc3
        {
            get
            {
                string value = _Desc3;
                OnGetDesc3(ref value);
                return value;
            }
            set
            {
                if (_Desc3 != value)
                {
                  OnDesc3Changing(ref value);
                  ReportPropertyChanging("Desc3");
                  _Desc3 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Desc3");
                  OnDesc3Changed();
              }
            }
        }
        private string _Desc3;
        partial void OnGetDesc3(ref string value);
        partial void OnDesc3Changing(ref string value);
        partial void OnDesc3Changed();
    
        /// <summary>
        /// There are no comments for Desc4 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Desc4
        {
            get
            {
                string value = _Desc4;
                OnGetDesc4(ref value);
                return value;
            }
            set
            {
                if (_Desc4 != value)
                {
                  OnDesc4Changing(ref value);
                  ReportPropertyChanging("Desc4");
                  _Desc4 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Desc4");
                  OnDesc4Changed();
              }
            }
        }
        private string _Desc4;
        partial void OnGetDesc4(ref string value);
        partial void OnDesc4Changing(ref string value);
        partial void OnDesc4Changed();
    
        /// <summary>
        /// There are no comments for Desc5 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string Desc5
        {
            get
            {
                string value = _Desc5;
                OnGetDesc5(ref value);
                return value;
            }
            set
            {
                if (_Desc5 != value)
                {
                  OnDesc5Changing(ref value);
                  ReportPropertyChanging("Desc5");
                  _Desc5 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Desc5");
                  OnDesc5Changed();
              }
            }
        }
        private string _Desc5;
        partial void OnGetDesc5(ref string value);
        partial void OnDesc5Changing(ref string value);
        partial void OnDesc5Changed();
    
        /// <summary>
        /// There are no comments for integrado in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> integrado
        {
            get
            {
                global::System.Nullable<bool> value = _integrado;
                OnGetintegrado(ref value);
                return value;
            }
            set
            {
                if (_integrado != value)
                {
                  OnintegradoChanging(ref value);
                  ReportPropertyChanging("integrado");
                  _integrado = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("integrado");
                  OnintegradoChanged();
              }
            }
        }
        private global::System.Nullable<bool> _integrado;
        partial void OnGetintegrado(ref global::System.Nullable<bool> value);
        partial void OnintegradoChanging(ref global::System.Nullable<bool> value);
        partial void OnintegradoChanged();
    
        /// <summary>
        /// There are no comments for NRENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string NRENCO
        {
            get
            {
                string value = _NRENCO;
                OnGetNRENCO(ref value);
                return value;
            }
            set
            {
                if (_NRENCO != value)
                {
                  OnNRENCOChanging(ref value);
                  ReportPropertyChanging("NRENCO");
                  _NRENCO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NRENCO");
                  OnNRENCOChanged();
              }
            }
        }
        private string _NRENCO;
        partial void OnGetNRENCO(ref string value);
        partial void OnNRENCOChanging(ref string value);
        partial void OnNRENCOChanged();
    
        /// <summary>
        /// There are no comments for LNENCO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> LNENCO
        {
            get
            {
                global::System.Nullable<int> value = _LNENCO;
                OnGetLNENCO(ref value);
                return value;
            }
            set
            {
                if (_LNENCO != value)
                {
                  OnLNENCOChanging(ref value);
                  ReportPropertyChanging("LNENCO");
                  _LNENCO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("LNENCO");
                  OnLNENCOChanged();
              }
            }
        }
        private global::System.Nullable<int> _LNENCO;
        partial void OnGetLNENCO(ref global::System.Nullable<int> value);
        partial void OnLNENCOChanging(ref global::System.Nullable<int> value);
        partial void OnLNENCOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            ENCO_HOL obj = new ENCO_HOL();
            obj.EncoCli = EncoCli;
            obj.Linha = Linha;
            obj.LinhaMatriz = LinhaMatriz;
            obj.TipoArtigo = TipoArtigo;
            obj.Modelo = Modelo;
            obj.DescAgente = DescAgente;
            obj.Descricao = Descricao;
            obj.NTam = NTam;
            obj.VTam = VTam;
            obj.CliDesp = CliDesp;
            obj.Unmed = Unmed;
            obj.Quant1 = Quant1;
            obj.Quant2 = Quant2;
            obj.Preco = Preco;
            obj.Prazo = Prazo;
            obj.PrazoEnt = PrazoEnt;
            obj.DataEncoCli = DataEncoCli;
            obj.DataEnco = DataEnco;
            obj.DataPlano = DataPlano;
            obj.Marca = Marca;
            obj.Coleccao = Coleccao;
            obj.Estacao = Estacao;
            obj.Tema = Tema;
            obj.Desc1 = Desc1;
            obj.Desc2 = Desc2;
            obj.Desc3 = Desc3;
            obj.Desc4 = Desc4;
            obj.Desc5 = Desc5;
            obj.integrado = integrado;
            obj.NRENCO = NRENCO;
            obj.LNENCO = LNENCO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          ENCO_HOL toCompare = obj as ENCO_HOL;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.EncoCli, toCompare.EncoCli))
            return false;
          if (!Object.Equals(this.Linha, toCompare.Linha))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + EncoCli.GetHashCode();
          hashCode = (hashCode * 7) + Linha.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
