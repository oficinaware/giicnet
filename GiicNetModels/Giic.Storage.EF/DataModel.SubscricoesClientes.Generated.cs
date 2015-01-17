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
    /// There are no comments for DataGiic_LiagoModel.SubscricoesClientes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CodSubscricao
    /// Cliente
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="DataGiic_LiagoModel", Name="SubscricoesClientes")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SubscricoesClientes : EntityObject, ICloneable    {
        #region Factory Method

        /// <summary>
        /// Create a new SubscricoesClientes object.
        /// </summary>
        /// <param name="codSubscricao">Initial value of CodSubscricao.</param>
        /// <param name="cliente">Initial value of Cliente.</param>
        public static SubscricoesClientes CreateSubscricoesClientes(string codSubscricao, string cliente)
        {
            SubscricoesClientes subscricoesClientes = new SubscricoesClientes();
            subscricoesClientes.CodSubscricao = codSubscricao;
            subscricoesClientes.Cliente = cliente;
            return subscricoesClientes;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for CodSubscricao in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string CodSubscricao
        {
            get
            {
                string value = _CodSubscricao;
                OnGetCodSubscricao(ref value);
                return value;
            }
            set
            {
                if (_CodSubscricao != value)
                {
                  OnCodSubscricaoChanging(ref value);
                  ReportPropertyChanging("CodSubscricao");
                  _CodSubscricao = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("CodSubscricao");
                  OnCodSubscricaoChanged();
              }
            }
        }
        private string _CodSubscricao = @"";
        partial void OnGetCodSubscricao(ref string value);
        partial void OnCodSubscricaoChanging(ref string value);
        partial void OnCodSubscricaoChanged();
    
        /// <summary>
        /// There are no comments for Cliente in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(5)]
        [System.ComponentModel.DataAnnotations.Required()]
        public string Cliente
        {
            get
            {
                string value = _Cliente;
                OnGetCliente(ref value);
                return value;
            }
            set
            {
                if (_Cliente != value)
                {
                  OnClienteChanging(ref value);
                  ReportPropertyChanging("Cliente");
                  _Cliente = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Cliente");
                  OnClienteChanged();
              }
            }
        }
        private string _Cliente = @"";
        partial void OnGetCliente(ref string value);
        partial void OnClienteChanging(ref string value);
        partial void OnClienteChanged();
    
        /// <summary>
        /// There are no comments for id in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.Guid> id
        {
            get
            {
                global::System.Nullable<System.Guid> value = _id;
                OnGetid(ref value);
                return value;
            }
            set
            {
                if (_id != value)
                {
                  OnidChanging(ref value);
                  ReportPropertyChanging("id");
                  _id = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("id");
                  OnidChanged();
              }
            }
        }
        private global::System.Nullable<System.Guid> _id;
        partial void OnGetid(ref global::System.Nullable<System.Guid> value);
        partial void OnidChanging(ref global::System.Nullable<System.Guid> value);
        partial void OnidChanged();
    
        /// <summary>
        /// There are no comments for report in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string report
        {
            get
            {
                string value = _report;
                OnGetreport(ref value);
                return value;
            }
            set
            {
                if (_report != value)
                {
                  OnreportChanging(ref value);
                  ReportPropertyChanging("report");
                  _report = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("report");
                  OnreportChanged();
              }
            }
        }
        private string _report;
        partial void OnGetreport(ref string value);
        partial void OnreportChanging(ref string value);
        partial void OnreportChanged();
    
        /// <summary>
        /// There are no comments for destinatario in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(80)]
        public string destinatario
        {
            get
            {
                string value = _destinatario;
                OnGetdestinatario(ref value);
                return value;
            }
            set
            {
                if (_destinatario != value)
                {
                  OndestinatarioChanging(ref value);
                  ReportPropertyChanging("destinatario");
                  _destinatario = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("destinatario");
                  OndestinatarioChanged();
              }
            }
        }
        private string _destinatario;
        partial void OnGetdestinatario(ref string value);
        partial void OndestinatarioChanging(ref string value);
        partial void OndestinatarioChanged();
    
        /// <summary>
        /// There are no comments for inclui_report in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> inclui_report
        {
            get
            {
                global::System.Nullable<bool> value = _inclui_report;
                OnGetinclui_report(ref value);
                return value;
            }
            set
            {
                if (_inclui_report != value)
                {
                  Oninclui_reportChanging(ref value);
                  ReportPropertyChanging("inclui_report");
                  _inclui_report = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("inclui_report");
                  Oninclui_reportChanged();
              }
            }
        }
        private global::System.Nullable<bool> _inclui_report;
        partial void OnGetinclui_report(ref global::System.Nullable<bool> value);
        partial void Oninclui_reportChanging(ref global::System.Nullable<bool> value);
        partial void Oninclui_reportChanged();
    
        /// <summary>
        /// There are no comments for RenderFormat in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string RenderFormat
        {
            get
            {
                string value = _RenderFormat;
                OnGetRenderFormat(ref value);
                return value;
            }
            set
            {
                if (_RenderFormat != value)
                {
                  OnRenderFormatChanging(ref value);
                  ReportPropertyChanging("RenderFormat");
                  _RenderFormat = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("RenderFormat");
                  OnRenderFormatChanged();
              }
            }
        }
        private string _RenderFormat;
        partial void OnGetRenderFormat(ref string value);
        partial void OnRenderFormatChanging(ref string value);
        partial void OnRenderFormatChanged();
    
        /// <summary>
        /// There are no comments for Inclui_Link in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<bool> Inclui_Link
        {
            get
            {
                global::System.Nullable<bool> value = _Inclui_Link;
                OnGetInclui_Link(ref value);
                return value;
            }
            set
            {
                if (_Inclui_Link != value)
                {
                  OnInclui_LinkChanging(ref value);
                  ReportPropertyChanging("Inclui_Link");
                  _Inclui_Link = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Inclui_Link");
                  OnInclui_LinkChanged();
              }
            }
        }
        private global::System.Nullable<bool> _Inclui_Link;
        partial void OnGetInclui_Link(ref global::System.Nullable<bool> value);
        partial void OnInclui_LinkChanging(ref global::System.Nullable<bool> value);
        partial void OnInclui_LinkChanged();
    
        /// <summary>
        /// There are no comments for param1 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string param1
        {
            get
            {
                string value = _param1;
                OnGetparam1(ref value);
                return value;
            }
            set
            {
                if (_param1 != value)
                {
                  Onparam1Changing(ref value);
                  ReportPropertyChanging("param1");
                  _param1 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("param1");
                  Onparam1Changed();
              }
            }
        }
        private string _param1;
        partial void OnGetparam1(ref string value);
        partial void Onparam1Changing(ref string value);
        partial void Onparam1Changed();
    
        /// <summary>
        /// There are no comments for param2 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string param2
        {
            get
            {
                string value = _param2;
                OnGetparam2(ref value);
                return value;
            }
            set
            {
                if (_param2 != value)
                {
                  Onparam2Changing(ref value);
                  ReportPropertyChanging("param2");
                  _param2 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("param2");
                  Onparam2Changed();
              }
            }
        }
        private string _param2;
        partial void OnGetparam2(ref string value);
        partial void Onparam2Changing(ref string value);
        partial void Onparam2Changed();
    
        /// <summary>
        /// There are no comments for param3 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string param3
        {
            get
            {
                string value = _param3;
                OnGetparam3(ref value);
                return value;
            }
            set
            {
                if (_param3 != value)
                {
                  Onparam3Changing(ref value);
                  ReportPropertyChanging("param3");
                  _param3 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("param3");
                  Onparam3Changed();
              }
            }
        }
        private string _param3;
        partial void OnGetparam3(ref string value);
        partial void Onparam3Changing(ref string value);
        partial void Onparam3Changed();
    
        /// <summary>
        /// There are no comments for param4 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string param4
        {
            get
            {
                string value = _param4;
                OnGetparam4(ref value);
                return value;
            }
            set
            {
                if (_param4 != value)
                {
                  Onparam4Changing(ref value);
                  ReportPropertyChanging("param4");
                  _param4 = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("param4");
                  Onparam4Changed();
              }
            }
        }
        private string _param4;
        partial void OnGetparam4(ref string value);
        partial void Onparam4Changing(ref string value);
        partial void Onparam4Changed();
    
        /// <summary>
        /// There are no comments for param10 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> param10
        {
            get
            {
                global::System.Nullable<decimal> value = _param10;
                OnGetparam10(ref value);
                return value;
            }
            set
            {
                if (_param10 != value)
                {
                  Onparam10Changing(ref value);
                  ReportPropertyChanging("param10");
                  _param10 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("param10");
                  Onparam10Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _param10;
        partial void OnGetparam10(ref global::System.Nullable<decimal> value);
        partial void Onparam10Changing(ref global::System.Nullable<decimal> value);
        partial void Onparam10Changed();
    
        /// <summary>
        /// There are no comments for param11 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> param11
        {
            get
            {
                global::System.Nullable<decimal> value = _param11;
                OnGetparam11(ref value);
                return value;
            }
            set
            {
                if (_param11 != value)
                {
                  Onparam11Changing(ref value);
                  ReportPropertyChanging("param11");
                  _param11 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("param11");
                  Onparam11Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _param11;
        partial void OnGetparam11(ref global::System.Nullable<decimal> value);
        partial void Onparam11Changing(ref global::System.Nullable<decimal> value);
        partial void Onparam11Changed();
    
        /// <summary>
        /// There are no comments for param12 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<decimal> param12
        {
            get
            {
                global::System.Nullable<decimal> value = _param12;
                OnGetparam12(ref value);
                return value;
            }
            set
            {
                if (_param12 != value)
                {
                  Onparam12Changing(ref value);
                  ReportPropertyChanging("param12");
                  _param12 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("param12");
                  Onparam12Changed();
              }
            }
        }
        private global::System.Nullable<decimal> _param12;
        partial void OnGetparam12(ref global::System.Nullable<decimal> value);
        partial void Onparam12Changing(ref global::System.Nullable<decimal> value);
        partial void Onparam12Changed();
    
        /// <summary>
        /// There are no comments for param21 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> param21
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _param21;
                OnGetparam21(ref value);
                return value;
            }
            set
            {
                if (_param21 != value)
                {
                  Onparam21Changing(ref value);
                  ReportPropertyChanging("param21");
                  _param21 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("param21");
                  Onparam21Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _param21;
        partial void OnGetparam21(ref global::System.Nullable<System.DateTime> value);
        partial void Onparam21Changing(ref global::System.Nullable<System.DateTime> value);
        partial void Onparam21Changed();
    
        /// <summary>
        /// There are no comments for param22 in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<System.DateTime> param22
        {
            get
            {
                global::System.Nullable<System.DateTime> value = _param22;
                OnGetparam22(ref value);
                return value;
            }
            set
            {
                if (_param22 != value)
                {
                  Onparam22Changing(ref value);
                  ReportPropertyChanging("param22");
                  _param22 = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("param22");
                  Onparam22Changed();
              }
            }
        }
        private global::System.Nullable<System.DateTime> _param22;
        partial void OnGetparam22(ref global::System.Nullable<System.DateTime> value);
        partial void Onparam22Changing(ref global::System.Nullable<System.DateTime> value);
        partial void Onparam22Changed();

        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            SubscricoesClientes obj = new SubscricoesClientes();
            obj.CodSubscricao = CodSubscricao;
            obj.Cliente = Cliente;
            obj.id = id;
            obj.report = report;
            obj.destinatario = destinatario;
            obj.inclui_report = inclui_report;
            obj.RenderFormat = RenderFormat;
            obj.Inclui_Link = Inclui_Link;
            obj.param1 = param1;
            obj.param2 = param2;
            obj.param3 = param3;
            obj.param4 = param4;
            obj.param10 = param10;
            obj.param11 = param11;
            obj.param12 = param12;
            obj.param21 = param21;
            obj.param22 = param22;
            return obj;
        }

        #endregion
    
        #region Equals and GetHashCode methods

        public override bool Equals(object obj)
        {
          SubscricoesClientes toCompare = obj as SubscricoesClientes;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CodSubscricao, toCompare.CodSubscricao))
            return false;
          if (!Object.Equals(this.Cliente, toCompare.Cliente))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CodSubscricao.GetHashCode();
          hashCode = (hashCode * 7) + Cliente.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
