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
    
    public partial class TABRUBRICAS
    {
        public TABRUBRICAS()
        {
            this.CLIENTES_CRM = new HashSet<CLIENTES_CRM>();
        }
    
        public string rubrica { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<CLIENTES_CRM> CLIENTES_CRM { get; set; }
    }
}
