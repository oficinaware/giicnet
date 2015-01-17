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
    /// There are no comments for DataGiic_LiagoModel.CARACT in the schema.
    /// </summary>
    /// <KeyProperties>
    /// MODELO
    /// VARIANTE
    /// POS
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="CARACT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CARACT : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new CARACT object.
        /// </summary>
        /// <param name="mODELO">Initial value of MODELO.</param>
        /// <param name="vARIANTE">Initial value of VARIANTE.</param>
        /// <param name="pOS">Initial value of POS.</param>
        /// <param name="fAMILIA">Initial value of FAMILIA.</param>
        public static CARACT CreateCARACT(string mODELO, string vARIANTE, int pOS, string fAMILIA)
        {
            CARACT cARACT = new CARACT();
            cARACT.MODELO = mODELO;
            cARACT.VARIANTE = vARIANTE;
            cARACT.POS = pOS;
            cARACT.FAMILIA = fAMILIA;
            return cARACT;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for MODELO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string MODELO
        {
            get
            {
                string value = _MODELO;
                OnGetMODELO(ref value);
                return value;
            }
            set
            {
                if (_MODELO != value)
                {
                  OnMODELOChanging(ref value);
                  ReportPropertyChanging("MODELO");
                  _MODELO = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("MODELO");
                  OnMODELOChanged();
              }
            }
        }
        private string _MODELO;
        partial void OnGetMODELO(ref string value);
        partial void OnMODELOChanging(ref string value);
        partial void OnMODELOChanged();
    
        /// <summary>
        /// There are no comments for VARIANTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        [System.ComponentModel.DataAnnotations.Required()]
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
                  _VARIANTE = StructuralObject.SetValidValue(value, false);
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
        /// There are no comments for POS in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int POS
        {
            get
            {
                int value = _POS;
                OnGetPOS(ref value);
                return value;
            }
            set
            {
                if (_POS != value)
                {
                  OnPOSChanging(ref value);
                  ReportPropertyChanging("POS");
                  _POS = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("POS");
                  OnPOSChanged();
              }
            }
        }
        private int _POS;
        partial void OnGetPOS(ref int value);
        partial void OnPOSChanging(ref int value);
        partial void OnPOSChanged();
    
        /// <summary>
        /// There are no comments for COMPONENTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string COMPONENTE
        {
            get
            {
                string value = _COMPONENTE;
                OnGetCOMPONENTE(ref value);
                return value;
            }
            set
            {
                if (_COMPONENTE != value)
                {
                  OnCOMPONENTEChanging(ref value);
                  ReportPropertyChanging("COMPONENTE");
                  _COMPONENTE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COMPONENTE");
                  OnCOMPONENTEChanged();
              }
            }
        }
        private string _COMPONENTE;
        partial void OnGetCOMPONENTE(ref string value);
        partial void OnCOMPONENTEChanging(ref string value);
        partial void OnCOMPONENTEChanged();
    
        /// <summary>
        /// There are no comments for FAMILIA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string FAMILIA
        {
            get
            {
                string value = _FAMILIA;
                OnGetFAMILIA(ref value);
                return value;
            }
            set
            {
                if (_FAMILIA != value)
                {
                  OnFAMILIAChanging(ref value);
                  ReportPropertyChanging("FAMILIA");
                  _FAMILIA = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("FAMILIA");
                  OnFAMILIAChanged();
              }
            }
        }
        private string _FAMILIA;
        partial void OnGetFAMILIA(ref string value);
        partial void OnFAMILIAChanging(ref string value);
        partial void OnFAMILIAChanged();
    
        /// <summary>
        /// There are no comments for CARTAZ in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        public string CARTAZ
        {
            get
            {
                string value = _CARTAZ;
                OnGetCARTAZ(ref value);
                return value;
            }
            set
            {
                if (_CARTAZ != value)
                {
                  OnCARTAZChanging(ref value);
                  ReportPropertyChanging("CARTAZ");
                  _CARTAZ = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CARTAZ");
                  OnCARTAZChanged();
              }
            }
        }
        private string _CARTAZ = @"space(5)";
        partial void OnGetCARTAZ(ref string value);
        partial void OnCARTAZChanging(ref string value);
        partial void OnCARTAZChanged();
    
        /// <summary>
        /// There are no comments for CODCOR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string CODCOR
        {
            get
            {
                string value = _CODCOR;
                OnGetCODCOR(ref value);
                return value;
            }
            set
            {
                if (_CODCOR != value)
                {
                  OnCODCORChanging(ref value);
                  ReportPropertyChanging("CODCOR");
                  _CODCOR = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("CODCOR");
                  OnCODCORChanged();
              }
            }
        }
        private string _CODCOR = @"space(3)";
        partial void OnGetCODCOR(ref string value);
        partial void OnCODCORChanging(ref string value);
        partial void OnCODCORChanged();
    
        /// <summary>
        /// There are no comments for PERC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> PERC
        {
            get
            {
                global::System.Nullable<decimal> value = _PERC;
                OnGetPERC(ref value);
                return value;
            }
            set
            {
                if (_PERC != value)
                {
                  OnPERCChanging(ref value);
                  ReportPropertyChanging("PERC");
                  _PERC = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PERC");
                  OnPERCChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _PERC;
        partial void OnGetPERC(ref global::System.Nullable<decimal> value);
        partial void OnPERCChanging(ref global::System.Nullable<decimal> value);
        partial void OnPERCChanged();
    
        /// <summary>
        /// There are no comments for CONSUMO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> CONSUMO
        {
            get
            {
                global::System.Nullable<decimal> value = _CONSUMO;
                OnGetCONSUMO(ref value);
                return value;
            }
            set
            {
                if (_CONSUMO != value)
                {
                  OnCONSUMOChanging(ref value);
                  ReportPropertyChanging("CONSUMO");
                  _CONSUMO = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("CONSUMO");
                  OnCONSUMOChanged();
              }
            }
        }
        private global::System.Nullable<decimal> _CONSUMO;
        partial void OnGetCONSUMO(ref global::System.Nullable<decimal> value);
        partial void OnCONSUMOChanging(ref global::System.Nullable<decimal> value);
        partial void OnCONSUMOChanged();
    
        /// <summary>
        /// There are no comments for OPERACAO in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
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
                  _OPERACAO = StructuralObject.SetValidValue(value, true);
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
        /// There are no comments for PRESERIE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string PRESERIE
        {
            get
            {
                string value = _PRESERIE;
                OnGetPRESERIE(ref value);
                return value;
            }
            set
            {
                if (_PRESERIE != value)
                {
                  OnPRESERIEChanging(ref value);
                  ReportPropertyChanging("PRESERIE");
                  _PRESERIE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("PRESERIE");
                  OnPRESERIEChanged();
              }
            }
        }
        private string _PRESERIE;
        partial void OnGetPRESERIE(ref string value);
        partial void OnPRESERIEChanging(ref string value);
        partial void OnPRESERIEChanged();
    
        /// <summary>
        /// There are no comments for TC in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string TC
        {
            get
            {
                string value = _TC;
                OnGetTC(ref value);
                return value;
            }
            set
            {
                if (_TC != value)
                {
                  OnTCChanging(ref value);
                  ReportPropertyChanging("TC");
                  _TC = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("TC");
                  OnTCChanged();
              }
            }
        }
        private string _TC;
        partial void OnGetTC(ref string value);
        partial void OnTCChanging(ref string value);
        partial void OnTCChanged();
    
        /// <summary>
        /// There are no comments for OBSV in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string OBSV
        {
            get
            {
                string value = _OBSV;
                OnGetOBSV(ref value);
                return value;
            }
            set
            {
                if (_OBSV != value)
                {
                  OnOBSVChanging(ref value);
                  ReportPropertyChanging("OBSV");
                  _OBSV = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("OBSV");
                  OnOBSVChanged();
              }
            }
        }
        private string _OBSV;
        partial void OnGetOBSV(ref string value);
        partial void OnOBSVChanging(ref string value);
        partial void OnOBSVChanged();
    
        /// <summary>
        /// There are no comments for UTENTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string UTENTE
        {
            get
            {
                string value = _UTENTE;
                OnGetUTENTE(ref value);
                return value;
            }
            set
            {
                if (_UTENTE != value)
                {
                  OnUTENTEChanging(ref value);
                  ReportPropertyChanging("UTENTE");
                  _UTENTE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("UTENTE");
                  OnUTENTEChanged();
              }
            }
        }
        private string _UTENTE;
        partial void OnGetUTENTE(ref string value);
        partial void OnUTENTEChanging(ref string value);
        partial void OnUTENTEChanged();
    
        /// <summary>
        /// There are no comments for DATA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DATA
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DATA;
                OnGetDATA(ref value);
                return value;
            }
            set
            {
                if (_DATA != value)
                {
                  OnDATAChanging(ref value);
                  ReportPropertyChanging("DATA");
                  _DATA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DATA");
                  OnDATAChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DATA;
        partial void OnGetDATA(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDATAChanged();
    
        /// <summary>
        /// There are no comments for HORA in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> HORA
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _HORA;
                OnGetHORA(ref value);
                return value;
            }
            set
            {
                if (_HORA != value)
                {
                  OnHORAChanging(ref value);
                  ReportPropertyChanging("HORA");
                  _HORA = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("HORA");
                  OnHORAChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _HORA;
        partial void OnGetHORA(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORAChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnHORAChanged();
    
        /// <summary>
        /// There are no comments for DataUltAlt in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DataUltAlt
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DataUltAlt;
                OnGetDataUltAlt(ref value);
                return value;
            }
            set
            {
                if (_DataUltAlt != value)
                {
                  OnDataUltAltChanging(ref value);
                  ReportPropertyChanging("DataUltAlt");
                  _DataUltAlt = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DataUltAlt");
                  OnDataUltAltChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DataUltAlt = DateTime.Now;
        partial void OnGetDataUltAlt(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataUltAltChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDataUltAltChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for ARTIGOS in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_CARACT_ARTIGOS", "ARTIGOS")]
        public ARTIGOS ARTIGOS
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CARACT_ARTIGOS", "ARTIGOS").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CARACT_ARTIGOS", "ARTIGOS").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for ARTIGOS in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ARTIGOS> ARTIGOSReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CARACT_ARTIGOS", "ARTIGOS");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CARACT_ARTIGOS", "ARTIGOS", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ARTIGOS>("DataGiic_LiagoModel.FK_CARACT_ARTIGOS", "ARTIGOS").Value = null;
                }
            }
        }
    
        /// <summary>
        /// There are no comments for PECAS in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DataGiic_LiagoModel", "FK_CARACT_PECAS", "PECAS")]
        public PECAS PECAS
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<PECAS>("DataGiic_LiagoModel.FK_CARACT_PECAS", "PECAS").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<PECAS>("DataGiic_LiagoModel.FK_CARACT_PECAS", "PECAS").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for PECAS in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<PECAS> PECASReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<PECAS>("DataGiic_LiagoModel.FK_CARACT_PECAS", "PECAS");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<PECAS>("DataGiic_LiagoModel.FK_CARACT_PECAS", "PECAS", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<PECAS>("DataGiic_LiagoModel.FK_CARACT_PECAS", "PECAS").Value = null;
                }
            }
        }

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            CARACT obj = new CARACT();
            obj.MODELO = MODELO;
            obj.VARIANTE = VARIANTE;
            obj.POS = POS;
            obj.COMPONENTE = COMPONENTE;
            obj.FAMILIA = FAMILIA;
            obj.CARTAZ = CARTAZ;
            obj.CODCOR = CODCOR;
            obj.PERC = PERC;
            obj.CONSUMO = CONSUMO;
            obj.OPERACAO = OPERACAO;
            obj.PRESERIE = PRESERIE;
            obj.TC = TC;
            obj.OBSV = OBSV;
            obj.UTENTE = UTENTE;
            obj.DATA = DATA;
            obj.HORA = HORA;
            obj.DataUltAlt = DataUltAlt;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          CARACT toCompare = obj as CARACT;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.MODELO, toCompare.MODELO))
            return false;
          if (!Object.Equals(this.VARIANTE, toCompare.VARIANTE))
            return false;
          if (!Object.Equals(this.POS, toCompare.POS))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + MODELO.GetHashCode();
          hashCode = (hashCode * 7) + VARIANTE.GetHashCode();
          hashCode = (hashCode * 7) + POS.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
