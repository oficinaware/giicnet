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
    /// There are no comments for DataGiic_LiagoModel.PLANO_DIA_HORAS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SECCAO
    /// DATADIA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="PLANO_DIA_HORAS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PLANO_DIA_HORAS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new PLANO_DIA_HORAS object.
        /// </summary>
        /// <param name="sECCAO">Initial value of SECCAO.</param>
        /// <param name="dATADIA">Initial value of DATADIA.</param>
        public static PLANO_DIA_HORAS CreatePLANO_DIA_HORAS(string sECCAO, global::System.DateTime dATADIA)
        {
            PLANO_DIA_HORAS pLANO_DIA_HORAS = new PLANO_DIA_HORAS();
            pLANO_DIA_HORAS.SECCAO = sECCAO;
            pLANO_DIA_HORAS.DATADIA = dATADIA;
            return pLANO_DIA_HORAS;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for SECCAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string SECCAO
        {
            get
            {
                string value = _SECCAO;
                OnGetSECCAO(ref value);
                return value;
            }
            set
            {
                if (_SECCAO != value)
                {
                  OnSECCAOChanging(ref value);
                  ReportPropertyChanging("SECCAO");
                  _SECCAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("SECCAO");
                  OnSECCAOChanged();
              }
            }
        }
        private string _SECCAO;
        partial void OnGetSECCAO(ref string value);
        partial void OnSECCAOChanging(ref string value);
        partial void OnSECCAOChanged();
    
        /// <summary>
        /// There are no comments for DATADIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.DateTime DATADIA
        {
            get
            {
                global::System.DateTime value = _DATADIA;
                OnGetDATADIA(ref value);
                return value;
            }
            set
            {
                if (_DATADIA != value)
                {
                  OnDATADIAChanging(ref value);
                  ReportPropertyChanging("DATADIA");
                  _DATADIA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATADIA");
                  OnDATADIAChanged();
              }
            }
        }
        private global::System.DateTime _DATADIA;
        partial void OnGetDATADIA(ref global::System.DateTime value);
        partial void OnDATADIAChanging(ref global::System.DateTime value);
        partial void OnDATADIAChanged();
    
        /// <summary>
        /// There are no comments for COD_HORARIO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string COD_HORARIO
        {
            get
            {
                string value = _COD_HORARIO;
                OnGetCOD_HORARIO(ref value);
                return value;
            }
            set
            {
                if (_COD_HORARIO != value)
                {
                  OnCOD_HORARIOChanging(ref value);
                  ReportPropertyChanging("COD_HORARIO");
                  _COD_HORARIO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COD_HORARIO");
                  OnCOD_HORARIOChanged();
              }
            }
        }
        private string _COD_HORARIO;
        partial void OnGetCOD_HORARIO(ref string value);
        partial void OnCOD_HORARIOChanging(ref string value);
        partial void OnCOD_HORARIOChanged();
    
        /// <summary>
        /// There are no comments for I01 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> I01
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _I01;
                OnGetI01(ref value);
                return value;
            }
            set
            {
                if (_I01 != value)
                {
                  OnI01Changing(ref value);
                  ReportPropertyChanging("I01");
                  _I01 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("I01");
                  OnI01Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _I01;
        partial void OnGetI01(ref global::System.Nullable<System.DateTime> value);
        partial void OnI01Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnI01Changed();
    
        /// <summary>
        /// There are no comments for F01 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> F01
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _F01;
                OnGetF01(ref value);
                return value;
            }
            set
            {
                if (_F01 != value)
                {
                  OnF01Changing(ref value);
                  ReportPropertyChanging("F01");
                  _F01 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("F01");
                  OnF01Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _F01;
        partial void OnGetF01(ref global::System.Nullable<System.DateTime> value);
        partial void OnF01Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnF01Changed();
    
        /// <summary>
        /// There are no comments for I02 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> I02
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _I02;
                OnGetI02(ref value);
                return value;
            }
            set
            {
                if (_I02 != value)
                {
                  OnI02Changing(ref value);
                  ReportPropertyChanging("I02");
                  _I02 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("I02");
                  OnI02Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _I02;
        partial void OnGetI02(ref global::System.Nullable<System.DateTime> value);
        partial void OnI02Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnI02Changed();
    
        /// <summary>
        /// There are no comments for F02 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> F02
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _F02;
                OnGetF02(ref value);
                return value;
            }
            set
            {
                if (_F02 != value)
                {
                  OnF02Changing(ref value);
                  ReportPropertyChanging("F02");
                  _F02 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("F02");
                  OnF02Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _F02;
        partial void OnGetF02(ref global::System.Nullable<System.DateTime> value);
        partial void OnF02Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnF02Changed();
    
        /// <summary>
        /// There are no comments for I03 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> I03
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _I03;
                OnGetI03(ref value);
                return value;
            }
            set
            {
                if (_I03 != value)
                {
                  OnI03Changing(ref value);
                  ReportPropertyChanging("I03");
                  _I03 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("I03");
                  OnI03Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _I03;
        partial void OnGetI03(ref global::System.Nullable<System.DateTime> value);
        partial void OnI03Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnI03Changed();
    
        /// <summary>
        /// There are no comments for F03 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> F03
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _F03;
                OnGetF03(ref value);
                return value;
            }
            set
            {
                if (_F03 != value)
                {
                  OnF03Changing(ref value);
                  ReportPropertyChanging("F03");
                  _F03 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("F03");
                  OnF03Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _F03;
        partial void OnGetF03(ref global::System.Nullable<System.DateTime> value);
        partial void OnF03Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnF03Changed();
    
        /// <summary>
        /// There are no comments for I04 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> I04
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _I04;
                OnGetI04(ref value);
                return value;
            }
            set
            {
                if (_I04 != value)
                {
                  OnI04Changing(ref value);
                  ReportPropertyChanging("I04");
                  _I04 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("I04");
                  OnI04Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _I04;
        partial void OnGetI04(ref global::System.Nullable<System.DateTime> value);
        partial void OnI04Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnI04Changed();
    
        /// <summary>
        /// There are no comments for F04 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> F04
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _F04;
                OnGetF04(ref value);
                return value;
            }
            set
            {
                if (_F04 != value)
                {
                  OnF04Changing(ref value);
                  ReportPropertyChanging("F04");
                  _F04 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("F04");
                  OnF04Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _F04;
        partial void OnGetF04(ref global::System.Nullable<System.DateTime> value);
        partial void OnF04Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnF04Changed();
    
        /// <summary>
        /// There are no comments for I05 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> I05
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _I05;
                OnGetI05(ref value);
                return value;
            }
            set
            {
                if (_I05 != value)
                {
                  OnI05Changing(ref value);
                  ReportPropertyChanging("I05");
                  _I05 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("I05");
                  OnI05Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _I05;
        partial void OnGetI05(ref global::System.Nullable<System.DateTime> value);
        partial void OnI05Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnI05Changed();
    
        /// <summary>
        /// There are no comments for F05 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> F05
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _F05;
                OnGetF05(ref value);
                return value;
            }
            set
            {
                if (_F05 != value)
                {
                  OnF05Changing(ref value);
                  ReportPropertyChanging("F05");
                  _F05 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("F05");
                  OnF05Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _F05;
        partial void OnGetF05(ref global::System.Nullable<System.DateTime> value);
        partial void OnF05Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnF05Changed();
    
        /// <summary>
        /// There are no comments for I06 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> I06
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _I06;
                OnGetI06(ref value);
                return value;
            }
            set
            {
                if (_I06 != value)
                {
                  OnI06Changing(ref value);
                  ReportPropertyChanging("I06");
                  _I06 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("I06");
                  OnI06Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _I06;
        partial void OnGetI06(ref global::System.Nullable<System.DateTime> value);
        partial void OnI06Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnI06Changed();
    
        /// <summary>
        /// There are no comments for F06 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> F06
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _F06;
                OnGetF06(ref value);
                return value;
            }
            set
            {
                if (_F06 != value)
                {
                  OnF06Changing(ref value);
                  ReportPropertyChanging("F06");
                  _F06 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("F06");
                  OnF06Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _F06;
        partial void OnGetF06(ref global::System.Nullable<System.DateTime> value);
        partial void OnF06Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnF06Changed();
    
        /// <summary>
        /// There are no comments for I07 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> I07
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _I07;
                OnGetI07(ref value);
                return value;
            }
            set
            {
                if (_I07 != value)
                {
                  OnI07Changing(ref value);
                  ReportPropertyChanging("I07");
                  _I07 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("I07");
                  OnI07Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _I07;
        partial void OnGetI07(ref global::System.Nullable<System.DateTime> value);
        partial void OnI07Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnI07Changed();
    
        /// <summary>
        /// There are no comments for F07 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> F07
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _F07;
                OnGetF07(ref value);
                return value;
            }
            set
            {
                if (_F07 != value)
                {
                  OnF07Changing(ref value);
                  ReportPropertyChanging("F07");
                  _F07 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("F07");
                  OnF07Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _F07;
        partial void OnGetF07(ref global::System.Nullable<System.DateTime> value);
        partial void OnF07Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnF07Changed();
    
        /// <summary>
        /// There are no comments for I08 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> I08
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _I08;
                OnGetI08(ref value);
                return value;
            }
            set
            {
                if (_I08 != value)
                {
                  OnI08Changing(ref value);
                  ReportPropertyChanging("I08");
                  _I08 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("I08");
                  OnI08Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _I08;
        partial void OnGetI08(ref global::System.Nullable<System.DateTime> value);
        partial void OnI08Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnI08Changed();
    
        /// <summary>
        /// There are no comments for F08 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> F08
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _F08;
                OnGetF08(ref value);
                return value;
            }
            set
            {
                if (_F08 != value)
                {
                  OnF08Changing(ref value);
                  ReportPropertyChanging("F08");
                  _F08 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("F08");
                  OnF08Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _F08;
        partial void OnGetF08(ref global::System.Nullable<System.DateTime> value);
        partial void OnF08Changing(ref global::System.Nullable<System.DateTime> value);
        partial void OnF08Changed();
    
        /// <summary>
        /// There are no comments for TOTMIN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TOTMIN
        {
            get
            {
                global::System.Nullable<int> value = _TOTMIN;
                OnGetTOTMIN(ref value);
                return value;
            }
            set
            {
                if (_TOTMIN != value)
                {
                  OnTOTMINChanging(ref value);
                  ReportPropertyChanging("TOTMIN");
                  _TOTMIN = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTMIN");
                  OnTOTMINChanged();
              }
            }
        }
        private global::System.Nullable<int> _TOTMIN;
        partial void OnGetTOTMIN(ref global::System.Nullable<int> value);
        partial void OnTOTMINChanging(ref global::System.Nullable<int> value);
        partial void OnTOTMINChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            PLANO_DIA_HORAS obj = new PLANO_DIA_HORAS();
            obj.SECCAO = SECCAO;
            obj.DATADIA = DATADIA;
            obj.COD_HORARIO = COD_HORARIO;
            obj.I01 = I01;
            obj.F01 = F01;
            obj.I02 = I02;
            obj.F02 = F02;
            obj.I03 = I03;
            obj.F03 = F03;
            obj.I04 = I04;
            obj.F04 = F04;
            obj.I05 = I05;
            obj.F05 = F05;
            obj.I06 = I06;
            obj.F06 = F06;
            obj.I07 = I07;
            obj.F07 = F07;
            obj.I08 = I08;
            obj.F08 = F08;
            obj.TOTMIN = TOTMIN;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          PLANO_DIA_HORAS toCompare = obj as PLANO_DIA_HORAS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.SECCAO, toCompare.SECCAO))
            return false;
          if (!Object.Equals(this.DATADIA, toCompare.DATADIA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + SECCAO.GetHashCode();
          hashCode = (hashCode * 7) + DATADIA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
