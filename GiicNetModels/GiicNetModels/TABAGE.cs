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
    
    public partial class TABAGE : Base
    {
        public TABAGE()
        {
            this.TABAGE1 = new HashSet<TABAGE>();
            this.CLIENTES = new HashSet<CLIENTES>();
        }
    
        public string AGENTE { get; set; }
        public string NOME { get; set; }
        public string MORADA1 { get; set; }
        public string MORADA2 { get; set; }
        public string MORADA3 { get; set; }
        public string MORADA4 { get; set; }
        public Nullable<decimal> COMISSAO { get; set; }
        public string TELEF { get; set; }
        public string FAX { get; set; }
        public string TELM { get; set; }
        public string EMAIL { get; set; }
        public string FTPFOLDER { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string FTPDIRREMOTO { get; set; }
        public Nullable<bool> STAT { get; set; }
        public string LINGUA { get; set; }
        public string PREFIXO_ENC { get; set; }
        public string AGENTEPAI { get; set; }
        public Nullable<bool> COMISSIONISTA { get; set; }
        public string COMENT1 { get; set; }
        public string COMENT2 { get; set; }
    
        public virtual ICollection<TABAGE> TABAGE1 { get; set; }
        public virtual TABAGE TABAGE2 { get; set; }
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }
    }
}
