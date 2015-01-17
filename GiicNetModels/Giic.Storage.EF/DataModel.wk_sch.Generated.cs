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
    /// There are no comments for DataGiic_LiagoModel.wk_sch in the schema.
    /// </summary>
    /// <KeyProperties>
    /// fase
    /// seq
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="wk_sch")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class wk_sch : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new wk_sch object.
        /// </summary>
        /// <param name="fase">Initial value of fase.</param>
        /// <param name="seq">Initial value of seq.</param>
        /// <param name="orderid">Initial value of orderid.</param>
        /// <param name="start">Initial value of start.</param>
        /// <param name="finish">Initial value of finish.</param>
        public static wk_sch Createwk_sch(int fase, int seq, int orderid, decimal start, decimal finish)
        {
            wk_sch wk_sch = new wk_sch();
            wk_sch.fase = fase;
            wk_sch.seq = seq;
            wk_sch.orderid = orderid;
            wk_sch.start = start;
            wk_sch.finish = finish;
            return wk_sch;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for fase in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int fase
        {
            get
            {
                int value = _fase;
                OnGetfase(ref value);
                return value;
            }
            set
            {
                if (_fase != value)
                {
                  OnfaseChanging(ref value);
                  ReportPropertyChanging("fase");
                  _fase = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("fase");
                  OnfaseChanged();
              }
            }
        }
        private int _fase;
        partial void OnGetfase(ref int value);
        partial void OnfaseChanging(ref int value);
        partial void OnfaseChanged();
    
        /// <summary>
        /// There are no comments for seq in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int seq
        {
            get
            {
                int value = _seq;
                OnGetseq(ref value);
                return value;
            }
            set
            {
                if (_seq != value)
                {
                  OnseqChanging(ref value);
                  ReportPropertyChanging("seq");
                  _seq = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("seq");
                  OnseqChanged();
              }
            }
        }
        private int _seq;
        partial void OnGetseq(ref int value);
        partial void OnseqChanging(ref int value);
        partial void OnseqChanged();
    
        /// <summary>
        /// There are no comments for orderid in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public int orderid
        {
            get
            {
                int value = _orderid;
                OnGetorderid(ref value);
                return value;
            }
            set
            {
                if (_orderid != value)
                {
                  OnorderidChanging(ref value);
                  ReportPropertyChanging("orderid");
                  _orderid = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("orderid");
                  OnorderidChanged();
              }
            }
        }
        private int _orderid;
        partial void OnGetorderid(ref int value);
        partial void OnorderidChanging(ref int value);
        partial void OnorderidChanged();
    
        /// <summary>
        /// There are no comments for start in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public decimal start
        {
            get
            {
                decimal value = _start;
                OnGetstart(ref value);
                return value;
            }
            set
            {
                if (_start != value)
                {
                  OnstartChanging(ref value);
                  ReportPropertyChanging("start");
                  _start = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("start");
                  OnstartChanged();
              }
            }
        }
        private decimal _start;
        partial void OnGetstart(ref decimal value);
        partial void OnstartChanging(ref decimal value);
        partial void OnstartChanged();
    
        /// <summary>
        /// There are no comments for finish in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Required()]
        public decimal finish
        {
            get
            {
                decimal value = _finish;
                OnGetfinish(ref value);
                return value;
            }
            set
            {
                if (_finish != value)
                {
                  OnfinishChanging(ref value);
                  ReportPropertyChanging("finish");
                  _finish = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("finish");
                  OnfinishChanged();
              }
            }
        }
        private decimal _finish;
        partial void OnGetfinish(ref decimal value);
        partial void OnfinishChanging(ref decimal value);
        partial void OnfinishChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            wk_sch obj = new wk_sch();
            obj.fase = fase;
            obj.seq = seq;
            obj.orderid = orderid;
            obj.start = start;
            obj.finish = finish;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          wk_sch toCompare = obj as wk_sch;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.fase, toCompare.fase))
            return false;
          if (!Object.Equals(this.seq, toCompare.seq))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + fase.GetHashCode();
          hashCode = (hashCode * 7) + seq.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
