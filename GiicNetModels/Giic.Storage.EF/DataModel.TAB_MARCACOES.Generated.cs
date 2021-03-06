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
    /// There are no comments for DataGiic_LiagoModel.TAB_MARCACOES in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ARM
    /// DATA_REF
    /// CODFUNC
    /// NR_MARCACAO
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="TAB_MARCACOES")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TAB_MARCACOES : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new TAB_MARCACOES object.
        /// </summary>
        /// <param name="aRM">Initial value of ARM.</param>
        /// <param name="dATA_REF">Initial value of DATA_REF.</param>
        /// <param name="cODFUNC">Initial value of CODFUNC.</param>
        /// <param name="nR_MARCACAO">Initial value of NR_MARCACAO.</param>
        public static TAB_MARCACOES CreateTAB_MARCACOES(string aRM, global::System.DateTime dATA_REF, string cODFUNC, int nR_MARCACAO)
        {
            TAB_MARCACOES tAB_MARCACOES = new TAB_MARCACOES();
            tAB_MARCACOES.ARM = aRM;
            tAB_MARCACOES.DATA_REF = dATA_REF;
            tAB_MARCACOES.CODFUNC = cODFUNC;
            tAB_MARCACOES.NR_MARCACAO = nR_MARCACAO;
            return tAB_MARCACOES;
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
        /// There are no comments for DATA_REF in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public global::System.DateTime DATA_REF
        {
            get
            {
                global::System.DateTime value = _DATA_REF;
                OnGetDATA_REF(ref value);
                return value;
            }
            set
            {
                if (_DATA_REF != value)
                {
                  OnDATA_REFChanging(ref value);
                  ReportPropertyChanging("DATA_REF");
                  _DATA_REF = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_REF");
                  OnDATA_REFChanged();
              }
            }
        }
        private global::System.DateTime _DATA_REF;
        partial void OnGetDATA_REF(ref global::System.DateTime value);
        partial void OnDATA_REFChanging(ref global::System.DateTime value);
        partial void OnDATA_REFChanged();
    
        /// <summary>
        /// There are no comments for CODFUNC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CODFUNC
        {
            get
            {
                string value = _CODFUNC;
                OnGetCODFUNC(ref value);
                return value;
            }
            set
            {
                if (_CODFUNC != value)
                {
                  OnCODFUNCChanging(ref value);
                  ReportPropertyChanging("CODFUNC");
                  _CODFUNC = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CODFUNC");
                  OnCODFUNCChanged();
              }
            }
        }
        private string _CODFUNC;
        partial void OnGetCODFUNC(ref string value);
        partial void OnCODFUNCChanging(ref string value);
        partial void OnCODFUNCChanged();
    
        /// <summary>
        /// There are no comments for NR_MARCACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int NR_MARCACAO
        {
            get
            {
                int value = _NR_MARCACAO;
                OnGetNR_MARCACAO(ref value);
                return value;
            }
            set
            {
                if (_NR_MARCACAO != value)
                {
                  OnNR_MARCACAOChanging(ref value);
                  ReportPropertyChanging("NR_MARCACAO");
                  _NR_MARCACAO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("NR_MARCACAO");
                  OnNR_MARCACAOChanged();
              }
            }
        }
        private int _NR_MARCACAO;
        partial void OnGetNR_MARCACAO(ref int value);
        partial void OnNR_MARCACAOChanging(ref int value);
        partial void OnNR_MARCACAOChanged();
    
        /// <summary>
        /// There are no comments for COD_TURNO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string COD_TURNO
        {
            get
            {
                string value = _COD_TURNO;
                OnGetCOD_TURNO(ref value);
                return value;
            }
            set
            {
                if (_COD_TURNO != value)
                {
                  OnCOD_TURNOChanging(ref value);
                  ReportPropertyChanging("COD_TURNO");
                  _COD_TURNO = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COD_TURNO");
                  OnCOD_TURNOChanged();
              }
            }
        }
        private string _COD_TURNO;
        partial void OnGetCOD_TURNO(ref string value);
        partial void OnCOD_TURNOChanging(ref string value);
        partial void OnCOD_TURNOChanged();
    
        /// <summary>
        /// There are no comments for DATA_E in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_E
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_E;
                OnGetDATA_E(ref value);
                return value;
            }
            set
            {
                if (_DATA_E != value)
                {
                  OnDATA_EChanging(ref value);
                  ReportPropertyChanging("DATA_E");
                  _DATA_E = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_E");
                  OnDATA_EChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_E;
        partial void OnGetDATA_E(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_EChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_EChanged();
    
        /// <summary>
        /// There are no comments for DATA_S in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA_S
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA_S;
                OnGetDATA_S(ref value);
                return value;
            }
            set
            {
                if (_DATA_S != value)
                {
                  OnDATA_SChanging(ref value);
                  ReportPropertyChanging("DATA_S");
                  _DATA_S = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA_S");
                  OnDATA_SChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA_S;
        partial void OnGetDATA_S(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_SChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATA_SChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            TAB_MARCACOES obj = new TAB_MARCACOES();
            obj.ARM = ARM;
            obj.DATA_REF = DATA_REF;
            obj.CODFUNC = CODFUNC;
            obj.NR_MARCACAO = NR_MARCACAO;
            obj.COD_TURNO = COD_TURNO;
            obj.DATA_E = DATA_E;
            obj.DATA_S = DATA_S;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          TAB_MARCACOES toCompare = obj as TAB_MARCACOES;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ARM, toCompare.ARM))
            return false;
          if (!Object.Equals(this.DATA_REF, toCompare.DATA_REF))
            return false;
          if (!Object.Equals(this.CODFUNC, toCompare.CODFUNC))
            return false;
          if (!Object.Equals(this.NR_MARCACAO, toCompare.NR_MARCACAO))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ARM.GetHashCode();
          hashCode = (hashCode * 7) + DATA_REF.GetHashCode();
          hashCode = (hashCode * 7) + CODFUNC.GetHashCode();
          hashCode = (hashCode * 7) + NR_MARCACAO.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
