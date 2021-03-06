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
    /// There are no comments for DataGiic_LiagoModel.CORES_PA in the schema.
    /// </summary>
    /// <KeyProperties>
    /// cor
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CORES_PA")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CORES_PA : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CORES_PA object.
        /// </summary>
        /// <param name="cor">Initial value of cor.</param>
        public static CORES_PA CreateCORES_PA(string cor)
        {
            CORES_PA cORES_PA = new CORES_PA();
            cORES_PA.cor = cor;
            return cORES_PA;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for cor in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string cor
        {
            get
            {
                string value = _cor;
                OnGetcor(ref value);
                return value;
            }
            set
            {
                if (_cor != value)
                {
                  OncorChanging(ref value);
                  ReportPropertyChanging("cor");
                  _cor = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("cor");
                  OncorChanged();
              }
            }
        }
        private string _cor;
        partial void OnGetcor(ref string value);
        partial void OncorChanging(ref string value);
        partial void OncorChanged();
    
        /// <summary>
        /// There are no comments for ingles in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string ingles
        {
            get
            {
                string value = _ingles;
                OnGetingles(ref value);
                return value;
            }
            set
            {
                if (_ingles != value)
                {
                  OninglesChanging(ref value);
                  ReportPropertyChanging("ingles");
                  _ingles = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("ingles");
                  OninglesChanged();
              }
            }
        }
        private string _ingles;
        partial void OnGetingles(ref string value);
        partial void OninglesChanging(ref string value);
        partial void OninglesChanged();
    
        /// <summary>
        /// There are no comments for frances in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string frances
        {
            get
            {
                string value = _frances;
                OnGetfrances(ref value);
                return value;
            }
            set
            {
                if (_frances != value)
                {
                  OnfrancesChanging(ref value);
                  ReportPropertyChanging("frances");
                  _frances = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("frances");
                  OnfrancesChanged();
              }
            }
        }
        private string _frances;
        partial void OnGetfrances(ref string value);
        partial void OnfrancesChanging(ref string value);
        partial void OnfrancesChanged();
    
        /// <summary>
        /// There are no comments for alemao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string alemao
        {
            get
            {
                string value = _alemao;
                OnGetalemao(ref value);
                return value;
            }
            set
            {
                if (_alemao != value)
                {
                  OnalemaoChanging(ref value);
                  ReportPropertyChanging("alemao");
                  _alemao = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("alemao");
                  OnalemaoChanged();
              }
            }
        }
        private string _alemao;
        partial void OnGetalemao(ref string value);
        partial void OnalemaoChanging(ref string value);
        partial void OnalemaoChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CORES_PA obj = new CORES_PA();
            obj.cor = cor;
            obj.ingles = ingles;
            obj.frances = frances;
            obj.alemao = alemao;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CORES_PA toCompare = obj as CORES_PA;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.cor, toCompare.cor))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + cor.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
