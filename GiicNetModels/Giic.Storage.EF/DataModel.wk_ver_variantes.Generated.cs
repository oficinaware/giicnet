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
    /// There are no comments for DataGiic_LiagoModel.wk_ver_variantes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// spid
    /// modelo
    /// variante
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wk_ver_variantes")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wk_ver_variantes : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wk_ver_variantes object.
        /// </summary>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="modelo">Initial value of modelo.</param>
        /// <param name="variante">Initial value of variante.</param>
        public static wk_ver_variantes Createwk_ver_variantes(int spid, string modelo, string variante)
        {
            wk_ver_variantes wk_ver_variantes = new wk_ver_variantes();
            wk_ver_variantes.spid = spid;
            wk_ver_variantes.modelo = modelo;
            wk_ver_variantes.variante = variante;
            return wk_ver_variantes;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for spid in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int spid
        {
            get
            {
                int value = _spid;
                OnGetspid(ref value);
                return value;
            }
            set
            {
                if (_spid != value)
                {
                  OnspidChanging(ref value);
                  ReportPropertyChanging("spid");
                  _spid = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("spid");
                  OnspidChanged();
              }
            }
        }
        private int _spid;
        partial void OnGetspid(ref int value);
        partial void OnspidChanging(ref int value);
        partial void OnspidChanged();
    
        /// <summary>
        /// There are no comments for modelo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string modelo
        {
            get
            {
                string value = _modelo;
                OnGetmodelo(ref value);
                return value;
            }
            set
            {
                if (_modelo != value)
                {
                  OnmodeloChanging(ref value);
                  ReportPropertyChanging("modelo");
                  _modelo = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("modelo");
                  OnmodeloChanged();
              }
            }
        }
        private string _modelo;
        partial void OnGetmodelo(ref string value);
        partial void OnmodeloChanging(ref string value);
        partial void OnmodeloChanged();
    
        /// <summary>
        /// There are no comments for variante in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string variante
        {
            get
            {
                string value = _variante;
                OnGetvariante(ref value);
                return value;
            }
            set
            {
                if (_variante != value)
                {
                  OnvarianteChanging(ref value);
                  ReportPropertyChanging("variante");
                  _variante = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("variante");
                  OnvarianteChanged();
              }
            }
        }
        private string _variante;
        partial void OnGetvariante(ref string value);
        partial void OnvarianteChanging(ref string value);
        partial void OnvarianteChanged();
    
        /// <summary>
        /// There are no comments for componente01 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente01
        {
            get
            {
                string value = _componente01;
                OnGetcomponente01(ref value);
                return value;
            }
            set
            {
                if (_componente01 != value)
                {
                  Oncomponente01Changing(ref value);
                  ReportPropertyChanging("componente01");
                  _componente01 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente01");
                  Oncomponente01Changed();
              }
            }
        }
        private string _componente01;
        partial void OnGetcomponente01(ref string value);
        partial void Oncomponente01Changing(ref string value);
        partial void Oncomponente01Changed();
    
        /// <summary>
        /// There are no comments for cartaz01 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz01
        {
            get
            {
                string value = _cartaz01;
                OnGetcartaz01(ref value);
                return value;
            }
            set
            {
                if (_cartaz01 != value)
                {
                  Oncartaz01Changing(ref value);
                  ReportPropertyChanging("cartaz01");
                  _cartaz01 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz01");
                  Oncartaz01Changed();
              }
            }
        }
        private string _cartaz01 = @"space(5)";
        partial void OnGetcartaz01(ref string value);
        partial void Oncartaz01Changing(ref string value);
        partial void Oncartaz01Changed();
    
        /// <summary>
        /// There are no comments for codcor01 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor01
        {
            get
            {
                string value = _codcor01;
                OnGetcodcor01(ref value);
                return value;
            }
            set
            {
                if (_codcor01 != value)
                {
                  Oncodcor01Changing(ref value);
                  ReportPropertyChanging("codcor01");
                  _codcor01 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor01");
                  Oncodcor01Changed();
              }
            }
        }
        private string _codcor01 = @"space(3)";
        partial void OnGetcodcor01(ref string value);
        partial void Oncodcor01Changing(ref string value);
        partial void Oncodcor01Changed();
    
        /// <summary>
        /// There are no comments for componente02 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente02
        {
            get
            {
                string value = _componente02;
                OnGetcomponente02(ref value);
                return value;
            }
            set
            {
                if (_componente02 != value)
                {
                  Oncomponente02Changing(ref value);
                  ReportPropertyChanging("componente02");
                  _componente02 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente02");
                  Oncomponente02Changed();
              }
            }
        }
        private string _componente02;
        partial void OnGetcomponente02(ref string value);
        partial void Oncomponente02Changing(ref string value);
        partial void Oncomponente02Changed();
    
        /// <summary>
        /// There are no comments for cartaz02 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz02
        {
            get
            {
                string value = _cartaz02;
                OnGetcartaz02(ref value);
                return value;
            }
            set
            {
                if (_cartaz02 != value)
                {
                  Oncartaz02Changing(ref value);
                  ReportPropertyChanging("cartaz02");
                  _cartaz02 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz02");
                  Oncartaz02Changed();
              }
            }
        }
        private string _cartaz02 = @"space(5)";
        partial void OnGetcartaz02(ref string value);
        partial void Oncartaz02Changing(ref string value);
        partial void Oncartaz02Changed();
    
        /// <summary>
        /// There are no comments for codcor02 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor02
        {
            get
            {
                string value = _codcor02;
                OnGetcodcor02(ref value);
                return value;
            }
            set
            {
                if (_codcor02 != value)
                {
                  Oncodcor02Changing(ref value);
                  ReportPropertyChanging("codcor02");
                  _codcor02 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor02");
                  Oncodcor02Changed();
              }
            }
        }
        private string _codcor02 = @"space(3)";
        partial void OnGetcodcor02(ref string value);
        partial void Oncodcor02Changing(ref string value);
        partial void Oncodcor02Changed();
    
        /// <summary>
        /// There are no comments for componente03 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente03
        {
            get
            {
                string value = _componente03;
                OnGetcomponente03(ref value);
                return value;
            }
            set
            {
                if (_componente03 != value)
                {
                  Oncomponente03Changing(ref value);
                  ReportPropertyChanging("componente03");
                  _componente03 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente03");
                  Oncomponente03Changed();
              }
            }
        }
        private string _componente03;
        partial void OnGetcomponente03(ref string value);
        partial void Oncomponente03Changing(ref string value);
        partial void Oncomponente03Changed();
    
        /// <summary>
        /// There are no comments for cartaz03 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz03
        {
            get
            {
                string value = _cartaz03;
                OnGetcartaz03(ref value);
                return value;
            }
            set
            {
                if (_cartaz03 != value)
                {
                  Oncartaz03Changing(ref value);
                  ReportPropertyChanging("cartaz03");
                  _cartaz03 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz03");
                  Oncartaz03Changed();
              }
            }
        }
        private string _cartaz03 = @"space(5)";
        partial void OnGetcartaz03(ref string value);
        partial void Oncartaz03Changing(ref string value);
        partial void Oncartaz03Changed();
    
        /// <summary>
        /// There are no comments for codcor03 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor03
        {
            get
            {
                string value = _codcor03;
                OnGetcodcor03(ref value);
                return value;
            }
            set
            {
                if (_codcor03 != value)
                {
                  Oncodcor03Changing(ref value);
                  ReportPropertyChanging("codcor03");
                  _codcor03 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor03");
                  Oncodcor03Changed();
              }
            }
        }
        private string _codcor03 = @"space(3)";
        partial void OnGetcodcor03(ref string value);
        partial void Oncodcor03Changing(ref string value);
        partial void Oncodcor03Changed();
    
        /// <summary>
        /// There are no comments for componente04 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente04
        {
            get
            {
                string value = _componente04;
                OnGetcomponente04(ref value);
                return value;
            }
            set
            {
                if (_componente04 != value)
                {
                  Oncomponente04Changing(ref value);
                  ReportPropertyChanging("componente04");
                  _componente04 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente04");
                  Oncomponente04Changed();
              }
            }
        }
        private string _componente04;
        partial void OnGetcomponente04(ref string value);
        partial void Oncomponente04Changing(ref string value);
        partial void Oncomponente04Changed();
    
        /// <summary>
        /// There are no comments for cartaz04 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz04
        {
            get
            {
                string value = _cartaz04;
                OnGetcartaz04(ref value);
                return value;
            }
            set
            {
                if (_cartaz04 != value)
                {
                  Oncartaz04Changing(ref value);
                  ReportPropertyChanging("cartaz04");
                  _cartaz04 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz04");
                  Oncartaz04Changed();
              }
            }
        }
        private string _cartaz04 = @"space(5)";
        partial void OnGetcartaz04(ref string value);
        partial void Oncartaz04Changing(ref string value);
        partial void Oncartaz04Changed();
    
        /// <summary>
        /// There are no comments for codcor04 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor04
        {
            get
            {
                string value = _codcor04;
                OnGetcodcor04(ref value);
                return value;
            }
            set
            {
                if (_codcor04 != value)
                {
                  Oncodcor04Changing(ref value);
                  ReportPropertyChanging("codcor04");
                  _codcor04 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor04");
                  Oncodcor04Changed();
              }
            }
        }
        private string _codcor04 = @"space(3)";
        partial void OnGetcodcor04(ref string value);
        partial void Oncodcor04Changing(ref string value);
        partial void Oncodcor04Changed();
    
        /// <summary>
        /// There are no comments for componente05 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente05
        {
            get
            {
                string value = _componente05;
                OnGetcomponente05(ref value);
                return value;
            }
            set
            {
                if (_componente05 != value)
                {
                  Oncomponente05Changing(ref value);
                  ReportPropertyChanging("componente05");
                  _componente05 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente05");
                  Oncomponente05Changed();
              }
            }
        }
        private string _componente05;
        partial void OnGetcomponente05(ref string value);
        partial void Oncomponente05Changing(ref string value);
        partial void Oncomponente05Changed();
    
        /// <summary>
        /// There are no comments for cartaz05 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz05
        {
            get
            {
                string value = _cartaz05;
                OnGetcartaz05(ref value);
                return value;
            }
            set
            {
                if (_cartaz05 != value)
                {
                  Oncartaz05Changing(ref value);
                  ReportPropertyChanging("cartaz05");
                  _cartaz05 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz05");
                  Oncartaz05Changed();
              }
            }
        }
        private string _cartaz05 = @"space(5)";
        partial void OnGetcartaz05(ref string value);
        partial void Oncartaz05Changing(ref string value);
        partial void Oncartaz05Changed();
    
        /// <summary>
        /// There are no comments for codcor05 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor05
        {
            get
            {
                string value = _codcor05;
                OnGetcodcor05(ref value);
                return value;
            }
            set
            {
                if (_codcor05 != value)
                {
                  Oncodcor05Changing(ref value);
                  ReportPropertyChanging("codcor05");
                  _codcor05 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor05");
                  Oncodcor05Changed();
              }
            }
        }
        private string _codcor05 = @"space(3)";
        partial void OnGetcodcor05(ref string value);
        partial void Oncodcor05Changing(ref string value);
        partial void Oncodcor05Changed();
    
        /// <summary>
        /// There are no comments for componente06 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente06
        {
            get
            {
                string value = _componente06;
                OnGetcomponente06(ref value);
                return value;
            }
            set
            {
                if (_componente06 != value)
                {
                  Oncomponente06Changing(ref value);
                  ReportPropertyChanging("componente06");
                  _componente06 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente06");
                  Oncomponente06Changed();
              }
            }
        }
        private string _componente06;
        partial void OnGetcomponente06(ref string value);
        partial void Oncomponente06Changing(ref string value);
        partial void Oncomponente06Changed();
    
        /// <summary>
        /// There are no comments for cartaz06 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz06
        {
            get
            {
                string value = _cartaz06;
                OnGetcartaz06(ref value);
                return value;
            }
            set
            {
                if (_cartaz06 != value)
                {
                  Oncartaz06Changing(ref value);
                  ReportPropertyChanging("cartaz06");
                  _cartaz06 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz06");
                  Oncartaz06Changed();
              }
            }
        }
        private string _cartaz06 = @"space(5)";
        partial void OnGetcartaz06(ref string value);
        partial void Oncartaz06Changing(ref string value);
        partial void Oncartaz06Changed();
    
        /// <summary>
        /// There are no comments for codcor06 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor06
        {
            get
            {
                string value = _codcor06;
                OnGetcodcor06(ref value);
                return value;
            }
            set
            {
                if (_codcor06 != value)
                {
                  Oncodcor06Changing(ref value);
                  ReportPropertyChanging("codcor06");
                  _codcor06 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor06");
                  Oncodcor06Changed();
              }
            }
        }
        private string _codcor06 = @"space(3)";
        partial void OnGetcodcor06(ref string value);
        partial void Oncodcor06Changing(ref string value);
        partial void Oncodcor06Changed();
    
        /// <summary>
        /// There are no comments for componente07 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente07
        {
            get
            {
                string value = _componente07;
                OnGetcomponente07(ref value);
                return value;
            }
            set
            {
                if (_componente07 != value)
                {
                  Oncomponente07Changing(ref value);
                  ReportPropertyChanging("componente07");
                  _componente07 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente07");
                  Oncomponente07Changed();
              }
            }
        }
        private string _componente07;
        partial void OnGetcomponente07(ref string value);
        partial void Oncomponente07Changing(ref string value);
        partial void Oncomponente07Changed();
    
        /// <summary>
        /// There are no comments for cartaz07 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz07
        {
            get
            {
                string value = _cartaz07;
                OnGetcartaz07(ref value);
                return value;
            }
            set
            {
                if (_cartaz07 != value)
                {
                  Oncartaz07Changing(ref value);
                  ReportPropertyChanging("cartaz07");
                  _cartaz07 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz07");
                  Oncartaz07Changed();
              }
            }
        }
        private string _cartaz07 = @"space(5)";
        partial void OnGetcartaz07(ref string value);
        partial void Oncartaz07Changing(ref string value);
        partial void Oncartaz07Changed();
    
        /// <summary>
        /// There are no comments for codcor07 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor07
        {
            get
            {
                string value = _codcor07;
                OnGetcodcor07(ref value);
                return value;
            }
            set
            {
                if (_codcor07 != value)
                {
                  Oncodcor07Changing(ref value);
                  ReportPropertyChanging("codcor07");
                  _codcor07 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor07");
                  Oncodcor07Changed();
              }
            }
        }
        private string _codcor07 = @"space(3)";
        partial void OnGetcodcor07(ref string value);
        partial void Oncodcor07Changing(ref string value);
        partial void Oncodcor07Changed();
    
        /// <summary>
        /// There are no comments for componente08 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente08
        {
            get
            {
                string value = _componente08;
                OnGetcomponente08(ref value);
                return value;
            }
            set
            {
                if (_componente08 != value)
                {
                  Oncomponente08Changing(ref value);
                  ReportPropertyChanging("componente08");
                  _componente08 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente08");
                  Oncomponente08Changed();
              }
            }
        }
        private string _componente08;
        partial void OnGetcomponente08(ref string value);
        partial void Oncomponente08Changing(ref string value);
        partial void Oncomponente08Changed();
    
        /// <summary>
        /// There are no comments for cartaz08 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz08
        {
            get
            {
                string value = _cartaz08;
                OnGetcartaz08(ref value);
                return value;
            }
            set
            {
                if (_cartaz08 != value)
                {
                  Oncartaz08Changing(ref value);
                  ReportPropertyChanging("cartaz08");
                  _cartaz08 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz08");
                  Oncartaz08Changed();
              }
            }
        }
        private string _cartaz08 = @"space(5)";
        partial void OnGetcartaz08(ref string value);
        partial void Oncartaz08Changing(ref string value);
        partial void Oncartaz08Changed();
    
        /// <summary>
        /// There are no comments for codcor08 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor08
        {
            get
            {
                string value = _codcor08;
                OnGetcodcor08(ref value);
                return value;
            }
            set
            {
                if (_codcor08 != value)
                {
                  Oncodcor08Changing(ref value);
                  ReportPropertyChanging("codcor08");
                  _codcor08 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor08");
                  Oncodcor08Changed();
              }
            }
        }
        private string _codcor08 = @"space(3)";
        partial void OnGetcodcor08(ref string value);
        partial void Oncodcor08Changing(ref string value);
        partial void Oncodcor08Changed();
    
        /// <summary>
        /// There are no comments for componente09 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente09
        {
            get
            {
                string value = _componente09;
                OnGetcomponente09(ref value);
                return value;
            }
            set
            {
                if (_componente09 != value)
                {
                  Oncomponente09Changing(ref value);
                  ReportPropertyChanging("componente09");
                  _componente09 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente09");
                  Oncomponente09Changed();
              }
            }
        }
        private string _componente09;
        partial void OnGetcomponente09(ref string value);
        partial void Oncomponente09Changing(ref string value);
        partial void Oncomponente09Changed();
    
        /// <summary>
        /// There are no comments for cartaz09 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz09
        {
            get
            {
                string value = _cartaz09;
                OnGetcartaz09(ref value);
                return value;
            }
            set
            {
                if (_cartaz09 != value)
                {
                  Oncartaz09Changing(ref value);
                  ReportPropertyChanging("cartaz09");
                  _cartaz09 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz09");
                  Oncartaz09Changed();
              }
            }
        }
        private string _cartaz09 = @"space(5)";
        partial void OnGetcartaz09(ref string value);
        partial void Oncartaz09Changing(ref string value);
        partial void Oncartaz09Changed();
    
        /// <summary>
        /// There are no comments for codcor09 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor09
        {
            get
            {
                string value = _codcor09;
                OnGetcodcor09(ref value);
                return value;
            }
            set
            {
                if (_codcor09 != value)
                {
                  Oncodcor09Changing(ref value);
                  ReportPropertyChanging("codcor09");
                  _codcor09 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor09");
                  Oncodcor09Changed();
              }
            }
        }
        private string _codcor09 = @"space(3)";
        partial void OnGetcodcor09(ref string value);
        partial void Oncodcor09Changing(ref string value);
        partial void Oncodcor09Changed();
    
        /// <summary>
        /// There are no comments for componente10 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string componente10
        {
            get
            {
                string value = _componente10;
                OnGetcomponente10(ref value);
                return value;
            }
            set
            {
                if (_componente10 != value)
                {
                  Oncomponente10Changing(ref value);
                  ReportPropertyChanging("componente10");
                  _componente10 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("componente10");
                  Oncomponente10Changed();
              }
            }
        }
        private string _componente10;
        partial void OnGetcomponente10(ref string value);
        partial void Oncomponente10Changing(ref string value);
        partial void Oncomponente10Changed();
    
        /// <summary>
        /// There are no comments for cartaz10 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string cartaz10
        {
            get
            {
                string value = _cartaz10;
                OnGetcartaz10(ref value);
                return value;
            }
            set
            {
                if (_cartaz10 != value)
                {
                  Oncartaz10Changing(ref value);
                  ReportPropertyChanging("cartaz10");
                  _cartaz10 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("cartaz10");
                  Oncartaz10Changed();
              }
            }
        }
        private string _cartaz10 = @"space(5)";
        partial void OnGetcartaz10(ref string value);
        partial void Oncartaz10Changing(ref string value);
        partial void Oncartaz10Changed();
    
        /// <summary>
        /// There are no comments for codcor10 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string codcor10
        {
            get
            {
                string value = _codcor10;
                OnGetcodcor10(ref value);
                return value;
            }
            set
            {
                if (_codcor10 != value)
                {
                  Oncodcor10Changing(ref value);
                  ReportPropertyChanging("codcor10");
                  _codcor10 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("codcor10");
                  Oncodcor10Changed();
              }
            }
        }
        private string _codcor10 = @"space(3)";
        partial void OnGetcodcor10(ref string value);
        partial void Oncodcor10Changing(ref string value);
        partial void Oncodcor10Changed();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wk_ver_variantes obj = new wk_ver_variantes();
            obj.spid = spid;
            obj.modelo = modelo;
            obj.variante = variante;
            obj.componente01 = componente01;
            obj.cartaz01 = cartaz01;
            obj.codcor01 = codcor01;
            obj.componente02 = componente02;
            obj.cartaz02 = cartaz02;
            obj.codcor02 = codcor02;
            obj.componente03 = componente03;
            obj.cartaz03 = cartaz03;
            obj.codcor03 = codcor03;
            obj.componente04 = componente04;
            obj.cartaz04 = cartaz04;
            obj.codcor04 = codcor04;
            obj.componente05 = componente05;
            obj.cartaz05 = cartaz05;
            obj.codcor05 = codcor05;
            obj.componente06 = componente06;
            obj.cartaz06 = cartaz06;
            obj.codcor06 = codcor06;
            obj.componente07 = componente07;
            obj.cartaz07 = cartaz07;
            obj.codcor07 = codcor07;
            obj.componente08 = componente08;
            obj.cartaz08 = cartaz08;
            obj.codcor08 = codcor08;
            obj.componente09 = componente09;
            obj.cartaz09 = cartaz09;
            obj.codcor09 = codcor09;
            obj.componente10 = componente10;
            obj.cartaz10 = cartaz10;
            obj.codcor10 = codcor10;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wk_ver_variantes toCompare = obj as wk_ver_variantes;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.spid, toCompare.spid))
            return false;
          if (!Object.Equals(this.modelo, toCompare.modelo))
            return false;
          if (!Object.Equals(this.variante, toCompare.variante))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + spid.GetHashCode();
          hashCode = (hashCode * 7) + modelo.GetHashCode();
          hashCode = (hashCode * 7) + variante.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
