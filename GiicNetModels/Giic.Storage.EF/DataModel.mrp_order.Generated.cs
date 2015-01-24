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
    /// There are no comments for DataGiic_LiagoModel.mrp_order in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Order_Id
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="mrp_order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class mrp_order : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new mrp_order object.
        /// </summary>
        /// <param name="order_Id">Initial value of Order_Id.</param>
        public static mrp_order Createmrp_order(int order_Id)
        {
            mrp_order mrp_order = new mrp_order();
            mrp_order.Order_Id = order_Id;
            return mrp_order;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for Order_Id in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int Order_Id
        {
            get
            {
                int value = _Order_Id;
                OnGetOrder_Id(ref value);
                return value;
            }
            set
            {
                if (_Order_Id != value)
                {
                  OnOrder_IdChanging(ref value);
                  ReportPropertyChanging("Order_Id");
                  _Order_Id = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Order_Id");
                  OnOrder_IdChanged();
              }
            }
        }
        private int _Order_Id;
        partial void OnGetOrder_Id(ref int value);
        partial void OnOrder_IdChanging(ref int value);
        partial void OnOrder_IdChanged();
    
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string Order
        {
            get
            {
                string value = _Order;
                OnGetOrder(ref value);
                return value;
            }
            set
            {
                if (_Order != value)
                {
                  OnOrderChanging(ref value);
                  ReportPropertyChanging("Order");
                  _Order = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Order");
                  OnOrderChanged();
              }
            }
        }
        private string _Order;
        partial void OnGetOrder(ref string value);
        partial void OnOrderChanging(ref string value);
        partial void OnOrderChanged();
    
        /// <summary>
        /// There are no comments for Priority in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> Priority
        {
            get
            {
                global::System.Nullable<int> value = _Priority;
                OnGetPriority(ref value);
                return value;
            }
            set
            {
                if (_Priority != value)
                {
                  OnPriorityChanging(ref value);
                  ReportPropertyChanging("Priority");
                  _Priority = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Priority");
                  OnPriorityChanged();
              }
            }
        }
        private global::System.Nullable<int> _Priority;
        partial void OnGetPriority(ref global::System.Nullable<int> value);
        partial void OnPriorityChanging(ref global::System.Nullable<int> value);
        partial void OnPriorityChanged();
    
        /// <summary>
        /// There are no comments for DueDate in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> DueDate
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _DueDate;
                OnGetDueDate(ref value);
                return value;
            }
            set
            {
                if (_DueDate != value)
                {
                  OnDueDateChanging(ref value);
                  ReportPropertyChanging("DueDate");
                  _DueDate = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DueDate");
                  OnDueDateChanged();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _DueDate;
        partial void OnGetDueDate(ref global::System.Nullable<System.DateTime> value);
        partial void OnDueDateChanging(ref global::System.Nullable<System.DateTime> value);
        partial void OnDueDateChanged();
    
        /// <summary>
        /// There are no comments for Scheduleorder in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> Scheduleorder
        {
            get
            {
                global::System.Nullable<int> value = _Scheduleorder;
                OnGetScheduleorder(ref value);
                return value;
            }
            set
            {
                if (_Scheduleorder != value)
                {
                  OnScheduleorderChanging(ref value);
                  ReportPropertyChanging("Scheduleorder");
                  _Scheduleorder = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Scheduleorder");
                  OnScheduleorderChanged();
              }
            }
        }
        private global::System.Nullable<int> _Scheduleorder;
        partial void OnGetScheduleorder(ref global::System.Nullable<int> value);
        partial void OnScheduleorderChanging(ref global::System.Nullable<int> value);
        partial void OnScheduleorderChanged();
    
        /// <summary>
        /// There are no comments for KeyOrder in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public string KeyOrder
        {
            get
            {
                string value = _KeyOrder;
                OnGetKeyOrder(ref value);
                return value;
            }
            set
            {
                if (_KeyOrder != value)
                {
                  OnKeyOrderChanging(ref value);
                  ReportPropertyChanging("KeyOrder");
                  _KeyOrder = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("KeyOrder");
                  OnKeyOrderChanged();
              }
            }
        }
        private string _KeyOrder;
        partial void OnGetKeyOrder(ref string value);
        partial void OnKeyOrderChanging(ref string value);
        partial void OnKeyOrderChanged();
    
        /// <summary>
        /// There are no comments for Mat in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> Mat
        {
            get
            {
                global::System.Nullable<bool> value = _Mat;
                OnGetMat(ref value);
                return value;
            }
            set
            {
                if (_Mat != value)
                {
                  OnMatChanging(ref value);
                  ReportPropertyChanging("Mat");
                  _Mat = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Mat");
                  OnMatChanged();
              }
            }
        }
        private global::System.Nullable<bool> _Mat;
        partial void OnGetMat(ref global::System.Nullable<bool> value);
        partial void OnMatChanging(ref global::System.Nullable<bool> value);
        partial void OnMatChanged();
    
        /// <summary>
        /// There are no comments for modelo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(10)]
        public string modelo
        {
            get
            {
                string value = _modelo;
                OnGetmodelo(ref value);
                return value;
            }
            set
            {
                if (_modelo != value)
                {
                  OnmodeloChanging(ref value);
                  ReportPropertyChanging("modelo");
                  _modelo = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("modelo");
                  OnmodeloChanged();
              }
            }
        }
        private string _modelo;
        partial void OnGetmodelo(ref string value);
        partial void OnmodeloChanging(ref string value);
        partial void OnmodeloChanged();
    
        /// <summary>
        /// There are no comments for variante in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string variante
        {
            get
            {
                string value = _variante;
                OnGetvariante(ref value);
                return value;
            }
            set
            {
                if (_variante != value)
                {
                  OnvarianteChanging(ref value);
                  ReportPropertyChanging("variante");
                  _variante = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("variante");
                  OnvarianteChanged();
              }
            }
        }
        private string _variante;
        partial void OnGetvariante(ref string value);
        partial void OnvarianteChanging(ref string value);
        partial void OnvarianteChanged();
    
        /// <summary>
        /// There are no comments for qt in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> qt
        {
            get
            {
                global::System.Nullable<int> value = _qt;
                OnGetqt(ref value);
                return value;
            }
            set
            {
                if (_qt != value)
                {
                  OnqtChanging(ref value);
                  ReportPropertyChanging("qt");
                  _qt = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("qt");
                  OnqtChanged();
              }
            }
        }
        private global::System.Nullable<int> _qt;
        partial void OnGetqt(ref global::System.Nullable<int> value);
        partial void OnqtChanging(ref global::System.Nullable<int> value);
        partial void OnqtChanged();
    
        /// <summary>
        /// There are no comments for stat in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public string stat
        {
            get
            {
                string value = _stat;
                OnGetstat(ref value);
                return value;
            }
            set
            {
                if (_stat != value)
                {
                  OnstatChanging(ref value);
                  ReportPropertyChanging("stat");
                  _stat = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("stat");
                  OnstatChanged();
              }
            }
        }
        private string _stat;
        partial void OnGetstat(ref string value);
        partial void OnstatChanging(ref string value);
        partial void OnstatChanged();
    
        /// <summary>
        /// There are no comments for tipo in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(2)]
        public string tipo
        {
            get
            {
                string value = _tipo;
                OnGettipo(ref value);
                return value;
            }
            set
            {
                if (_tipo != value)
                {
                  OntipoChanging(ref value);
                  ReportPropertyChanging("tipo");
                  _tipo = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("tipo");
                  OntipoChanged();
              }
            }
        }
        private string _tipo;
        partial void OnGettipo(ref string value);
        partial void OntipoChanging(ref string value);
        partial void OntipoChanged();
    
        /// <summary>
        /// There are no comments for nrenco in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string nrenco
        {
            get
            {
                string value = _nrenco;
                OnGetnrenco(ref value);
                return value;
            }
            set
            {
                if (_nrenco != value)
                {
                  OnnrencoChanging(ref value);
                  ReportPropertyChanging("nrenco");
                  _nrenco = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("nrenco");
                  OnnrencoChanged();
              }
            }
        }
        private string _nrenco;
        partial void OnGetnrenco(ref string value);
        partial void OnnrencoChanging(ref string value);
        partial void OnnrencoChanged();
    
        /// <summary>
        /// There are no comments for lnenco in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> lnenco
        {
            get
            {
                global::System.Nullable<int> value = _lnenco;
                OnGetlnenco(ref value);
                return value;
            }
            set
            {
                if (_lnenco != value)
                {
                  OnlnencoChanging(ref value);
                  ReportPropertyChanging("lnenco");
                  _lnenco = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("lnenco");
                  OnlnencoChanged();
              }
            }
        }
        private global::System.Nullable<int> _lnenco;
        partial void OnGetlnenco(ref global::System.Nullable<int> value);
        partial void OnlnencoChanging(ref global::System.Nullable<int> value);
        partial void OnlnencoChanged();
    
        /// <summary>
        /// There are no comments for PRIORIDADE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> PRIORIDADE
        {
            get
            {
                global::System.Nullable<int> value = _PRIORIDADE;
                OnGetPRIORIDADE(ref value);
                return value;
            }
            set
            {
                if (_PRIORIDADE != value)
                {
                  OnPRIORIDADEChanging(ref value);
                  ReportPropertyChanging("PRIORIDADE");
                  _PRIORIDADE = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("PRIORIDADE");
                  OnPRIORIDADEChanged();
              }
            }
        }
        private global::System.Nullable<int> _PRIORIDADE;
        partial void OnGetPRIORIDADE(ref global::System.Nullable<int> value);
        partial void OnPRIORIDADEChanging(ref global::System.Nullable<int> value);
        partial void OnPRIORIDADEChanged();
    
        /// <summary>
        /// There are no comments for NR_FOLDER_PLN in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        public string NR_FOLDER_PLN
        {
            get
            {
                string value = _NR_FOLDER_PLN;
                OnGetNR_FOLDER_PLN(ref value);
                return value;
            }
            set
            {
                if (_NR_FOLDER_PLN != value)
                {
                  OnNR_FOLDER_PLNChanging(ref value);
                  ReportPropertyChanging("NR_FOLDER_PLN");
                  _NR_FOLDER_PLN = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NR_FOLDER_PLN");
                  OnNR_FOLDER_PLNChanged();
              }
            }
        }
        private string _NR_FOLDER_PLN;
        partial void OnGetNR_FOLDER_PLN(ref string value);
        partial void OnNR_FOLDER_PLNChanging(ref string value);
        partial void OnNR_FOLDER_PLNChanged();
    
        /// <summary>
        /// There are no comments for COR in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(15)]
        public string COR
        {
            get
            {
                string value = _COR;
                OnGetCOR(ref value);
                return value;
            }
            set
            {
                if (_COR != value)
                {
                  OnCORChanging(ref value);
                  ReportPropertyChanging("COR");
                  _COR = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("COR");
                  OnCORChanged();
              }
            }
        }
        private string _COR;
        partial void OnGetCOR(ref string value);
        partial void OnCORChanging(ref string value);
        partial void OnCORChanged();
    
        /// <summary>
        /// There are no comments for NOME_CLIENTE in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(35)]
        public string NOME_CLIENTE
        {
            get
            {
                string value = _NOME_CLIENTE;
                OnGetNOME_CLIENTE(ref value);
                return value;
            }
            set
            {
                if (_NOME_CLIENTE != value)
                {
                  OnNOME_CLIENTEChanging(ref value);
                  ReportPropertyChanging("NOME_CLIENTE");
                  _NOME_CLIENTE = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("NOME_CLIENTE");
                  OnNOME_CLIENTEChanged();
              }
            }
        }
        private string _NOME_CLIENTE;
        partial void OnGetNOME_CLIENTE(ref string value);
        partial void OnNOME_CLIENTEChanging(ref string value);
        partial void OnNOME_CLIENTEChanged();
    
        /// <summary>
        /// There are no comments for sequencia in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> sequencia
        {
            get
            {
                global::System.Nullable<int> value = _sequencia;
                OnGetsequencia(ref value);
                return value;
            }
            set
            {
                if (_sequencia != value)
                {
                  OnsequenciaChanging(ref value);
                  ReportPropertyChanging("sequencia");
                  _sequencia = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("sequencia");
                  OnsequenciaChanged();
              }
            }
        }
        private global::System.Nullable<int> _sequencia;
        partial void OnGetsequencia(ref global::System.Nullable<int> value);
        partial void OnsequenciaChanging(ref global::System.Nullable<int> value);
        partial void OnsequenciaChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            mrp_order obj = new mrp_order();
            obj.Order_Id = Order_Id;
            obj.Order = Order;
            obj.Priority = Priority;
            obj.DueDate = DueDate;
            obj.Scheduleorder = Scheduleorder;
            obj.KeyOrder = KeyOrder;
            obj.Mat = Mat;
            obj.modelo = modelo;
            obj.variante = variante;
            obj.qt = qt;
            obj.stat = stat;
            obj.tipo = tipo;
            obj.nrenco = nrenco;
            obj.lnenco = lnenco;
            obj.PRIORIDADE = PRIORIDADE;
            obj.NR_FOLDER_PLN = NR_FOLDER_PLN;
            obj.COR = COR;
            obj.NOME_CLIENTE = NOME_CLIENTE;
            obj.sequencia = sequencia;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          mrp_order toCompare = obj as mrp_order;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Order_Id, toCompare.Order_Id))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Order_Id.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}