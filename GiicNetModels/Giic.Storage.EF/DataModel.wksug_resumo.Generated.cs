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
    /// There are no comments for DataGiic_LiagoModel.wksug_resumo in the schema.
    /// </summary>
    /// <KeyProperties>
    /// spid
    /// forn
    /// nroc
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wksug_resumo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wksug_resumo : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wksug_resumo object.
        /// </summary>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="forn">Initial value of forn.</param>
        /// <param name="nroc">Initial value of nroc.</param>
        public static wksug_resumo Createwksug_resumo(int spid, string forn, int nroc)
        {
            wksug_resumo wksug_resumo = new wksug_resumo();
            wksug_resumo.spid = spid;
            wksug_resumo.forn = forn;
            wksug_resumo.nroc = nroc;
            return wksug_resumo;
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
        /// There are no comments for forn in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string forn
        {
            get
            {
                string value = _forn;
                OnGetforn(ref value);
                return value;
            }
            set
            {
                if (_forn != value)
                {
                  OnfornChanging(ref value);
                  ReportPropertyChanging("forn");
                  _forn = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("forn");
                  OnfornChanged();
              }
            }
        }
        private string _forn;
        partial void OnGetforn(ref string value);
        partial void OnfornChanging(ref string value);
        partial void OnfornChanged();
    
        /// <summary>
        /// There are no comments for nroc in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int nroc
        {
            get
            {
                int value = _nroc;
                OnGetnroc(ref value);
                return value;
            }
            set
            {
                if (_nroc != value)
                {
                  OnnrocChanging(ref value);
                  ReportPropertyChanging("nroc");
                  _nroc = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("nroc");
                  OnnrocChanged();
              }
            }
        }
        private int _nroc;
        partial void OnGetnroc(ref int value);
        partial void OnnrocChanging(ref int value);
        partial void OnnrocChanged();
    
        /// <summary>
        /// There are no comments for coment1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string coment1
        {
            get
            {
                string value = _coment1;
                OnGetcoment1(ref value);
                return value;
            }
            set
            {
                if (_coment1 != value)
                {
                  Oncoment1Changing(ref value);
                  ReportPropertyChanging("coment1");
                  _coment1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("coment1");
                  Oncoment1Changed();
              }
            }
        }
        private string _coment1 = @"N'Pendente";
        partial void OnGetcoment1(ref string value);
        partial void Oncoment1Changing(ref string value);
        partial void Oncoment1Changed();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wksug_resumo obj = new wksug_resumo();
            obj.spid = spid;
            obj.forn = forn;
            obj.nroc = nroc;
            obj.coment1 = coment1;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wksug_resumo toCompare = obj as wksug_resumo;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.spid, toCompare.spid))
            return false;
          if (!Object.Equals(this.forn, toCompare.forn))
            return false;
          if (!Object.Equals(this.nroc, toCompare.nroc))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + spid.GetHashCode();
          hashCode = (hashCode * 7) + forn.GetHashCode();
          hashCode = (hashCode * 7) + nroc.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}