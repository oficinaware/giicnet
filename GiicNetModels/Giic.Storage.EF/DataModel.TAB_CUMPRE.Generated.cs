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
    /// There are no comments for DataGiic_LiagoModel.TAB_CUMPRE in the schema.
    /// </summary>
    /// <KeyProperties>
    /// GRAU
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TAB_CUMPRE")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TAB_CUMPRE : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TAB_CUMPRE object.
        /// </summary>
        /// <param name="gRAU">Initial value of GRAU.</param>
        public static TAB_CUMPRE CreateTAB_CUMPRE(short gRAU)
        {
            TAB_CUMPRE tAB_CUMPRE = new TAB_CUMPRE();
            tAB_CUMPRE.GRAU = gRAU;
            return tAB_CUMPRE;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for GRAU in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public short GRAU
        {
            get
            {
                short value = _GRAU;
                OnGetGRAU(ref value);
                return value;
            }
            set
            {
                if (_GRAU != value)
                {
                  OnGRAUChanging(ref value);
                  ReportPropertyChanging("GRAU");
                  _GRAU = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("GRAU");
                  OnGRAUChanged();
              }
            }
        }
        private short _GRAU;
        partial void OnGetGRAU(ref short value);
        partial void OnGRAUChanging(ref short value);
        partial void OnGRAUChanged();
    
        /// <summary>
        /// There are no comments for TOLERANCIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> TOLERANCIA
        {
            get
            {
                global::System.Nullable<int> value = _TOLERANCIA;
                OnGetTOLERANCIA(ref value);
                return value;
            }
            set
            {
                if (_TOLERANCIA != value)
                {
                  OnTOLERANCIAChanging(ref value);
                  ReportPropertyChanging("TOLERANCIA");
                  _TOLERANCIA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TOLERANCIA");
                  OnTOLERANCIAChanged();
              }
            }
        }
        private global::System.Nullable<int> _TOLERANCIA;
        partial void OnGetTOLERANCIA(ref global::System.Nullable<int> value);
        partial void OnTOLERANCIAChanging(ref global::System.Nullable<int> value);
        partial void OnTOLERANCIAChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TAB_CUMPRE obj = new TAB_CUMPRE();
            obj.GRAU = GRAU;
            obj.TOLERANCIA = TOLERANCIA;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TAB_CUMPRE toCompare = obj as TAB_CUMPRE;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.GRAU, toCompare.GRAU))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + GRAU.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}