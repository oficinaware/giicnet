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
    /// There are no comments for DataGiic_LiagoModel.HORAS_PROD in the schema.
    /// </summary>
    /// <KeyProperties>
    /// seccao
    /// codemp
    /// datadia
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="HORAS_PROD")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class HORAS_PROD : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new HORAS_PROD object.
        /// </summary>
        /// <param name="seccao">Initial value of seccao.</param>
        /// <param name="codemp">Initial value of codemp.</param>
        /// <param name="datadia">Initial value of datadia.</param>
        public static HORAS_PROD CreateHORAS_PROD(string seccao, string codemp, global::System.DateTime datadia)
        {
            HORAS_PROD hORAS_PROD = new HORAS_PROD();
            hORAS_PROD.seccao = seccao;
            hORAS_PROD.codemp = codemp;
            hORAS_PROD.datadia = datadia;
            return hORAS_PROD;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for seccao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string seccao
        {
            get
            {
                string value = _seccao;
                OnGetseccao(ref value);
                return value;
            }
            set
            {
                if (_seccao != value)
                {
                  OnseccaoChanging(ref value);
                  ReportPropertyChanging("seccao");
                  _seccao = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("seccao");
                  OnseccaoChanged();
              }
            }
        }
        private string _seccao;
        partial void OnGetseccao(ref string value);
        partial void OnseccaoChanging(ref string value);
        partial void OnseccaoChanged();
    
        /// <summary>
        /// There are no comments for codemp in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string codemp
        {
            get
            {
                string value = _codemp;
                OnGetcodemp(ref value);
                return value;
            }
            set
            {
                if (_codemp != value)
                {
                  OncodempChanging(ref value);
                  ReportPropertyChanging("codemp");
                  _codemp = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("codemp");
                  OncodempChanged();
              }
            }
        }
        private string _codemp;
        partial void OnGetcodemp(ref string value);
        partial void OncodempChanging(ref string value);
        partial void OncodempChanged();
    
        /// <summary>
        /// There are no comments for datadia in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.DateTime datadia
        {
            get
            {
                global::System.DateTime value = _datadia;
                OnGetdatadia(ref value);
                return value;
            }
            set
            {
                if (_datadia != value)
                {
                  OndatadiaChanging(ref value);
                  ReportPropertyChanging("datadia");
                  _datadia = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("datadia");
                  OndatadiaChanged();
              }
            }
        }
        private global::System.DateTime _datadia;
        partial void OnGetdatadia(ref global::System.DateTime value);
        partial void OndatadiaChanging(ref global::System.DateTime value);
        partial void OndatadiaChanged();
    
        /// <summary>
        /// There are no comments for NOMEEMP in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string NOMEEMP
        {
            get
            {
                string value = _NOMEEMP;
                OnGetNOMEEMP(ref value);
                return value;
            }
            set
            {
                if (_NOMEEMP != value)
                {
                  OnNOMEEMPChanging(ref value);
                  ReportPropertyChanging("NOMEEMP");
                  _NOMEEMP = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NOMEEMP");
                  OnNOMEEMPChanged();
              }
            }
        }
        private string _NOMEEMP;
        partial void OnGetNOMEEMP(ref string value);
        partial void OnNOMEEMPChanging(ref string value);
        partial void OnNOMEEMPChanged();
    
        /// <summary>
        /// There are no comments for horas_horario in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string horas_horario
        {
            get
            {
                string value = _horas_horario;
                OnGethoras_horario(ref value);
                return value;
            }
            set
            {
                if (_horas_horario != value)
                {
                  Onhoras_horarioChanging(ref value);
                  ReportPropertyChanging("horas_horario");
                  _horas_horario = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("horas_horario");
                  Onhoras_horarioChanged();
              }
            }
        }
        private string _horas_horario;
        partial void OnGethoras_horario(ref string value);
        partial void Onhoras_horarioChanging(ref string value);
        partial void Onhoras_horarioChanged();
    
        /// <summary>
        /// There are no comments for horas_normal in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string horas_normal
        {
            get
            {
                string value = _horas_normal;
                OnGethoras_normal(ref value);
                return value;
            }
            set
            {
                if (_horas_normal != value)
                {
                  Onhoras_normalChanging(ref value);
                  ReportPropertyChanging("horas_normal");
                  _horas_normal = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("horas_normal");
                  Onhoras_normalChanged();
              }
            }
        }
        private string _horas_normal;
        partial void OnGethoras_normal(ref string value);
        partial void Onhoras_normalChanging(ref string value);
        partial void Onhoras_normalChanged();
    
        /// <summary>
        /// There are no comments for Horas_extra in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string Horas_extra
        {
            get
            {
                string value = _Horas_extra;
                OnGetHoras_extra(ref value);
                return value;
            }
            set
            {
                if (_Horas_extra != value)
                {
                  OnHoras_extraChanging(ref value);
                  ReportPropertyChanging("Horas_extra");
                  _Horas_extra = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Horas_extra");
                  OnHoras_extraChanged();
              }
            }
        }
        private string _Horas_extra;
        partial void OnGetHoras_extra(ref string value);
        partial void OnHoras_extraChanging(ref string value);
        partial void OnHoras_extraChanged();
    
        /// <summary>
        /// There are no comments for MIN_NORM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<float> MIN_NORM
        {
            get
            {
                global::System.Nullable<float> value = _MIN_NORM;
                OnGetMIN_NORM(ref value);
                return value;
            }
            set
            {
                if (_MIN_NORM != value)
                {
                  OnMIN_NORMChanging(ref value);
                  ReportPropertyChanging("MIN_NORM");
                  _MIN_NORM = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("MIN_NORM");
                  OnMIN_NORMChanged();
              }
            }
        }
        private global::System.Nullable<float> _MIN_NORM;
        partial void OnGetMIN_NORM(ref global::System.Nullable<float> value);
        partial void OnMIN_NORMChanging(ref global::System.Nullable<float> value);
        partial void OnMIN_NORMChanged();
    
        /// <summary>
        /// There are no comments for MIN_EXTRA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> MIN_EXTRA
        {
            get
            {
                global::System.Nullable<int> value = _MIN_EXTRA;
                OnGetMIN_EXTRA(ref value);
                return value;
            }
            set
            {
                if (_MIN_EXTRA != value)
                {
                  OnMIN_EXTRAChanging(ref value);
                  ReportPropertyChanging("MIN_EXTRA");
                  _MIN_EXTRA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("MIN_EXTRA");
                  OnMIN_EXTRAChanged();
              }
            }
        }
        private global::System.Nullable<int> _MIN_EXTRA;
        partial void OnGetMIN_EXTRA(ref global::System.Nullable<int> value);
        partial void OnMIN_EXTRAChanging(ref global::System.Nullable<int> value);
        partial void OnMIN_EXTRAChanged();
    
        /// <summary>
        /// There are no comments for TIPO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TIPO
        {
            get
            {
                global::System.Nullable<int> value = _TIPO;
                OnGetTIPO(ref value);
                return value;
            }
            set
            {
                if (_TIPO != value)
                {
                  OnTIPOChanging(ref value);
                  ReportPropertyChanging("TIPO");
                  _TIPO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TIPO");
                  OnTIPOChanged();
              }
            }
        }
        private global::System.Nullable<int> _TIPO = 1;
        partial void OnGetTIPO(ref global::System.Nullable<int> value);
        partial void OnTIPOChanging(ref global::System.Nullable<int> value);
        partial void OnTIPOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            HORAS_PROD obj = new HORAS_PROD();
            obj.seccao = seccao;
            obj.codemp = codemp;
            obj.datadia = datadia;
            obj.NOMEEMP = NOMEEMP;
            obj.horas_horario = horas_horario;
            obj.horas_normal = horas_normal;
            obj.Horas_extra = Horas_extra;
            obj.MIN_NORM = MIN_NORM;
            obj.MIN_EXTRA = MIN_EXTRA;
            obj.TIPO = TIPO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          HORAS_PROD toCompare = obj as HORAS_PROD;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.seccao, toCompare.seccao))
            return false;
          if (!Object.Equals(this.codemp, toCompare.codemp))
            return false;
          if (!Object.Equals(this.datadia, toCompare.datadia))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + seccao.GetHashCode();
          hashCode = (hashCode * 7) + codemp.GetHashCode();
          hashCode = (hashCode * 7) + datadia.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
