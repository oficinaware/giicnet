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
    /// There are no comments for DataGiic_LiagoModel.STKMINPA in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ARM
    /// ARTIGO
    /// IDSORT
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="STKMINPA")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class STKMINPA : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new STKMINPA object.
        /// </summary>
        /// <param name="aRM">Initial value of ARM.</param>
        /// <param name="aRTIGO">Initial value of ARTIGO.</param>
        /// <param name="iDSORT">Initial value of IDSORT.</param>
        public static STKMINPA CreateSTKMINPA(string aRM, string aRTIGO, string iDSORT)
        {
            STKMINPA sTKMINPA = new STKMINPA();
            sTKMINPA.ARM = aRM;
            sTKMINPA.ARTIGO = aRTIGO;
            sTKMINPA.IDSORT = iDSORT;
            return sTKMINPA;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ARM in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ARM
        {
            get
            {
                string value = _ARM;
                OnGetARM(ref value);
                return value;
            }
            set
            {
                if (_ARM != value)
                {
                  OnARMChanging(ref value);
                  ReportPropertyChanging("ARM");
                  _ARM = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ARM");
                  OnARMChanged();
              }
            }
        }
        private string _ARM;
        partial void OnGetARM(ref string value);
        partial void OnARMChanging(ref string value);
        partial void OnARMChanged();
    
        /// <summary>
        /// There are no comments for ARTIGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string ARTIGO
        {
            get
            {
                string value = _ARTIGO;
                OnGetARTIGO(ref value);
                return value;
            }
            set
            {
                if (_ARTIGO != value)
                {
                  OnARTIGOChanging(ref value);
                  ReportPropertyChanging("ARTIGO");
                  _ARTIGO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("ARTIGO");
                  OnARTIGOChanged();
              }
            }
        }
        private string _ARTIGO;
        partial void OnGetARTIGO(ref string value);
        partial void OnARTIGOChanging(ref string value);
        partial void OnARTIGOChanged();
    
        /// <summary>
        /// There are no comments for IDSORT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string IDSORT
        {
            get
            {
                string value = _IDSORT;
                OnGetIDSORT(ref value);
                return value;
            }
            set
            {
                if (_IDSORT != value)
                {
                  OnIDSORTChanging(ref value);
                  ReportPropertyChanging("IDSORT");
                  _IDSORT = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("IDSORT");
                  OnIDSORTChanged();
              }
            }
        }
        private string _IDSORT = @"0";
        partial void OnGetIDSORT(ref string value);
        partial void OnIDSORTChanging(ref string value);
        partial void OnIDSORTChanged();
    
        /// <summary>
        /// There are no comments for QE01 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE01
        {
            get
            {
                global::System.Nullable<int> value = _QE01;
                OnGetQE01(ref value);
                return value;
            }
            set
            {
                if (_QE01 != value)
                {
                  OnQE01Changing(ref value);
                  ReportPropertyChanging("QE01");
                  _QE01 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE01");
                  OnQE01Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE01;
        partial void OnGetQE01(ref global::System.Nullable<int> value);
        partial void OnQE01Changing(ref global::System.Nullable<int> value);
        partial void OnQE01Changed();
    
        /// <summary>
        /// There are no comments for QE02 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE02
        {
            get
            {
                global::System.Nullable<int> value = _QE02;
                OnGetQE02(ref value);
                return value;
            }
            set
            {
                if (_QE02 != value)
                {
                  OnQE02Changing(ref value);
                  ReportPropertyChanging("QE02");
                  _QE02 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE02");
                  OnQE02Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE02;
        partial void OnGetQE02(ref global::System.Nullable<int> value);
        partial void OnQE02Changing(ref global::System.Nullable<int> value);
        partial void OnQE02Changed();
    
        /// <summary>
        /// There are no comments for QE03 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE03
        {
            get
            {
                global::System.Nullable<int> value = _QE03;
                OnGetQE03(ref value);
                return value;
            }
            set
            {
                if (_QE03 != value)
                {
                  OnQE03Changing(ref value);
                  ReportPropertyChanging("QE03");
                  _QE03 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE03");
                  OnQE03Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE03;
        partial void OnGetQE03(ref global::System.Nullable<int> value);
        partial void OnQE03Changing(ref global::System.Nullable<int> value);
        partial void OnQE03Changed();
    
        /// <summary>
        /// There are no comments for QE04 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE04
        {
            get
            {
                global::System.Nullable<int> value = _QE04;
                OnGetQE04(ref value);
                return value;
            }
            set
            {
                if (_QE04 != value)
                {
                  OnQE04Changing(ref value);
                  ReportPropertyChanging("QE04");
                  _QE04 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE04");
                  OnQE04Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE04;
        partial void OnGetQE04(ref global::System.Nullable<int> value);
        partial void OnQE04Changing(ref global::System.Nullable<int> value);
        partial void OnQE04Changed();
    
        /// <summary>
        /// There are no comments for QE05 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE05
        {
            get
            {
                global::System.Nullable<int> value = _QE05;
                OnGetQE05(ref value);
                return value;
            }
            set
            {
                if (_QE05 != value)
                {
                  OnQE05Changing(ref value);
                  ReportPropertyChanging("QE05");
                  _QE05 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE05");
                  OnQE05Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE05;
        partial void OnGetQE05(ref global::System.Nullable<int> value);
        partial void OnQE05Changing(ref global::System.Nullable<int> value);
        partial void OnQE05Changed();
    
        /// <summary>
        /// There are no comments for QE06 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE06
        {
            get
            {
                global::System.Nullable<int> value = _QE06;
                OnGetQE06(ref value);
                return value;
            }
            set
            {
                if (_QE06 != value)
                {
                  OnQE06Changing(ref value);
                  ReportPropertyChanging("QE06");
                  _QE06 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE06");
                  OnQE06Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE06;
        partial void OnGetQE06(ref global::System.Nullable<int> value);
        partial void OnQE06Changing(ref global::System.Nullable<int> value);
        partial void OnQE06Changed();
    
        /// <summary>
        /// There are no comments for QE07 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE07
        {
            get
            {
                global::System.Nullable<int> value = _QE07;
                OnGetQE07(ref value);
                return value;
            }
            set
            {
                if (_QE07 != value)
                {
                  OnQE07Changing(ref value);
                  ReportPropertyChanging("QE07");
                  _QE07 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE07");
                  OnQE07Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE07;
        partial void OnGetQE07(ref global::System.Nullable<int> value);
        partial void OnQE07Changing(ref global::System.Nullable<int> value);
        partial void OnQE07Changed();
    
        /// <summary>
        /// There are no comments for QE08 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE08
        {
            get
            {
                global::System.Nullable<int> value = _QE08;
                OnGetQE08(ref value);
                return value;
            }
            set
            {
                if (_QE08 != value)
                {
                  OnQE08Changing(ref value);
                  ReportPropertyChanging("QE08");
                  _QE08 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE08");
                  OnQE08Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE08;
        partial void OnGetQE08(ref global::System.Nullable<int> value);
        partial void OnQE08Changing(ref global::System.Nullable<int> value);
        partial void OnQE08Changed();
    
        /// <summary>
        /// There are no comments for QE09 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE09
        {
            get
            {
                global::System.Nullable<int> value = _QE09;
                OnGetQE09(ref value);
                return value;
            }
            set
            {
                if (_QE09 != value)
                {
                  OnQE09Changing(ref value);
                  ReportPropertyChanging("QE09");
                  _QE09 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE09");
                  OnQE09Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE09;
        partial void OnGetQE09(ref global::System.Nullable<int> value);
        partial void OnQE09Changing(ref global::System.Nullable<int> value);
        partial void OnQE09Changed();
    
        /// <summary>
        /// There are no comments for QE10 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE10
        {
            get
            {
                global::System.Nullable<int> value = _QE10;
                OnGetQE10(ref value);
                return value;
            }
            set
            {
                if (_QE10 != value)
                {
                  OnQE10Changing(ref value);
                  ReportPropertyChanging("QE10");
                  _QE10 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE10");
                  OnQE10Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE10;
        partial void OnGetQE10(ref global::System.Nullable<int> value);
        partial void OnQE10Changing(ref global::System.Nullable<int> value);
        partial void OnQE10Changed();
    
        /// <summary>
        /// There are no comments for QE11 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE11
        {
            get
            {
                global::System.Nullable<int> value = _QE11;
                OnGetQE11(ref value);
                return value;
            }
            set
            {
                if (_QE11 != value)
                {
                  OnQE11Changing(ref value);
                  ReportPropertyChanging("QE11");
                  _QE11 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE11");
                  OnQE11Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE11;
        partial void OnGetQE11(ref global::System.Nullable<int> value);
        partial void OnQE11Changing(ref global::System.Nullable<int> value);
        partial void OnQE11Changed();
    
        /// <summary>
        /// There are no comments for QE12 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE12
        {
            get
            {
                global::System.Nullable<int> value = _QE12;
                OnGetQE12(ref value);
                return value;
            }
            set
            {
                if (_QE12 != value)
                {
                  OnQE12Changing(ref value);
                  ReportPropertyChanging("QE12");
                  _QE12 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE12");
                  OnQE12Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE12;
        partial void OnGetQE12(ref global::System.Nullable<int> value);
        partial void OnQE12Changing(ref global::System.Nullable<int> value);
        partial void OnQE12Changed();
    
        /// <summary>
        /// There are no comments for QE13 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE13
        {
            get
            {
                global::System.Nullable<int> value = _QE13;
                OnGetQE13(ref value);
                return value;
            }
            set
            {
                if (_QE13 != value)
                {
                  OnQE13Changing(ref value);
                  ReportPropertyChanging("QE13");
                  _QE13 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE13");
                  OnQE13Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE13;
        partial void OnGetQE13(ref global::System.Nullable<int> value);
        partial void OnQE13Changing(ref global::System.Nullable<int> value);
        partial void OnQE13Changed();
    
        /// <summary>
        /// There are no comments for QE14 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE14
        {
            get
            {
                global::System.Nullable<int> value = _QE14;
                OnGetQE14(ref value);
                return value;
            }
            set
            {
                if (_QE14 != value)
                {
                  OnQE14Changing(ref value);
                  ReportPropertyChanging("QE14");
                  _QE14 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE14");
                  OnQE14Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE14;
        partial void OnGetQE14(ref global::System.Nullable<int> value);
        partial void OnQE14Changing(ref global::System.Nullable<int> value);
        partial void OnQE14Changed();
    
        /// <summary>
        /// There are no comments for QE15 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE15
        {
            get
            {
                global::System.Nullable<int> value = _QE15;
                OnGetQE15(ref value);
                return value;
            }
            set
            {
                if (_QE15 != value)
                {
                  OnQE15Changing(ref value);
                  ReportPropertyChanging("QE15");
                  _QE15 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE15");
                  OnQE15Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE15;
        partial void OnGetQE15(ref global::System.Nullable<int> value);
        partial void OnQE15Changing(ref global::System.Nullable<int> value);
        partial void OnQE15Changed();
    
        /// <summary>
        /// There are no comments for QE16 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE16
        {
            get
            {
                global::System.Nullable<int> value = _QE16;
                OnGetQE16(ref value);
                return value;
            }
            set
            {
                if (_QE16 != value)
                {
                  OnQE16Changing(ref value);
                  ReportPropertyChanging("QE16");
                  _QE16 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE16");
                  OnQE16Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE16;
        partial void OnGetQE16(ref global::System.Nullable<int> value);
        partial void OnQE16Changing(ref global::System.Nullable<int> value);
        partial void OnQE16Changed();
    
        /// <summary>
        /// There are no comments for QE17 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE17
        {
            get
            {
                global::System.Nullable<int> value = _QE17;
                OnGetQE17(ref value);
                return value;
            }
            set
            {
                if (_QE17 != value)
                {
                  OnQE17Changing(ref value);
                  ReportPropertyChanging("QE17");
                  _QE17 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE17");
                  OnQE17Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE17;
        partial void OnGetQE17(ref global::System.Nullable<int> value);
        partial void OnQE17Changing(ref global::System.Nullable<int> value);
        partial void OnQE17Changed();
    
        /// <summary>
        /// There are no comments for QE18 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE18
        {
            get
            {
                global::System.Nullable<int> value = _QE18;
                OnGetQE18(ref value);
                return value;
            }
            set
            {
                if (_QE18 != value)
                {
                  OnQE18Changing(ref value);
                  ReportPropertyChanging("QE18");
                  _QE18 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE18");
                  OnQE18Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE18;
        partial void OnGetQE18(ref global::System.Nullable<int> value);
        partial void OnQE18Changing(ref global::System.Nullable<int> value);
        partial void OnQE18Changed();
    
        /// <summary>
        /// There are no comments for QE19 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE19
        {
            get
            {
                global::System.Nullable<int> value = _QE19;
                OnGetQE19(ref value);
                return value;
            }
            set
            {
                if (_QE19 != value)
                {
                  OnQE19Changing(ref value);
                  ReportPropertyChanging("QE19");
                  _QE19 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE19");
                  OnQE19Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE19;
        partial void OnGetQE19(ref global::System.Nullable<int> value);
        partial void OnQE19Changing(ref global::System.Nullable<int> value);
        partial void OnQE19Changed();
    
        /// <summary>
        /// There are no comments for QE20 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE20
        {
            get
            {
                global::System.Nullable<int> value = _QE20;
                OnGetQE20(ref value);
                return value;
            }
            set
            {
                if (_QE20 != value)
                {
                  OnQE20Changing(ref value);
                  ReportPropertyChanging("QE20");
                  _QE20 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE20");
                  OnQE20Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE20;
        partial void OnGetQE20(ref global::System.Nullable<int> value);
        partial void OnQE20Changing(ref global::System.Nullable<int> value);
        partial void OnQE20Changed();
    
        /// <summary>
        /// There are no comments for QE21 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE21
        {
            get
            {
                global::System.Nullable<int> value = _QE21;
                OnGetQE21(ref value);
                return value;
            }
            set
            {
                if (_QE21 != value)
                {
                  OnQE21Changing(ref value);
                  ReportPropertyChanging("QE21");
                  _QE21 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE21");
                  OnQE21Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE21;
        partial void OnGetQE21(ref global::System.Nullable<int> value);
        partial void OnQE21Changing(ref global::System.Nullable<int> value);
        partial void OnQE21Changed();
    
        /// <summary>
        /// There are no comments for QE22 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE22
        {
            get
            {
                global::System.Nullable<int> value = _QE22;
                OnGetQE22(ref value);
                return value;
            }
            set
            {
                if (_QE22 != value)
                {
                  OnQE22Changing(ref value);
                  ReportPropertyChanging("QE22");
                  _QE22 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE22");
                  OnQE22Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE22;
        partial void OnGetQE22(ref global::System.Nullable<int> value);
        partial void OnQE22Changing(ref global::System.Nullable<int> value);
        partial void OnQE22Changed();
    
        /// <summary>
        /// There are no comments for QE23 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE23
        {
            get
            {
                global::System.Nullable<int> value = _QE23;
                OnGetQE23(ref value);
                return value;
            }
            set
            {
                if (_QE23 != value)
                {
                  OnQE23Changing(ref value);
                  ReportPropertyChanging("QE23");
                  _QE23 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE23");
                  OnQE23Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE23;
        partial void OnGetQE23(ref global::System.Nullable<int> value);
        partial void OnQE23Changing(ref global::System.Nullable<int> value);
        partial void OnQE23Changed();
    
        /// <summary>
        /// There are no comments for QE24 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE24
        {
            get
            {
                global::System.Nullable<int> value = _QE24;
                OnGetQE24(ref value);
                return value;
            }
            set
            {
                if (_QE24 != value)
                {
                  OnQE24Changing(ref value);
                  ReportPropertyChanging("QE24");
                  _QE24 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE24");
                  OnQE24Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE24;
        partial void OnGetQE24(ref global::System.Nullable<int> value);
        partial void OnQE24Changing(ref global::System.Nullable<int> value);
        partial void OnQE24Changed();
    
        /// <summary>
        /// There are no comments for QE25 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE25
        {
            get
            {
                global::System.Nullable<int> value = _QE25;
                OnGetQE25(ref value);
                return value;
            }
            set
            {
                if (_QE25 != value)
                {
                  OnQE25Changing(ref value);
                  ReportPropertyChanging("QE25");
                  _QE25 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE25");
                  OnQE25Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE25;
        partial void OnGetQE25(ref global::System.Nullable<int> value);
        partial void OnQE25Changing(ref global::System.Nullable<int> value);
        partial void OnQE25Changed();
    
        /// <summary>
        /// There are no comments for QE26 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE26
        {
            get
            {
                global::System.Nullable<int> value = _QE26;
                OnGetQE26(ref value);
                return value;
            }
            set
            {
                if (_QE26 != value)
                {
                  OnQE26Changing(ref value);
                  ReportPropertyChanging("QE26");
                  _QE26 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE26");
                  OnQE26Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE26;
        partial void OnGetQE26(ref global::System.Nullable<int> value);
        partial void OnQE26Changing(ref global::System.Nullable<int> value);
        partial void OnQE26Changed();
    
        /// <summary>
        /// There are no comments for QE27 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE27
        {
            get
            {
                global::System.Nullable<int> value = _QE27;
                OnGetQE27(ref value);
                return value;
            }
            set
            {
                if (_QE27 != value)
                {
                  OnQE27Changing(ref value);
                  ReportPropertyChanging("QE27");
                  _QE27 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE27");
                  OnQE27Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE27;
        partial void OnGetQE27(ref global::System.Nullable<int> value);
        partial void OnQE27Changing(ref global::System.Nullable<int> value);
        partial void OnQE27Changed();
    
        /// <summary>
        /// There are no comments for QE28 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QE28
        {
            get
            {
                global::System.Nullable<int> value = _QE28;
                OnGetQE28(ref value);
                return value;
            }
            set
            {
                if (_QE28 != value)
                {
                  OnQE28Changing(ref value);
                  ReportPropertyChanging("QE28");
                  _QE28 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QE28");
                  OnQE28Changed();
              }
            }
        }
        private global::System.Nullable<int> _QE28;
        partial void OnGetQE28(ref global::System.Nullable<int> value);
        partial void OnQE28Changing(ref global::System.Nullable<int> value);
        partial void OnQE28Changed();
    
        /// <summary>
        /// There are no comments for TOTQT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TOTQT
        {
            get
            {
                global::System.Nullable<int> value = _TOTQT;
                OnGetTOTQT(ref value);
                return value;
            }
            set
            {
                if (_TOTQT != value)
                {
                  OnTOTQTChanging(ref value);
                  ReportPropertyChanging("TOTQT");
                  _TOTQT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOTQT");
                  OnTOTQTChanged();
              }
            }
        }
        private global::System.Nullable<int> _TOTQT;
        partial void OnGetTOTQT(ref global::System.Nullable<int> value);
        partial void OnTOTQTChanging(ref global::System.Nullable<int> value);
        partial void OnTOTQTChanged();
    
        /// <summary>
        /// There are no comments for QTPACK in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> QTPACK
        {
            get
            {
                global::System.Nullable<int> value = _QTPACK;
                OnGetQTPACK(ref value);
                return value;
            }
            set
            {
                if (_QTPACK != value)
                {
                  OnQTPACKChanging(ref value);
                  ReportPropertyChanging("QTPACK");
                  _QTPACK = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("QTPACK");
                  OnQTPACKChanged();
              }
            }
        }
        private global::System.Nullable<int> _QTPACK = 0;
        partial void OnGetQTPACK(ref global::System.Nullable<int> value);
        partial void OnQTPACKChanging(ref global::System.Nullable<int> value);
        partial void OnQTPACKChanged();
    
        /// <summary>
        /// There are no comments for DATA_ACT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_ACT
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_ACT;
                OnGetDATA_ACT(ref value);
                return value;
            }
            set
            {
                if (_DATA_ACT != value)
                {
                  OnDATA_ACTChanging(ref value);
                  ReportPropertyChanging("DATA_ACT");
                  _DATA_ACT = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_ACT");
                  OnDATA_ACTChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_ACT;
        partial void OnGetDATA_ACT(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ACTChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_ACTChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            STKMINPA obj = new STKMINPA();
            obj.ARM = ARM;
            obj.ARTIGO = ARTIGO;
            obj.IDSORT = IDSORT;
            obj.QE01 = QE01;
            obj.QE02 = QE02;
            obj.QE03 = QE03;
            obj.QE04 = QE04;
            obj.QE05 = QE05;
            obj.QE06 = QE06;
            obj.QE07 = QE07;
            obj.QE08 = QE08;
            obj.QE09 = QE09;
            obj.QE10 = QE10;
            obj.QE11 = QE11;
            obj.QE12 = QE12;
            obj.QE13 = QE13;
            obj.QE14 = QE14;
            obj.QE15 = QE15;
            obj.QE16 = QE16;
            obj.QE17 = QE17;
            obj.QE18 = QE18;
            obj.QE19 = QE19;
            obj.QE20 = QE20;
            obj.QE21 = QE21;
            obj.QE22 = QE22;
            obj.QE23 = QE23;
            obj.QE24 = QE24;
            obj.QE25 = QE25;
            obj.QE26 = QE26;
            obj.QE27 = QE27;
            obj.QE28 = QE28;
            obj.TOTQT = TOTQT;
            obj.QTPACK = QTPACK;
            obj.DATA_ACT = DATA_ACT;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          STKMINPA toCompare = obj as STKMINPA;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ARM, toCompare.ARM))
            return false;
          if (!Object.Equals(this.ARTIGO, toCompare.ARTIGO))
            return false;
          if (!Object.Equals(this.IDSORT, toCompare.IDSORT))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ARM.GetHashCode();
          hashCode = (hashCode * 7) + ARTIGO.GetHashCode();
          hashCode = (hashCode * 7) + IDSORT.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}