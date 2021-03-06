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
    /// There are no comments for DataGiic_LiagoModel.input_etiq in the schema.
    /// </summary>
    /// <KeyProperties>
    /// spid
    /// donr
    /// daln
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="input_etiq")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class input_etiq : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new input_etiq object.
        /// </summary>
        /// <param name="spid">Initial value of spid.</param>
        /// <param name="donr">Initial value of donr.</param>
        /// <param name="daln">Initial value of daln.</param>
        public static input_etiq Createinput_etiq(int spid, string donr, int daln)
        {
            input_etiq input_etiq = new input_etiq();
            input_etiq.spid = spid;
            input_etiq.donr = donr;
            input_etiq.daln = daln;
            return input_etiq;
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
        /// There are no comments for donr in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string donr
        {
            get
            {
                string value = _donr;
                OnGetdonr(ref value);
                return value;
            }
            set
            {
                if (_donr != value)
                {
                  OndonrChanging(ref value);
                  ReportPropertyChanging("donr");
                  _donr = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("donr");
                  OndonrChanged();
              }
            }
        }
        private string _donr;
        partial void OnGetdonr(ref string value);
        partial void OndonrChanging(ref string value);
        partial void OndonrChanged();
    
        /// <summary>
        /// There are no comments for daln in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public int daln
        {
            get
            {
                int value = _daln;
                OnGetdaln(ref value);
                return value;
            }
            set
            {
                if (_daln != value)
                {
                  OndalnChanging(ref value);
                  ReportPropertyChanging("daln");
                  _daln = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("daln");
                  OndalnChanged();
              }
            }
        }
        private int _daln;
        partial void OnGetdaln(ref int value);
        partial void OndalnChanging(ref int value);
        partial void OndalnChanged();
    
        /// <summary>
        /// There are no comments for atenr in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public string atenr
        {
            get
            {
                string value = _atenr;
                OnGetatenr(ref value);
                return value;
            }
            set
            {
                if (_atenr != value)
                {
                  OnatenrChanging(ref value);
                  ReportPropertyChanging("atenr");
                  _atenr = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("atenr");
                  OnatenrChanged();
              }
            }
        }
        private string _atenr;
        partial void OnGetatenr(ref string value);
        partial void OnatenrChanging(ref string value);
        partial void OnatenrChanged();
    
        /// <summary>
        /// There are no comments for ateln in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> ateln
        {
            get
            {
                global::System.Nullable<int> value = _ateln;
                OnGetateln(ref value);
                return value;
            }
            set
            {
                if (_ateln != value)
                {
                  OnatelnChanging(ref value);
                  ReportPropertyChanging("ateln");
                  _ateln = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ateln");
                  OnatelnChanged();
              }
            }
        }
        private global::System.Nullable<int> _ateln;
        partial void OnGetateln(ref global::System.Nullable<int> value);
        partial void OnatelnChanging(ref global::System.Nullable<int> value);
        partial void OnatelnChanged();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            input_etiq obj = new input_etiq();
            obj.spid = spid;
            obj.donr = donr;
            obj.daln = daln;
            obj.atenr = atenr;
            obj.ateln = ateln;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          input_etiq toCompare = obj as input_etiq;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.spid, toCompare.spid))
            return false;
          if (!Object.Equals(this.donr, toCompare.donr))
            return false;
          if (!Object.Equals(this.daln, toCompare.daln))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + spid.GetHashCode();
          hashCode = (hashCode * 7) + donr.GetHashCode();
          hashCode = (hashCode * 7) + daln.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
