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
    /// There are no comments for DataGiic_LiagoModel.TAM_CORRESP in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TIPSORT
    /// COD_REGRA
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TAM_CORRESP")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TAM_CORRESP : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TAM_CORRESP object.
        /// </summary>
        /// <param name="tIPSORT">Initial value of TIPSORT.</param>
        /// <param name="cOD_REGRA">Initial value of COD_REGRA.</param>
        public static TAM_CORRESP CreateTAM_CORRESP(string tIPSORT, string cOD_REGRA)
        {
            TAM_CORRESP tAM_CORRESP = new TAM_CORRESP();
            tAM_CORRESP.TIPSORT = tIPSORT;
            tAM_CORRESP.COD_REGRA = cOD_REGRA;
            return tAM_CORRESP;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for TIPSORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TIPSORT
        {
            get
            {
                string value = _TIPSORT;
                OnGetTIPSORT(ref value);
                return value;
            }
            set
            {
                if (_TIPSORT != value)
                {
                  OnTIPSORTChanging(ref value);
                  ReportPropertyChanging("TIPSORT");
                  _TIPSORT = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TIPSORT");
                  OnTIPSORTChanged();
              }
            }
        }
        private string _TIPSORT;
        partial void OnGetTIPSORT(ref string value);
        partial void OnTIPSORTChanging(ref string value);
        partial void OnTIPSORTChanged();
    
        /// <summary>
        /// There are no comments for COD_REGRA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string COD_REGRA
        {
            get
            {
                string value = _COD_REGRA;
                OnGetCOD_REGRA(ref value);
                return value;
            }
            set
            {
                if (_COD_REGRA != value)
                {
                  OnCOD_REGRAChanging(ref value);
                  ReportPropertyChanging("COD_REGRA");
                  _COD_REGRA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("COD_REGRA");
                  OnCOD_REGRAChanged();
              }
            }
        }
        private string _COD_REGRA;
        partial void OnGetCOD_REGRA(ref string value);
        partial void OnCOD_REGRAChanging(ref string value);
        partial void OnCOD_REGRAChanged();
    
        /// <summary>
        /// There are no comments for VT01 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT01
        {
            get
            {
                string value = _VT01;
                OnGetVT01(ref value);
                return value;
            }
            set
            {
                if (_VT01 != value)
                {
                  OnVT01Changing(ref value);
                  ReportPropertyChanging("VT01");
                  _VT01 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT01");
                  OnVT01Changed();
              }
            }
        }
        private string _VT01;
        partial void OnGetVT01(ref string value);
        partial void OnVT01Changing(ref string value);
        partial void OnVT01Changed();
    
        /// <summary>
        /// There are no comments for VT02 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT02
        {
            get
            {
                string value = _VT02;
                OnGetVT02(ref value);
                return value;
            }
            set
            {
                if (_VT02 != value)
                {
                  OnVT02Changing(ref value);
                  ReportPropertyChanging("VT02");
                  _VT02 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT02");
                  OnVT02Changed();
              }
            }
        }
        private string _VT02;
        partial void OnGetVT02(ref string value);
        partial void OnVT02Changing(ref string value);
        partial void OnVT02Changed();
    
        /// <summary>
        /// There are no comments for VT03 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT03
        {
            get
            {
                string value = _VT03;
                OnGetVT03(ref value);
                return value;
            }
            set
            {
                if (_VT03 != value)
                {
                  OnVT03Changing(ref value);
                  ReportPropertyChanging("VT03");
                  _VT03 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT03");
                  OnVT03Changed();
              }
            }
        }
        private string _VT03;
        partial void OnGetVT03(ref string value);
        partial void OnVT03Changing(ref string value);
        partial void OnVT03Changed();
    
        /// <summary>
        /// There are no comments for VT04 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT04
        {
            get
            {
                string value = _VT04;
                OnGetVT04(ref value);
                return value;
            }
            set
            {
                if (_VT04 != value)
                {
                  OnVT04Changing(ref value);
                  ReportPropertyChanging("VT04");
                  _VT04 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT04");
                  OnVT04Changed();
              }
            }
        }
        private string _VT04;
        partial void OnGetVT04(ref string value);
        partial void OnVT04Changing(ref string value);
        partial void OnVT04Changed();
    
        /// <summary>
        /// There are no comments for VT05 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT05
        {
            get
            {
                string value = _VT05;
                OnGetVT05(ref value);
                return value;
            }
            set
            {
                if (_VT05 != value)
                {
                  OnVT05Changing(ref value);
                  ReportPropertyChanging("VT05");
                  _VT05 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT05");
                  OnVT05Changed();
              }
            }
        }
        private string _VT05;
        partial void OnGetVT05(ref string value);
        partial void OnVT05Changing(ref string value);
        partial void OnVT05Changed();
    
        /// <summary>
        /// There are no comments for VT06 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT06
        {
            get
            {
                string value = _VT06;
                OnGetVT06(ref value);
                return value;
            }
            set
            {
                if (_VT06 != value)
                {
                  OnVT06Changing(ref value);
                  ReportPropertyChanging("VT06");
                  _VT06 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT06");
                  OnVT06Changed();
              }
            }
        }
        private string _VT06;
        partial void OnGetVT06(ref string value);
        partial void OnVT06Changing(ref string value);
        partial void OnVT06Changed();
    
        /// <summary>
        /// There are no comments for VT07 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT07
        {
            get
            {
                string value = _VT07;
                OnGetVT07(ref value);
                return value;
            }
            set
            {
                if (_VT07 != value)
                {
                  OnVT07Changing(ref value);
                  ReportPropertyChanging("VT07");
                  _VT07 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT07");
                  OnVT07Changed();
              }
            }
        }
        private string _VT07;
        partial void OnGetVT07(ref string value);
        partial void OnVT07Changing(ref string value);
        partial void OnVT07Changed();
    
        /// <summary>
        /// There are no comments for VT08 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT08
        {
            get
            {
                string value = _VT08;
                OnGetVT08(ref value);
                return value;
            }
            set
            {
                if (_VT08 != value)
                {
                  OnVT08Changing(ref value);
                  ReportPropertyChanging("VT08");
                  _VT08 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT08");
                  OnVT08Changed();
              }
            }
        }
        private string _VT08;
        partial void OnGetVT08(ref string value);
        partial void OnVT08Changing(ref string value);
        partial void OnVT08Changed();
    
        /// <summary>
        /// There are no comments for VT09 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT09
        {
            get
            {
                string value = _VT09;
                OnGetVT09(ref value);
                return value;
            }
            set
            {
                if (_VT09 != value)
                {
                  OnVT09Changing(ref value);
                  ReportPropertyChanging("VT09");
                  _VT09 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT09");
                  OnVT09Changed();
              }
            }
        }
        private string _VT09;
        partial void OnGetVT09(ref string value);
        partial void OnVT09Changing(ref string value);
        partial void OnVT09Changed();
    
        /// <summary>
        /// There are no comments for VT10 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT10
        {
            get
            {
                string value = _VT10;
                OnGetVT10(ref value);
                return value;
            }
            set
            {
                if (_VT10 != value)
                {
                  OnVT10Changing(ref value);
                  ReportPropertyChanging("VT10");
                  _VT10 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT10");
                  OnVT10Changed();
              }
            }
        }
        private string _VT10;
        partial void OnGetVT10(ref string value);
        partial void OnVT10Changing(ref string value);
        partial void OnVT10Changed();
    
        /// <summary>
        /// There are no comments for VT11 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT11
        {
            get
            {
                string value = _VT11;
                OnGetVT11(ref value);
                return value;
            }
            set
            {
                if (_VT11 != value)
                {
                  OnVT11Changing(ref value);
                  ReportPropertyChanging("VT11");
                  _VT11 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT11");
                  OnVT11Changed();
              }
            }
        }
        private string _VT11;
        partial void OnGetVT11(ref string value);
        partial void OnVT11Changing(ref string value);
        partial void OnVT11Changed();
    
        /// <summary>
        /// There are no comments for VT12 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT12
        {
            get
            {
                string value = _VT12;
                OnGetVT12(ref value);
                return value;
            }
            set
            {
                if (_VT12 != value)
                {
                  OnVT12Changing(ref value);
                  ReportPropertyChanging("VT12");
                  _VT12 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT12");
                  OnVT12Changed();
              }
            }
        }
        private string _VT12;
        partial void OnGetVT12(ref string value);
        partial void OnVT12Changing(ref string value);
        partial void OnVT12Changed();
    
        /// <summary>
        /// There are no comments for VT13 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT13
        {
            get
            {
                string value = _VT13;
                OnGetVT13(ref value);
                return value;
            }
            set
            {
                if (_VT13 != value)
                {
                  OnVT13Changing(ref value);
                  ReportPropertyChanging("VT13");
                  _VT13 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT13");
                  OnVT13Changed();
              }
            }
        }
        private string _VT13;
        partial void OnGetVT13(ref string value);
        partial void OnVT13Changing(ref string value);
        partial void OnVT13Changed();
    
        /// <summary>
        /// There are no comments for VT14 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT14
        {
            get
            {
                string value = _VT14;
                OnGetVT14(ref value);
                return value;
            }
            set
            {
                if (_VT14 != value)
                {
                  OnVT14Changing(ref value);
                  ReportPropertyChanging("VT14");
                  _VT14 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT14");
                  OnVT14Changed();
              }
            }
        }
        private string _VT14;
        partial void OnGetVT14(ref string value);
        partial void OnVT14Changing(ref string value);
        partial void OnVT14Changed();
    
        /// <summary>
        /// There are no comments for VT15 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT15
        {
            get
            {
                string value = _VT15;
                OnGetVT15(ref value);
                return value;
            }
            set
            {
                if (_VT15 != value)
                {
                  OnVT15Changing(ref value);
                  ReportPropertyChanging("VT15");
                  _VT15 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT15");
                  OnVT15Changed();
              }
            }
        }
        private string _VT15;
        partial void OnGetVT15(ref string value);
        partial void OnVT15Changing(ref string value);
        partial void OnVT15Changed();
    
        /// <summary>
        /// There are no comments for VT16 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT16
        {
            get
            {
                string value = _VT16;
                OnGetVT16(ref value);
                return value;
            }
            set
            {
                if (_VT16 != value)
                {
                  OnVT16Changing(ref value);
                  ReportPropertyChanging("VT16");
                  _VT16 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT16");
                  OnVT16Changed();
              }
            }
        }
        private string _VT16;
        partial void OnGetVT16(ref string value);
        partial void OnVT16Changing(ref string value);
        partial void OnVT16Changed();
    
        /// <summary>
        /// There are no comments for VT17 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT17
        {
            get
            {
                string value = _VT17;
                OnGetVT17(ref value);
                return value;
            }
            set
            {
                if (_VT17 != value)
                {
                  OnVT17Changing(ref value);
                  ReportPropertyChanging("VT17");
                  _VT17 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT17");
                  OnVT17Changed();
              }
            }
        }
        private string _VT17;
        partial void OnGetVT17(ref string value);
        partial void OnVT17Changing(ref string value);
        partial void OnVT17Changed();
    
        /// <summary>
        /// There are no comments for VT18 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT18
        {
            get
            {
                string value = _VT18;
                OnGetVT18(ref value);
                return value;
            }
            set
            {
                if (_VT18 != value)
                {
                  OnVT18Changing(ref value);
                  ReportPropertyChanging("VT18");
                  _VT18 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT18");
                  OnVT18Changed();
              }
            }
        }
        private string _VT18;
        partial void OnGetVT18(ref string value);
        partial void OnVT18Changing(ref string value);
        partial void OnVT18Changed();
    
        /// <summary>
        /// There are no comments for VT19 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT19
        {
            get
            {
                string value = _VT19;
                OnGetVT19(ref value);
                return value;
            }
            set
            {
                if (_VT19 != value)
                {
                  OnVT19Changing(ref value);
                  ReportPropertyChanging("VT19");
                  _VT19 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT19");
                  OnVT19Changed();
              }
            }
        }
        private string _VT19;
        partial void OnGetVT19(ref string value);
        partial void OnVT19Changing(ref string value);
        partial void OnVT19Changed();
    
        /// <summary>
        /// There are no comments for VT20 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT20
        {
            get
            {
                string value = _VT20;
                OnGetVT20(ref value);
                return value;
            }
            set
            {
                if (_VT20 != value)
                {
                  OnVT20Changing(ref value);
                  ReportPropertyChanging("VT20");
                  _VT20 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT20");
                  OnVT20Changed();
              }
            }
        }
        private string _VT20;
        partial void OnGetVT20(ref string value);
        partial void OnVT20Changing(ref string value);
        partial void OnVT20Changed();
    
        /// <summary>
        /// There are no comments for VT21 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT21
        {
            get
            {
                string value = _VT21;
                OnGetVT21(ref value);
                return value;
            }
            set
            {
                if (_VT21 != value)
                {
                  OnVT21Changing(ref value);
                  ReportPropertyChanging("VT21");
                  _VT21 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT21");
                  OnVT21Changed();
              }
            }
        }
        private string _VT21;
        partial void OnGetVT21(ref string value);
        partial void OnVT21Changing(ref string value);
        partial void OnVT21Changed();
    
        /// <summary>
        /// There are no comments for VT22 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT22
        {
            get
            {
                string value = _VT22;
                OnGetVT22(ref value);
                return value;
            }
            set
            {
                if (_VT22 != value)
                {
                  OnVT22Changing(ref value);
                  ReportPropertyChanging("VT22");
                  _VT22 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT22");
                  OnVT22Changed();
              }
            }
        }
        private string _VT22;
        partial void OnGetVT22(ref string value);
        partial void OnVT22Changing(ref string value);
        partial void OnVT22Changed();
    
        /// <summary>
        /// There are no comments for VT23 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT23
        {
            get
            {
                string value = _VT23;
                OnGetVT23(ref value);
                return value;
            }
            set
            {
                if (_VT23 != value)
                {
                  OnVT23Changing(ref value);
                  ReportPropertyChanging("VT23");
                  _VT23 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT23");
                  OnVT23Changed();
              }
            }
        }
        private string _VT23;
        partial void OnGetVT23(ref string value);
        partial void OnVT23Changing(ref string value);
        partial void OnVT23Changed();
    
        /// <summary>
        /// There are no comments for VT24 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT24
        {
            get
            {
                string value = _VT24;
                OnGetVT24(ref value);
                return value;
            }
            set
            {
                if (_VT24 != value)
                {
                  OnVT24Changing(ref value);
                  ReportPropertyChanging("VT24");
                  _VT24 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT24");
                  OnVT24Changed();
              }
            }
        }
        private string _VT24;
        partial void OnGetVT24(ref string value);
        partial void OnVT24Changing(ref string value);
        partial void OnVT24Changed();
    
        /// <summary>
        /// There are no comments for VT25 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT25
        {
            get
            {
                string value = _VT25;
                OnGetVT25(ref value);
                return value;
            }
            set
            {
                if (_VT25 != value)
                {
                  OnVT25Changing(ref value);
                  ReportPropertyChanging("VT25");
                  _VT25 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT25");
                  OnVT25Changed();
              }
            }
        }
        private string _VT25;
        partial void OnGetVT25(ref string value);
        partial void OnVT25Changing(ref string value);
        partial void OnVT25Changed();
    
        /// <summary>
        /// There are no comments for VT26 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT26
        {
            get
            {
                string value = _VT26;
                OnGetVT26(ref value);
                return value;
            }
            set
            {
                if (_VT26 != value)
                {
                  OnVT26Changing(ref value);
                  ReportPropertyChanging("VT26");
                  _VT26 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT26");
                  OnVT26Changed();
              }
            }
        }
        private string _VT26;
        partial void OnGetVT26(ref string value);
        partial void OnVT26Changing(ref string value);
        partial void OnVT26Changed();
    
        /// <summary>
        /// There are no comments for VT27 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT27
        {
            get
            {
                string value = _VT27;
                OnGetVT27(ref value);
                return value;
            }
            set
            {
                if (_VT27 != value)
                {
                  OnVT27Changing(ref value);
                  ReportPropertyChanging("VT27");
                  _VT27 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT27");
                  OnVT27Changed();
              }
            }
        }
        private string _VT27;
        partial void OnGetVT27(ref string value);
        partial void OnVT27Changing(ref string value);
        partial void OnVT27Changed();
    
        /// <summary>
        /// There are no comments for VT28 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        public string VT28
        {
            get
            {
                string value = _VT28;
                OnGetVT28(ref value);
                return value;
            }
            set
            {
                if (_VT28 != value)
                {
                  OnVT28Changing(ref value);
                  ReportPropertyChanging("VT28");
                  _VT28 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VT28");
                  OnVT28Changed();
              }
            }
        }
        private string _VT28;
        partial void OnGetVT28(ref string value);
        partial void OnVT28Changing(ref string value);
        partial void OnVT28Changed();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TAM_CORRESP obj = new TAM_CORRESP();
            obj.TIPSORT = TIPSORT;
            obj.COD_REGRA = COD_REGRA;
            obj.VT01 = VT01;
            obj.VT02 = VT02;
            obj.VT03 = VT03;
            obj.VT04 = VT04;
            obj.VT05 = VT05;
            obj.VT06 = VT06;
            obj.VT07 = VT07;
            obj.VT08 = VT08;
            obj.VT09 = VT09;
            obj.VT10 = VT10;
            obj.VT11 = VT11;
            obj.VT12 = VT12;
            obj.VT13 = VT13;
            obj.VT14 = VT14;
            obj.VT15 = VT15;
            obj.VT16 = VT16;
            obj.VT17 = VT17;
            obj.VT18 = VT18;
            obj.VT19 = VT19;
            obj.VT20 = VT20;
            obj.VT21 = VT21;
            obj.VT22 = VT22;
            obj.VT23 = VT23;
            obj.VT24 = VT24;
            obj.VT25 = VT25;
            obj.VT26 = VT26;
            obj.VT27 = VT27;
            obj.VT28 = VT28;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TAM_CORRESP toCompare = obj as TAM_CORRESP;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.TIPSORT, toCompare.TIPSORT))
            return false;
          if (!Object.Equals(this.COD_REGRA, toCompare.COD_REGRA))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + TIPSORT.GetHashCode();
          hashCode = (hashCode * 7) + COD_REGRA.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}