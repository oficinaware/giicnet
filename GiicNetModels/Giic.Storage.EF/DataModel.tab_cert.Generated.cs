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
    /// There are no comments for DataGiic_LiagoModel.tab_cert in the schema.
    /// </summary>
    /// <KeyProperties>
    /// spid
    /// arm
    /// tpdoc
    /// nrfact
    /// TIPO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="tab_cert")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tab_cert : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new tab_cert object.
        /// </summary>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="arm">Initial value of arm.</param>
        /// <param name="tpdoc">Initial value of tpdoc.</param>
        /// <param name="nrfact">Initial value of nrfact.</param>
        /// <param name="tIPO">Initial value of TIPO.</param>
        public static tab_cert Createtab_cert(int spid, string arm, string tpdoc, int nrfact, string tIPO)
        {
            tab_cert tab_cert = new tab_cert();
            tab_cert.spid = spid;
            tab_cert.arm = arm;
            tab_cert.tpdoc = tpdoc;
            tab_cert.nrfact = nrfact;
            tab_cert.TIPO = tIPO;
            return tab_cert;
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
        /// There are no comments for arm in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string arm
        {
            get
            {
                string value = _arm;
                OnGetarm(ref value);
                return value;
            }
            set
            {
                if (_arm != value)
                {
                  OnarmChanging(ref value);
                  ReportPropertyChanging("arm");
                  _arm = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("arm");
                  OnarmChanged();
              }
            }
        }
        private string _arm;
        partial void OnGetarm(ref string value);
        partial void OnarmChanging(ref string value);
        partial void OnarmChanged();
    
        /// <summary>
        /// There are no comments for tpdoc in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string tpdoc
        {
            get
            {
                string value = _tpdoc;
                OnGettpdoc(ref value);
                return value;
            }
            set
            {
                if (_tpdoc != value)
                {
                  OntpdocChanging(ref value);
                  ReportPropertyChanging("tpdoc");
                  _tpdoc = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("tpdoc");
                  OntpdocChanged();
              }
            }
        }
        private string _tpdoc;
        partial void OnGettpdoc(ref string value);
        partial void OntpdocChanging(ref string value);
        partial void OntpdocChanged();
    
        /// <summary>
        /// There are no comments for nrfact in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int nrfact
        {
            get
            {
                int value = _nrfact;
                OnGetnrfact(ref value);
                return value;
            }
            set
            {
                if (_nrfact != value)
                {
                  OnnrfactChanging(ref value);
                  ReportPropertyChanging("nrfact");
                  _nrfact = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("nrfact");
                  OnnrfactChanged();
              }
            }
        }
        private int _nrfact;
        partial void OnGetnrfact(ref int value);
        partial void OnnrfactChanging(ref int value);
        partial void OnnrfactChanged();
    
        /// <summary>
        /// There are no comments for TIPO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(1)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string TIPO
        {
            get
            {
                string value = _TIPO;
                OnGetTIPO(ref value);
                return value;
            }
            set
            {
                if (_TIPO != value)
                {
                  OnTIPOChanging(ref value);
                  ReportPropertyChanging("TIPO");
                  _TIPO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("TIPO");
                  OnTIPOChanged();
              }
            }
        }
        private string _TIPO = @"N'I";
        partial void OnGetTIPO(ref string value);
        partial void OnTIPOChanging(ref string value);
        partial void OnTIPOChanged();
    
        /// <summary>
        /// There are no comments for str_input in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(250)]
        public string str_input
        {
            get
            {
                string value = _str_input;
                OnGetstr_input(ref value);
                return value;
            }
            set
            {
                if (_str_input != value)
                {
                  Onstr_inputChanging(ref value);
                  ReportPropertyChanging("str_input");
                  _str_input = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("str_input");
                  Onstr_inputChanged();
              }
            }
        }
        private string _str_input;
        partial void OnGetstr_input(ref string value);
        partial void Onstr_inputChanging(ref string value);
        partial void Onstr_inputChanged();
    
        /// <summary>
        /// There are no comments for str_output in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(200)]
        public string str_output
        {
            get
            {
                string value = _str_output;
                OnGetstr_output(ref value);
                return value;
            }
            set
            {
                if (_str_output != value)
                {
                  Onstr_outputChanging(ref value);
                  ReportPropertyChanging("str_output");
                  _str_output = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("str_output");
                  Onstr_outputChanged();
              }
            }
        }
        private string _str_output;
        partial void OnGetstr_output(ref string value);
        partial void Onstr_outputChanging(ref string value);
        partial void Onstr_outputChanged();
    
        /// <summary>
        /// There are no comments for validado in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> validado
        {
            get
            {
                global::System.Nullable<int> value = _validado;
                OnGetvalidado(ref value);
                return value;
            }
            set
            {
                if (_validado != value)
                {
                  OnvalidadoChanging(ref value);
                  ReportPropertyChanging("validado");
                  _validado = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("validado");
                  OnvalidadoChanged();
              }
            }
        }
        private global::System.Nullable<int> _validado = 0;
        partial void OnGetvalidado(ref global::System.Nullable<int> value);
        partial void OnvalidadoChanging(ref global::System.Nullable<int> value);
        partial void OnvalidadoChanged();
    
        /// <summary>
        /// There are no comments for USERNAME in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string USERNAME
        {
            get
            {
                string value = _USERNAME;
                OnGetUSERNAME(ref value);
                return value;
            }
            set
            {
                if (_USERNAME != value)
                {
                  OnUSERNAMEChanging(ref value);
                  ReportPropertyChanging("USERNAME");
                  _USERNAME = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("USERNAME");
                  OnUSERNAMEChanged();
              }
            }
        }
        private string _USERNAME;
        partial void OnGetUSERNAME(ref string value);
        partial void OnUSERNAMEChanging(ref string value);
        partial void OnUSERNAMEChanged();
    
        /// <summary>
        /// There are no comments for PASSWORD in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public string PASSWORD
        {
            get
            {
                string value = _PASSWORD;
                OnGetPASSWORD(ref value);
                return value;
            }
            set
            {
                if (_PASSWORD != value)
                {
                  OnPASSWORDChanging(ref value);
                  ReportPropertyChanging("PASSWORD");
                  _PASSWORD = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("PASSWORD");
                  OnPASSWORDChanged();
              }
            }
        }
        private string _PASSWORD;
        partial void OnGetPASSWORD(ref string value);
        partial void OnPASSWORDChanging(ref string value);
        partial void OnPASSWORDChanged();
    
        /// <summary>
        /// There are no comments for TIPO_PEDIDO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string TIPO_PEDIDO
        {
            get
            {
                string value = _TIPO_PEDIDO;
                OnGetTIPO_PEDIDO(ref value);
                return value;
            }
            set
            {
                if (_TIPO_PEDIDO != value)
                {
                  OnTIPO_PEDIDOChanging(ref value);
                  ReportPropertyChanging("TIPO_PEDIDO");
                  _TIPO_PEDIDO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TIPO_PEDIDO");
                  OnTIPO_PEDIDOChanged();
              }
            }
        }
        private string _TIPO_PEDIDO = @"N'H";
        partial void OnGetTIPO_PEDIDO(ref string value);
        partial void OnTIPO_PEDIDOChanging(ref string value);
        partial void OnTIPO_PEDIDOChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            tab_cert obj = new tab_cert();
            obj.spid = spid;
            obj.arm = arm;
            obj.tpdoc = tpdoc;
            obj.nrfact = nrfact;
            obj.TIPO = TIPO;
            obj.str_input = str_input;
            obj.str_output = str_output;
            obj.validado = validado;
            obj.USERNAME = USERNAME;
            obj.PASSWORD = PASSWORD;
            obj.TIPO_PEDIDO = TIPO_PEDIDO;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          tab_cert toCompare = obj as tab_cert;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.spid, toCompare.spid))
            return false;
          if (!Object.Equals(this.arm, toCompare.arm))
            return false;
          if (!Object.Equals(this.tpdoc, toCompare.tpdoc))
            return false;
          if (!Object.Equals(this.nrfact, toCompare.nrfact))
            return false;
          if (!Object.Equals(this.TIPO, toCompare.TIPO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + spid.GetHashCode();
          hashCode = (hashCode * 7) + arm.GetHashCode();
          hashCode = (hashCode * 7) + tpdoc.GetHashCode();
          hashCode = (hashCode * 7) + nrfact.GetHashCode();
          hashCode = (hashCode * 7) + TIPO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
