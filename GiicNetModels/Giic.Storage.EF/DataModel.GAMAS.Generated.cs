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
    /// There are no comments for DataGiic_LiagoModel.GAMAS in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CODROTA
    /// OPERACAO
    /// SEQ
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="GAMAS")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class GAMAS : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new GAMAS object.
        /// </summary>
        /// <param name="cODROTA">Initial value of CODROTA.</param>
        /// <param name="oPERACAO">Initial value of OPERACAO.</param>
        /// <param name="sEQ">Initial value of SEQ.</param>
        public static GAMAS CreateGAMAS(string cODROTA, string oPERACAO, int sEQ)
        {
            GAMAS gAMAS = new GAMAS();
            gAMAS.CODROTA = cODROTA;
            gAMAS.OPERACAO = oPERACAO;
            gAMAS.SEQ = sEQ;
            return gAMAS;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CODROTA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODROTA
        {
            get
            {
                string value = _CODROTA;
                OnGetCODROTA(ref value);
                return value;
            }
            set
            {
                if (_CODROTA != value)
                {
                  OnCODROTAChanging(ref value);
                  ReportPropertyChanging("CODROTA");
                  _CODROTA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODROTA");
                  OnCODROTAChanged();
              }
            }
        }
        private string _CODROTA;
        partial void OnGetCODROTA(ref string value);
        partial void OnCODROTAChanging(ref string value);
        partial void OnCODROTAChanged();
    
        /// <summary>
        /// There are no comments for OPERACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string OPERACAO
        {
            get
            {
                string value = _OPERACAO;
                OnGetOPERACAO(ref value);
                return value;
            }
            set
            {
                if (_OPERACAO != value)
                {
                  OnOPERACAOChanging(ref value);
                  ReportPropertyChanging("OPERACAO");
                  _OPERACAO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("OPERACAO");
                  OnOPERACAOChanged();
              }
            }
        }
        private string _OPERACAO;
        partial void OnGetOPERACAO(ref string value);
        partial void OnOPERACAOChanging(ref string value);
        partial void OnOPERACAOChanged();
    
        /// <summary>
        /// There are no comments for SEQ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int SEQ
        {
            get
            {
                int value = _SEQ;
                OnGetSEQ(ref value);
                return value;
            }
            set
            {
                if (_SEQ != value)
                {
                  OnSEQChanging(ref value);
                  ReportPropertyChanging("SEQ");
                  _SEQ = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("SEQ");
                  OnSEQChanged();
              }
            }
        }
        private int _SEQ;
        partial void OnGetSEQ(ref int value);
        partial void OnSEQChanging(ref int value);
        partial void OnSEQChanged();
    
        /// <summary>
        /// There are no comments for VARIANTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string VARIANTE
        {
            get
            {
                string value = _VARIANTE;
                OnGetVARIANTE(ref value);
                return value;
            }
            set
            {
                if (_VARIANTE != value)
                {
                  OnVARIANTEChanging(ref value);
                  ReportPropertyChanging("VARIANTE");
                  _VARIANTE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("VARIANTE");
                  OnVARIANTEChanged();
              }
            }
        }
        private string _VARIANTE;
        partial void OnGetVARIANTE(ref string value);
        partial void OnVARIANTEChanging(ref string value);
        partial void OnVARIANTEChanged();
    
        /// <summary>
        /// There are no comments for idopc in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string idopc
        {
            get
            {
                string value = _idopc;
                OnGetidopc(ref value);
                return value;
            }
            set
            {
                if (_idopc != value)
                {
                  OnidopcChanging(ref value);
                  ReportPropertyChanging("idopc");
                  _idopc = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("idopc");
                  OnidopcChanged();
              }
            }
        }
        private string _idopc;
        partial void OnGetidopc(ref string value);
        partial void OnidopcChanging(ref string value);
        partial void OnidopcChanged();
    
        /// <summary>
        /// There are no comments for DESCRICAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(60)]
        public string DESCRICAO
        {
            get
            {
                string value = _DESCRICAO;
                OnGetDESCRICAO(ref value);
                return value;
            }
            set
            {
                if (_DESCRICAO != value)
                {
                  OnDESCRICAOChanging(ref value);
                  ReportPropertyChanging("DESCRICAO");
                  _DESCRICAO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("DESCRICAO");
                  OnDESCRICAOChanged();
              }
            }
        }
        private string _DESCRICAO;
        partial void OnGetDESCRICAO(ref string value);
        partial void OnDESCRICAOChanging(ref string value);
        partial void OnDESCRICAOChanged();
    
        /// <summary>
        /// There are no comments for TEMPO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> TEMPO
        {
            get
            {
                global::System.Nullable<decimal> value = _TEMPO;
                OnGetTEMPO(ref value);
                return value;
            }
            set
            {
                if (_TEMPO != value)
                {
                  OnTEMPOChanging(ref value);
                  ReportPropertyChanging("TEMPO");
                  _TEMPO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("TEMPO");
                  OnTEMPOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _TEMPO = 0m;
        partial void OnGetTEMPO(ref global::System.Nullable<decimal> value);
        partial void OnTEMPOChanging(ref global::System.Nullable<decimal> value);
        partial void OnTEMPOChanged();
    
        /// <summary>
        /// There are no comments for TIPOMAQ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string TIPOMAQ
        {
            get
            {
                string value = _TIPOMAQ;
                OnGetTIPOMAQ(ref value);
                return value;
            }
            set
            {
                if (_TIPOMAQ != value)
                {
                  OnTIPOMAQChanging(ref value);
                  ReportPropertyChanging("TIPOMAQ");
                  _TIPOMAQ = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TIPOMAQ");
                  OnTIPOMAQChanged();
              }
            }
        }
        private string _TIPOMAQ;
        partial void OnGetTIPOMAQ(ref string value);
        partial void OnTIPOMAQChanging(ref string value);
        partial void OnTIPOMAQChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            GAMAS obj = new GAMAS();
            obj.CODROTA = CODROTA;
            obj.OPERACAO = OPERACAO;
            obj.SEQ = SEQ;
            obj.VARIANTE = VARIANTE;
            obj.idopc = idopc;
            obj.DESCRICAO = DESCRICAO;
            obj.TEMPO = TEMPO;
            obj.TIPOMAQ = TIPOMAQ;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          GAMAS toCompare = obj as GAMAS;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CODROTA, toCompare.CODROTA))
            return false;
          if (!Object.Equals(this.OPERACAO, toCompare.OPERACAO))
            return false;
          if (!Object.Equals(this.SEQ, toCompare.SEQ))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CODROTA.GetHashCode();
          hashCode = (hashCode * 7) + OPERACAO.GetHashCode();
          hashCode = (hashCode * 7) + SEQ.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
