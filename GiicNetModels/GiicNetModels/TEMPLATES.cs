//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiicNetModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class TEMPLATES
    {
        public string TEMPLATE { get; set; }
        public int POS { get; set; }
        public string PECA { get; set; }
        public Nullable<bool> COMERCIAL { get; set; }
        public Nullable<byte> ETIQ { get; set; }
        public Nullable<bool> GERA_COD { get; set; }
        public Nullable<bool> WEB { get; set; }
    
        public virtual PECAS PECAS { get; set; }
        public virtual TEMPLATES_CAB TEMPLATES_CAB { get; set; }
    }
}