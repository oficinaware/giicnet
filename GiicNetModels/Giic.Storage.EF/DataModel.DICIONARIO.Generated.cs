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
    /// There are no comments for DataGiic_LiagoModel.DICIONARIO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// NATIVO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="DICIONARIO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DICIONARIO : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new DICIONARIO object.
        /// </summary>
        /// <param name="nATIVO">Initial value of NATIVO.</param>
        public static DICIONARIO CreateDICIONARIO(string nATIVO)
        {
            DICIONARIO dICIONARIO = new DICIONARIO();
            dICIONARIO.NATIVO = nATIVO;
            return dICIONARIO;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for NATIVO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(75)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string NATIVO
        {
            get
            {
                string value = _NATIVO;
                OnGetNATIVO(ref value);
                return value;
            }
            set
            {
                if (_NATIVO != value)
                {
                  OnNATIVOChanging(ref value);
                  ReportPropertyChanging("NATIVO");
                  _NATIVO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("NATIVO");
                  OnNATIVOChanged();
              }
            }
        }
        private string _NATIVO;
        partial void OnGetNATIVO(ref string value);
        partial void OnNATIVOChanging(ref string value);
        partial void OnNATIVOChanged();
    
        /// <summary>
        /// There are no comments for INGLES in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(75)]
        public string INGLES
        {
            get
            {
                string value = _INGLES;
                OnGetINGLES(ref value);
                return value;
            }
            set
            {
                if (_INGLES != value)
                {
                  OnINGLESChanging(ref value);
                  ReportPropertyChanging("INGLES");
                  _INGLES = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("INGLES");
                  OnINGLESChanged();
              }
            }
        }
        private string _INGLES;
        partial void OnGetINGLES(ref string value);
        partial void OnINGLESChanging(ref string value);
        partial void OnINGLESChanged();
    
        /// <summary>
        /// There are no comments for FRANCES in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(75)]
        public string FRANCES
        {
            get
            {
                string value = _FRANCES;
                OnGetFRANCES(ref value);
                return value;
            }
            set
            {
                if (_FRANCES != value)
                {
                  OnFRANCESChanging(ref value);
                  ReportPropertyChanging("FRANCES");
                  _FRANCES = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("FRANCES");
                  OnFRANCESChanged();
              }
            }
        }
        private string _FRANCES;
        partial void OnGetFRANCES(ref string value);
        partial void OnFRANCESChanging(ref string value);
        partial void OnFRANCESChanged();
    
        /// <summary>
        /// There are no comments for ESPANHOL in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(75)]
        public string ESPANHOL
        {
            get
            {
                string value = _ESPANHOL;
                OnGetESPANHOL(ref value);
                return value;
            }
            set
            {
                if (_ESPANHOL != value)
                {
                  OnESPANHOLChanging(ref value);
                  ReportPropertyChanging("ESPANHOL");
                  _ESPANHOL = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ESPANHOL");
                  OnESPANHOLChanged();
              }
            }
        }
        private string _ESPANHOL;
        partial void OnGetESPANHOL(ref string value);
        partial void OnESPANHOLChanging(ref string value);
        partial void OnESPANHOLChanged();
    
        /// <summary>
        /// There are no comments for ALEMAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(75)]
        public string ALEMAO
        {
            get
            {
                string value = _ALEMAO;
                OnGetALEMAO(ref value);
                return value;
            }
            set
            {
                if (_ALEMAO != value)
                {
                  OnALEMAOChanging(ref value);
                  ReportPropertyChanging("ALEMAO");
                  _ALEMAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ALEMAO");
                  OnALEMAOChanged();
              }
            }
        }
        private string _ALEMAO;
        partial void OnGetALEMAO(ref string value);
        partial void OnALEMAOChanging(ref string value);
        partial void OnALEMAOChanged();
    
        /// <summary>
        /// There are no comments for data in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> data
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _data;
                OnGetdata(ref value);
                return value;
            }
            set
            {
                if (_data != value)
                {
                  OndataChanging(ref value);
                  ReportPropertyChanging("data");
                  _data = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("data");
                  OndataChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _data;
        partial void OnGetdata(ref global::System.Nullable<System.DateTime> value);
        partial void OndataChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OndataChanged();
    
        /// <summary>
        /// There are no comments for ok in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> ok
        {
            get
            {
                global::System.Nullable<bool> value = _ok;
                OnGetok(ref value);
                return value;
            }
            set
            {
                if (_ok != value)
                {
                  OnokChanging(ref value);
                  ReportPropertyChanging("ok");
                  _ok = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ok");
                  OnokChanged();
              }
            }
        }
        private global::System.Nullable<bool> _ok;
        partial void OnGetok(ref global::System.Nullable<bool> value);
        partial void OnokChanging(ref global::System.Nullable<bool> value);
        partial void OnokChanged();
    
        /// <summary>
        /// There are no comments for MENU in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> MENU
        {
            get
            {
                global::System.Nullable<bool> value = _MENU;
                OnGetMENU(ref value);
                return value;
            }
            set
            {
                if (_MENU != value)
                {
                  OnMENUChanging(ref value);
                  ReportPropertyChanging("MENU");
                  _MENU = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("MENU");
                  OnMENUChanged();
              }
            }
        }
        private global::System.Nullable<bool> _MENU;
        partial void OnGetMENU(ref global::System.Nullable<bool> value);
        partial void OnMENUChanging(ref global::System.Nullable<bool> value);
        partial void OnMENUChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            DICIONARIO obj = new DICIONARIO();
            obj.NATIVO = NATIVO;
            obj.INGLES = INGLES;
            obj.FRANCES = FRANCES;
            obj.ESPANHOL = ESPANHOL;
            obj.ALEMAO = ALEMAO;
            obj.data = data;
            obj.ok = ok;
            obj.MENU = MENU;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          DICIONARIO toCompare = obj as DICIONARIO;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.NATIVO, toCompare.NATIVO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + NATIVO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
