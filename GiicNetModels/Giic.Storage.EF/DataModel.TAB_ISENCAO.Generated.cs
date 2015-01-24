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
    /// There are no comments for DataGiic_LiagoModel.TAB_ISENCAO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CODIGO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TAB_ISENCAO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TAB_ISENCAO : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TAB_ISENCAO object.
        /// </summary>
        /// <param name="cODIGO">Initial value of CODIGO.</param>
        /// <param name="dESC_FACTURA">Initial value of DESC_FACTURA.</param>
        /// <param name="dESC_SAFT">Initial value of DESC_SAFT.</param>
        /// <param name="cOD_SAFT">Initial value of COD_SAFT.</param>
        public static TAB_ISENCAO CreateTAB_ISENCAO(string cODIGO, string dESC_FACTURA, string dESC_SAFT, string cOD_SAFT)
        {
            TAB_ISENCAO tAB_ISENCAO = new TAB_ISENCAO();
            tAB_ISENCAO.CODIGO = cODIGO;
            tAB_ISENCAO.DESC_FACTURA = dESC_FACTURA;
            tAB_ISENCAO.DESC_SAFT = dESC_SAFT;
            tAB_ISENCAO.COD_SAFT = cOD_SAFT;
            return tAB_ISENCAO;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CODIGO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODIGO
        {
            get
            {
                string value = _CODIGO;
                OnGetCODIGO(ref value);
                return value;
            }
            set
            {
                if (_CODIGO != value)
                {
                  OnCODIGOChanging(ref value);
                  ReportPropertyChanging("CODIGO");
                  _CODIGO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODIGO");
                  OnCODIGOChanged();
              }
            }
        }
        private string _CODIGO;
        partial void OnGetCODIGO(ref string value);
        partial void OnCODIGOChanging(ref string value);
        partial void OnCODIGOChanged();
    
        /// <summary>
        /// There are no comments for DESC_FACTURA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string DESC_FACTURA
        {
            get
            {
                string value = _DESC_FACTURA;
                OnGetDESC_FACTURA(ref value);
                return value;
            }
            set
            {
                if (_DESC_FACTURA != value)
                {
                  OnDESC_FACTURAChanging(ref value);
                  ReportPropertyChanging("DESC_FACTURA");
                  _DESC_FACTURA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("DESC_FACTURA");
                  OnDESC_FACTURAChanged();
              }
            }
        }
        private string _DESC_FACTURA;
        partial void OnGetDESC_FACTURA(ref string value);
        partial void OnDESC_FACTURAChanging(ref string value);
        partial void OnDESC_FACTURAChanged();
    
        /// <summary>
        /// There are no comments for DESC_SAFT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string DESC_SAFT
        {
            get
            {
                string value = _DESC_SAFT;
                OnGetDESC_SAFT(ref value);
                return value;
            }
            set
            {
                if (_DESC_SAFT != value)
                {
                  OnDESC_SAFTChanging(ref value);
                  ReportPropertyChanging("DESC_SAFT");
                  _DESC_SAFT = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("DESC_SAFT");
                  OnDESC_SAFTChanged();
              }
            }
        }
        private string _DESC_SAFT;
        partial void OnGetDESC_SAFT(ref string value);
        partial void OnDESC_SAFTChanging(ref string value);
        partial void OnDESC_SAFTChanged();
    
        /// <summary>
        /// There are no comments for COD_SAFT in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(4)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string COD_SAFT
        {
            get
            {
                string value = _COD_SAFT;
                OnGetCOD_SAFT(ref value);
                return value;
            }
            set
            {
                if (_COD_SAFT != value)
                {
                  OnCOD_SAFTChanging(ref value);
                  ReportPropertyChanging("COD_SAFT");
                  _COD_SAFT = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("COD_SAFT");
                  OnCOD_SAFTChanged();
              }
            }
        }
        private string _COD_SAFT;
        partial void OnGetCOD_SAFT(ref string value);
        partial void OnCOD_SAFTChanging(ref string value);
        partial void OnCOD_SAFTChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TAB_ISENCAO obj = new TAB_ISENCAO();
            obj.CODIGO = CODIGO;
            obj.DESC_FACTURA = DESC_FACTURA;
            obj.DESC_SAFT = DESC_SAFT;
            obj.COD_SAFT = COD_SAFT;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TAB_ISENCAO toCompare = obj as TAB_ISENCAO;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CODIGO, toCompare.CODIGO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CODIGO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}